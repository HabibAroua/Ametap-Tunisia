using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;
using AMETAP.Controller.Script;
using System.Windows.Forms;
namespace AMETAP.Controller
{
    public class ContribuesController
    {
        AdherentDA aDA;
        ContribuesDA cDA;
        BudgetDA bDA;
        BudgetCategorieDA bcDA;
        DateValue date;
        Mailing mailing;
        public ContribuesController()
        {
            aDA = new AdherentDA();
            cDA = new ContribuesDA();
            bDA = new BudgetDA();
            bcDA = new BudgetCategorieDA();
            date = new DateValue();
        }

        public int MontantTotalContribues()
        {
            int s = 0;
            foreach (int i in aDA.listMatricule())
            {
                s++;
            }

            return s*2;
        }

        public void ContribueParMois()
        {
            foreach (int matricule in aDA.listMatricule())
            {
                MessageBox.Show("id =0  mensualité ="+date.getToday()+" Montant =2DT"+"matricule="+matricule+" idBudget="+bDA.findIdByLastYear());
                Contribues c = new Contribues(0, date.getToday(), 2, new Adherent(matricule), new Budget(bDA.findIdByLastYear()));
                cDA.insert(c);
            }
            bDA.AjouterValeurBudget(bDA.findIdByLastYear(), MontantTotalContribues());
            bcDA.ajouterValeurBudgetCat(bDA.findIdByLastYear(), MontantTotalContribues() / 2);

            foreach(String adresse in aDA.listAdresse())
            {
                mailing = new Mailing(adresse, "Information", "Nous vous informe qu'on à soustraire de votre salaire de 2 Dinar ");
                mailing.sendMail();
            }
            MessageBox.Show("La soustraire des salires est effectué","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
