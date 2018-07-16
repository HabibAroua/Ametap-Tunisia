using System;

namespace AMETAP.Model.Business
{
    public class Categorie
    {
        public int id
        {
            get;
            set;
        }

        public String libelle
        {
            get;
            set;
        }

        public Categorie(int id,String libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
