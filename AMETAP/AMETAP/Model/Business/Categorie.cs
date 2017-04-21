using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
