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

namespace SLAM_AP2.Unites
{
    public partial class UniteForm : Form
    {

        List<BLL_Unite> unites;
        int indexSelectedRow;

        public UniteForm()
        {
            InitializeComponent();
            unites = new List<BLL_Unite>();
            UpdateUnites();
        }

        public void UpdateUnites()
        {
            unites = BLL_Unite.GetUnites();
            DgvUnites.DataSource = unites;
        }

        private void FiltrerUnitBtn_Click(object sender, EventArgs e)
        {
            string id = IdTxtBox.Text;
            string nom = NomTxtBox.Text;

            unites = BLL_Unite.FilterUnites(id, nom);
            DgvUnites.DataSource = unites;
        }

        private void CreateUnitBtn_Click(object sender, EventArgs e)
        {
            new AddUniteForm().ShowDialog();
            UpdateUnites();
        }

        private void DgvUnite_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                CtxMnStrip.Show(Cursor.Position);
                indexSelectedRow = e.RowIndex;
            }
        }

        private void ModifierSTMItem_Click(object sender, EventArgs e)
        {
            new EditUniteForm(unites[indexSelectedRow]).ShowDialog();
        }

        private void SupprimerSTMItem_Click(object sender, EventArgs e)
        {
            string msg = $"Vous etes surs de supprimer l'article avec l'identifiant {unites[indexSelectedRow].Code} ?";
            var ok = MessageBox.Show(msg, "Confirmer suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // todo: integrity constraint check

            if (ok == DialogResult.Yes)
            {
                unites[indexSelectedRow].DeleteUnite();
                UpdateUnites();
            }
        }
    }
}
