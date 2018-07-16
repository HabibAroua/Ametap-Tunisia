using System;

namespace AMETAP.Model.Business
{
    public class Club
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
        
        public Club(int id,String description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
