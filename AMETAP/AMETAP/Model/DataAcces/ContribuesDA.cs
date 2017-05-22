using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using AMETAP.Model.Business;
namespace AMETAP.Model.DataAcces
{
    public class ContribuesDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public ContribuesDA()
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
        public Boolean delete(object o)
        {
            throw new NotImplementedException();
        }

        public Boolean insert(object o)
        {
           try
            {
                Contribues c = (Contribues)o;
                int id = c.id;
                String mensualite = c.mensualite;
                double montant = c.montant;
                int matricule = c.a.matriculeEtap;
                int idBudget = c.b.id;
                string req = string.Format("insert into Contribues values (contribues_auto_inscr.nextval ,'"+mensualite+"' , "+(decimal)montant+" , "+(decimal)matricule+" , "+(decimal)idBudget+")");
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable search(string objet)
        {
            throw new NotImplementedException();
        }

        public DataTable sellectAll()
        {
            throw new NotImplementedException();
        }

        public Boolean update(object o1, object o2)
        {
            throw new NotImplementedException();
        }
    }
}
