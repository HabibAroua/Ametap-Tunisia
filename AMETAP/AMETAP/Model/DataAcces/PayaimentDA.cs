using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace AMETAP.Model.DataAcces
{
    public class PayaimentDA : IData
    {

        private OleDbConnection cn;
        private OleDbCommand cmd;

        public PayaimentDA()
        {
            cn = new OleDbConnection(Properties.Settings.Default.ch);
            cmd = new OleDbCommand();
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
    }
}
