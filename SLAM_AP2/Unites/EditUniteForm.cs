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

namespace SLAM_AP2.Unites
{
    public partial class EditUniteForm : Form
    {
        private readonly BLL_Unite unitModifie;
        public EditUniteForm(BLL_Unite unite)
        {
            InitializeComponent();
            IdTxtBox.Text = unite.Code;
            NomTxtBox.Text = unite.Libelle;
            unitModifie = unite;
        }

        private void ModifierFabBtn_Click(object sender, EventArgs e)
        {
            string newId = IdTxtBox.Text;
            string newNom = NomTxtBox.Text;

            unitModifie.UpdateUnite(newId, newNom);
        }
    }
}
