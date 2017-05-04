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

        private void btAccepter_Click(object sender, EventArgs e)
        {
            //pc.Accepter(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString()), int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()),int.Parse(dataGridView1.CurrentRow.Cells[11].Value.ToString()));
            afficher();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            pc.refuser(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
        }

        public void afficher()
        {
            
        }
    }
}
