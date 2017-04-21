using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.DataAcces;
using System.Windows.Forms;
using System.Data;
namespace AMETAP.Controller
{
    public class ParticipationController
    {
        ParticipationDA pDA;

        public ParticipationController()
        {
            pDA = new ParticipationDA();
        }

        public void AfficheDemande(DataGridView d)
        {
            d.DataSource = pDA.sellectAll();
        }


    }
}
