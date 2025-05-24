using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LIB_DAL;

namespace LIB_BLL
{
    public class BLL_Fabricant
    {
        private string _id;
        private string _name;

        // taille limite 
        private const int MaxIdLength = 10;
        private const int MaxNameLength = 50;

        public BLL_Fabricant(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Retrieves all fabricants from database
        /// </summary>
        /// <returns>
        /// List of <see cref="BLL_Fabricant">
        /// </returns>
        public static List<BLL_Fabricant> GetFabricants()
        {
            List<BLL_Fabricant> fabricants = new List<BLL_Fabricant>();
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return fabricants;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM fabricant;", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["fab_id"].ToString();
                        string name = reader["fab_nom"].ToString();

                        fabricants.Add(new BLL_Fabricant(id, name));
                    }
                } 
            }
            Database.CloseConnection();
            return fabricants;
        }
        public static string FindFabCode(string nom)
        {
            string code = "";
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return code;

            string query = "SELECT * FROM fabricant " +
                "WHERE fab_nom = @Nom";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Nom", nom);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    code = reader["fab_id"].ToString();
                }
            }

            Database.CloseConnection();
            return code;
        }

        public static string FindFabLibelle(string id)
        {
            string nom = "";
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return nom;

            string query = "SELECT * FROM fabricant " +
                "WHERE fab_id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    nom = reader["fab_nom"].ToString();
                }
            }

            Database.CloseConnection();
            return nom;
        }

        public static List<BLL_Fabricant> FiltrerFabricants(string id, string nom)
        {
            List<BLL_Fabricant> fabricantsFiltres = new List<BLL_Fabricant>();
            SqlConnection conn = Database.OpenConnection();

            if (conn == null) return fabricantsFiltres;

            List<string> conditions  = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            if(!string.IsNullOrEmpty(id))
            {
                conditions.Add("fab_id  = @Id");
                cmd.Parameters.AddWithValue("@Id", id);
            }

            if(!string.IsNullOrEmpty(nom))
            {
                conditions.Add("fab_nom = @Nom");
                cmd.Parameters.AddWithValue("@Nom", nom);
            }

            string whereClause = conditions.Count > 0 ? " WHERE " + string.Join(" AND ", conditions) : "";
            cmd.CommandText = "SELECT * FROM fabricant" + whereClause;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string Fid = reader["fab_id"].ToString();
                    string Fnom = reader["fab_nom"].ToString();

                    fabricantsFiltres.Add(new BLL_Fabricant(Fid, Fnom));
                }
            }

            Database.CloseConnection();
            return fabricantsFiltres;
        }

        public void AddFabricant ()
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "INSERT INTO fabricant (fab_id, fab_nom) " +
                "VALUES (@Id, @Nom);";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", this.Id);
                cmd.Parameters.AddWithValue("@Nom", this.Name);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();

        }

         public void DeleteFabricant()
        {
            SqlConnection conn = Database.OpenConnection(); 
            if (conn == null) return;

            string query = "DELETE FROM fabricant" +
                "WHERE fab_id = @Id;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", this.Id);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
        }

        public void UpdateFabricant(string id, string nom)
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "UPDATE fabricant " +
                "SET fab_id = @NewId, fab_nom = @NewNom " + 
                "WHERE fab_id = @OldId;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NewId", id);     
                cmd.Parameters.AddWithValue("@NewNom", nom);     
                cmd.Parameters.AddWithValue("@OldId", this.Id);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
        }



    }
} 