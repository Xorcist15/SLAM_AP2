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
    public partial class EditDepotForm : Form
    {

        private readonly BLL_Depot depotModif;

        public EditDepotForm(BLL_Depot depot)
        {
            InitializeComponent();
            NumTxtBox.Text = depot.Num.ToString();
            NomTxtBox.Text = depot.Nom;
            SuperficieTxtBox.Text = depot.Superficie.ToString();
            LatTxtBox.Text = depot.Lat.ToString();
            LongTxtBox.Text = depot.Long.ToString();
            VilleCmBox.Text = depot.Ville;
            PaysCmBox.Text = depot.Pays;
            depotModif = depot ;
        }

        private void ModifierDepotBtn_Click(object sender, EventArgs e)
        {
            string num = NumTxtBox.Text;
            string nom = NomTxtBox.Text;
            string supf = SuperficieTxtBox.Text;
            string lat = LatTxtBox.Text;
            string lon = LongTxtBox.Text;
            string vil = VilleCmBox.Text;
            string pays = PaysCmBox.Text;

            // conversion
            int int_num = int.Parse(num);
            decimal dec_supr = decimal.Parse(supf);
            decimal dec_lat = decimal.Parse(lat);
            decimal dec_lon = decimal.Parse(lon);

            depotModif.UpdateDepot(int_num, nom, dec_supr, dec_lat, dec_lon, vil, pays);
        }
    }
}
