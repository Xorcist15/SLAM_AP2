using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_BLL;
using SLAM_AP2.Fabricants;
using SLAM_AP2.Unites;
using SLAM_AP2.Utils;

namespace SLAM_AP2
{
    public partial class MainMenu : Form
    {
        List<BLL_Article> articles;
        private int indexSelectedRow;

        public MainMenu()
        {
            InitializeComponent();
            IHMUtils.SetupCbBoxes(CbCategorie, CbFabricant, CbUnite);
            UpdateArticlesList();
        }
        private void BtnCreateArticle_Click(object sender, EventArgs e)
        {
            new AddArticleForm().ShowDialog();
            UpdateArticlesList();
        }


        private void FiltrerBtn_Click(object sender, EventArgs e)
        {
            string lib = LibTxtBox.Text;

            string unit = BLL_Unite.FindUniteCode(CbUnite.Text);
            string cat = BLL_Categorie.FindCatCode(CbCategorie.Text);
            string fab = BLL_Fabricant.FindFabCode(CbFabricant.Text);

            List<BLL_Article> articles = BLL_Article.FilterArticles(lib, unit, cat, fab);
            DgvArticles.DataSource = articles;
        }

        private void DgvArticles_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                contextMenuStrip.Show(Cursor.Position);
                indexSelectedRow = e.RowIndex;
            }
        }

        private void ModifierTSMItem_Click(object sender, EventArgs e)
        {
            new EditArticleForm(articles[indexSelectedRow]).ShowDialog();    
        }

        private void SupprimerTSMItem_Click(object sender, EventArgs e)
        {
            // show validation windw
            string msg = $"Vous etes surs de supprimer l'article avec la reference {articles[indexSelectedRow].Ref} ?";
            var ok = MessageBox.Show(msg, "Confirmer suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ok == DialogResult.Yes) 
            {
                articles[indexSelectedRow].DeleteArticle();
            }
        }

        private void UpdateArticlesList()
        {
            articles = BLL_Article.GetArticles();
            DgvArticles.DataSource = articles;
        }

        private void ArticlesSTMItem_Click(object sender, EventArgs e)
        {
            GbArticles.Visible = true;
            GbDepots.Visible = false;
        }

        private void DepotsSTMIem_Click(object sender, EventArgs e)
        {
            GbArticles.Visible = false;
            GbDepots.Visible = true;
        }

        private void CatSTMItem_Click(object sender, EventArgs e)
        {
            new CategoryForm().ShowDialog();
        }

        private void FabSTMItem_Click(object sender, EventArgs e)
        {
            new FabricantForm().ShowDialog();
        }

        private void UnitSTMItem_Click(object sender, EventArgs e)
        {
            new UniteForm().ShowDialog();
        }
    }
}
