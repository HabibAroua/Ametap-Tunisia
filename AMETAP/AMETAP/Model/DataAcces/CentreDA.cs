using System;
using System.Data.OleDb;
using System.Data;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces.PLSQL;

namespace AMETAP.Model.DataAcces
{
    public class CentreDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public CentreDA()
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
                Centre c = (Centre)o;
                int id = c.id;
                String description = c.description;
                string req = string.Format("insert into Centre values (" + id + ",'" + description + "')");
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
            try
            {
                Organisateur or = (Organisateur)o1;
                Centre c = (Centre)o2;
                int id = or.id;
                String nom = or.nom_organisateur;
                String email = or.email;
                String adresse = or.adresse;
                String description = c.description;
                Pl_SQL plsql = new Pl_SQL();
                string req = string.Format(plsql.ModifierCentre(id, nom, email, adresse, description));
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

        public Boolean delete(Object o)
        {
            try
            {
                int id = (int)o;

                Pl_SQL plsql = new Pl_SQL();
                string req = string.Format(plsql.SupprimerCentre(id));
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

        public DataTable sellectAll()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select  * from Organisateur , Centre where Organisateur.id=Centre.id   ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Organisateur");
            tab1 = dtst.Tables["Organisateur"];
            return tab1;
        }

        public DataTable search(String objet)
        {
            return null;
        }
    }
}
