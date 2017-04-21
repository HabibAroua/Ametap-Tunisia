using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class BudgetCategorie
    {
        public int id
        {
            get;
            set;
        }

        public double montant
        {
            get;
            set;
        }

  

        public BudgetCategorie(int id,double montant)
        {
            this.id = id;
            this.montant = montant;
        }
    }
}
