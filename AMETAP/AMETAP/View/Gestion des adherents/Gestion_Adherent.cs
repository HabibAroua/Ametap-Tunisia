using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using AMETAP.Controller;

namespace AMETAP.View.Gestion_des_adherents
{
    public partial class Gestion_Adherent : MetroForm
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
        AdherentController ac;
        public Gestion_Adherent()
        {
            InitializeComponent();
            ac = new AdherentController();
        }

        private void Gestion_Adherent_Load(object sender, EventArgs e)
        {
            ac.affihcer(dataAdherent);
        }

        public void Afficher()
        {
            ac.affihcer(dataAdherent);
        
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ac.affihcer(dataAdherent);
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            ac.Supprimer(int.Parse(dataAdherent.CurrentRow.Cells[0].Value.ToString()));
        }

        private void txtChercher_TextChanged(object sender, EventArgs e)
        {
            ac.recherche(dataAdherent, txtChercher.Text.ToString());
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

        private void dataAdherent_DoubleClick(object sender, EventArgs e)
        {
            Famille f = new Famille();
            f.matricule = dataAdherent.CurrentRow.Cells[0].Value.ToString();
            f.Show();
        }
    }
}
