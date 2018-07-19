using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using AMETAP.Model.Business;

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
            catch (OleDbException ex)
            {
                System.Console.WriteLine("Error :"+ex.Message);
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
                int idBudgetCategorie = a.idBudgetCategorie;
                int idOrganisateur = a.idOrganisateur;
                String date_debut_inscription = a.date_debut_inscription;
                String date_fin_inscription = a.date_fin_inscription;
                int nbr_point = a.nbr_point;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.AjouterActivite(nom_activite, capacite, date_debut, date_fin, prix_unitaire, montant_prevu, montant_actuel, idBudgetCategorie, idOrganisateur, date_debut_inscription, date_fin_inscription, nbr_point));
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
            return false;
        }

        public Boolean ModifierActivite(int id, String nom_activite, int capacite, String date_fin_inscription,
            String date_debut, String date_fin, double prix_unitaire, double montant_prevu, int nbr_point, int idBudgetCat,
            double provisoire_ajouter, int idOldBudgetCat)
        {
            try
            {
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.ModifierActivite(id, nom_activite, capacite, date_fin_inscription, date_debut, date_fin, prix_unitaire, montant_prevu, nbr_point, idBudgetCat, provisoire_ajouter, idOldBudgetCat));
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
            adap1 = new OleDbDataAdapter("select Activite.id , Activite.nom_Activite , Activite.montant_prevu , Activite.date_debut,Activite.date_fin, Activite.capacite , Activite.nombre_participant ,Organisateur.Nom_Organisateur ,Activite.date_fin_inscription , Activite.PRIX_UINITAIRE , Activite.NBR_POINT as Point from Activite,Organisateur,Budget,BudgetCategorie  where Activite.idOrganisateur=Organisateur.id and Budget.annee=" + objet + " and Budget.id=BudgetCategorie.IDBUDGET and Activite.IDBUDGETCAT=BudgetCategorie.id", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Activite");
            tab1 = dtst.Tables["Activite"];
            return tab1;
        }

        public DataTable getActuelleActivty()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Activite.id , Activite.nom_Activite , Activite.montant_prevu , Activite.date_debut,Activite.date_fin, Activite.capacite , Activite.nombre_participant ,Organisateur.Nom_Organisateur ,Activite.date_fin_inscription , Activite.PRIX_UINITAIRE , Activite.NBR_POINT as Point from Activite,Organisateur,Budget,BudgetCategorie  where Activite.idOrganisateur=Organisateur.id and Budget.id=BudgetCategorie.IDBUDGET and Activite.IDBUDGETCAT=BudgetCategorie.id and date_debut_inscription<=sysdate and date_fin_inscription>=sysdate", Properties.Settings.Default.ch);
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
            adap1 = new OleDbDataAdapter("Select DISTINCT Activite.Nom_Activite ,Activite.MONTANT_PREVU , null as Total_des_activites , null as Total from Activite , Budget, BudgetCategorie where Activite.idBudgetCat=BudgetCategorie.id and Budget.annee=" + annee + " union all select DISTINCT null, null, sum(Montant_prevu), null as Total from Activite , Budget where Budget.annee = " + annee + " union all select DISTINCT null, null, null, Budget.MONTANT_FINAL from Activite , Budget where Budget.annee = " + annee + "", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Activite");
            tab1 = dtst.Tables["Activite"];
            return tab1;
        }

        public List<Activite> selectNomActiviteCulturel(String annee)
        {
            List<Activite> listActivite = new List<Activite>();
            string req = string.Format("select Activite.Nom_Activite , Activite.Montant_prevu from Activite ,Budget ,BudgetCategorie where (Activite.IDBUDGETCAT=BudgetCategorie.id) AND (Budget.annee=" + annee + ") and (Budget.id=BudgetCategorie.IDBUDGET) and (Activite.IDBUDGETCAT=BudgetCategorie.id) and (BudgetCategorie.Categorie='Activité culturel') ");
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

        public List<Activite> selectNomActiviteLoisir(String annee)
        {
            List<Activite> listActivite = new List<Activite>();
            string req = string.Format("select Activite.Nom_Activite , Activite.Montant_prevu from Activite ,Budget ,BudgetCategorie where (Activite.IDBUDGETCAT=BudgetCategorie.id) AND (Budget.annee=" + annee + ") and (Budget.id=BudgetCategorie.IDBUDGET) and (Activite.IDBUDGETCAT=BudgetCategorie.id) and (BudgetCategorie.Categorie='Activité de loisir') ");
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

        public int getId(String typeActivite, int annee)
        {
            int res = 0;
            string req = string.Format("select BudgetCategorie.id  from budgetCategorie , Budget where budgetCategorie.idBudget=budget.id and budget.annee=" + annee + " and BudgetCategorie.Categorie='" + typeActivite + "' ");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res = (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return res;
        }

        public int getCapacite(int id)
        {
            int res = 0;
            string req = string.Format("select capacite from Activite where id=" + id + "");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res = (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return res;
        }

        public int getNombreParticipant(int id)
        {
            int res = 0;
            string req = string.Format("select NOMBRE_PARTICIPANT from Activite where id=" + id + "");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res = (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return res;
        }

        public int sumMontant_prevuLoisir(String annee)
        {
            int res = 0;
            string req = string.Format("select montant_prevu from Activite , BudgetCategorie , Budget where Activite.IdBudgetCat=BudgetCategorie.id and BudgetCategorie.Categorie='Activité de loisir' and Budget.id=BudgetCategorie.idbudget and Budget.annee=" + annee + "");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res = res + (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return res;
        }

        public int sumMontant_prevuCulturel(String annee)
        {
            int res = 0;
            string req = string.Format("select montant_prevu from Activite , BudgetCategorie , Budget where Activite.IdBudgetCat=BudgetCategorie.id and BudgetCategorie.Categorie='Activité culturel' and Budget.id=BudgetCategorie.idbudget and Budget.annee=" + annee + "");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res = res + (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return res;
        }

        public DataTable activiteActuel()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Activite.ID , Activite.Nom_activite , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE , Organisateur.nom_organisateur , Activite.NBR_POINT  from Activite , organisateur where (Activite.date_debut_inscription<=sysdate) and (Activite.date_fin_inscription>=sysdate) and Organisateur.id=Activite.idOrganisateur", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Activite");
            tab1 = dtst.Tables["Activite"];
            return tab1;
        }

        public int restePlace(int idActivite)
        {

            int res = 0;
            string req = string.Format("select CAPACITE-NOMBRE_PARTICIPANT from Activite where id=" + idActivite);
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res = res + (int)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return res;
        }

        public double findMontantPrevuById(int id)
        {
            double res = 0;
            string req = string.Format("select MONTANT_PREVU from Activite where id=" + id);
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res = res + (double)Reader.GetDecimal(0);
            }
            Reader.Close();
            cn.Close();
            return res;
        }

        public int getNombreActiviteActuel()
        {
            try
            {
                int res = 0;
                string req = string.Format("select Activite.id , Activite.nom_Activite , Activite.montant_prevu , Activite.date_debut,Activite.date_fin, Activite.capacite , Activite.nombre_participant ,Organisateur.Nom_Organisateur ,Activite.date_fin_inscription , Activite.PRIX_UINITAIRE , Activite.NBR_POINT as Point from Activite,Organisateur,Budget,BudgetCategorie  where Activite.idOrganisateur=Organisateur.id and Budget.id=BudgetCategorie.IDBUDGET and Activite.IDBUDGETCAT=BudgetCategorie.id and date_debut_inscription<=sysdate and date_fin_inscription>=sysdate");
                //        cn.Open();
                cmd = new OleDbCommand(req, cn);
                OleDbDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    res++;
                }
                Reader.Close();
                cn.Close();
                return res;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return 0;
            }
        }
        public List<int> getListIdOrganisateur()
        {
            try
            {
                List<int> list = new List<int>();
                string req = string.Format("select  distinct idOrganisateur from Activite , Organisateur where Organisateur.id=Activite.idOrganisateur");
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
            catch (Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return null;
            }
        }
    }
}
