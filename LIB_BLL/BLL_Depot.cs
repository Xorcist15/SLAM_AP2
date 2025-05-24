using LIB_DAL;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace LIB_BLL
{
    public class BLL_Depot
    {
        private int _depotNum;
        private string _depotNom;
        private decimal _depotSuperficie;
        private decimal _depotLat;
        private decimal _depotLong;
        private string _villeNom;
        private string _paysNom;

        // Constants for character limits
        private const int MaxDepotNomLength = 50;
        private const int MaxVilleNomLength = 50;
        private const int MaxPaysNomLength = 50;

        public BLL_Depot(
                int depotNum, 
                string depotNom, 
                decimal depotSuperficie, 
                decimal depotLat, 
                decimal depotLong, 
                string villeNom, 
                string paysNom
            )
        {
            _depotNum = depotNum;
            _depotNom = depotNom;
            _depotSuperficie = depotSuperficie;
            _depotLat = depotLat;
            _depotLong = depotLong;
            _villeNom = villeNom;
            _paysNom = paysNom;
        }

        public int Num
        {
            get { return _depotNum; }
            set { _depotNum = value; }
        }

        public string Nom
        {
            get { return _depotNom; }
            set { _depotNom = value; }
        }

        public decimal Superficie
        {
            get { return _depotSuperficie; }
            set { _depotSuperficie = value; }
        }

        public decimal Lat
        {
            get { return _depotLat; }
            set { _depotLat = value; }
        }

        public decimal Long
        {
            get { return _depotLong; }
            set { _depotLong = value; }
        }

        public string Ville
        {
            get { return _villeNom; }
            set { _villeNom = value; }
        }

        public string Pays
        {
            get { return _paysNom; }
            set { _paysNom = value; }
        }
        
        public static List<BLL_Depot> GetDepots()
        {
            List<BLL_Depot> depots = new List<BLL_Depot>();
            SqlConnection conn = Database.OpenConnection();
            if (conn == null ) return depots;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM depot", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read()) 
                    {
                        string num = reader["depot_num"].ToString();
                        string nom = reader["depot_nom"].ToString();
                        string supf = reader["depot_superficie"].ToString();
                        string lat = reader["depot_lat"].ToString();
                        string lon = reader["depot_long"].ToString();
                        string vil = reader["ville_nom"].ToString();
                        string pay = reader["pays_nom"].ToString();


                        // conversion
                        int int_num = int.Parse(num);
                        decimal dec_supr = decimal.Parse(supf);
                        decimal dec_lat = decimal.Parse(lat);
                        decimal dec_lon = decimal.Parse(lon);

                        depots.Add(new BLL_Depot(int_num, nom, dec_supr, dec_lat, dec_lon, vil, pay));
                    }
                }
            }

            Database.CloseConnection();
            return depots;
        }


        public void AddDepot()
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "INSERT INTO depot (depot_num, depot_nom, depot_superficie, depot_lat, depot_long, ville_nom, pays_nom) " +
                "VALUES (@Num, @Nom, @Super, @Lat, @Long, @Ville, @Pays);";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Num", this.Num);
                cmd.Parameters.AddWithValue("@Nom", this.Nom);
                cmd.Parameters.AddWithValue("@Super", this.Superficie);
                cmd.Parameters.AddWithValue("@Lat", this.Lat);
                cmd.Parameters.AddWithValue("@Long", this.Long);
                cmd.Parameters.AddWithValue("@Ville", this.Ville);
                cmd.Parameters.AddWithValue("@Pays", this.Pays);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
            return;
        }

        public void UpdateDepot(
                int num,
                string nom,
                decimal superficie,
                decimal lat,
                decimal lon,
                string ville,
                string pays
            )
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "Update depot " +
                "SET " +
                    "depot_num = @NewNum, depot_superficie = @Super, depot_lat = @Lat, " +
                    "depot_long = @Long, ville_nom = @Ville, pays_nom = @Pays " +
                "WHERE depot_num = @OldNum ;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NewNum", num);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Super", superficie);
                cmd.Parameters.AddWithValue("@Lat", lat);
                cmd.Parameters.AddWithValue("@Long", lon);
                cmd.Parameters.AddWithValue("@Ville", ville);
                cmd.Parameters.AddWithValue("@Pays", pays);
                cmd.Parameters.AddWithValue("@OldNum", this.Num);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
            return;
        }

        public void DeleteDepot()
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "DELETE FROM depot " +
                "WHERE depot_num = @Num ;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Num", this.Num);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
            return;
        }

    }
}
