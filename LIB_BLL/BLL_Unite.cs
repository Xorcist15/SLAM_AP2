using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LIB_DAL;

namespace LIB_BLL
{
    public class BLL_Unite
    {
        private string _code;
        private string _libelle;

        // Constants for character limits
        private const int MaxCodeLength = 3;
        private const int MaxLibelleLength = 30;

        public BLL_Unite(string code, string libelle)
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
        /// Retrieves all unities in database
        /// </summary>
        /// <returns>
        /// List of <see cref="BLL_Unite">
        /// </returns>
        public static List<BLL_Unite> GetUnites()
        { 
            List<BLL_Unite> unites = new List<BLL_Unite>();
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return unites;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM unite;", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string code = reader["unit_code"].ToString();
                        string libelle = reader["unit_libelle"].ToString();

                        unites.Add(new BLL_Unite(code, libelle));
                    }
                }
            }

            Database.CloseConnection();
            return unites;
        }

        /// <summary>
        /// Adds new Unity to database
        /// </summary>
        /// <remarks>
        /// Inserts new unity to 'unite' table in database
        /// </remarks>
        public void AddUnite()
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "INSERT INTO unite (unit_code, unit_libelle) " +
                "VALUE (@Code, @Libelle);";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Code", this.Code);
                cmd.Parameters.AddWithValue("@Libelle", this.Libelle);

                cmd.ExecuteNonQuery();
            }
            Database.CloseConnection();
        }

        /// <summary>
        /// finds the code associated to a unity libelle
        /// </summary>
        /// <param name="libelle">name of the unity</param>
        /// <returns></returns>
        public static string FindUniteCode(string libelle)
        {
            string code = "";
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return code;

            string query = "SELECT * FROM unite " +
                "WHERE unit_libelle = @Libelle";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Libelle", libelle);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    code = reader["unit_code"].ToString();
                }
            }

            Database.CloseConnection();
            return code;
        }

        public static string FindUnitLibelle(string code)
        {
            string libelle = "";
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return libelle;

            string query = "SELECT * FROM unite " +
                "WHERE unit_code = @Code";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Code", code);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    libelle = reader["unit_libelle"].ToString();
                }
            }

            Database.CloseConnection();
            return libelle;
        }

        public static List<BLL_Unite> FilterUnites(string id, string nom)
        {
            List<BLL_Unite> unitesFiltres = new List<BLL_Unite>();
            SqlConnection conn = Database.OpenConnection();
            if(conn == null) return unitesFiltres;
            
            List<string> conditions = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            if(!string.IsNullOrEmpty(id))
            {
                conditions.Add("unit_code = @Code");
                cmd.Parameters.AddWithValue("@Code", id);
            }

            if(!string.IsNullOrEmpty(nom))
            {
                conditions.Add("unite_libelle = @Nom");
                cmd.Parameters.AddWithValue("@Nom", nom);
            }

            string whereClause = conditions.Count > 0 ?  " WHERE " + string.Join(" AND ", conditions) : "";
            cmd.CommandText = "SELECT * FROM unite" + whereClause;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string Fcode = reader["unit_code"].ToString();
                    string Flib = reader["unit_libelle"].ToString();

                    unitesFiltres.Add(new BLL_Unite(Fcode, Flib));
                }
            }
            Database.CloseConnection();
            return unitesFiltres;
        }

        public void DeleteUnite()
        {
            SqlConnection conn = Database.OpenConnection(); 
            if (conn == null) return;

            string query = "DELETE FROM unite " +
                "WHERE unit_code = @Code;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Code", this.Code);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
        }


        public void UpdateUnite(string code, string libelle)
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "UPDATE unite " +
                "SET unit_code = @NewCode, unit_libelle = @NewLib " + 
                "WHERE unite_code = @OldCode;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NewCode", code);     
                cmd.Parameters.AddWithValue("@NewLib", libelle);     
                cmd.Parameters.AddWithValue("@OldCode", this.Code);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
        }
 

    }
}
