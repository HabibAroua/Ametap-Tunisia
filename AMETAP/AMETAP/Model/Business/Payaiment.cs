namespace AMETAP.Model.Business
{
    public class Payaiment
    {
        public int id
        {
            get;
            set;
        }

        public int etat
        {
            get;
            set;
        }

        public Payaiment(int id,int etat)
        {
            this.id = id;
            this.etat = etat;
        }
    }
}
