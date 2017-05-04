using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Participant
    {
        //Implemment attribut
        public int matricule
        {
            get;
            set;
        }

        public String date_inscription
        {
            get;
            set;
        }

        public Adherent adherent
        {
            get;
            set;
        }

        public Conjoint conjoint
        {
            get;
            set;
        }

        public Enfant enfant
        {
            get;
            set;
        }
        //Constructeur
        public Participant(int matricule,String date_inscription)
        {
            this.matricule = matricule;
            this.date_inscription = date_inscription;
        }

        public Participant()
        {

        }
        public Participant(int matricule)
        {
            this.matricule = matricule;
        }

        public Participant(int matricule ,String date_inscription,Adherent adherent)
        {
            this.matricule = matricule;
            this.date_inscription = date_inscription;
            this.adherent = adherent;
        }

        public Participant(int matricule ,String date_inscription,Conjoint conjoint)
        {
            this.matricule = matricule;
            this.date_inscription = date_inscription;
            this.conjoint = conjoint;
        }

        public Participant(int matricule,String date_inscription,Enfant enfant)
        {
            this.matricule = matricule;
            this.date_inscription = date_inscription;
            this.enfant = enfant;
        }

        
    }
}
