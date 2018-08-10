using System;

namespace AMETAP.Model.Business
{
    public class Adherent
    {

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
