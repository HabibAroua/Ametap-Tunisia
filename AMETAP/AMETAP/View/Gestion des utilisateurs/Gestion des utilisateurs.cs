using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using AMETAP.Controller;

namespace AMETAP.View.Gestion_des_utilisateurs
{
    public partial class Gestion_des_utilisateurs : MetroForm
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

        AdminController ac;
        public Gestion_des_utilisateurs()
        {
            ac = new AdminController();
            InitializeComponent();
        }

        private void Gestion_des_utilisateurs_Load(object sender, EventArgs e)
        {
            ac.afficher(dataUtilisateur);
        }

        private void txtRecherhce_TextChanged(object sender, EventArgs e)
        {
            ac.rechercher(txtRecherhce.Text.ToString(), dataUtilisateur);
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            ac.supprimer(int.Parse(dataUtilisateur.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ac.afficher(dataUtilisateur);
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
