using System;
using MetroFramework.Forms;
using AMETAP.Controller;

namespace AMETAP.View.Gestion_des_Inscriptions
{
    public partial class Gestion_des_inscriptions : MetroForm
    {
        ParticipationController pc;
        PayaimentController paC;
        public Gestion_des_inscriptions()
        {
            pc = new ParticipationController();
            paC = new PayaimentController();
            InitializeComponent();
        }

        private void Gestion_des_inscriptions_Load(object sender, EventArgs e)
        {
            pc.AfficheDemande(dataGridView1);
            paC.afficheNonPayaiment(dataGridView2);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            pc.refuser(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
        }
    }
}
