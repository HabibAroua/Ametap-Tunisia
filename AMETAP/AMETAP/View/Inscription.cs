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

namespace AMETAP.View
{
    public partial class Inscription : MetroForm
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            txtMatricule.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btInscrire_Click(object sender, EventArgs e)
        {
            AdminController ac = new AdminController();
            if(txtPassword.Text.ToString().Equals(txtConfirmPassword.Text.ToString()))
            {
                Cryptage c = new Cryptage();
                ac.Inscrire(int.Parse(txtMatricule.Text.ToString()), txtLogin.Text.ToString(),c.Encrypt(txtPassword.Text.ToString()));
            }
            else
            {
                MessageBox.Show("Vérifier le mot de passe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {
           if((!txtLogin.Text.ToString().Equals(""))&&(!txtMatricule.Text.ToString().Equals(""))&&(!txtPassword.Text.ToString().Equals(""))&&(!txtConfirmPassword.Text.ToString().Equals("")))
            {
                btInscrire.Enabled = true;
            }
           else
            {
                btInscrire.Enabled = false;
            }
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            btInscrire.Enabled = false;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if ((!txtLogin.Text.ToString().Equals("")) && (!txtMatricule.Text.ToString().Equals("")) && (!txtPassword.Text.ToString().Equals("")) && (!txtConfirmPassword.Text.ToString().Equals("")))
            {
                btInscrire.Enabled = true;
            }
            else
            {
                btInscrire.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if ((!txtLogin.Text.ToString().Equals("")) && (!txtMatricule.Text.ToString().Equals("")) && (!txtPassword.Text.ToString().Equals("")) && (!txtConfirmPassword.Text.ToString().Equals("")))
            {
                btInscrire.Enabled = true;
            }
            else
            {
                btInscrire.Enabled = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if ((!txtLogin.Text.ToString().Equals("")) && (!txtMatricule.Text.ToString().Equals("")) && (!txtPassword.Text.ToString().Equals("")) && (!txtConfirmPassword.Text.ToString().Equals("")))
            {
                btInscrire.Enabled = true;
            }
            else
            {
                btInscrire.Enabled = false;
            }
        }

        private void Inscription_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
