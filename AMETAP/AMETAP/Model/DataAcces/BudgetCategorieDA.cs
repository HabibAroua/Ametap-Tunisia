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
    public class BudgetCategorieDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public BudgetCategorieDA()
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
            //try
            //{
                //BudgetCategorie b = (BudgetCategorie)o;
                //double montant = b.montant;
                //int idBudget = b.budget.id;
                //string req = string.Format(plSql.Inscrire(matricule, login, password));
                //cmd.Connection = cn;
                //cn.Open();
                //cmd.CommandText = req;
                //cmd.ExecuteNonQuery();
              //  return true;
            //}
            //catch (OleDbException)
            //{
            //  return false;
            //}
            //finally
            //{
            //  cn.Close();
            //}
            return false;
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
    }
}
