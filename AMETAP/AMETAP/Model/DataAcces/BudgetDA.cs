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
    public class BudgetDA :IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataAdapter adap1;
        DataTable tab1;
        public BudgetDA()
        {
            cn = new OleDbConnection(Properties.Settings.Default.ch);
            cmd = new OleDbCommand();
        }
        public Boolean insert(Object o)
        {
            try
            {
                Budget b = (Budget)o;
                int id = b.id;
                int annee  = b.annee;
                double montant_provisoire = b.montant_provisoire;
                double montant_final = b.montant_final;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.FixerBudget(annee, montant_provisoire, montant_final));
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
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select * from Budget", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Budget");
            tab1 = dtst.Tables["Budget"];
            return tab1;
        }
        public DataTable search(String objet)
        {
            return null;
        }

        public int LastYear()
        {
            cmd=cn.CreateCommand();
            cmd.CommandText = "select MAX(annee) from Budget";
            cn.Open();
            decimal r = 0;
            r = Convert.ToDecimal(cmd.ExecuteScalar());
            cn.Close();
            return (int)r;
        }

        public double LastPrixProvisore()
        {
            return 1;
        }

        public int findIdByLastYear()
        {
            int id = 0;
            string req = string.Format("SELECT id  FROM Budget where annee=" + LastYear() + "");
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
