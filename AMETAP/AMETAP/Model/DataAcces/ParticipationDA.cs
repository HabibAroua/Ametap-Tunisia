using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces.PLSQL;
using System.Windows.Forms;
namespace AMETAP.Model.DataAcces
{
    public class ParticipationDA : IData
    {
        private OleDbConnection cn;
        private  OleDbCommand cmd;
        public ParticipationDA()
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
            return false;
        }
        public Boolean update(Object o1, Object o2)
        {
            return false;
        }
        public Boolean delete(Object o)
        {
            return false;
        }

        public DataTable sellectAll()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select distinct Personnel.Matricule,Participation.id , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite , Activite.Id , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=1", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable selectDemandeParActivite(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select distinct Personnel.Matricule,Participation.id , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite , Activite.Id , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite="+idActivite+ "order by Adherent.Nombre_Point desc", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable search(String objet)
        {
            return null;
        }

        public Boolean accepter(Participation p,int valeur)
        {
            try
            {
                int matricule = p.participant.matricule;
                int idActivite = p.activite.id;
                int id = p.id;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.AccepterDemandeAdherent(matricule,idActivite,id,valeur));
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(OleDbException)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public Boolean refuser(Participation p)
        {
            try
            {
                int id = p.id;
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.RefuserDemandeAdherent(id));
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

        public DataTable getParticipationAdherent(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Personnel.Nom , Personnel.prenom ,Personnel.DATE_NAISSAINCE ,Adherent.NOMBRE_POINT from Personnel , Adherent , Participation ,Activite where Personnel.matricule=Adherent.matriculeEtap and Participation.idActivite=Activite.id and Participation.idActivite=" + idActivite+" and Adherent.matriculeEtap=Participation.MATRICULEPART and Participation.Etat=1", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }
        public List<Participation> affich(int idActivite)
        {
            List<Participation> list = new List<Participation>();
            string req = string.Format("select distinct Personnel.Matricule,Participation.id , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite , Activite.Id , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite=" + idActivite + "order by Adherent.Nombre_Point desc");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            Participant participant = new Participant();
            Participation participation = new Participation();
            Activite activite = new Activite();
 
            while (Reader.Read())
            {
                //MessageBox.Show((int)Reader.GetDecimal(0) + "");
                
                list.Add(new Participation((int)Reader.GetDecimal(1),new Participant((int)Reader.GetDecimal(0))));
            }
            Reader.Close();
            cn.Close();
            return list;   
        }
    }
}
