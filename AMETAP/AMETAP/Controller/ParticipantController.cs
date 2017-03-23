using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;
namespace AMETAP.Controller
{
    public class ParticipantController
    {
        ParticipantDA pDA;
        public ParticipantController()
        {
            pDA = new ParticipantDA();
        }

        public void Suuprimer(int matricule)
        {
            pDA.delete(matricule);
        }
    }
}
