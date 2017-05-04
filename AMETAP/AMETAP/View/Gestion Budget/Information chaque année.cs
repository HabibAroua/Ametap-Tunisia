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
        BudgetController bc;
        public Information_chaque_année()
        {
            InitializeComponent();
            ac = new ActiviteController();
            bc = new BudgetController();
        }

        private void btAfficher_Click(object sender, EventArgs e)
        {
            foreach (Activite a in ac.StatCulturel(viewAnnee.Text))
            {
                dataActivite.Rows.Add(a.nom_Activite, a.montant_prevu ,ac.totalMontant_prevuCulturel(viewAnnee.Text.ToString()),bc.getBudget(viewAnnee.Text.ToString()));
                chart1.Series["Activites"].Points.AddXY(a.nom_Activite, a.montant_prevu);
            }

            foreach (Activite a in ac.StatLoisir(viewAnnee.Text))
            {
                dataGridView1.Rows.Add(a.nom_Activite, a.montant_prevu, ac.totalMontant_prevuLoisir(viewAnnee.Text.ToString()),bc.getBudget(viewAnnee.Text.ToString()));
                chart2.Series["Activites"].Points.AddXY(a.nom_Activite, a.montant_prevu.ToString());

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
