using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using AMETAP.Model.Business;
using System.Windows.Forms;
namespace AMETAP.Model.DataAcces
{
    public class ActiviteDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public ActiviteDA()
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
                Activite a = (Activite)o;
                int id = a.id;
                String nom_activite = a.nom_Activite;
                int capacite = a.capacite;
                int nombre_participant = a.nombre_participant;
                String date_debut = a.date_debut;
                String date_fin = a.date_fin;
                double prix_unitaire = a.prix_unitaire;
                double montant_prevu = a.montant_prevu;
                double montant_actuel = a.montant_actuel;
                int id_TypeActivite = a.id_TypeActivite;
                int idBudget = a.idBudget;
                int idOrganisateur = a.idOrganisateur;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                //MessageBox.Show("nom activité :" + nom_activite + " capacité " + capacite + " nombre part :" + nombre_participant + " montant prevu " + montant_prevu + " " + "id type" + id_TypeActivite + " id budget" + idBudget + " id Organisateur" + idOrganisateur);
                string req = string.Format(plSql.AjouterActivite(nom_activite, capacite, date_debut, date_fin, prix_unitaire, montant_prevu, montant_actuel, id_TypeActivite, idBudget, idOrganisateur));
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
                int id = (int)o1;
                Activite a = (Activite)o2;
                String nom_activite = a.nom_Activite;
                int capacite = a.capacite;
                int id_TypeActivite = a.id_TypeActivite;
                int idOrganisateur = a.idOrganisateur;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.ModifierActivite(id, nom_activite, capacite, id_TypeActivite, idOrganisateur));
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
            //cn.Close();
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
                Activite a = (Activite)o;
                int id = a.id;
                double montant_prevu = a.montant_prevu;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.SupprimerActivite(id, montant_prevu));
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

            }

        }
        public DataTable sellectAll()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Activite.id , Activite.nom_Activite , Activite.montant_prevu , Activite.date_debut,Activite.date_fin, Activite.capacite , Activite.nombre_participant ,Organisateur.Nom_Organisateur , Type_Activite.libelle from Activite,Budget,Organisateur ,Type_Activite where Activite.idBudget=Budget.id and Activite.ID_TYPEACTIVITE=Type_Activite.id and Activite.idOrganisateur=Organisateur.id ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Activite");
            tab1 = dtst.Tables["Activite"];
            return tab1;
        }
        public DataTable search(String objet)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Activite.id , Activite.nom_Activite , Activite.montant_prevu , Activite.date_debut,Activite.date_fin, Activite.capacite , Activite.nombre_participant ,Organisateur.Nom_Organisateur , Type_Activite.libelle from Activite,Budget,Organisateur ,Type_Activite where Activite.idBudget=Budget.id and Activite.ID_TYPEACTIVITE=Type_Activite.id and Activite.idOrganisateur=Organisateur.id and Budget.annee=" + objet + "", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Activite");
            tab1 = dtst.Tables["Activite"];
            return tab1;
        }

        public int YearOfThisActivity(int id)
        {
            string req = string.Format("SELECT annee  FROM Type_Activite where libelle='" + id + "'");
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

        public DataTable selectInformation(String annee)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("Select  Activite.nom_activite , Activite.Montant_prevu , null AS Total   from Activite , Budget  where Budget.annee=" + annee + " union all Select null, null, Montant_provisoire from Budget where annee = " + annee + " union all Select DISTINCT  null, null, Budget.Montant_final from Activite , Budget where annee =" + annee + " ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Activite");
            tab1 = dtst.Tables["Activite"];
            return tab1;
        }

        public List<Activite> selectNomActivite(String annee)
        {
            List<Activite> listActivite = new List<Activite>();
            string req = string.Format("select Activite.Nom_Activite , Activite.Montant_prevu from Activite ,Budget where (Activite.idbudget=Budget.id) AND (Budget.annee=2006)");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                listActivite.Add(new Activite(Reader.GetString(0), (double)Reader.GetDecimal(1)));
            }
            Reader.Close();
            cn.Close();
            return listActivite;
        }


    }
}
