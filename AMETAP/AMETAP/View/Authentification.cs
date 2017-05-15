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
using System.Threading;

namespace AMETAP
{
    public partial class Authentification : MetroForm
    {
        
        AdminController ac;
        
        public Authentification()
        {
            Thread t = new Thread(startForm);
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if((!txtLogin.Text.ToString().Equals("")) && (!txtPassword.Text.ToString().Equals("")))
            {
                btConnexion.Enabled = true;
            }
            else
            {
                btConnexion.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if ((!txtLogin.Text.ToString().Equals("")) && (!txtPassword.Text.ToString().Equals("")))
            {
                btConnexion.Enabled = true;
            }
            else
            {
                btConnexion.Enabled = false;
            }

        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            btConnexion.Enabled = false;
            ac = new AdminController();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            AMETAP.View.Inscription i = new View.Inscription();
            i.Show();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            Boolean test= ac.Connecter(txtLogin.Text.ToString(),txtPassword.Text.ToString());
            if(test==true)
            {
                View.Index m = new View.Index();
                m.Show();
                this.Hide();
            }
            else
            {
                Application.Restart();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Authentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void startForm()
        {
            Application.Run(new View.SplashScreen());
        }
    }
}
