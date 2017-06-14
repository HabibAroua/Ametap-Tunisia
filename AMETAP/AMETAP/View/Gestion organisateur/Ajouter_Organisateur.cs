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
    public partial class Ajouter_Organisateur : MetroForm
    {
        OrganisateurController oc;
        public Ajouter_Organisateur()
        {
            InitializeComponent();
            oc= new OrganisateurController();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            txtAdresse.Clear();
            txtEmail.Clear();
            txtNom.Clear();
        }

        private void Ajouter_Organisateur_Load(object sender, EventArgs e)
        {
            //comboOrganisateur.Items.Add("Club");
            //comboOrganisateur.Items.Add("Agence de voyage");
            //comboOrganisateur.Items.Add("Centre");
            
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            RegularExpression r = new RegularExpression();
            //try
            //{
                if ((txtNom.ToString().Equals("")) || (txtAdresse.Text.ToString().Equals("")) || (txtEmail.Text.ToString().Equals("")) || (txtDescription.Text.ToString().Equals("")))
                {
                    MessageBox.Show("SVP remplir les champs manquant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboOrganisateur == null)
                    {
                        MessageBox.Show("SVP donner le type de l'organisateur", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (r.VerifMail(txtEmail.Text.ToString()) == false)
                        {
                            MessageBox.Show("Il faut saisir un mail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            oc.AjouterOrganisateur(comboOrganisateur.SelectedItem.ToString(), 0, txtNom.Text.ToString(), txtEmail.Text.ToString(), txtAdresse.Text.ToString(), txtDescription.Text.ToString());
                        this.Close();
                        }
                    }
                }
            //}
            //catch(Exception ex)
            //{
              //  MessageBox.Show("SVP donner le type de l'organisateur", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }
    }
}
