using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMETAP.Model.DataAcces
{
    public class PersonnelDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public PersonnelDA()
        {
            try
            {
                cn = new OleDbConnection(Properties.Settings.Default.ch);
                cmd = new OleDbCommand();
            }
            catch(OleDbException)
            {

            }
        }
        public bool delete(object o)
        {
            throw new NotImplementedException();
        }

        public bool insert(object o)
        {
            throw new NotImplementedException();
        }

        public DataTable search(string objet)
        {
            throw new NotImplementedException();
        }

        public DataTable sellectAll()
        {
            throw new NotImplementedException();
        }

        public bool update(object o1, object o2)
        {
            throw new NotImplementedException();
        }

        public String getEtat_Civil(int matricule)
        {
            String  res = "";
            string req = string.Format("select etat_civil from Personnel where matricule="+matricule+"");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res = Reader.GetString(0);
            }
            Reader.Close();
            cn.Close();
            return res;
        }
    }
}
