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
namespace AMETAP.View.Gestion_organisateur
{
    public partial class GestionOrganisateur : MetroForm
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        OrganisateurController oc;
        ClubController cl;
        CentreController ce;
        Agence_VoyageController av;
        public GestionOrganisateur()
        {
            oc = new OrganisateurController();
            cl = new ClubController();
            ce = new CentreController();
            av = new Agence_VoyageController();
            InitializeComponent();
        }

        private void GestionOrganisateur_Load(object sender, EventArgs e)
        {
            oc.affiche(dataOrganisation);

        }
        private void btAjouter_Click(object sender, EventArgs e)
        {
            Ajouter_Organisateur ao = new Ajouter_Organisateur();
            ao.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            r1.Checked = false;
            r2.Checked = false;
            r3.Checked = false;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            r1.Checked = false;
            r2.Checked = false;
            r3.Checked = false;
            r1.Enabled = true;
            r2.Enabled = true;
            r3.Enabled = true;
            oc.affiche(dataOrganisation);
        }

        private void btSupprimer_Click(object sender, EventArgs e)
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

        private void txtChercher_Click(object sender, EventArgs e)
        {
            r1.Checked = false;
            r2.Checked = false;
            r3.Checked = false;
            r1.Enabled = true;
            r2.Enabled = true;
            r3.Enabled = true;
            oc.affiche(dataOrganisation);
        }

        private void txtChercher_TextChanged(object sender, EventArgs e)
        {
            oc.recherche(dataOrganisation, txtChercher.Text.ToString());
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            Modifier_Organisateur mo = new Modifier_Organisateur();
            mo.Show();
            mo.id = int.Parse(dataOrganisation.CurrentRow.Cells[0].Value.ToString());
            mo.txtNom.Text = dataOrganisation.CurrentRow.Cells[1].Value.ToString();
            mo.txtEmail.Text = dataOrganisation.CurrentRow.Cells[2].Value.ToString();
            mo.txtAdresse.Text = dataOrganisation.CurrentRow.Cells[3].Value.ToString();
            mo.txtDescription.Text = dataOrganisation.CurrentRow.Cells[4].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            View.Menu m = new View.Menu();
            m.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
