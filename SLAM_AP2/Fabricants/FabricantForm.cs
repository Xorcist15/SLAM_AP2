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

namespace SLAM_AP2.Fabricants
{
    public partial class FabricantForm : Form
    {

        List<BLL_Fabricant> fabricants;
        int indexSelectedRow;

        public FabricantForm()
        {
            InitializeComponent();
            fabricants = new List<BLL_Fabricant>();
            UpdateFabricants();
        }

        public void UpdateFabricants()
        {
            fabricants = BLL_Fabricant.GetFabricants();
            DgvFabricant.DataSource = fabricants;
        }

        private void FiltrerFabBtn_Click(object sender, EventArgs e)
        {
            string id = IdTxtBox.Text;
            string nom = NomTxtBox.Text;

            fabricants = BLL_Fabricant.FiltrerFabricants(id, nom);
            DgvFabricant.DataSource = fabricants;
        }

        private void CreateFabBtn_Click(object sender, EventArgs e)
        {
            new AddFabricantForm().ShowDialog();
            UpdateFabricants();
        }

        private void DgvFabricant_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                CtxMnStrip.Show(Cursor.Position);
                indexSelectedRow = e.RowIndex;
            }
        }

        private void ModifierSTMItem_Click(object sender, EventArgs e)
        {
            new EditFabricantForm(fabricants[indexSelectedRow]).ShowDialog();
        }

        private void SupprimerSTMItem_Click(object sender, EventArgs e)
        {
            string msg = $"Vous etes surs de supprimer l'article avec l'identifiant {fabricants[indexSelectedRow].Id} ?";
            var ok = MessageBox.Show(msg, "Confirmer suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // todo: integrity constraint check

            if (ok == DialogResult.Yes)
            {
                fabricants[indexSelectedRow].DeleteFabricant();
                UpdateFabricants();
            }
        }
    }
}
