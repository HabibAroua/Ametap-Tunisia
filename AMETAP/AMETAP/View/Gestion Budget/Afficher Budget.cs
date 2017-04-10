using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
