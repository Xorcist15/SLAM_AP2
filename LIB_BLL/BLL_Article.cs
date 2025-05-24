using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LIB_DAL;

namespace LIB_BLL
{
    public class BLL_Article
    {
        private string _ref;
        private string _libelle;
        private string _unitCode;
        private string _catCode;
        private string _fabId;

        public BLL_Article(string refId, string libelle, string unitCode, string catCode, string fabId)
        {
            _ref = refId;
            _libelle = libelle;
            _unitCode = unitCode;
            _catCode = catCode;
            _fabId = fabId;
        }

        public override string ToString()
        {
            return this.Ref + " " + this.Libelle + " " + this.UnitCode + " " + this.CatCode + " " + this.FabId;
        }

        public string Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        public string UnitCode
        {
            get { return _unitCode; }
            set { _unitCode = value; }
        }

        public string CatCode
        {
            get { return _catCode; }
            set { _catCode = value; }
        }

        public string FabId
        {
            get { return _fabId; }
            set { _fabId = value; }
        }

        /// <summary>
        /// retrieves list of all articles from database
        /// </summary>
        /// <returns>
        /// list of <see cref="BLL_Article"> of all articles in database
        /// </returns>
        public static List<BLL_Article> GetArticles()
        {
            List<BLL_Article> articles = new List<BLL_Article>();

            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return articles;



            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Article", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string refId = reader["article_ref"].ToString();
                        string libelle = reader["article_libelle"].ToString();
                        string unitCode = reader["unit_code"].ToString();
                        string catCode = reader["cat_code"].ToString();
                        string fabId = reader["fab_id"].ToString();

                        articles.Add(new BLL_Article(refId, libelle, unitCode, catCode, fabId));
                    }
                }
            }

            Database.CloseConnection();
            return articles;
        }

        public static List<BLL_Article> FilterArticles(string Lib, string Ucode, string Ccode, string FId)
        {
            List<BLL_Article> articles_filtres = new List<BLL_Article>();
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return articles_filtres;

            List<string> conditions = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            if (!string.IsNullOrEmpty(Ucode))
            {
                conditions.Add("unit_code = @UnitCode");
                cmd.Parameters.AddWithValue("@UnitCode", Ucode);
            }
            if (!string.IsNullOrEmpty(Ccode))
            {
                conditions.Add("cat_code = @CatCode");
                cmd.Parameters.AddWithValue("@CatCode", Ccode);
            }
            if (!string.IsNullOrEmpty(FId))
            {
                conditions.Add("fab_id = @FabId");
                cmd.Parameters.AddWithValue("@FabId", FId);
            }
            if (!string.IsNullOrEmpty(Lib))
            {
                conditions.Add("article_libelle LIKE @Lib");
                cmd.Parameters.AddWithValue("@Lib", "%" + Lib + "%");
            }

            string whereClause = conditions.Count > 0 ? " WHERE " + string.Join(" AND ", conditions) : "";
            cmd.CommandText = "SELECT * FROM article" + whereClause;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string refId = reader["article_ref"].ToString();
                    string libelle = reader["article_libelle"].ToString();
                    string unitCode = reader["unit_code"].ToString();
                    string catCode = reader["cat_code"].ToString();
                    string fabId = reader["fab_id"].ToString();

                    articles_filtres.Add(new BLL_Article(refId, libelle, unitCode, catCode, fabId));
                }
            }

            Database.CloseConnection();
            return articles_filtres;
        }


        /// <summary>
        /// adds new article to database
        /// </summary>
        /// <remarks>
        /// inserts a new article into "article" table in database
        /// </remarks>
        public void AddArticle()
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "INSERT INTO article (article_ref, article_libelle, unit_code, cat_code, fab_id) " +
            "VALUES (@Ref, @Libelle, @UnitCode, @CatCode, @FabId);";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Ref", this.Ref);
                cmd.Parameters.AddWithValue("@Libelle", this.Libelle);
                cmd.Parameters.AddWithValue("@UnitCode", this.UnitCode);
                cmd.Parameters.AddWithValue("@CatCode", this.CatCode);
                cmd.Parameters.AddWithValue("@FabId", this.FabId);

                cmd.ExecuteNonQuery();
            }
            Database.CloseConnection();
        }

        public void DeleteArticle()
        {
            SqlConnection conn = Database.OpenConnection(); if (conn == null) return;

            string query = "DELETE FROM article WHERE article_ref = @Ref;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Ref", this.Ref);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection() ;
        }

        public void UpdateArticle(
                string rf,
                string lib,
                string unit,
                string cat,
                string fab
            )
        {
            SqlConnection conn = Database.OpenConnection();
            if (conn == null) return;

            string query = "UPDATE article " +
                "SET article_ref = @NewRef, article_libelle = @Lib, unit_code = @Unit, cat_code = @Cat, fab_id = @Fab " +
                "WHERE article_ref = @OldRef;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NewRef", rf);
                cmd.Parameters.AddWithValue("@Lib", lib);
                cmd.Parameters.AddWithValue("@Unit", unit);
                cmd.Parameters.AddWithValue("@Cat", cat);
                cmd.Parameters.AddWithValue("@Fab", fab);
                cmd.Parameters.AddWithValue("@OldRef", this.Ref);

                cmd.ExecuteNonQuery();
            }

            Database.CloseConnection();
        }
    }
}

