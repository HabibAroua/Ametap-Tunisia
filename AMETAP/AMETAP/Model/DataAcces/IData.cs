using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AMETAP.Model.DataAcces
{
    public interface IData
    {
        Boolean insert(Object o);
        Boolean update(Object o1, Object o2);
        Boolean delete(Object o);
        DataTable sellectAll();
        DataTable search(String objet);

    }
}
