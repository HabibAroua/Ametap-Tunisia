using System;

namespace AMETAP.Model.Business
{
    public class Admin
    {
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
		
        public Personnel personnel
        {
            get;
            set;
        }

        public String estAdmin
        {
            get;
            set;
        }

        public Admin(Personnel personnel, String login, String password,String estAdmin)
        {
            this.personnel = personnel;
            this.login = login;
            this.password = password;
            this.estAdmin = estAdmin;
        }
    }
}
