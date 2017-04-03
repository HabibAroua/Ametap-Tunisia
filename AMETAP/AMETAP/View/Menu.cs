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

namespace AMETAP.View
{
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            Authentification a = new Authentification();
            a.Show();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionDesAdhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Gestion_des_adherents.Gestion_Adherent ga = new Gestion_des_adherents.Gestion_Adherent();
            ga.Show();
            this.Hide();
        }

        private void gestionDesOrganisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Gestion_organisateur.GestionOrganisateur go = new Gestion_organisateur.GestionOrganisateur();
            go.Show();
            this.Hide();
        }

        private void gestionDesUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Gestion_des_utilisateurs.Gestion_des_utilisateurs gu = new Gestion_des_utilisateurs.Gestion_des_utilisateurs();
            gu.Show();
            this.Hide();
        }

        private void gestionDesActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Gestion_des_activites.GestionActivite ga = new Gestion_des_activites.GestionActivite();
            ga.Show();
            this.Hide();
        }

        private void fixerBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Gestion_Budget.Fixer_Budget fb = new Gestion_Budget.Fixer_Budget();
            fb.Show();
            this.Hide();

        }
    }
}
