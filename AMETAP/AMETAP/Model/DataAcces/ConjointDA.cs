using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace AMETAP.Model.DataAcces
{
    public class ConjointDA :IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        public ConjointDA()
        {
            try
            {
                cn = new OleDbConnection(Properties.Settings.Default.ch);
                cmd = new OleDbCommand();
            }
            catch (OleDbException)
            {

            }


        }

        public Boolean insert(Object o)
        {
            return true;
        }
        public Boolean update(Object o1, Object o2)
        {
            return false;
        }
        public Boolean delete(Object o)
        {
            try
            {
                int cin = (int)o;
                string req = string.Format("delete Conjoint where cin=" + cin);
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
        public DataTable sellectAll()
        {
            return null;
        }
        public DataTable search(String objet)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select * from Conjoint where matricule ="+objet+"", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Conjoint");
            tab1 = dtst.Tables["Conjoint"];
            return tab1;
        }

        public int findCinByMatricule(int matricule)
        {
            int cin = 0;
            string req = string.Format("select Conjoint.cin from Conjoint where matricule="+matricule);
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                cin = (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return cin;
        }

    }
}
