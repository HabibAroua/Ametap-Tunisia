using System;

namespace AMETAP.Model.Business
{
    public class TypeActivite
    {
        public int id
        {
            get;
            set;
        }

        public String libelle
        {
            get;
            set;
        }

        public TypeActivite()
        {}

        public TypeActivite(int id,String libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
