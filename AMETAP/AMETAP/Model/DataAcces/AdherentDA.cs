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
            adap1 = new OleDbDataAdapter("Select Personnel.matricule,Personnel.cin, Personnel.nom, Personnel.prenom, Personnel.ETAT_CIVIL, Personnel.NBR_ENFANT, Personnel.DATE_NAISSAINCE,Personnel.lieu,Personnel.adresse,Personnel.Tel, Adherent.login, Adherent.NOMBRE_POINT as Point from Personnel , Adherent where Personnel.matricule = Adherent.matriculeAmetap", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Adherent");
            tab1 = dtst.Tables["Adherent"];
            return tab1;
        }
        public DataTable search(String objet)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select Personnel.matricule , Personnel.nom , Personnel.prenom , Adherent.login, Adherent.NOMBRE_POINT from Personnel , Adherent where (Personnel.matricule=Adherent.matriculeAmetap) AND ((Adherent.login LIKE LOWER('" + objet+"%') or Adherent.login LIKE UPPER('"+objet+"%')) )", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Adherent");
            tab1 = dtst.Tables["Adherent"];
            return tab1;
        }

        public List<String> listAdresse()
        {
            List<String> list = new List<string>();
            string req = string.Format("select Personnel.EMAIL from personnel , adherent where Personnel.matricule=Adherent.matriculeEtap");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                list.Add(Reader.GetString(0));
            }
            Reader.Close();
            cn.Close();
            return list;
        }

        public List<String> listAdresse(int matricule)
        {
            List<String> list = new List<string>();
            string req = string.Format("select Personnel.EMAIL from personnel , adherent where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap="+matricule);
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                list.Add(Reader.GetString(0));
            }
            Reader.Close();
            cn.Close();
            return list;
        }

        public List<int> listMatricule()
        {
            List<int> list = new List<int>();
            string req = string.Format("select matriculeEtap From Adherent");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                int values = (int)Reader.GetDecimal(0);
                list.Add(values);
            }
            Reader.Close();
            cn.Close();
            return list;
        }

        public void InitialiserNombrePoint()
        {
            string req = string.Format("update Adherent set NOMBRE_POINT=100");
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public int getNombrePoint(int matricule)
        {
            int nb = 0;
            string req = string.Format("select nombre_point from Adherent where matriculeEtap="+matricule);
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                nb= (int)(Reader.GetDecimal(0));
            }
            Reader.Close();
            cn.Close();
            return nb;
        }
    }
}
