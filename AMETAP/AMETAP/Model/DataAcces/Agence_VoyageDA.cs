using System;
using System.Data.OleDb;
using AMETAP.Model.Business;
using System.Data;
using AMETAP.Model.DataAcces.PLSQL;

namespace AMETAP.Model.DataAcces
{
    public class Agence_VoyageDA :IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public Agence_VoyageDA()
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
                Agence_Voyage ag = (Agence_Voyage)o;
                int id = ag.id;
                String description = ag.description;
                string req = string.Format("insert into Agence_Voyage values (" + id + ",'" + description + "')");
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
                Agence_Voyage av = (Agence_Voyage)o2;
                int id = or.id;
                String nom = or.nom_organisateur;
                String email = or.email;
                String adresse = or.adresse;
                String description = av.description;
                Pl_SQL plsql = new Pl_SQL();
                string req = string.Format(plsql.ModifierAgence(id, nom, email, adresse, description));
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
                string req = string.Format(plsql.SupprimerAgence(id));
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
            adap1 = new OleDbDataAdapter("Select  * from Organisateur , Agence_voyage where Organisateur.id=Agence_voyage.id   ", Properties.Settings.Default.ch);
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
