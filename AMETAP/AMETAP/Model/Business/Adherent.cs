using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace AMETAP.Model.Business
{
    public class Adherent
    {
        //Implement attribut
        public int matriculeAmetap
        {
            get;
            set;
        }

        public int matriculeEtap
        {
            get;
            set;
        }


        public String login
        {
            get;
            set;
        }
        public String password
        {
            get;
            set;
        }
        //Constructeur
        public Adherent(int matriculeAmetap, int matriculeEtap,String login,String password)
        {
            this.matriculeAmetap = matriculeAmetap;
            this.matriculeEtap = matriculeEtap;
            this.login = login;
            this.password = password;
        }
    }
}
