using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces.PLSQL;
using System.Data.OleDb;

namespace AMETAP.Model.DataAcces
{
    public class AdherentDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        public AdherentDA()
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
            return false;
        }
        public Boolean update(Object o1, Object o2)
        {
            return false;
        }
        public Boolean delete(Object o)
        {
            try
            {
                int matricule = (int)o;

                Pl_SQL plsql = new Pl_SQL();
                string req = string.Format(plsql.SupprimerAdherent(matricule));
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
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select Personnel.matricule , Personnel.nom , Personnel.prenom , Adherent.login from Personnel , Adherent where Personnel.matricule=Adherent.matriculeAmetap", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Adherent");
            tab1 = dtst.Tables["Adherent"];
            return tab1;
        }
        public DataTable search(String objet)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select Personnel.matricule , Personnel.nom , Personnel.prenom , Adherent.login from Personnel , Adherent where (Personnel.matricule=Adherent.matriculeAmetap) AND ((Adherent.login LIKE LOWER('"+objet+"%') or Adherent.login LIKE UPPER('"+objet+"%')) )", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Adherent");
            tab1 = dtst.Tables["Adherent"];
            return tab1;
        }
    }
}
