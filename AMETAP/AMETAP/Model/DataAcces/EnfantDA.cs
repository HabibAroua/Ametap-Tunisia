using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace AMETAP.Model.DataAcces
{
    public class EnfantDA :IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        public EnfantDA()
        {
            try
            {
                cn = new OleDbConnection(Properties.Settings.Default.ch);
                cmd = new OleDbCommand();
            }
            catch (OleDbException ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
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
            try
            {
                int id = (int)o;
                string req = string.Format("delete enfant where id="+id);
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException ex)
            {
                System.Console.WriteLine("error : " + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
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

        public List<int> findIdByMatricule(int matricule)
        {
            List<int> list = new List<int>();
            string req = string.Format("select distinct Enfant.id from Enfant where matricule=" + matricule);
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                list.Add((int)Reader.GetDecimal(0));
            }
            Reader.Close();
            cn.Close();
            return list;
        }
    }
}
