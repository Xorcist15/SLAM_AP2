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
    public partial class DepotForm : Form
    {

        List<BLL_Depot> depots;
        int indexSelectedRow;

        public DepotForm()
        {
            InitializeComponent();
            depots = new List<BLL_Depot>();
            UpdateDepotsList();
        }

        public void UpdateDepotsList()
        {
            depots = BLL_Depot.GetDepots();
            DgvDepots.DataSource = depots;
        }

        private void CreateDepot_Click(object sender, EventArgs e)
        {
            new AddDepotForm().ShowDialog();
            UpdateDepotsList();
        }

        private void DgvDepots_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                CtxMnStrip.Show(Cursor.Position);
                indexSelectedRow = e.RowIndex;
            }
        }

        private void ModifierTSMItem_Click(object sender, EventArgs e)
        {
            new EditDepotForm(depots[indexSelectedRow]).ShowDialog();
        }

        private void SupprimerTSMItem_Click(object sender, EventArgs e)
        {
            string msg = $"Vous etes surs de supprimer le depot avec la reference {depots[indexSelectedRow].Num} ?";
            var ok = MessageBox.Show(msg, "Confirmer suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
            // todo: integrity constraint check

            if (ok == DialogResult.Yes) 
            {
                depots[indexSelectedRow].DeleteDepot();
                UpdateDepotsList();
            }
        }

        private void FiltrerCatBtn_Click(object sender, EventArgs e)
        {
            categories = BLL_Categorie.FiltrerCategories(catCode, catLib);
            DgvDepots.DataSource = categories;
        }
    }
}
