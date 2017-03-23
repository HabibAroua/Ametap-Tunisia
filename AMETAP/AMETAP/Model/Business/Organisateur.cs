using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Organisateur
    {
        //Implemment attribut
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
        //constructeur sans paramétre 
        public Organisateur()
        { }
        //Constructeur 
        public Organisateur(int id, String nom_organisateur,String email,String adresse)
        {
            this.id = id;
            this.nom_organisateur = nom_organisateur;
            this.adresse = adresse;
            this.email = email;
        }

    }
}
