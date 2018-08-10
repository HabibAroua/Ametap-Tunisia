using System;

namespace AMETAP.Model.Business
{
    public class Personnel
    {
        
        public Personnel()
        { }
        
        public int matricule
        {
            get;
            set;
        }
		
        public String nom
        {
            get;
            set;
        }
		
        public String prenom
        {
            get;
            set;
        }
		
        public int ID_NATURAGENT
        {
            get;
            set;
        }
		
        public int CODE_FONC
        {
            get;
            set;
        }
		
        public int PERS_CET
        {
            get;
            set;
        }

        public String sex
        {
            get;
            set;
        }

        public String Etat_Civil
        {
            get;
            set;
        }

        public int nombre_enfant
        {
            get;
            set;
        }

        public String date_naissance
        {
            get;
            set;
        }

        public String Lieu
        {
            get;
            set;
        }
		
        public String cin
        {
            get;
            set;
        }
		
        public String adresse
        {
            get;
            set;
        }
		
        public String date_recrutement
        {
            get;
            set;
        }

        public String pers_affect
        {
            get;
            set;
        }
		
        public String ocuupation
        {
            get;
            set;
        }

        public int code_banque
        {
            get;
            set;
        }
		
        public int code_agence
        {
            get;
            set;
        }

        public int numero_compte
        {
            get;
            set;
        }
		
        public String tel
        {
            get;
            set;
        }

        public String email
        {
            get;
            set;
        }
        
        public Personnel(int matricule, String nom, String prenom, int ID_NATURAGENT, int CODE_FONC, int PERS_CET,
            String sex, String Etat_Civil, int nombre_enfant, String date_naissance, String Lieu, String cin,
            String adresse, String tel, String date_recrutement, String pers_affect, String ocuupation, int code_banque
            , int code_agence, int numero_compte, String email)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.ID_NATURAGENT = ID_NATURAGENT;
            this.CODE_FONC = CODE_FONC;
            this.PERS_CET = PERS_CET;
            this.sex = sex;
            this.Etat_Civil = Etat_Civil;
            this.nombre_enfant = nombre_enfant;
            this.date_naissance = date_naissance;
            this.Lieu = Lieu;
            this.cin = cin;
            this.adresse = adresse;
            this.tel = tel;
            this.date_recrutement = date_recrutement;
            this.pers_affect = pers_affect;
            this.ocuupation = ocuupation;
            this.code_banque = code_banque;
            this.code_agence = code_agence;
            this.numero_compte = numero_compte;
            this.email = email;
        }

        public Personnel(String nom,String prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

    }
}

