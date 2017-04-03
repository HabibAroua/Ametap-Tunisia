using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Budget
    {
        public int id
        {
            get;
            set;
        }

        public int annee
        {
            get;
            set;
        }

        public double montant_provisoire
        {
            get;
            set;
        }

        public double montant_final
        {
            get;
            set;
        }

        public Budget(int id,int annee,double montant_provisoire,double montant_final)
        {
            this.id = id;
            this.annee = annee;
            this.montant_provisoire = montant_provisoire;
            this.montant_final = montant_final;
        }
    }
}
