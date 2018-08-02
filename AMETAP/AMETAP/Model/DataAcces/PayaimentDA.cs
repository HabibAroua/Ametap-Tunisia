using System;
using System.Data;
using System.Data.OleDb;

namespace AMETAP.Model.DataAcces
{
    public class PayaimentDA : IData
    {

        private OleDbConnection cn;
        private OleDbCommand cmd;

        public PayaimentDA()
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

        public bool delete(object o)
        {
            throw new NotImplementedException();
        }

        public bool insert(object o)
        {
            throw new NotImplementedException();
        }

        public DataTable search(string objet)
        {
            throw new NotImplementedException();
        }

        public DataTable sellectAll()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select distinct Personnel.Matricule , Personnel.Nom , Personnel.Prenom , Personnel.etat_civil , Personnel.DATE_NAISSAINCE , Adherent.NOMBRE_POINT , Activite.nom_Activite  from Personnel , Adherent ,Activite , Participant , Participation where Personnel.matricule=Adherent.matriculeEtap and Adherent.matriculeEtap=Participant.matricule and Personnel.matricule=Participant.matricule and Activite.id=Participation.idActivite and Participant.matricule=Participation.matriculePart and ((date_debut>='01/01/2009') and (date_debut<='31/12/2009')) and Participation.EtatPayaiment=0", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public bool update(object o1, object o2)
        {
            throw new NotImplementedException();
        }

        public DataTable sellectNonPayer(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Personnel.matricule , Personnel.Nom , Personnel.prenom ,Personnel.DATE_NAISSAINCE , Activite.id  from Personnel , Adherent , Participation ,Activite ,Participant where Personnel.matricule=Adherent.matriculeEtap and Participation.idActivite=Activite.id and Participation.idActivite="+idActivite+" and Adherent.matriculeEtap=Participation.MATRICULEPART and Participation.Etat=1 and Participant.matricule=Adherent.matriculeEtap and Participation.matriculePart=Participant.matricule and Participation.ETATPAYAIMENT=0 union all select Enfant.id, Enfant.nom, Enfant.prenom, Enfant.date_naissance, idActivite from Enfant , Participation, Participant, Activite where Activite.id = Participation.idActivite and Participant.matricule = Enfant.id and Participation.matriculePart = Enfant.id and Participation.etat = 1 and Participation.idActivite ="+idActivite+" and Participation.ETATPAYAIMENT=0 union all select Conjoint.cin, Conjoint.nom, Conjoint.prenom, Conjoint.date_naissance, idActivite from Conjoint , Participation, Participant, Activite where Activite.id = Participation.idActivite and Participant.matricule = Conjoint.cin and Participation.matriculePart = Conjoint.cin and Participation.etat = 1 and Participation.idActivite ="+idActivite+" and Participation.ETATPAYAIMENT=0", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable selectAdherentNonPayer(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Personnel.matricule , Personnel.Nom , Personnel.prenom ,Personnel.DATE_NAISSAINCE , Activite.id  from Personnel , Adherent , Participation , Activite , Participant where Personnel.matricule=Adherent.matriculeEtap and Participation.idActivite=Activite.id and Participation.idActivite=" + idActivite + " and Adherent.matriculeEtap=Participation.MATRICULEPART and Participation.Etat=1 and Participant.matricule=Adherent.matriculeEtap and Participation.matriculePart=Participant.matricule and Participation.ETATPAYAIMENT=0", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable selectConjointNonPayer(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Conjoint.cin, Conjoint.nom, Conjoint.prenom, Conjoint.date_naissance, idActivite from Conjoint , Participation, Participant, Activite where Activite.id = Participation.idActivite and Participant.matricule = Conjoint.cin and Participation.matriculePart = Conjoint.cin and Participation.etat = 1 and Participation.idActivite =" + idActivite + " and Participation.ETATPAYAIMENT=0", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }

        public DataTable selectEnfantNonPayer(int idActivite)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Enfant.id, Enfant.nom, Enfant.prenom, Enfant.date_naissance, idActivite from Enfant , Participation, Participant, Activite where Activite.id = Participation.idActivite and Participant.matricule = Enfant.id and Participation.matriculePart = Enfant.id and Participation.etat = 1 and Participation.idActivite =" + idActivite + " and Participation.ETATPAYAIMENT=0", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Participation");
            tab1 = dtst.Tables["Participation"];
            return tab1;
        }
    }
}
