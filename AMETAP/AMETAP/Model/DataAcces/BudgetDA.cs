using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using AMETAP.Model.Business;

namespace AMETAP.Model.DataAcces
{
    public class BudgetDA :IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        public BudgetDA()
        {
            try
            {
                cn = new OleDbConnection(Properties.Settings.Default.ch);
                cmd = new OleDbCommand();
            }
            catch(OleDbException ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
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
                double montantBudget1 = b.b1.montant;
                double montantBudget2 = b.b2.montant;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.FixerBudget(id,annee,montant_provisoire,montant_final,montantBudget1,montantBudget2));
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
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
            adap1 = new OleDbDataAdapter("Select * from Budget order by annee desc", Properties.Settings.Default.ch);
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
            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = "select MAX(annee) from Budget";
                cn.Open();
                decimal r = 0;
                r = Convert.ToDecimal(cmd.ExecuteScalar());
                cn.Close();
                return (int)r;
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return 2005;
            }
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

        public int getBudget(String annee)
        {
            int budget = 0;
            string req = string.Format("select BUDGET_ACCRDE from Budget where Annee=" + annee);
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                budget = (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return budget;
        }

        public int maxID()
        {
            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = "select MAX(id) from Budget";
                cn.Open();
                decimal r = 0;
                r = Convert.ToDecimal(cmd.ExecuteScalar());
                cn.Close();
                return (int)r;
            }
            catch (InvalidCastException ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        public void AjouterValeurBudget(int id,int valeur)
        {
            try
            {
                string req = string.Format("update Budget set BUDGET_ACTUEL=BUDGET_ACTUEL+"+valeur+"where id="+id);
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Budget>listBudget()
        {
            List<Budget> list = new List<Budget>();
            string req = string.Format("Select  annee , Budget_Actuel from Budget order by Annee asc");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                list.Add(new Budget((int)Reader.GetDecimal(0),(double)Reader.GetDecimal(1)));
            }
            Reader.Close();
            cn.Close();
            return list;
        }
    }
}
