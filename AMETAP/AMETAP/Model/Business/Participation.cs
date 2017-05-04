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

        public Payaiment payaiment
        {
            get;
            set;
        }

        public Participant participant
        {
            get;
            set;
        }

        public Activite activite
        {
            get;
            set;
        }

        public Participation()
        {

        }

        public Participation(int id,Participant participant)
        {
            this.id = id;
            this.participant = participant;
        }

        public Participation(int id,String date_part,int etat,String notif)
        {
            this.id = id;
            this.date_part = date_part;
            this.notif = notif;
        }
        

        public Participation(int id, String date_part, int etat, String notif, Payaiment payaiment)
        {
            this.id = id;
            this.date_part = date_part;
            this.notif = notif;
            this.payaiment = payaiment;
        }

        public Participation(int id, String date_part, int etat, String notif, Payaiment payaiment,Participant participant,Activite activite)
        {
            this.id = id;
            this.date_part = date_part;
            this.notif = notif;
            this.payaiment = payaiment;
            this.participant = participant;
            this.activite = activite;
        }

        public Participation(int id)
        {
            this.id = id;
        }
    }
}
