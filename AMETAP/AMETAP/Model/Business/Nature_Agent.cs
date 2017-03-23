using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Nature_Agent
    {
        //implemment attribut
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
        //Constructeur
        public Nature_Agent(int id_natureAgent, String description)
        {
            this.id_natureAgent = id_natureAgent;
            this.description = description;
        }
    }
}
