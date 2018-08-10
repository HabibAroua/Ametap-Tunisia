using System;

namespace AMETAP.Model.Business
{
    public class Agence_Voyage
    {
      
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
        
        public Agence_Voyage(int id,String description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
