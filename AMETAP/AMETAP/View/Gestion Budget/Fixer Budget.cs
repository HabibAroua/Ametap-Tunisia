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
            txtBudgetCulturel.Enabled = false;
            txtBudgetLoisir.Enabled = false;
            comboAnnee.Items.Add((bc.MaxAnnee()+1).ToString());
            btFixer.Enabled = false;   
        }

        private void txtMontantFinal_TextChanged(object sender, EventArgs e)
        {
            txtMontantProvisoire.Text = txtMontantFinal.Text.ToString();
            if(!txtMontantFinal.Text.ToString().Equals(""))
            {
                txtBudgetCulturel.Enabled = true;
                txtBudgetLoisir.Enabled = true;
            }
            else
            {
                txtBudgetCulturel.Enabled = false;
                txtBudgetLoisir.Enabled = false;
                txtBudgetLoisir.Clear();
                txtMontantProvisoire.Clear();
                txtBudgetCulturel.Clear();
            }
            if ((!txtBudgetCulturel.Text.ToString().Equals("")) && (!txtBudgetLoisir.Text.ToString().Equals("")) && (!txtMontantProvisoire.Text.ToString().Equals("") && (!txtMontantFinal.Text.ToString().Equals(""))))
            {
                btFixer.Enabled = true;
            }



        }

        private void btFixer_Click(object sender, EventArgs e)
        {
            bc.fixerBudget(int.Parse(comboAnnee.SelectedItem.ToString()), double.Parse(txtMontantProvisoire.Text.ToString()), double.Parse(txtMontantFinal.Text.ToString()),double.Parse(txtBudgetCulturel.Text.ToString()),double.Parse(txtBudgetCulturel.Text.ToString()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu m = new View.Menu();
            m.Show();
            this.Close();
        }
        private void txtBudgetCulturel_Click(object sender, EventArgs e)
        {
            try
            {
                int res = int.Parse(txtMontantFinal.Text.ToString()) - int.Parse(txtBudgetLoisir.Text.ToString());
                if(res<0)
                {
                    MessageBox.Show("Impossible", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBudgetCulturel.Clear();
                    txtBudgetLoisir.Clear();
                    txtMontantFinal.Clear();
                }
                else
                {
                    txtBudgetCulturel.Text = "" + res;
                }
            }
            catch(Exception ex)
            {
               // MessageBox.Show("Il faut saisie caractére numérique", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtBudgetLoisir_Click(object sender, EventArgs e)
        {
            try
            {
                int res = int.Parse(txtMontantFinal.Text.ToString()) - int.Parse(txtBudgetCulturel.Text.ToString());
                if (res < 0)
                {
                    MessageBox.Show("Impossible", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBudgetCulturel.Clear();
                    txtBudgetLoisir.Clear();
                    txtMontantFinal.Clear();
                }
                else
                {
                    txtBudgetLoisir.Text = "" + res;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Il faut saisie caractére numérique", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtBudgetCulturel_TextChanged(object sender, EventArgs e)
        {
            if((!txtBudgetCulturel.Text.ToString().Equals(""))&&(!txtBudgetLoisir.Text.ToString().Equals("")))
            {
                txtMontantFinal.Enabled = false;
                txtBudgetCulturel.Enabled = false;
                txtBudgetLoisir.Enabled = false;
            }

            if ((!txtBudgetCulturel.Text.ToString().Equals("")) && (!txtBudgetLoisir.Text.ToString().Equals("")) && (!txtMontantProvisoire.Text.ToString().Equals("") && (!txtMontantFinal.Text.ToString().Equals(""))))
            {
                btFixer.Enabled = true;
            }
        }

        private void txtBudgetLoisir_TextChanged(object sender, EventArgs e)
        {
            if ((!txtBudgetCulturel.Text.ToString().Equals("")) && (!txtBudgetLoisir.Text.ToString().Equals("")))
            {
                txtMontantFinal.Enabled = false;
                txtMontantFinal.Enabled = false;
                txtBudgetCulturel.Enabled = false;
                txtBudgetLoisir.Enabled = false;
            }

            if ((!txtBudgetCulturel.Text.ToString().Equals("")) && (!txtBudgetLoisir.Text.ToString().Equals("")) && (!txtMontantProvisoire.Text.ToString().Equals("") && (!txtMontantFinal.Text.ToString().Equals(""))))
            {
                btFixer.Enabled = true;
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            AMETAP.Model.DataAcces.BudgetDA b = new Model.DataAcces.BudgetDA();
            MessageBox.Show("Le max est :" + b.maxID());
        }
    }
}
