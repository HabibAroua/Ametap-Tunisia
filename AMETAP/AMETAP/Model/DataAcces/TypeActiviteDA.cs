using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using AMETAP.Model.Business;
namespace AMETAP.Model.DataAcces
{
    class TypeActiviteDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        public TypeActiviteDA()
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

        public List<TypeActivite> SelectAll()
        {
            List<TypeActivite> listTypeActivite = new List<TypeActivite>();
            string req = string.Format("SELECT *  FROM Type_Activite");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                TypeActivite ta = new TypeActivite((int)Reader.GetDecimal(0), Reader.GetString(1));
                listTypeActivite.Add(ta);
            }
            Reader.Close();
            cn.Close();
            return listTypeActivite;
        }

        public int findIdByLibelle(String libelle)
        {
            int id = 0;
            string req = string.Format("SELECT id  FROM Type_Activite where libelle='"+libelle+"'");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                id = (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return id;
        }
    }
}
