using System;

namespace AMETAP.Model.Business
{
    public class Nature_Agent
    {

        public int id_natureAgent
        {
            get;
            set;
        }

        public String description
        {
            get;
            set;
        }
       
        public Nature_Agent(int id_natureAgent, String description)
        {
            this.id_natureAgent = id_natureAgent;
            this.description = description;
        }
    }
}
