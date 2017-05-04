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
    }
}
