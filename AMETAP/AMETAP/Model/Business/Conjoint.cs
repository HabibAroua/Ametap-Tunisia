using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Conjoint
    {
        public int cin
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

        public String metier
        {
            get;
            set;
        }

        public Conjoint(int cin,String nom,String prenom,String date_naissance,String metier)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.metier = metier;
        }
    }
}
