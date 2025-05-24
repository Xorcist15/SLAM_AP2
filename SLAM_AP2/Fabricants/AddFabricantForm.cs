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

namespace SLAM_AP2.Fabricants
{
    public partial class AddFabricantForm : Form
    {
        public AddFabricantForm()
        {
            InitializeComponent();
        }

        private void CreateFabricant_Click(object sender, EventArgs e)
        {
            // TODO DO THE TESTS AND ALALALALAL
            string id = IdTxtBox.Text;
            string nom = NomTxtBox.Text;

            // create new 
            BLL_Fabricant newFab = new BLL_Fabricant(id, nom);
            newFab.AddFabricant();
        }
    }
}
