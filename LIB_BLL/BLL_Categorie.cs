using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using LIB_DAL;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace LIB_BLL
{
    public class BLL_Categorie
    {
        private string _code;
        private string _libelle;

        // Constants for character limits
        private const int MaxCodeLength = 5;
        private const int MaxLibelleLength = 50;

        public BLL_Categorie(string code, string libelle)
        {
            _code = code;
            _libelle = libelle;
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        /// <summary>
        /// retrieves all categories from database
        /// </summary>
        /// <returns>
        /// list of <see cref="BLL_Categorie"> of all categories in database
        /// </returns>
        public static List<BLL_Categorie> GetCategories()
        {
            List<BLL_Categorie> categories = new List<BLL_Categorie>();
            SqlConnection conn = Database.OpenConnection();
            if (conn == null ) return categories;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM categorie", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read()) 
                    {
                        string code = reader["cat_code"].ToString();
                        string libelle = reader["cat_libelle"].ToString();

                        categories.Add(new BLL_Categorie(code, libelle));
                    }
                }
            }

            Database.CloseConnection();
            return categories;
        }

        public static string FindCatCode(string libelle)
        {
            string code = "";
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return code;

            string query = "SELECT * FROM categorie " +
                "WHERE cat_libelle = @Libelle";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Libelle", libelle);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    code = reader["cat_code"].ToString();
                }
            }

            Database.CloseConnection();
            return code;
        }

        public static string FindCatLibelle(string code)
        {
            string libelle = "";
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return libelle;

            string query = "SELECT * FROM categorie " +
                "WHERE cat_code = @Code";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Code", code);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    libelle = reader["cat_libelle"].ToString();
                }
            }

            Database.CloseConnection();
            return libelle;
        }

        public void AddCategory()
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "INSERT INTO categorie (cat_code, cat_libelle) " +
                "VALUES (@Code, @Lib);";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Code", this.Code);
                cmd.Parameters.AddWithValue("@Lib", this.Libelle);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
        }

        public void DeleteCategory()
        {
            SqlConnection conn = Database.OpenConnection(); 
            if (conn == null) return;

            string query = "DELETE FROM categorie " +
                "WHERE cat_code = @Code;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Code", this.Code);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
        }

        public void UpdateCategory(string code, string libelle)
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "UPDATE categorie " +
                "SET cat_code = @NewCode, cat_libelle = @NewLib " + 
                "WHERE cat_code = @OldCode;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NewCode", code);     
                cmd.Parameters.AddWithValue("@NewLib", libelle);     
                cmd.Parameters.AddWithValue("@OldCode", this.Code);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
        }

        public static List<BLL_Categorie> FiltrerCategories(string code, string libelle)
        {
            List<BLL_Categorie> categoriesFiltres = new List<BLL_Categorie>();
            SqlConnection conn = Database.OpenConnection();

            if (conn == null) return categoriesFiltres;

            List<string> conditions  = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            if(!string.IsNullOrEmpty(code))
            {
                conditions.Add("cat_code = @Code");
                cmd.Parameters.AddWithValue("@Code", code);
            }

            if(!string.IsNullOrEmpty(libelle))
            {
                conditions.Add("cat_libelle = @Lib");
                cmd.Parameters.AddWithValue("@Lib", libelle);
            }

            string whereClause = conditions.Count > 0 ? " WHERE " + string.Join(" AND ", conditions) : "";
            cmd.CommandText = "SELECT * FROM categorie" + whereClause;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string codeF = reader["cat_code"].ToString();
                    string libelleF = reader["cat_libelle"].ToString();

                    categoriesFiltres.Add(new BLL_Categorie(codeF, libelleF));
                }
            }

            Database.CloseConnection();
            return categoriesFiltres;
        }
    }
}
