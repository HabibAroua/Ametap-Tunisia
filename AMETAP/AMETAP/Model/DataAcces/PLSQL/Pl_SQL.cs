using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.DataAcces.PLSQL
{
    public class Pl_SQL
    {
        public Pl_SQL()
        {

        }
        public String Inscrire(int matricule,String login,String password)
        {
            return "Begin Inscrire("+matricule+",'"+login+"','"+password+"'); end;  ";
        }

        public String SupprimerClub(int id)
        {
            return "Begin SupprimerClub("+id+"); end;  ";
        }

        public String SupprimerAgence(int id)
        {
            return "Begin SupprimerAgence("+id+"); end;  ";
        }

        public String SupprimerCentre(int id)
        {
            return "Begin SupprimerCentre("+id+"); end;  ";
        }

        public String ModifierAgence(int id ,String nomOrganisateur , String email ,String adresse ,String description)
        {
            return "Begin ModifierAgence(" + id + ",'" + nomOrganisateur + "','" + email + "','" + adresse + "','" + description + "'); END;";

        }

        public String ModifierCentre(int id, String nomOrganisateur, String email, String adresse, String description)
        {
            return "Begin ModifierCentre(" + id + ",'" + nomOrganisateur + "','" + email + "','"+adresse+"','" + description + "'); END;";
        }

        public String ModifierClub(int id, String nomOrganisateur, String email, String adresse, String description)
        {
            return "Begin ModifierClub(" + id + ",'" + nomOrganisateur + "','" + email + "','" + adresse + "','" + description + "'); END;";

        }

        public String SupprimerParticipant(int matricule)
        {
            return "Begin SupprimerParticipant(" + matricule + "); end;  ";
        }

        public String SupprimerAdherent(int matricule)
        {
            return "Begin SupprimerAdherent(" + matricule + "); end;  ";
        }

        public String SupprimerAdmin(int matricule)
        {
            return "Begin SupprimerAdmin(" + matricule + "); end;  ";
        }

        public String FixerBudget(int id,int annee,double montant_provisoiore,double montant_final,double montantCat1, double montantCat2)
        {
            return "Begin FixerBudget("+id+","+annee+","+montant_provisoiore+","+montant_final+","+montantCat1+","+montantCat2+"); end;";
        }

        public String AjouterActivite(String nom_activite,int capacite ,String date_debut
            ,String date_fin,double prix_unitaire, double montant_prevu,
            double montant_actuel,int idBudgetCat,int idOrganisateur,String date_debut_inscription,String date_fin_inscription)
        {
            return "Begin AjouterActivite('" + nom_activite + "'," + capacite + ",'" + date_debut + "','" + date_fin + "',"+prix_unitaire+"," + montant_prevu + "," + montant_actuel +"," + idBudgetCat + ","+idOrganisateur+",'"+date_debut_inscription+"','"+date_fin_inscription+"'); end;";
        }

        public String SupprimerActivite(int id,double montant_prevu)
        {
            return "Begin SupprimerActivite(" + id + "," + montant_prevu + "); end;";
        }

        public String ModifierActivite(int id, String nomActivite, int capacite, int idTypeActivite, int idOrganisateur)
        {
            return "Begin ModifierActivite(" + id + ",'" + nomActivite + "'," + capacite + "," + idTypeActivite + "," + idOrganisateur + "); end;";
        }

        public String AccepterDemandeAdherent(int matricule,int idActivite,int id,int valeur)
        {
            return "Begin AccepterDemandeAdherent("+matricule+","+idActivite+","+id+","+valeur+"); END;";
        }

        public String RefuserDemandeAdherent(int id)
        {
            return "Begin RefuserDemandeAdherent(" + id + "); END;";
        }

        public String AccepterDemandeEnfant(int matricule, int idActivite, int id, int valeur)
        {
            return "Begin AccepterDemandeEnfant(" + matricule + "," + idActivite + "," + id + "," + valeur + "); END;";
        }

        public String AccepterDemandeConjoint(int matricule, int idActivite, int id, int valeur)
        {
            return "Begin AccepterDemandeConjoint(" + matricule + "," + idActivite + "," + id + "," + valeur + "); END;";
        }
    }
}
