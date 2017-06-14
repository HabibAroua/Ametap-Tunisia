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
            try
            {
                int matricule = (int)o;
                string req = string.Format("delete participation where matriculePart="+matricule);
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
            adap1 = new OleDbDataAdapter("select Personnel.Matricule,Personnel.Nom , Personnel.Prenom ,Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite="+idActivite+" UNION ALL select Conjoint.cin, Conjoint.nom, Conjoint.prenom, Conjoint.date_naissance, Adherent.Nombre_point from Conjoint , Adherent, Activite, Participation, Participant where Adherent.matriculeEtap = Conjoint.matricule and Activite.id = Participation.idActivite and idActivite ="+idActivite+" and Participation.etat = 0 and Participant.matricule = Conjoint.cin and Participation.matriculePart = Participant.matricule and Participant.matricule = Conjoint.cin UNION ALL select Enfant.id, Enfant.nom, Enfant.prenom, Enfant.date_naissance, Adherent.Nombre_point from Enfant , Adherent, Activite, Participation, Participant where Adherent.matriculeEtap = Enfant.matricule and Activite.id = Participation.idActivite and idActivite ="+idActivite+" and Participation.etat = 0 and Participant.matricule = Enfant.id and Participation.matriculePart = Participant.matricule and Participant.matricule = Enfant.id", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable search(String objet)
        {
            return null;
        }

        public Boolean accepterAdherent(int matricule, int idActivite, int id, int valeur)
        {
            try
            {
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

        public Boolean accepterEnfant(int matricule, int idActivite, int id, int valeur)
        {
            try
            {
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.AccepterDemandeEnfant(matricule, idActivite, id, valeur));
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

        public Boolean accepterConjoint(int matricule, int idActivite, int id, int valeur)
        {
            try
            {
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.AccepterDemandeConjoint(matricule, idActivite, id, valeur));
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

        public Boolean confirmePaymentConjoint(int matricule, int idActivite, int id, int valeur)
        {
            try
            {
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.ConfPayerConjoint(matricule, idActivite, id, valeur));
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

        public Boolean confirmePaymentEnfant(int matricule, int idActivite, int id, int valeur)
        {
            try
            {
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.ConfPayerEnfant(matricule, idActivite, id, valeur));
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

        public Boolean confirmePaymentAdherent(int matricule, int idActivite, int id, int valeur)
        {
            try
            {
                PLSQL.Pl_SQL plSql = new PLSQL.Pl_SQL();
                string req = string.Format(plSql.ConfPayerAdherent(matricule, idActivite, id, valeur));
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
            adap1 = new OleDbDataAdapter("select Personnel.Nom , Personnel.prenom ,Personnel.DATE_NAISSAINCE ,Adherent.NOMBRE_POINT from Personnel , Adherent , Participation ,Activite where Personnel.matricule=Adherent.matriculeEtap and Participation.idActivite=Activite.id and Participation.idActivite=" + idActivite+ " and Adherent.matriculeEtap=Participation.MATRICULEPART and Participation.Etat=1 and Participation.ETATPAYAIMENT=1", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable getAllParticipant(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Personnel.matricule , Personnel.Nom , Personnel.prenom ,Personnel.DATE_NAISSAINCE , Activite.id  from Personnel , Adherent , Participation ,Activite ,Participant where Personnel.matricule=Adherent.matriculeEtap and Participation.idActivite=Activite.id and Participation.idActivite="+idActivite+ " and Adherent.matriculeEtap=Participation.MATRICULEPART and Participation.Etat=1 and Participant.matricule=Adherent.matriculeEtap and Participation.matriculePart=Participant.matricule and Participation.ETATPAYAIMENT=1 union all select Enfant.id, Enfant.nom, Enfant.prenom, Enfant.date_naissance, idActivite from Enfant , Participation, Participant, Activite where Activite.id = Participation.idActivite and Participant.matricule = Enfant.id and Participation.matriculePart = Enfant.id and Participation.etat = 1 and Participation.idActivite =" + idActivite+ " and Participation.ETATPAYAIMENT=1 union all select Conjoint.cin, Conjoint.nom, Conjoint.prenom, Conjoint.date_naissance, idActivite from Conjoint , Participation, Participant, Activite where Activite.id = Participation.idActivite and Participant.matricule = Conjoint.cin and Participation.matriculePart = Conjoint.cin and Participation.etat = 1 and Participation.idActivite =" + idActivite+ " and Participation.ETATPAYAIMENT=1", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable getParticipantEnfant(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Enfant.id , Enfant.nom , Enfant.prenom , Enfant.date_naissance , idActivite from Enfant , Participation , Participant , Activite where Activite.id=Participation.idActivite and Participant.matricule=Enfant.id and Participation.matriculePart=Enfant.id and Participation.etat=1 and Participation.idActivite="+idActivite+ " and Participation.ETATPAYAIMENT=1", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable getParticipantConjoint(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Conjoint.cin , Conjoint.nom , Conjoint.prenom , Conjoint.date_naissance , idActivite from Conjoint , Participation , Participant , Activite where Activite.id=Participation.idActivite and Participant.matricule=Conjoint.cin and Participation.matriculePart=Conjoint.cin and Participation.etat=1 and Participation.idActivite="+idActivite+ "  and Participation.ETATPAYAIMENT=1", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public List<Participation> affich(int idActivite)
        {
            List<Participation> list = new List<Participation>();
            string req = string.Format("select Personnel.Matricule, Participation.id from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite=" + idActivite+ " order by Adherent.nombre_point desc");
            //string req = string.Format("select distinct Personnel.Matricule,Participation.id , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite , Activite.Id , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite=" + idActivite + "order by Adherent.Nombre_Point desc");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            Participant participant = new Participant();
            Participation participation = new Participation();
            Activite activite = new Activite();
            while (Reader.Read())
            {
                //MessageBox.Show((int)Reader.GetDecimal(0) + "");
                list.Add(new Participation((int)Reader.GetDecimal(1), new Participant((int)Reader.GetDecimal(0))));
            }
            Reader.Close();
            cn.Close();
            return list;
        }

        public List<Participation> affichConjoint(int idActivite)
        {
            List<Participation> list = new List<Participation>();
            string req = string.Format("select Conjoint.cin, Participation.id from Conjoint , Adherent, Activite, Participation, Participant where Adherent.matriculeEtap = Conjoint.matricule and Activite.id = Participation.idActivite and idActivite ="+idActivite+ " and Participation.etat = 0 and Participant.matricule = Conjoint.cin and Participation.matriculePart = Participant.matricule and Participant.matricule = Conjoint.cin order by Adherent.nombre_point desc");
            //string req = string.Format("select distinct Personnel.Matricule,Participation.id , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite , Activite.Id , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite=" + idActivite + "order by Adherent.Nombre_Point desc");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            Participant participant = new Participant();
            Participation participation = new Participation();
            Activite activite = new Activite();
            while (Reader.Read())
            {
                //MessageBox.Show((int)Reader.GetDecimal(0) + "");
                list.Add(new Participation((int)Reader.GetDecimal(1), new Participant((int)Reader.GetDecimal(0))));
            }
            Reader.Close();
            cn.Close();
            return list;
        }

        public List<Participation> affichEnfant(int idActivite)
        {
            List<Participation> list = new List<Participation>();
            string req = string.Format("select Enfant.id, Participation.id from Enfant , Adherent, Activite, Participation, Participant where Adherent.matriculeEtap = Enfant.matricule and Activite.id = Participation.idActivite and idActivite ="+idActivite+" and Participation.etat = 0 and Participant.matricule = Enfant.id and Participation.matriculePart = Participant.matricule and Participant.matricule = Enfant.id");
            //string req = string.Format("select distinct Personnel.Matricule,Participation.id , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite , Activite.Id , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite=" + idActivite + "order by Adherent.Nombre_Point desc");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            Participant participant = new Participant();
            Participation participation = new Participation();
            Activite activite = new Activite();
            while (Reader.Read())
            {
                //MessageBox.Show((int)Reader.GetDecimal(0) + "");
                list.Add(new Participation((int)Reader.GetDecimal(1), new Participant((int)Reader.GetDecimal(0))));
            }
            Reader.Close();
            cn.Close();
            return list;
        }

        public DataTable getDemandeConjoint(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Conjoint.cin, Conjoint.nom, Conjoint.prenom, Conjoint.date_naissance, Adherent.Nombre_point from Conjoint , Adherent, Activite, Participation , Participant where Adherent.matriculeEtap = Conjoint.matricule and Activite.id = Participation.idActivite and idActivite ="+idActivite+" and Participation.etat = 0 and Participant.matricule=Conjoint.cin and Participation.matriculePart=Participant.matricule and Participant.matricule=Conjoint.cin order by Adherent.nombre_point desc", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;   
        }

        public DataTable getDemandeEnfant(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Enfant.id, Enfant.nom, Enfant.prenom, Enfant.date_naissance, Adherent.Nombre_point from Enfant , Adherent, Activite, Participation, Participant where Adherent.matriculeEtap = Enfant.matricule and Activite.id = Participation.idActivite and idActivite ="+idActivite+ " and Participation.etat = 0 and Participant.matricule = Enfant.id and Participation.matriculePart = Participant.matricule and Participant.matricule = Enfant.id order by Adherent.nombre_point desc", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }
        
           
    }
}
