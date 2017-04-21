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
using AMETAP.Model.Business;
namespace AMETAP.View.Gestion_Budget
{
    public partial class Information_chaque_année : MetroForm
    {
        ActiviteController ac;
        public Information_chaque_année()
        {
            InitializeComponent();
            ac = new ActiviteController();
        }

        private void btAfficher_Click(object sender, EventArgs e)
        {
            ac.AfficheInformation(dataActivite, viewAnnee.Text.ToString());
            foreach (Activite a in ac.Stat(viewAnnee.Text))
            {
                //MessageBox.Show(a.nom_Activite);
               chart1.Series["Activites"].Points.AddXY(a.nom_Activite, a.montant_prevu);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu m = new View.Menu();
            m.Show();
            this.Close();
        }
    }
}
