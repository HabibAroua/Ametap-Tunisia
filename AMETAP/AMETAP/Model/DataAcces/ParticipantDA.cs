using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using AMETAP.Model.DataAcces.PLSQL;

namespace AMETAP.Model.DataAcces
{
    public class ParticipantDA :IData
    {
        OleDbConnection cn;
        OleDbCommand cmd;

        public ParticipantDA()
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
                string req = string.Format("delete participant where matricule="+matricule);
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            
            }
            catch (OleDbException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable sellectAll()
        {
            return null;
        }
        public DataTable search(String objet)
        {
            return null;
        }

        public int getMatriculeByEnfant(int matriculePart)
        {
            int res = 0;
            string req = string.Format("select matricule from Enfant where id="+matriculePart);
            //string req = string.Format("select distinct Personnel.Matricule,Participation.id , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite , Activite.Id , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite=" + idActivite + "order by Adherent.Nombre_Point desc");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                res=(int)Reader.GetDecimal(0) ;
                
            }
            Reader.Close();
            cn.Close();
            return res;
        }

        public int getMatriculeByConjoint(int matriculePart)
        {
            int res = 0;
            string req = string.Format("select matricule from Conjoint where cin=" + matriculePart);
            //string req = string.Format("select distinct Personnel.Matricule,Participation.id , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite , Activite.Id , Activite.date_debut , Activite.date_fin , Activite.PRIX_UINITAIRE from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and Participation.etat=0 and Participation.idActivite=" + idActivite + "order by Adherent.Nombre_Point desc");
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

        public DataTable findAllMembreFamilleByMatricule(int matricule)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select cin as identifiant , nom ,prenom,date_naissance, Metier as Metier_Ecole   from Conjoint where matricule="+matricule+" Union all select id as identifiant , nom ,prenom,date_naissance , ecole  from Enfant where matricule="+matricule, Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participant");
            tab1 = dtst.Tables["Participant"];
            return tab1;
        }

        public List<int> find_List_MatPart_byMatricule_Adherent(int matricule)
        {
            List<int> list = new List<int>();
            string req = string.Format("select participant.matricule from Participant , adherent , conjoint , enfant where Adherent.matriculeEtap=conjoint.matricule and Adherent.matriculeEtap=enfant.matricule and Adherent.matriculeEtap="+matricule+" and enfant.matricule="+matricule+" and conjoint.matricule="+matricule+" and participant.matricule=enfant.id union all select distinct participant.matricule from Participant , adherent, conjoint, enfant where Adherent.matriculeEtap = conjoint.matricule and Adherent.matriculeEtap = enfant.matricule and Adherent.matriculeEtap = "+matricule+" and enfant.matricule ="+matricule+" and conjoint.matricule ="+matricule+" and participant.matricule = conjoint.cin");
            cn.Open();
            cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                list.Add((int)Reader.GetDouble(0));
            }
            Reader.Close();
            cn.Close();
            return list;
        }
    }
}
