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
    public class OrganisateurDA :IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader Reader;
        public OrganisateurDA()
        {
            try
            {
                cn = new OleDbConnection(Properties.Settings.Default.ch);
                cmd = new OleDbCommand();
            }
            catch(OleDbException)
            {

            }
        }
        public Boolean insert(Object o)
        {
            try
            {
                Organisateur or = (Organisateur)o;
                int id = or.id;
                String nom_organisateur = or.nom_organisateur;
                String email = or.email;
                String adresse = or.adresse;
                string req = string.Format("insert into Organisateur values ("+id+",'"+nom_organisateur+"','"+email+"', '"+adresse+"')");
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
            return false;
        }
        public Boolean delete(Object o)
        {
            try
            {
                int id = (int)o;
                Pl_SQL plsql = new Pl_SQL();
                string req = string.Format(plsql.SupprimerOrganisateur(id));
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
            adap1 = new OleDbDataAdapter("Select Organisateur.id , Organisateur.nom_organisateur , Organisateur.Email , Organisateur.Adresse , Club.Description from Organisateur , Club where Organisateur.id=Club.id Union ALL Select Organisateur.id, Organisateur.nom_organisateur, Organisateur.Email, Organisateur.Adresse, Centre.Description from Organisateur , Centre where Organisateur.id = Centre.id Union All Select Organisateur.id, Organisateur.nom_organisateur, Organisateur.Email, Organisateur.Adresse, Agence_Voyage.Description from Organisateur , Agence_Voyage where Organisateur.id = Agence_Voyage.id ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Organisateur");
            tab1 = dtst.Tables["Organisateur"];
            return tab1;
        }

        public DataTable search(String objet)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select  Organisateur.id , Organisateur.nom_organisateur , Organisateur.email , Organisateur.adresse , Club.description   from Organisateur , Club where (Organisateur.id=Club.id) and   (nom_organisateur LIKE LOWER('"+objet+"%') or nom_organisateur LIKE UPPER('"+objet+"%')) UNION ALL Select Organisateur.id, Organisateur.nom_organisateur, Organisateur.email, Organisateur.adresse, Centre.description from Organisateur , Centre where(Organisateur.id = Centre.id) and(nom_organisateur LIKE LOWER('"+objet+"%') or nom_organisateur LIKE UPPER('"+objet+"%')) UNION ALL  Select Organisateur.id, Organisateur.nom_organisateur, Organisateur.email, Organisateur.adresse, Agence_Voyage.description from Organisateur , Agence_Voyage where(nom_organisateur LIKE LOWER('"+objet+"%') or nom_organisateur LIKE UPPER('"+objet+"%'))  and(Organisateur.id = Agence_Voyage.id)", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Organisateur");
            tab1 = dtst.Tables["Organisateur"];
            return tab1;
        }

        public List<Organisateur>AllOrganisateur()
        {
            List<Organisateur> list = new List<Organisateur>();
            string req = string.Format("SELECT *  FROM Organisateur");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                list.Add(new Organisateur((int)Reader.GetDecimal(0), Reader.GetString(1),Reader.GetString(2),Reader.GetString(3)));
            }
            Reader.Close();
            cn.Close();
            return list;
        }

        public int findIdByNomOrganisateur(String nomOrganisateur)
        {
            int id = 0;
            List<Organisateur> list = new List<Organisateur>();
            string req = string.Format("SELECT id  FROM Organisateur where NOM_ORGANISATEUR='"+nomOrganisateur+"' ");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                id = (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return id;
        }

        public int maxID()
        {
            try
            {
                //cn.Open();
                cmd = cn.CreateCommand();
                cmd.CommandText = "select MAX(id) from Organisateur";
                cn.Open();
                decimal r = 0;
                r = Convert.ToDecimal(cmd.ExecuteScalar());
                cn.Close();
                return (int)r;
            }
            catch(InvalidCastException)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        

    }
}
