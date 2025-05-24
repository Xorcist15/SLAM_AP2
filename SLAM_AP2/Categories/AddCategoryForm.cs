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

namespace SLAM_AP2
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void CreateCategory_Click(object sender, EventArgs e)
        {
            string code = CodeTxtBox.Text;
            string lib = LibTxtBox.Text;
            // todo the test and all
            BLL_Categorie newCat = new BLL_Categorie(code, lib);
            newCat.AddCategory();   
        }
    }
}
