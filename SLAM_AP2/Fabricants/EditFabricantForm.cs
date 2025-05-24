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
    public partial class EditFabricantForm : Form
    {
        private readonly BLL_Fabricant fabModifie;
        public EditFabricantForm(BLL_Fabricant fabricant)
        {
            InitializeComponent();
            IdTxtBox.Text = fabricant.Id;
            NomTxtBox.Text = fabricant.Name;
            fabModifie = fabricant;
        }

        private void ModifierFabBtn_Click(object sender, EventArgs e)
        {
            string newId = IdTxtBox.Text;
            string newNom = NomTxtBox.Text;

            fabModifie.UpdateFabricant(newId, newNom);
        }
    }
}
