using System;

namespace AMETAP.Model.Business
{
    public class Organisateur
    {
        
        public int id
        {
            get;
            set;
        }
        public String nom_organisateur
        {
            get;
            set;
        }

        public String email
        {
            get;
            set;
        }
        public String adresse
        {
            get;
            set;
        }
         
        public Organisateur()
        { }
         
        public Organisateur(int id, String nom_organisateur,String email,String adresse)
        {
            this.id = id;
            this.nom_organisateur = nom_organisateur;
            this.adresse = adresse;
            this.email = email;
        }

    }
}
