using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Participation
    {
        public int id
        {
            get;
            set;
        }

        public String date_part
        {
            get;
            set;
        }

        public int etat
        {
            get;
            set;
        }

        public String notif
        {
            get;
            set;
        }

        public Participation(int id,String date_part,int etat,String notif)
        {
            this.id = id;
            this.date_part = date_part;
            this.notif = notif;
        }
    }
}
