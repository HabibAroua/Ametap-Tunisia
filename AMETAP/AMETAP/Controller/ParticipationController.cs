using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.DataAcces;
using System.Windows.Forms;
using System.Data;
using AMETAP.Model.Business;

namespace AMETAP.Controller
{
    public class ParticipationController
    {
        ParticipationDA pDA;
        ActiviteDA aDA;
        PersonnelDA perDA;
        public ParticipationController()
        {
            pDA = new ParticipationDA();
            aDA = new ActiviteDA();
            perDA = new PersonnelDA();
        }

        public void AfficheDemande(DataGridView d)
        {
            d.DataSource = pDA.sellectAll();
        }

        public void AfficheDemandeParActivite(DataGridView d,int idActivite)
        {
            d.DataSource = pDA.selectDemandeParActivite(idActivite);
        }

        public void Accepter(int matricule , int idActivite , int id ,int valeur)
        {
            if(aDA.getCapacite(idActivite)==aDA.getNombreParticipant(idActivite))
            {
                MessageBox.Show("Vous êtes pas accepter autres demandes ! le nombre de place est plein ", "Errur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Boolean test = false;
                if(perDA.getEtat_Civil(matricule)=="M")
                {
                    test = pDA.accepter(new Participation(id, "", 1, "", new Payaiment(0, 0), new Participant(matricule), new Activite(idActivite)), valeur*2);
                }
                else
                {
                    test = pDA.accepter(new Participation(id, "", 1, "", new Payaiment(0, 0), new Participant(matricule), new Activite(idActivite)), valeur);
                }
                if (test == true)
                {
                    //MessageBox.Show("Inscription effectué", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   // MessageBox.Show("Erreur d'inscription", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void refuser(int id)
        {
            Boolean test = pDA.refuser(new Participation(id));
            if(test==true)
            {
                //MessageBox.Show("Votre demande est réfusé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getParticipationAdherent(DataGridView d,int idActivite)
        {
            d.DataSource = pDA.getParticipationAdherent(idActivite);
        }

        public List<Participation> DemandeList(int idActivite)
        {
             return pDA.affich(idActivite);
        }
    }

}