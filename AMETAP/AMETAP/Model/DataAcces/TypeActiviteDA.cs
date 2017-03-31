using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AMETAP.Model.DataAcces
{
    class TypeActiviteDA : IData
    {
        public Boolean insert(Object o)
        {
            return true;
        }
        public Boolean update(Object o1, Object o2)
        {
            return true;
        }
        public Boolean delete(Object o)
        {
            return true;
        }
        public DataTable sellectAll()
        {
            return null;
        }
        public DataTable search(String objet)
        {
            return null;
        }
    }
}
