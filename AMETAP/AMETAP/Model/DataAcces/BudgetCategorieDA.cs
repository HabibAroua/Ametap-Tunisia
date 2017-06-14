using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using AMETAP.Model.Business;

namespace AMETAP.Model.DataAcces
{
    public class BudgetCategorieDA : IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public BudgetCategorieDA()
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
        public Boolean delete(object o)
        {
            throw new NotImplementedException();
        }

        public Boolean insert(object o)
        {
            //try
            //{
                //BudgetCategorie b = (BudgetCategorie)o;
                //double montant = b.montant;
                //int idBudget = b.budget.id;
                //string req = string.Format(plSql.Inscrire(matricule, login, password));
                //cmd.Connection = cn;
                //cn.Open();
                //cmd.CommandText = req;
                //cmd.ExecuteNonQuery();
              //  return true;
            //}
            //catch (OleDbException)
            //{
            //  return false;
            //}
            //finally
            //{
            //  cn.Close();
            //}
            return false;
        }

        public DataTable search(string objet)
        {
            throw new NotImplementedException();
        }

        public DataTable sellectAll()
        {
            throw new NotImplementedException();
        }

        public bool update(object o1, object o2)
        {
            throw new NotImplementedException();
        }

        public DataTable selectActiviteCulturel(String annee)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Activite.id , Activite.nom_Activite , Activite.montant_prevu , Activite.date_debut,Activite.date_fin, Activite.capacite , Activite.nombre_participant ,Organisateur.Nom_Organisateur ,Activite.date_fin_inscription , Activite.PRIX_UINITAIRE , Activite.NBR_POINT as Point from Activite , BudgetCategorie , Budget ,Organisateur where Activite.IdBudgetCat=BudgetCategorie.id and BudgetCategorie.Categorie='Activité culturel' and Budget.id=BudgetCategorie.idbudget and Budget.annee=" + annee+ " and Activite.IdBudgetCat = BudgetCategorie.id and Organisateur.id=Activite.idOrganisateur", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Budget");
            tab1 = dtst.Tables["Budget"];
            return tab1;
        }

        public DataTable selectActiviteLoisir(String annee)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Activite.id , Activite.nom_Activite , Activite.montant_prevu , Activite.date_debut,Activite.date_fin, Activite.capacite , Activite.nombre_participant ,Organisateur.Nom_Organisateur ,Activite.date_fin_inscription , Activite.PRIX_UINITAIRE , Activite.NBR_POINT as Point from Activite , BudgetCategorie , Budget , Organisateur where Activite.IdBudgetCat=BudgetCategorie.id and BudgetCategorie.Categorie='Activité de loisir' and Budget.id=BudgetCategorie.idbudget and Budget.annee=" + annee + " and Activite.IdBudgetCat = BudgetCategorie.id and Organisateur.id=Activite.idOrganisateur", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Budget");
            tab1 = dtst.Tables["Budget"];
            return tab1;
        }

        public double getMontantProvisoire(int annee , String categorie)
        {
            double provisoire = 0;
            string req = string.Format("select BudgetCategorie.Provisoire from BudgetCategorie , Budget where (Budget.id=BudgetCategorie.idBudget) and (Budget.annee="+annee+") and (BudgetCategorie.Categorie='"+categorie+"')");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                provisoire = Reader.GetDouble(0);
            }
            Reader.Close();
            cn.Close();
            return provisoire;
        }

        public void ajouterValeurBudgetCat(int id,int valeur)
        {
            //try
            //{
                string req = string.Format("update budgetCategorie set PROVISOIRE=PROVISOIRE+" + valeur + " , MONTANT=MONTANT+"+valeur+ " where IDBUDGET=" + id);
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
            //}
            //catch (OleDbException)
            //{

            //}
            //finally
            //{
                cn.Close();
            //}
        }
        public BudgetCategorie getBudgetCategorieByIdActivite(int idActivite)
        {
            BudgetCategorie budgetCategorie=new BudgetCategorie();
            string req = string.Format("select budgetCategorie.id , budgetCategorie.provisoire  from budgetCategorie , Activite where budgetCategorie.id=Activite.idBudgetCat and Activite.id="+idActivite);
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                budgetCategorie = new BudgetCategorie((int)Reader.GetDecimal(0), Reader.GetDouble(1));
            }
            Reader.Close();
            cn.Close();
            return budgetCategorie;
        }
    }
}
