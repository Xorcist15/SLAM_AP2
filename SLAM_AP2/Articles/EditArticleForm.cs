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
using SLAM_AP2.Utils;

namespace SLAM_AP2
{
    public partial class EditArticleForm : Form
    {

        private readonly BLL_Article articleModifie;


        public EditArticleForm(BLL_Article article)
        {
            InitializeComponent();
            IHMUtils.SetupCbBoxes(CbCategorie, CbFabricant, CbUnite);
            RefTxtBox.Text = article.Ref;
            LibTxtBox.Text = article.Libelle;
            CbCategorie.Text = BLL_Categorie.FindCatLibelle(article.CatCode);
            CbFabricant.Text = BLL_Fabricant.FindFabLibelle(article.FabId);
            CbUnite.Text = BLL_Unite.FindUnitLibelle(article.UnitCode);
            articleModifie = article;
        }

        private void ModifierArticleBtn_Click(object sender, EventArgs e)
        {
             string newRef  = RefTxtBox.Text;
             string newLib  = LibTxtBox.Text;
             string newUnit = BLL_Unite.FindUniteCode(CbUnite.Text);
             string newFab  = BLL_Fabricant.FindFabCode(CbFabricant.Text);
             string newCat  = BLL_Categorie.FindCatCode(CbCategorie.Text);
            
            articleModifie.UpdateArticle(newRef, newLib, newUnit, newCat, newFab);
        }
    }

}
