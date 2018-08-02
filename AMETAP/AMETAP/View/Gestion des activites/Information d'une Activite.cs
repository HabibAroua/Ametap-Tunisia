using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using AMETAP.Controller;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;

namespace AMETAP.View.Gestion_des_activites
{
    public partial class Information_d_une_Activite : MetroForm
    {
        public int idActivite;
        ParticipationController pc;
        public void setIdActivite(int idActivite)
        {
            this.idActivite = idActivite;
        }

        public int getIdActivite()
        {
            return idActivite;
        }
        public Information_d_une_Activite()
        {
            InitializeComponent();
            pc = new ParticipationController();
        }

        private void rdAdherent_Click(object sender, EventArgs e)
        {
            pc.getParticipationAdherent(dataGridView1, getIdActivite());
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AdherentDA a = new AdherentDA();
            List<Participation> list = new List<Participation>();
            list= pc.DemandeListAdherent(getIdActivite());
            int reste = int.Parse(viewReste.Text.ToString());
            int nbr = 0;
            foreach (Participation l in list)
            {
                MessageBox.Show(l.participant.matricule+"");
            }
            if(nbr<=reste)
            {
                reste = nbr;
            }
        }

        private void rdTous_Click(object sender, EventArgs e)
        {
            pc.getAllParticipant(dataGridView1,getIdActivite());
        }

        private void rdConjoint_Click(object sender, EventArgs e)
        {
            pc.getParticipationConjoint(dataGridView1, getIdActivite());
        }

        private void rdEnfant_Click(object sender, EventArgs e)
        {
            pc.getParticipationEnfant(dataGridView1, getIdActivite());
        }
    }
}
