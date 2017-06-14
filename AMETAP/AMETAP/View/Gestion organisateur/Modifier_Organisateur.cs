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
using AMETAP.View.Script;

namespace AMETAP.View.Gestion_organisateur
{
    public partial class Modifier_Organisateur : MetroForm
    {
        OrganisateurController oc;
        public int id;

        public int getID()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public Modifier_Organisateur()
        {
            oc = new OrganisateurController();
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            txtAdresse.Clear();
            txtDescription.Clear();
            txtEmail.Clear();
            txtNom.Clear();
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            RegularExpression r = new RegularExpression();
            if (r.VerifMail(txtEmail.Text.ToString()) == false)
            {
                MessageBox.Show("Il faut saisir un Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                oc.modifier(id, txtNom.Text.ToString(), txtEmail.Text.ToString(), txtAdresse.Text.ToString(), txtDescription.Text.ToString());
                Index i = new Index();
                i.Index_Load(sender, e);
                this.Close();
            }
        }
    }
}
