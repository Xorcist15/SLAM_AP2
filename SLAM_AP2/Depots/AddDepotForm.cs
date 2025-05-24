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
    public partial class AddDepotForm : Form
    {
        public AddDepotForm()
        {
            InitializeComponent();
        }

        private void CreateDepot_Click(object sender, EventArgs e)
        {
            string num = NumTxtBox.Text;
            string nom = NomTxtBox.Text;
            string supf = SuperficieTxtBox.Text;
            string lat = LatTxtBox.Text;
            string lon = LongTxtBox.Text;
            string vil = VilleCmBox.Text;
            string pay = PaysCmBox.Text;

            // conversion
            int int_num = int.Parse(num);
            decimal dec_supr = decimal.Parse(supf);
            decimal dec_lat = decimal.Parse(lat);
            decimal dec_lon = decimal.Parse(lon);

            // todo the test and all

            BLL_Depot newDepot = new BLL_Depot(int_num, nom, dec_supr, dec_lat, dec_lon, vil, pay);
            newDepot.AddDepot();   
        }
    }
}
