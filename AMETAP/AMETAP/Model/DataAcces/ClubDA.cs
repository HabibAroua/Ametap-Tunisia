using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using AMETAP.Model.Business;
using System.Data;
using AMETAP.Model.DataAcces.PLSQL;
namespace AMETAP.Model.DataAcces
{

    public class ClubDA :IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        
        public ClubDA()
        {
            try
            {
                cn = new OleDbConnection(Properties.Settings.Default.ch);
                cmd = new OleDbCommand();
            }
            catch(OleDbException)
            {
                return;
            }
        }
        public Boolean insert(Object o)
        {
            try
            {
                Club c = (Club)o;
                int id = c.id;
                String description = c.description;
                string req = string.Format("insert into Club values (" + id + ",'" + description + "')");
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
            try
            {
                Organisateur or = (Organisateur)o1;
                Club c = (Club)o2;
                int id = or.id;
                String nom = or.nom_organisateur;
                String email = or.email;
                String adresse = or.adresse;
                String description = c.description;
                Pl_SQL plsql = new Pl_SQL();
                string req = string.Format(plsql.ModifierClub(id,nom,email,adresse,description));
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
        public Boolean delete(Object o)
        {
            try
            {
                int id = (int)o;

                Pl_SQL plsql = new Pl_SQL();
                string req = string.Format(plsql.SupprimerClub(id));
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
            adap1 = new OleDbDataAdapter("Select  * from Organisateur , Club where Organisateur.id=Club.id   ", Properties.Settings.Default.ch);
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
