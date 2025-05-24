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
using SLAM_AP2.Categories;

namespace SLAM_AP2
{
    public partial class CategoryForm : Form
    {

        List<BLL_Categorie> categories;
        int indexSelectedRow;

        public CategoryForm()
        {
            InitializeComponent();
            categories = new List<BLL_Categorie>();
            UpdateCategoriesList();
        }

        public void UpdateCategoriesList()
        {
            categories = BLL_Categorie.GetCategories();
            DgvCategories.DataSource = categories;
        }

        private void CreateCategory_Click(object sender, EventArgs e)
        {
            new AddCategoryForm().ShowDialog();
            UpdateCategoriesList();
        }

        private void DgvCategories_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                CtxMnStrip.Show(Cursor.Position);
                indexSelectedRow = e.RowIndex;
            }
        }

        private void ModifierTSMItem_Click(object sender, EventArgs e)
        {
            new EditCategoryForm(categories[indexSelectedRow]).ShowDialog();
        }

        private void SupprimerTSMItem_Click(object sender, EventArgs e)
        {
            string msg = $"Vous etes surs de supprimer l'article avec la reference {categories[indexSelectedRow].Code} ?";
            var ok = MessageBox.Show(msg, "Confirmer suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
            // todo: integrity constraint check

            if (ok == DialogResult.Yes) 
            {
                categories[indexSelectedRow].DeleteCategory();
                UpdateCategoriesList();
            }
        }

        private void FiltrerCatBtn_Click(object sender, EventArgs e)
        {
            string catCode = CodeTxtBox.Text;
            string catLib = LibTxtBox.Text;

            categories = BLL_Categorie.FiltrerCategories(catCode, catLib);
            DgvCategories.DataSource = categories;
        }
    }
}
