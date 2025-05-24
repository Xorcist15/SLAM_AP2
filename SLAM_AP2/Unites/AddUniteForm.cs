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
    public partial class AddUniteForm : Form
    {
        public AddUniteForm ()
        {
            InitializeComponent();
        }

        private void CreateUnite_Click(object sender, EventArgs e)
        {
            // TODO DO THE TESTS AND ALALALALAL
            string code = CodeTxtBox.Text;
            string libelle = LibelleTxtBox.Text;

            Console.WriteLine("hello world");

            // create new 
            BLL_Unite newUnite = new BLL_Unite(code, libelle);
            newUnite.AddUnite();
        }
    }
}
