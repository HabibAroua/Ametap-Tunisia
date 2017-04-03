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

namespace AMETAP.View.Gestion_Budget
{
    public partial class Fixer_Budget : MetroForm
    {
        BudgetController bc;
        public Fixer_Budget()
        {
            InitializeComponent();
            bc = new BudgetController();
        }

        private void Fixer_Budget_Load(object sender, EventArgs e)
        {

            //first year is 2006
            txtMontantProvisoire.Enabled = false;
            comboAnnee.Items.Add((bc.MaxAnnee()+1).ToString());
            
            
        }

        private void txtMontantFinal_TextChanged(object sender, EventArgs e)
        {
            txtMontantProvisoire.Text = txtMontantFinal.Text.ToString();
        }

        private void btFixer_Click(object sender, EventArgs e)
        {
            bc.fixerBudget(int.Parse(comboAnnee.SelectedItem.ToString()), double.Parse(txtMontantProvisoire.Text.ToString()), double.Parse(txtMontantFinal.Text.ToString()));
        }
    }
}
