using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.DataAcces;
using System.Windows.Forms;
namespace AMETAP.Controller
{
    public class PayaimentController
    {
        private PayaimentDA payaimentDA;
        public PayaimentController()
        {
            payaimentDA = new PayaimentDA();
        }

        public void afficheNonPayaiment(DataGridView d)
        {
            d.DataSource = payaimentDA.sellectAll();
        }

        public void afficherNonPayer(DataGridView d, int idActivite)
        {
            d.DataSource = payaimentDA.sellectNonPayer(idActivite);
        }

        public void afficherAdherentNonPayer(DataGridView d,int idActivite)
        {
            d.DataSource = payaimentDA.selectAdherentNonPayer(idActivite);
        }

        public void afficherConjointNonPayer(DataGridView d,int idActivite)
        {
            d.DataSource = payaimentDA.selectConjointNonPayer(idActivite);
        }

        public void afficherEnfantNonPayer(DataGridView d,int idActivite)
        {
            d.DataSource = payaimentDA.selectEnfantNonPayer(idActivite);
        }

    }
}
