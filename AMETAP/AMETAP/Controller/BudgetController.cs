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
        public BudgetController()
        {
            bDA = new BudgetDA();
        }

        public void fixerBudget(int annee,double montant_provisoire,double montant_final)
        {
            b = new Budget(0, annee, montant_provisoire, montant_final);
            Boolean test = bDA.insert(b);
            if(test==true)
            {
                MessageBox.Show("Vous fixez ce budget !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

       
    }
}
