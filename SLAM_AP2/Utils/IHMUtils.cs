using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_BLL;

namespace SLAM_AP2.Utils
{
    public class IHMUtils
    { 
        public static void SetupCbBoxes(ComboBox cbCat, ComboBox cbFab, ComboBox cbUnit)
        {
            // setup categories
            List<BLL_Categorie> categories = BLL_Categorie.GetCategories();
            foreach (var cat in categories)
            {
                cbCat.Items.Add(cat.Libelle); 
            }

            // setup fabricant
            List<BLL_Fabricant> fabricants = BLL_Fabricant.GetFabricants();
            foreach (var fabricant in fabricants)
            {
                cbFab.Items.Add(fabricant.Name); 
            }
            
            // setup unite 
            List<BLL_Unite> unites = BLL_Unite.GetUnites();
            foreach (var unite in unites)
            {
                cbUnit.Items.Add(unite.Libelle); 
            }
        }
    }
}
