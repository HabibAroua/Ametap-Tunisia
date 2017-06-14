using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace AMETAP.Controller
{
    public class BudgetController
    {
        BudgetDA bDA;
        Budget b;
        AdherentDA aDA;
        public BudgetController()
        {
            bDA = new BudgetDA();
            aDA = new AdherentDA();
        }

        public void fixerBudget(int annee,double montant_provisoire,double montant_final,double montantBudget1,double montantBudget2)
        {
            b = new Budget(bDA.maxID()+1, annee, montant_provisoire, montant_final,new BudgetCategorie(0,montantBudget1),new BudgetCategorie(0,montantBudget2));
            Boolean test = bDA.insert(b);
            if(test==true)
            {
                MessageBox.Show("Vous avez fixé un nouveau budget", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aDA.InitialiserNombrePoint();
            }
            else
            {
                MessageBox.Show("Erreur !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int MaxAnnee()
        {
            return bDA.LastYear();
        }

        public void AfficherBudget(DataGridView d)
        {
            d.DataSource = bDA.sellectAll();
        }

        public int getBudget(String annee)
        {
            return bDA.getBudget(annee);
        }

        public List<Budget>listBudget()
        {
            return bDA.listBudget();
        }


    }
}
