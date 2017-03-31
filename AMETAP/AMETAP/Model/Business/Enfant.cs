using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Enfant
    {
        public int id
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

        public String date_naissance
        {
            get;
            set;
        }
        public String ecole
        {
            get;
            set;
        }

        public Enfant(int id,String nom,String prenom,String date_naissance ,String ecole)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.ecole = ecole;
        }
    }
}
