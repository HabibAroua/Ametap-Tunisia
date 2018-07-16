using System;
using AMETAP.Model.DataAcces;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AMETAP.Controller
{
    public class AdherentController
    {
        AdherentDA aDA;
        ParticipantDA participantDA;
        ParticipationDA participationDA;
        ConjointDA conjointDA;
        EnfantDA enfantDA;
        public AdherentController()
        {
            aDA = new AdherentDA();
            participantDA = new ParticipantDA();
            participationDA = new ParticipationDA();
            conjointDA = new ConjointDA();
            enfantDA = new EnfantDA();
        }

        public void affihcer(DataGridView d)
        {
            d.DataSource = aDA.sellectAll();
        }

        public void Supprimer(int matricule)
        {
            List<int> listEnfant = enfantDA.findIdByMatricule(matricule);
            foreach(int id in listEnfant)
            {
                participationDA.delete(id);
                enfantDA.delete(id);
                participantDA.delete(id);
            }
            int cin = conjointDA.findCinByMatricule(matricule);
            participationDA.delete(cin);
            conjointDA.delete(cin);
            participantDA.delete(cin);
            participationDA.delete(matricule);
            aDA.delete(matricule);
            Boolean test=participantDA.delete(matricule);
            if (test == true)
            {
                MessageBox.Show("La suppression de cet adhérent est effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur de suppression !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void recherche(DataGridView d,String recherche)
        {
            d.DataSource=aDA.search(recherche);
        }
    }
}
