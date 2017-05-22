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

        public Personnel personnel
        {
            get;
            set;
        }
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

        public int nombre_point
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

        public Adherent( String login, String password,int nombre_point,Personnel personnel)
        {
            this.login = login;
            this.password = password;
            this.nombre_point = nombre_point;
            this.personnel = personnel;
        }

        public Adherent(Personnel personnel,int nombre_point)
        {
            this.personnel = personnel;
            this.nombre_point = nombre_point;
        }

        public Adherent(int matriculeEtap)
        {
            this.matriculeEtap = matriculeEtap;
        }
    }
}
