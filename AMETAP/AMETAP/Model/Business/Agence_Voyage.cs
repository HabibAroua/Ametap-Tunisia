using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.Business
{
    public class Agence_Voyage
    {
        //Implemment attribut
        public int id
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
        public Agence_Voyage(int id,String description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
