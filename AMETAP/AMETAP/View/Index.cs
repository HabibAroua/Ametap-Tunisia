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
using AMETAP.View.Gestion_des_activites;
using AMETAP.View.Gestion_Budget;
using AMETAP.Model.Business;
using AMETAP.Model.DataAcces;
using AMETAP.View.Gestion_des_adherents;
using AMETAP.Controller.Script;
using AMETAP.View.Gestion_organisateur;
namespace AMETAP.View
{
    public partial class Index : MetroForm
    {
        private ActiviteController acc;
        private BudgetCategorieController bcc;
        private AdherentController ac;
        private OrganisateurController oc;
        private ClubController cl;
        private CentreController ce;
        private Agence_VoyageController av;
        private ParticipationController pc;
        private PayaimentController paC;
        private AdminController adC;
        private BudgetController bc;
        public Index()
        {
            ac = new AdherentController();
            acc = new ActiviteController();
            bcc = new BudgetCategorieController();
            oc = new OrganisateurController();
            cl = new ClubController();
            ce = new CentreController();
            av = new Agence_VoyageController();
            pc = new ParticipationController();
            paC = new PayaimentController();
            adC = new AdminController();
            bc = new BudgetController();
            InitializeComponent();
            //this.StyleManager = metroStyleManager1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nous sommes à la page 1");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nous sommes à la page 2");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nous sommes à la page 3");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void déconnexionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Authentification a = new Authentification();
            a.Show();
            this.Hide();
        }

        private void déconnexionToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Authentification a = new Authentification();
            a.Show();
            this.Hide();
        }

        private void déconnexionToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Authentification a = new Authentification();
            a.Show();
            this.Hide();
        }

        private void déconnexionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Authentification a = new Authentification();
            a.Show();
            this.Hide();
        }

        private void déconnexionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Authentification a = new Authentification();
            a.Show();
            this.Hide();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authentification a = new Authentification();
            a.Show();
            this.Hide();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            ac.affihcer(dataAdherent);
            for (int i = 2006; i < 2050; i++)
            {
                comboAnnee.Items.Add(i.ToString());
            }
            oc.affiche(dataOrganisation);
            //pc.AfficheDemande(dataActiviteActuel);
            //paC.afficheNonPayaiment(dataGridView2);
            adC.afficher(dataUtilisateur);
            bc.AfficherBudget(dataBudget);
            acc.ActiviteActuel(dataActiviteActuel);
            
        }

        private void comboAnnee_TextChanged(object sender, EventArgs e)
        {
            BudgetDA bDA = new BudgetDA();
            acc.findActivityByYear(dataActivite, comboAnnee.SelectedItem.ToString());
            if(bDA.LastYear()==int.Parse(comboAnnee.SelectedItem.ToString()))
            {
                btSupprimerActivite.Enabled = true;
                btModifierActivite.Enabled = true;
            }
            else
            {
                btSupprimerActivite.Enabled = false;
                btModifierActivite.Enabled = false;
            }
        }

        private void dataActivite_DoubleClick(object sender, EventArgs e)
        {
            Information_d_une_Activite iua = new Information_d_une_Activite();
            iua.viewActivite.Text = dataActivite.CurrentRow.Cells[1].Value.ToString();
            iua.viewDateDebut.Text = dataActivite.CurrentRow.Cells[3].Value.ToString().Substring(0, 10);
            iua.viewDateFin.Text = dataActivite.CurrentRow.Cells[4].Value.ToString().Substring(0, 10);
            iua.viewCapacite.Text = dataActivite.CurrentRow.Cells[5].Value.ToString();
            int reste = int.Parse(dataActivite.CurrentRow.Cells[5].Value.ToString()) - int.Parse(dataActivite.CurrentRow.Cells[6].Value.ToString());
            iua.viewReste.Text = reste.ToString();
            iua.viewPrixUnitaire.Text = dataActivite.CurrentRow.Cells[2].Value.ToString();
            iua.setIdActivite(int.Parse(dataActivite.CurrentRow.Cells[0].Value.ToString()));
            iua.Show();
        }

        private void rdActiviteLoisir_Click(object sender, EventArgs e)
        {
            bcc.afficheLoisir(dataActivite, comboAnnee.SelectedItem.ToString());
        }

        private void rdActiviteCulturel_Click(object sender, EventArgs e)
        {
            bcc.afficheCulturel(dataActivite, comboAnnee.SelectedItem.ToString());
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            AjouterActivite a = new AjouterActivite();
            a.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                acc.SupprimerActivite(int.Parse(dataActivite.CurrentRow.Cells[0].Value.ToString()), double.Parse(dataActivite.CurrentRow.Cells[2].Value.ToString()));
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Il faut séléctionner une activité", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Modifier_Activite ma = new Modifier_Activite();
                ma.txtNomActivite.Text = dataActivite.CurrentRow.Cells[1].Value.ToString();
                ma.txtCapacite.Text = dataActivite.CurrentRow.Cells[5].Value.ToString();
                ma.setId(int.Parse(dataActivite.CurrentRow.Cells[0].Value.ToString()));
                ma.setOrganisateur(dataActivite.CurrentRow.Cells[6].Value.ToString());
                ma.setTypeActivite(dataActivite.CurrentRow.Cells[7].Value.ToString());
                //MessageBox.Show(dataActivite.CurrentRow.Cells[7].Value.ToString() + " " + dataActivite.CurrentRow.Cells[8].Value.ToString());
                ma.Show();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Il faut séléctionner une activité", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Index i = new Index();
            i.Show();
            this.Close();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Ajouter_Organisateur ao = new Ajouter_Organisateur();
            ao.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous supprimer cet Organisateur ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                oc.supprimerOrganisateur(int.Parse(dataOrganisation.CurrentRow.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Vous annulez cette suppression !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Modifier_Organisateur mo = new Modifier_Organisateur();
            mo.Show();
            mo.id = int.Parse(dataOrganisation.CurrentRow.Cells[0].Value.ToString());
            mo.txtNom.Text = dataOrganisation.CurrentRow.Cells[1].Value.ToString();
            mo.txtEmail.Text = dataOrganisation.CurrentRow.Cells[2].Value.ToString();
            mo.txtAdresse.Text = dataOrganisation.CurrentRow.Cells[3].Value.ToString();
            mo.txtDescription.Text = dataOrganisation.CurrentRow.Cells[4].Value.ToString();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            r1.Checked = false;
            r2.Checked = false;
            r3.Checked = false;
            r1.Enabled = true;
            r2.Enabled = true;
            r3.Enabled = true;
            oc.affiche(dataOrganisation);
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            r1.Checked = false;
            r2.Checked = false;
            r3.Checked = false;
            r1.Enabled = true;
            r2.Enabled = true;
            r3.Enabled = true;
            oc.affiche(dataOrganisation);
        }

        private void r1_Click(object sender, EventArgs e)
        {
            r1.Enabled = false;
            r2.Enabled = true;
            r3.Enabled = true;
            av.affiche(dataOrganisation);
        }

        private void r2_Click(object sender, EventArgs e)
        {
            r2.Enabled = false;
            r3.Enabled = true;
            r1.Enabled = true;
            ce.affiche(dataOrganisation);
        }

        private void r3_Click(object sender, EventArgs e)
        {
            r3.Enabled = false;
            r1.Enabled = true;
            r2.Enabled = true;
            cl.affiche(dataOrganisation);
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            pc.refuser(int.Parse(dataActiviteActuel.CurrentRow.Cells[1].Value.ToString()));
        }

        private void txtRecherhce_TextChanged(object sender, EventArgs e)
        {
            adC.rechercher(txtRecherhce.Text.ToString(), dataUtilisateur);
        }
        private void metroTile8_Click(object sender, EventArgs e)
        {
            adC.supprimer(int.Parse(dataUtilisateur.CurrentRow.Cells[0].Value.ToString()));
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            adC.afficher(dataUtilisateur);
        }

        private void dataBudget_DoubleClick(object sender, EventArgs e)
        {
            Information_chaque_année ica = new Information_chaque_année();
            ica.Show();
            ica.viewAnnee.Text = dataBudget.CurrentRow.Cells[1].Value.ToString();
        }

        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            View.Gestion_Budget.Fixer_Budget fb = new Fixer_Budget();
            fb.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Changed");
        }
        AdherentDA a;
        List<Participation> list = new List<Participation>();
        private void dataActiviteActuel_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                a = new AdherentDA();

                list = pc.DemandeList(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                pc.AfficheDemandeParActivite(dataDemande, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
            }
            catch(Exception)
            {

            }
        }

        private void btAccepter_Click(object sender, EventArgs e)
        {
            ActiviteDA aDA = new ActiviteDA();
            AdherentDA aDDA = new AdherentDA();
            int reste = aDA.restePlace(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
            int i = 0;
            int nbr = 0;
            //MessageBox.Show("" + reste);
            foreach (Participation l in list)
            {
                //MessageBox.Show(l.participant.matricule + "");
                nbr++;
            }
            if (nbr <= reste)
            {
                reste = nbr;
            }
            else
            {

            }
            Mailing m;
            while (i != reste)
            {
                foreach (Participation l in list)
                {
                    if (aDDA.getNombrePoint(l.participant.matricule) <= 0)
                    {
                        pc.refuser(l.id);
                        //MessageBox.Show("Erreur");
                        continue;
                    }
                    else
                    {
                        foreach (String a in a.listAdresse(l.participant.matricule))
                        {

                            m = new Mailing(a, "Notification", "Vous etes le bienvenue , nous avons accepte votre demande");
                            m.sendMail();
                        }
                        pc.Accepter(l.participant.matricule, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()), l.id, 0);
                        if (i == reste)
                        {
                            break;
                        }
                        i++;
                    }
                }
            }
            MessageBox.Show("Tous les inscriptions sont effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            a = new AdherentDA();
            list = pc.DemandeList(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
            pc.AfficheDemandeParActivite(dataDemande, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
        }


    }
}
