using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMETAP.Model.DataAcces;
namespace AMETAP.Controller
{
    public class ConjointController
    {
        ConjointDA cDA;
        public ConjointController()
        {
            cDA = new ConjointDA();
        }

        public void afficherConjoint(DataGridView d,String matricule)
        {
            d.DataSource = cDA.search(matricule);
        }
    }
}
