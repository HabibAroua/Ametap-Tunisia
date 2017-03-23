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
    }
}
