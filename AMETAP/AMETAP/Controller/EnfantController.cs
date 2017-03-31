using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMETAP.Model.DataAcces;
namespace AMETAP.Controller
{
    public class EnfantController
    {
        EnfantDA eDA;
        public EnfantController()
        {
            eDA = new EnfantDA();
        }
        public void afficheEnfant(DataGridView d,String matricule)
        {
            d.DataSource = eDA.search(matricule);
        }
    }
}
