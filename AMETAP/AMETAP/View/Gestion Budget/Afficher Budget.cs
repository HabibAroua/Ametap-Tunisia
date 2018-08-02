using System;
using System.Windows.Forms;
using AMETAP.Controller;
using MetroFramework.Forms;

namespace AMETAP.View.Gestion_Budget
{
    public partial class Afficher_Budget : MetroForm
    {
        BudgetController bc;

        public Afficher_Budget()
        {
            InitializeComponent();
            bc = new BudgetController();
        }

        private void Afficher_Budget_Load(object sender, EventArgs e)
        {
            bc.AfficherBudget(dataBudget);
        }

        private void dataBudget_DoubleClick(object sender, EventArgs e)
        {
            Information_chaque_année ica = new Information_chaque_année();
            ica.Show();
            ica.viewAnnee.Text =dataBudget.CurrentRow.Cells[1].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu m = new View.Menu();
            m.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
