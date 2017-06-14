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
using AMETAP.Controller.Script;

namespace AMETAP.View.Gestion_Budget
{
    public partial class Fixer_Budget : MetroForm
    {
        BudgetController bc;
        BudgetCategorieController bcc;
        public Fixer_Budget()
        {
            InitializeComponent();
            bc = new BudgetController();
            bcc = new BudgetCategorieController();
        }

        private void Fixer_Budget_Load(object sender, EventArgs e)
        {
            //first year is 2006
            txtMontantProvisoire.Enabled = false;
            txtBudgetCulturel.Enabled = false;
            txtBudgetLoisir.Enabled = false;
            comboAnnee.Items.Add((bc.MaxAnnee()+1).ToString());
            viewResteBudget.Text = "" + (bcc.getMontantProvisoire("Activité culturel") + bcc.getMontantProvisoire("Activité de loisir"));
            btFixer.Enabled = false;
            DateValue d = new DateValue();
            //MessageBox.Show(d.getDayToday());
            if((d.getDayToday().Equals("29")) && (d.getMonthToday().Equals("04")))
            {
                //MessageBox.Show("Vrai");
            }
            else
            {
                //MessageBox.Show("", "Errur", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  txtMontantFinal.Enabled = false;
                //comboAnnee.Enabled = false;
            }
            if ((d.getDayToday().Equals("29")==true) && (!d.getMonthToday().Equals("04"))==true)
            {
                MessageBox.Show(d.getDayToday() + "  month" + d.getMonthToday());
                txtMontantFinal.Enabled = true;
                txtBudgetCulturel.Enabled = false;
                txtBudgetLoisir.Enabled = false;
                comboAnnee.Enabled = true;
            }
            else
            {
                //MessageBox.Show(d.getDayToday() + "  month" + d.getMonthToday());
                txtMontantFinal.Enabled = false;
                txtBudgetCulturel.Enabled = false;
                txtBudgetLoisir.Enabled = false;
                comboAnnee.Enabled = false;
            } 
        }

        private void txtMontantFinal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtMontantFinal.Text.ToString().Equals(""))
                {
                    txtBudgetCulturel.Enabled = true;
                    txtBudgetLoisir.Enabled = true;
                    txtMontantProvisoire.Text = "" + (int.Parse(txtMontantFinal.Text.ToString()) + int.Parse(viewResteBudget.Text.ToString()));
                    
                }
                else
                {
                    txtBudgetCulturel.Enabled = false;
                    txtBudgetLoisir.Enabled = false;
                    txtBudgetLoisir.Clear();
                    txtMontantProvisoire.Clear();
                    txtBudgetCulturel.Clear();
                    txtMontantProvisoire.Text = "" + int.Parse(viewResteBudget.Text.ToString());
                }
                if ((!txtBudgetCulturel.Text.ToString().Equals("")) && (!txtBudgetLoisir.Text.ToString().Equals("")) && (!txtMontantProvisoire.Text.ToString().Equals("") && (!txtMontantFinal.Text.ToString().Equals(""))))
                {
                    btFixer.Enabled = true;
                }

            }
            catch(Exception)
            {

            }

        }

        private void btFixer_Click(object sender, EventArgs e)
        {
            DateValue d = new DateValue();
            if ((!d.getDayToday().Equals("29")) && (!d.getMonthToday().Equals("12")))
            {
                txtMontantFinal.Enabled = false;
                txtBudgetCulturel.Enabled = false;
                txtBudgetLoisir.Enabled = false;
                comboAnnee.Enabled = false;
            }
            else
            {
                bc.fixerBudget(int.Parse(comboAnnee.SelectedItem.ToString()), double.Parse(txtMontantProvisoire.Text.ToString()), double.Parse(txtMontantProvisoire.Text.ToString()), double.Parse(txtBudgetCulturel.Text.ToString()), double.Parse(txtBudgetCulturel.Text.ToString()));
            }
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
                    int res = int.Parse(txtMontantProvisoire.Text.ToString()) - int.Parse(txtBudgetLoisir.Text.ToString());
                    if (res < 0)
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
                catch (Exception)
                {

                }
            
        }

        private void txtBudgetLoisir_Click(object sender, EventArgs e)
        {
            try
            {
                int res = int.Parse(txtMontantProvisoire.Text.ToString()) - int.Parse(txtBudgetCulturel.Text.ToString());
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
            catch (Exception)
            {
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
            DateValue d = new DateValue("29/04/2017");
            int month = int.Parse(d.getMonth());
            MessageBox.Show("convert "+month+" "+d.getDay()+"/"+d.getMonth()+"/"+d.getYear()+ "Today is :"+d.getToday());
        }
    }
}
