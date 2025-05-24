using System;
using System.Data.SqlClient;

namespace LIB_DAL
{
    public static class Database
    {
        private static SqlConnection connection;

        public static SqlConnection OpenConnection()
        {
            if (connection == null)
            {
                //string connectionString = "Server=localhost\\SQLEXPRESS;Database=test1;Trusted_Connection=True;";
                string connectionString = "Server=SRV-SQL\\SQL_SLAM;Database=BD_STOCK_BEN_HASSINE;Trusted_Connection=True;";
                connection = new SqlConnection(connectionString);
            }

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                return connection;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

}
