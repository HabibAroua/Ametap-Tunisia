using System;
using System.Collections.Generic;
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
        private ContribuesController contribuesController;
        private ParticipantController participantController;
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
            participantController = new ParticipantController();
            contribuesController = new ContribuesController();
            InitializeComponent();
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

        public void Index_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            lbldate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
            ac.affihcer(dataAdherent);
            comboAnnee.Items.Clear();
            dataActivite.ClearSelection();
            comboAnnee.Items.Add("Les activité actuelle");
            for (int i = 2006; i < 2050; i++)
            {
                comboAnnee.Items.Add(i.ToString());
            }
            oc.affiche(dataOrganisation);
            adC.afficher(dataUtilisateur);
            bc.AfficherBudget(dataBudget);
            acc.ActiviteActuel(dataActiviteActuel);
            try
            {
                a = new AdherentDA();
                listAdherent = pc.DemandeListAdherent(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                pc.getParticipationConjoint(dataDemande, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
            try
            {
                a = new AdherentDA();
                listAdherent = pc.DemandeListAdherent(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                listEnfant = pc.DemandeListEnfant(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                listConjoint = pc.DemandeListConjoint(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                pc.getParticipationEnfant(dataDemande, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
            foreach (Budget b in bc.listBudget())
            {
                chart1.Series["Budget"].Points.AddXY(b.annee, b.montant_final);
            }
        }

        private void comboAnnee_TextChanged(object sender, EventArgs e)
        {
            BudgetDA bDA = new BudgetDA();
            if (!comboAnnee.SelectedItem.ToString() .Equals("Les activité actuelle"))
            {
                acc.findActivityByYear(dataActivite, comboAnnee.SelectedItem.ToString());
                btSupprimerActivite.Enabled = false;
                btModifierActivite.Enabled = false;
            }
            else
            {
                acc.getActuelActivity(dataActivite);
                btSupprimerActivite.Enabled = true;
                btModifierActivite.Enabled = true;
                rdActiviteCulturel.Checked = false;
                rdActiviteLoisir.Checked = false;
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
            try
            {
                bcc.afficheLoisir(dataActivite, comboAnnee.SelectedItem.ToString());
            }
            catch(Exception ex)
            {
                rdActiviteCulturel.Checked = false;
                rdActiviteLoisir.Checked = false;
                MessageBox.Show("Vous devez séléctionner une année", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void rdActiviteCulturel_Click(object sender, EventArgs e)
        {
            try
            {
                bcc.afficheCulturel(dataActivite, comboAnnee.SelectedItem.ToString());
            }
            catch(Exception ex)
            {
                rdActiviteCulturel.Checked = false;
                rdActiviteLoisir.Checked = false;
                MessageBox.Show("Vous devez séléctionner une année", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                acc.getActuelActivity(dataActivite);
                btSupprimerActivite.Enabled = true;
                btModifierActivite.Enabled = true;

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
                ma.txtDateDebut.Text= dataActivite.CurrentRow.Cells[3].Value.ToString();
                ma.txtDatefin.Text= dataActivite.CurrentRow.Cells[4].Value.ToString();
                ma.dateFinInscription.Text= dataActivite.CurrentRow.Cells[8].Value.ToString();
                ma.txtMontantPrevu.Text = dataActivite.CurrentRow.Cells[2].Value.ToString();
                ma.txtPrixUnitaire.Text = dataActivite.CurrentRow.Cells[9].Value.ToString();
                ma.comboNbr_point.SelectedItem = dataActivite.CurrentRow.Cells[10].Value.ToString();
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
                oc.affiche(dataOrganisation);
            }
            else
            {
                MessageBox.Show("Vous annulez cette suppression !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            try
            {
                Modifier_Organisateur mo = new Modifier_Organisateur();
                mo.Show();
                mo.id = int.Parse(dataOrganisation.CurrentRow.Cells[0].Value.ToString());
                mo.txtNom.Text = dataOrganisation.CurrentRow.Cells[1].Value.ToString();
                mo.txtEmail.Text = dataOrganisation.CurrentRow.Cells[2].Value.ToString();
                mo.txtAdresse.Text = dataOrganisation.CurrentRow.Cells[3].Value.ToString();
                mo.txtDescription.Text = dataOrganisation.CurrentRow.Cells[4].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            oc.recherche(dataOrganisation,metroTextBox1.Text.ToString());
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
            adC.afficher(dataUtilisateur);
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
        List<Participation> listAdherent = new List<Participation>();
        List<Participation> listConjoint = new List<Participation>();
        List<Participation> listEnfant = new List<Participation>();
        private void dataActiviteActuel_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                    a = new AdherentDA();
                    listAdherent = pc.DemandeListAdherent(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                    listConjoint = pc.DemandeListConjoint(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                    listEnfant = pc.DemandeListEnfant(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                    pc.AfficheDemandeParActivite(dataDemande, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                    paC.afficherNonPayer(dataNonPaiment, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
              
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
        }

        private void btAccepter_Click(object sender, EventArgs e)
        {
            try
            { 
                ActiviteDA aDA = new ActiviteDA();
                AdherentDA aDDA = new AdherentDA();
                ParticipantDA pDA = new ParticipantDA();
                int reste = aDA.restePlace(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                if (reste <= 0)
                {
                    MessageBox.Show("Le nombre de place est peline", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int i = 0;
                    int nbr = 0;
                    foreach (Participation l in listAdherent)
                    {  
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
                    foreach (Participation l in listAdherent)
                    {
                        if ((aDDA.getNombrePoint(l.participant.matricule) <= 0))
                        {
                            pc.refuser(l.id);
                            MessageBox.Show("Demande réfusé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            continue;
                        }
                        else
                        {
                            foreach (String a in a.listAdresse(l.participant.matricule))
                            {
                                m = new Mailing(a, "Notification", "Vous etes le bienvenue , nous avons accepte votre demande");
                                m.sendMail();
                            }
                            pc.AccepterAdherent(l.participant.matricule, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()), 0, int.Parse(dataActiviteActuel.CurrentRow.Cells[4].Value.ToString()));

                            if (i == reste)
                            {
                                MessageBox.Show("Erreur");
                                break;
                            }
                            i++;
                        }
                    }
                    foreach (Participation l in listConjoint)
                    {
                        pc.AccepterConjoint(l.participant.matricule, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()), 0, 0);
                    }
                    foreach (Participation l in listEnfant)
                    {
                        pc.AccepterEnfant(l.participant.matricule, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()), 0, 0);
                    }
                    a = new AdherentDA();
                    listAdherent = pc.DemandeListAdherent(int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                    pc.AfficheDemandeParActivite(dataDemande, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void rdAdherentNonPayer_Click(object sender, EventArgs e)
        {
            paC.afficherAdherentNonPayer(dataNonPaiment, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
        }

        private void rdEnfantNonPayer_Click(object sender, EventArgs e)
        {
            paC.afficherEnfantNonPayer(dataNonPaiment, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
        }

        private void rdConjointNonPayer_Click(object sender, EventArgs e)
        {
            paC.afficherConjointNonPayer(dataNonPaiment, int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblheure.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblheure_SizeChanged(object sender, EventArgs e)
        {
            String time=lblheure.Text;
            String h = time.Substring(1,2);
            MessageBox.Show(h);
            
        }

        private void lblheure_TextChanged(object sender, EventArgs e)
        {
            String time = lblheure.Text;
            String h = time.Substring(0, 2);
            String m = time.Substring(3, 2);
            String s = time.Substring(6,2);
            if ((s.Equals("00")))
            {
                acc.ActiviteActuel(dataActiviteActuel);
            }
            else
            {
                if ((s.Equals("00")) || (s.Equals("30")) || (s.Equals("15")) || s.Equals("45"))
                {
                    acc.ActiviteActuel(dataActiviteActuel);
                    try
                    {
                        if (comboAnnee.SelectedItem.ToString().Equals("Les activité actuelle"))
                        {
                            acc.getActuelActivity(dataActivite);
                        }

                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine("error :" + ex.Message);
                    }
                }
            }
        }

        private void btConfirmerPayer_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdConjointNonPayer.Checked==true)
                {
                    pc.confirmerPaiymentConjoint(int.Parse(dataNonPaiment.CurrentRow.Cells[0].Value.ToString()), int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()), 0, int.Parse(dataActiviteActuel.CurrentRow.Cells[6].Value.ToString()));
                    MessageBox.Show("Paiyment confirmer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(rdEnfantNonPayer.Checked==true)
                    {
                        pc.confirmerPaiymentEnfant(int.Parse(dataNonPaiment.CurrentRow.Cells[0].Value.ToString()), int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()), 0, int.Parse(dataActiviteActuel.CurrentRow.Cells[6].Value.ToString()));
                        MessageBox.Show("Paiyment confirmer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if(rdAdherentNonPayer.Checked==true)
                        {
                            pc.confirmerPaiymentAdherent(int.Parse(dataNonPaiment.CurrentRow.Cells[0].Value.ToString()), int.Parse(dataActiviteActuel.CurrentRow.Cells[0].Value.ToString()), 0, int.Parse(dataActiviteActuel.CurrentRow.Cells[6].Value.ToString()));
                            MessageBox.Show("Paiyment confirmer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if((rdAdherentNonPayer.Checked==false)&&(rdConjointNonPayer.Checked==false)&&(rdEnfantNonPayer.Checked==false))
                            {
                                MessageBox.Show("Vous devez séléctionner le type de participant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
        }

        private void refreshToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refreshToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            refresh();
        }
        
        private void refreshToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refreshToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataAdherent_DoubleClick(object sender, EventArgs e)
        {
            Famille f = new Famille();
            f.matricule = dataAdherent.CurrentRow.Cells[0].Value.ToString();
            f.Show();
        }

        private void metroGrid1_Enter(object sender, EventArgs e)
        {
            try
            {
                if (comboAnnee.SelectedItem.ToString().Equals("Les activité actuelle"))
                {
                   // acc.getActuelActivity(dataActivite);
                    //btSupprimerActivite.Enabled = true;
                    //btModifierActivite.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
        }

        private void metroGrid1_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (comboAnnee.SelectedItem.ToString().Equals("Les activité actuelle"))
                {
                    //acc.getActuelActivity(dataActivite);
                    //btSupprimerActivite.Enabled = true;
                    //btModifierActivite.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous supprimer cet adhérent ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                ac.Supprimer(int.Parse(dataAdherent.CurrentRow.Cells[0].Value.ToString()));
                ac.affihcer(dataAdherent);
            }
            else
            {
                MessageBox.Show("La suppression est échoué !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtChercher_TextChanged(object sender, EventArgs e)
        {
            ac.recherche(dataAdherent, txtChercher.Text.ToString());
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            r1.Checked = false;
            r2.Checked = false;
            r3.Checked = false;
            oc.affiche(dataOrganisation);
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            r1.Checked = false;
            r2.Checked = false;
            r3.Checked = false;
            oc.affiche(dataOrganisation);
        }

        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (comboAnnee.SelectedItem.ToString().Equals("Les activité actuelle"))
                {
                    acc.getActuelActivity(dataActivite);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
            }
        }
    }
}
