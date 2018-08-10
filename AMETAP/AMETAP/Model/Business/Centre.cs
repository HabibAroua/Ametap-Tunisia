using System;

namespace AMETAP.Model.Business
{
    public class Centre
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
        
        public Centre(int id,String description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
