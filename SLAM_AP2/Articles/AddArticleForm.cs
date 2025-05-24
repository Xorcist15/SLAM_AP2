using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_BLL;
using SLAM_AP2.Utils;

namespace SLAM_AP2
{
    public partial class AddArticleForm : Form
    {
        public AddArticleForm()
        {
            InitializeComponent();
            IHMUtils.SetupCbBoxes(CbCategorie, CbFabricant, CbUnite);
        }

        private void CreateNewArticleBtn_Click(object sender, EventArgs e)
        {
            int MaxRefLength = 20;
            int MaxLibelleLength = 120;

            string reference;
            string libelle;

            if (RefTxtBox.Text.Length < MaxRefLength)
                reference = RefTxtBox.Text;
            else
            {
                string msg = "La reference ne peut pas depasser 20 characters";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefTxtBox.Text = "";
                return;
            }

            if (LibTxtBox.Text.Length < MaxLibelleLength)
                libelle = LibTxtBox.Text;
            else
            {
                string msg = "Le libelle ne peut pas depasser 120 characters";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LibTxtBox.Text = "";
                return;
            }

            string unit_code = BLL_Unite.FindUniteCode(CbUnite.Text);
            string cat_code = BLL_Categorie.FindCatCode(CbCategorie.Text);
            string fab_id = BLL_Fabricant.FindFabCode(CbFabricant.Text);
            BLL_Article article = new BLL_Article(reference, libelle, unit_code, cat_code, fab_id);

            //MessageBox.Show(article.ToString());
            // add to database if tests passed
            article.AddArticle();
        }
    }
}
