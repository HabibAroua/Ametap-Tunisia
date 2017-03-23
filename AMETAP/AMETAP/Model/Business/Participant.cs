using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Participant
    {
        //Implemment attribut
        public int matricule
        {
            get;
            set;
        }

        public String date_inscription
        {
            get;
            set;
        }
        //Constructeur
        public Participant(int matricule,String date_inscription)
        {
            this.matricule = matricule;
            this.date_inscription = date_inscription;
        }
    }
}
