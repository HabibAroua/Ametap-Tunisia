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

namespace AMETAP.View.Gestion_des_activites
{
    public partial class Modifier_Activite : MetroForm
    {
        BudgetCategorieController bcc;

     
        public String Organisateur;
        public int id;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public String getOrganisateur()
        {
            return Organisateur;
        }

        public void setOrganisateur(String Organisateur)
        {
            this.Organisateur = Organisateur;
        }

        ActiviteController ac;
        OrganisateurController oc;
        public Modifier_Activite()
        {
            InitializeComponent();
            ac = new ActiviteController();
            bcc = new BudgetCategorieController();
            oc = new OrganisateurController();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Modifier_Activite_Load(object sender, EventArgs e)
        {
            comboNbr_point.Items.Add("10");
            comboNbr_point.Items.Add("20");
            comboNbr_point.Items.Add("30");
            comboNbr_point.Items.Add("40");
            comboNbr_point.Items.Add("50");
            comboNbr_point.Items.Add("60");
        }

        private void btModifier_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(viewMontant.Text.ToString()) < int.Parse(txtMontantPrevu.Text.ToString()))
                {
                    MessageBox.Show("Le montant prévu est plus supérieur que le montant du budget", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rdActiviteCulturel.Checked == true)
                        ac.ModifierActivite(id, txtNomActivite.Text, dateFinInscription.Text, txtDateDebut.Text, txtDatefin.Text, int.Parse(txtCapacite.Text.ToString()), double.Parse(txtPrixUnitaire.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), int.Parse(comboNbr_point.SelectedItem.ToString()), "Activité culturel");
                    else
                    {
                        if (rdActiviteLoisir.Checked == true)
                            ac.ModifierActivite(id, txtNomActivite.Text, dateFinInscription.Text, txtDateDebut.Text, txtDatefin.Text, int.Parse(txtCapacite.Text.ToString()), double.Parse(txtPrixUnitaire.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), int.Parse(comboNbr_point.SelectedItem.ToString()), "Activité de loisir");
                    }
                    this.Close();
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Il faut séléctionner le nombre de point", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdActiviteCulturel_Click(object sender, EventArgs e)
        {
            viewMontant.Text = bcc.getMontantProvisoire("Activité culturel").ToString();
            dt.Show();
        }

        private void rdActiviteLoisir_Click(object sender, EventArgs e)
        {
            viewMontant.Text = "" + bcc.getMontantProvisoire("Activité de loisir").ToString();
            dt.Show();
        }

        private void txtCapacite_ValueChanged(object sender, EventArgs e)
        {
            if ((txtPrixUnitaire.Text.Equals("")) || (txtCapacite.Text.Equals("0")))
            {
                txtMontantPrevu.Text = "";
            }
            else
            {
                txtMontantPrevu.Text = "" + (int.Parse(txtPrixUnitaire.Text) / 2) * int.Parse(txtCapacite.Text);
            }
        }

        private void txtPrixUnitaire_TextChanged(object sender, EventArgs e)
        {
            if ((txtPrixUnitaire.Text.Equals("")) || (txtCapacite.Text.Equals("0")))
            {
                txtMontantPrevu.Text = "";
            }
            else
            {
                txtMontantPrevu.Text = "" + (int.Parse(txtPrixUnitaire.Text) / 2) * int.Parse(txtCapacite.Text);
            }
        }

        private void btAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
