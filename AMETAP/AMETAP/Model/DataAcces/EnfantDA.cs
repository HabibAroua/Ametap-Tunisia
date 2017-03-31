using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace AMETAP.Model.DataAcces
{
    public class EnfantDA :IData
    {
        public EnfantDA()
        {

        }

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
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select * from Enfant where matricule="+objet+"", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Enfant");
            tab1 = dtst.Tables["Enfant"];
            return tab1;
        }
    }
}
