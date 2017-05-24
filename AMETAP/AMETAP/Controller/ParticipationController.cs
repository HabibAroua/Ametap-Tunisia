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

        public void AccepterAdherent(int matricule , int idActivite , int id ,int valeur)
        {
            if (aDA.getCapacite(idActivite) == aDA.getNombreParticipant(idActivite))
            {
                MessageBox.Show("Vous êtes pas accepter autres demandes ! le nombre de place est plein ", "Errur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (((aDA.getNombreParticipant(matricule) <= 0)) || (valeur > aDA.getNombreParticipant(matricule)))
                {
                    MessageBox.Show("Le point de cet adherent " + matricule + "n'est pas suffisant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    Boolean test1 = pDA.accepterAdherent(matricule, idActivite, 0, 0);

                    if (test1 == true)
                    {
                        MessageBox.Show("Inscription de l'adherent effectué ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }             
            }

        }

        public void AccepterConjoint(int matricule, int idActivite, int id, int valeur)
        {
            if (aDA.getCapacite(idActivite) == aDA.getNombreParticipant(idActivite))
            {
                MessageBox.Show("Vous êtes pas accepter autres demandes ! le nombre de place est plein ", "Errur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Boolean test1 = pDA.accepterConjoint(matricule, idActivite, 0, 0);

                if (test1 == true)
                {
                    MessageBox.Show("Inscription de l'adherent effectué ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        public void AccepterEnfant(int matricule, int idActivite, int id, int valeur)
        {
            if (aDA.getCapacite(idActivite) == aDA.getNombreParticipant(idActivite))
            {
                MessageBox.Show("Vous êtes pas accepter autres demandes ! le nombre de place est plein ", "Errur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Boolean test2 = pDA.accepterEnfant(matricule, idActivite, 0, 0);
                if (test2 == true)
                {
                    MessageBox.Show("Inscription de Enfant effectué ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void confirmerPaiyment(int matricule, int idActivite, int id, int valeur)
        {
            pDA.confirmePaymentAdherent(matricule, idActivite, id, valeur);
            pDA.confirmePaymentConjoint(matricule, idActivite, id, valeur);
            pDA.confirmePaymentEnfant(matricule, idActivite, id, valeur);
        }

        public void getAllParticipant(DataGridView d, int idActivite)
        {
            d.DataSource = pDA.getAllParticipant(idActivite);
        }

        public void getParticipationAdherent(DataGridView d,int idActivite)
        {
            d.DataSource = pDA.getParticipationAdherent(idActivite);
        }

        public void getParticipationConjoint(DataGridView d,int idActivite)
        {
            d.DataSource = pDA.getParticipantConjoint(idActivite);
        }

        public void getParticipationEnfant(DataGridView d,int idActivite)
        {
            d.DataSource = pDA.getParticipantEnfant(idActivite);
        }

        public List<Participation> DemandeListAdherent(int idActivite)
        {
             return pDA.affich(idActivite);
        }

        public List<Participation> DemandeListConjoint(int idActivite)
        {
            return pDA.affichConjoint(idActivite);
        }

        public List<Participation> DemandeListEnfant(int idActivite)
        {
            return pDA.affichEnfant(idActivite);
        }

        public List<Participation> AllDemande(int idActivite)
        {
            List<Participation> listAll = new List<Participation>();
            foreach(Participation p in DemandeListAdherent(idActivite))
            {
                listAll.Add(p);
            }
            foreach(Participation p in DemandeListConjoint(idActivite))
            {
                listAll.Add(p);
            }
            foreach(Participation p in DemandeListEnfant(idActivite))
            {
                listAll.Add(p);
            }
            return listAll;
        }
    }
}