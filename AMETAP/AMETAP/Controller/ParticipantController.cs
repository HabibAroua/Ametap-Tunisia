using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;
using System.Windows.Forms;
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

        public void getAllMembreFamilleByMatricule(DataGridView d,int matricule)
        {
            d.DataSource = pDA.findAllMembreFamilleByMatricule(matricule);
        }

        public List<int> find_List_MatPart_byMatricule_Adherent(int matricule)
        {
            return pDA.find_List_MatPart_byMatricule_Adherent(matricule);
        }

        public void supprimer(int matricule)
        {
            pDA.delete(matricule);
        }
    }
}
