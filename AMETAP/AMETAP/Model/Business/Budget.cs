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

        public BudgetCategorie b1
        {
            get;
            set;
        }

        public BudgetCategorie b2
        {
            get;
            set;
        }

        public Budget(int id,int annee,double montant_provisoire,double montant_final, BudgetCategorie b1,BudgetCategorie b2)
        {
            this.id = id;
            this.annee = annee;
            this.montant_provisoire = montant_provisoire;
            this.montant_final = montant_final;
            this.b1 = b1;
            this.b2 = b2;
        }

        public Budget(int id)
        {
            this.id = id;
        }

        public Budget(int annee, double montant_final)
        {
            this.annee = annee;
            this.montant_final = montant_final;
        }
    }
}
