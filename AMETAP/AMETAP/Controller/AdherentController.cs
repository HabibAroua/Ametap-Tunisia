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
    public class AdherentController
    {
        //Adherent a;
        AdherentDA aDA;
        public AdherentController()
        {
            aDA = new AdherentDA();
        }

        public void affihcer(DataGridView d)
        {
            d.DataSource = aDA.sellectAll();
        }

        public void Supprimer(int matricule)
        {
            Boolean test = aDA.delete(matricule);
            ParticipantController pc = new ParticipantController();
            if (test == true)
            {
                MessageBox.Show("Cet adherent a été supprimé !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pc.Suuprimer(matricule);
            }
            else
            {
                MessageBox.Show("Erreur de suppresion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void recherche(DataGridView d,String recherche)
        {
            d.DataSource=aDA.search(recherche);
        }
    }
}
