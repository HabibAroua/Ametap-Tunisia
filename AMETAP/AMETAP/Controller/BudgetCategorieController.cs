using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMETAP.Model.DataAcces;
namespace AMETAP.Controller
{
    public class BudgetCategorieController
    {
        BudgetCategorieDA bcDA;
        BudgetDA bDA;
        public BudgetCategorieController()
        {
            bcDA = new BudgetCategorieDA();
            bDA = new BudgetDA();
        }

        public void afficheLoisir(DataGridView d,String annee)
        {
            d.DataSource = bcDA.selectActiviteLoisir(annee);
        }

        public void afficheCulturel(DataGridView d,String annee)
        {
            d.DataSource = bcDA.selectActiviteCulturel(annee);
        }

        public double getMontantProvisoire(String categorie)
        {
            return bcDA.getMontantProvisoire(bDA.LastYear(), categorie);
        }
    }
}
