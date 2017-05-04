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
    public partial class AjouterActivite : MetroForm
    {
        ActiviteController ac;
        TypeActiviteController taC;
        OrganisateurController oc;
        BudgetCategorieController bcc;
        public AjouterActivite()
        {
            InitializeComponent();
            ac = new ActiviteController();
            taC = new TypeActiviteController();
            oc = new OrganisateurController();
            bcc = new BudgetCategorieController();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (int.Parse(viewMontant.Text.ToString()) - int.Parse(txtMontantPrevu.Text.ToString()) >= 0)
            {
                if (rdActiviteCulturel.Checked == true)
                {
                    ac.AjouterActivite(comboNomActivite.SelectedItem.ToString(), int.Parse(txtCapacite.Text.ToString()), txtDateDebut.Text.ToString(), txtDatefin.Text.ToString(), double.Parse(txtPrixUnitaire.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), "Activité culturel", comboOrganisateur.SelectedItem.ToString(), txtDateDebutInscription.Text.ToString(), dateFinInscription.Text.ToString());

                }
                else
                {
                    if (rdActiviteLoisir.Checked == true)
                    {
                        ac.AjouterActivite(comboNomActivite.SelectedItem.ToString(), int.Parse(txtCapacite.Text.ToString()), txtDateDebut.Text.ToString(), txtDatefin.Text.ToString(), double.Parse(txtPrixUnitaire.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), "Activité de loisir", comboOrganisateur.SelectedItem.ToString(), txtDateDebutInscription.Text.ToString(), dateFinInscription.Text.ToString());
                        viewMontant.Text = bcc.getMontantProvisoire("Activité de loisir").ToString();
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas ajouter une nouvelle activité car le budget est inssuffisant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void AjouterActivite_Load(object sender, EventArgs e)
        {
            foreach (Organisateur o in oc.AllOrganisateur() )
            {
                comboOrganisateur.Items.Add(o.nom_organisateur);
            }
            txtMontantPrevu.Enabled = false;
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
        private void rdActiviteCulturel_CheckedChanged(object sender, EventArgs e)
        {
            comboNomActivite.Items.Clear();
            if (rdActiviteCulturel.Checked == true)
            {
                comboNomActivite.Items.Add("Cours Anglais");
                comboNomActivite.Items.Add("Cours francais");
                comboNomActivite.Items.Add("Cours Espagnole");
                comboNomActivite.Items.Add("Theatre");
                comboNomActivite.Items.Add("Cinema");
            }
        }

        private void rdActiviteLoisir_CheckedChanged(object sender, EventArgs e)
        {
            comboNomActivite.Items.Clear();
            if (rdActiviteLoisir.Checked == true)
            {
                comboNomActivite.Items.Add("Cours aerobic");
                comboNomActivite.Items.Add("Cours danse orientale");
                comboNomActivite.Items.Add("Omra");
                comboNomActivite.Items.Add("Voyage Japon");
                comboNomActivite.Items.Add("Voyage France");
                comboNomActivite.Items.Add("Voyage Espagne");
                comboNomActivite.Items.Add("Voyage Italie");
                comboNomActivite.Items.Add("Voyage Allemagne");
                comboNomActivite.Items.Add("Voyage Autriche");
            }
        }

        private void rdActiviteCulturel_Click(object sender, EventArgs e)
        {
            viewMontant.Text = bcc.getMontantProvisoire("Activité culturel").ToString();
        }

        private void rdActiviteLoisir_Click(object sender, EventArgs e)
        {
            viewMontant.Text =""+bcc.getMontantProvisoire("Activité de loisir");
        }
    }
}
