using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMETAP.Model.Business;
using System.Data;
using System.Data.OleDb;

namespace AMETAP.Model.DataAcces
{
    public class AdminDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public AdminDA()
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
            try
            {
                Admin a = (Admin)o;
                int matricule = a.personnel.matricule;
                String login = a.login;
                String password = a.password;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.Inscrire(matricule, login, password));
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
            try
            {
                int  matricule = (int)o;
                
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.SupprimerAdmin(matricule));
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

        public Admin Verif(String login)
        {
            Admin a=null;
            string req = string.Format("SELECT login , password , estAdmin  FROM admin where login='"+login+"'");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                Personnel p = new Personnel();
                a = new Admin(null,Reader.GetString(0), Reader.GetString(1),Reader.GetString(2));
            }
            Reader.Close();
            cn.Close();
            return a;
        }

        public DataTable sellectAll()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select Personnel.matricule , Personnel.cin, Personnel.nom, Personnel.prenom, Personnel.ETAT_CIVIL, Personnel.NBR_ENFANT, Personnel.DATE_NAISSAINCE,Personnel.lieu,Personnel.adresse,Personnel.Tel , Admin.login from Personnel , Admin where Personnel.matricule=admin.matricule", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Admin");
            tab1 = dtst.Tables["Admin"];
            return tab1;
        }

        public DataTable search(String objet)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select Personnel.matricule , Personnel.cin, Personnel.nom, Personnel.prenom, Personnel.ETAT_CIVIL, Personnel.NBR_ENFANT, Personnel.DATE_NAISSAINCE,Personnel.lieu,Personnel.adresse,Personnel.Tel , Admin.login from Personnel , Admin where (Personnel.matricule=Admin.matricule) AND ((Personnel.nom LIKE LOWER('" + objet + "%') or Personnel.nom LIKE UPPER('" + objet + "%')) )", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Adherent");
            tab1 = dtst.Tables["Adherent"];
            return tab1;
        }

    }

}

