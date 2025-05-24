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

namespace SLAM_AP2.Categories
{
    public partial class EditCategoryForm : Form
    {

        private readonly BLL_Categorie catModif;

        public EditCategoryForm(BLL_Categorie categorie)
        {
            InitializeComponent();
            CodeTxtBox.Text = categorie.Code;
            LibTxtBox.Text = categorie.Libelle;
            catModif = categorie;
        }

        private void ModifierCatBtn_Click(object sender, EventArgs e)
        {
            string newCode = CodeTxtBox.Text;
            string newLib = LibTxtBox.Text;

            catModif.UpdateCategory(newCode, newLib);
        }
    }
}
