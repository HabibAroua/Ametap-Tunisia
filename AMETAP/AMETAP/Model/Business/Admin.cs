using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Admin
    {
        //Implemment attribut
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

        //Constructeur
        public Admin(Personnel personnel, String login, String password,String estAdmin)
        {
            this.personnel = personnel;
            this.login = login;
            this.password = password;
            this.estAdmin = estAdmin;
        }
    }
}
