using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using AMETAP.Controller;
using AMETAP.Model.Business;
using AMETAP.Controller.Script;
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

        private void Information_d_une_Activite_Load(object sender, EventArgs e)
        {
            //pc.AfficheDemandeParActivite(dataGridView2,getIdActivite());
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AdherentDA a = new AdherentDA();
            List<Participation> list = new List<Participation>();
            list= pc.DemandeListAdherent(getIdActivite());
            int reste = int.Parse(viewReste.Text.ToString());
            int i = 0;
            int nbr = 0;
            foreach (Participation l in list)
            {
                MessageBox.Show(l.participant.matricule+"");
                //nbr++;
            }
            if(nbr<=reste)
            {
                reste = nbr;
            }
            else
            {
                
            }
            Mailing m;
            //while (i != reste)
            //{
                //foreach (Participation l in list)
                //{
                    
                    //foreach (String aDA in a.listAdresse(l.participant.matricule))
                    //{
                        
                      //  m = new Mailing(aDA, "Notification", "Vous etes le bienvenue , nous avons accepte votre demande");
                        //m.sendMail();
                    //}
                    //pc.Accepter(l.participant.matricule, getIdActivite(), l.id, int.Parse(viewPrixUnitaire.Text.ToString()));
                  //  MessageBox.Show(l.participant.matricule + "");
              //      if (i == reste)
                 //   {
                        //break;
                   // }
                    //i++;
                //}
            //}
            //Information_d_une_Activite ine = new Information_d_une_Activite();
           // ine.Show();
            //this.Close();
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
