using System;

namespace AMETAP.Model.Business
{
    public class Contribues
    {
        public int id
        {
            get;
            set;
        }

        public String mensualite
        {
            get;
            set;
        }

        public double montant
        {
            get;
            set;
        }

        public Adherent a
        {
            get;
            set;
        }

        public Budget b
        {
            get;
            set;
        }

        public Contribues(int id,String mensualite,double montant,Adherent a,Budget b)
        {
            this.id = id;
            this.mensualite = mensualite;
            this.montant = montant;
            this.a = a;
            this.b = b;
        }

    }
}
