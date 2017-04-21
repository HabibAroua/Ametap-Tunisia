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
        public AjouterActivite()
        {
            InitializeComponent();
            ac = new ActiviteController();
            taC = new TypeActiviteController();
            oc = new OrganisateurController();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (rdActiviteCulturel.Checked == true)
            {
                ac.AjouterActivite(txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), txtDateDebut.Text.ToString(), txtDatefin.Text.ToString(), double.Parse(txtPrixUnitaire.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), "Activité culturel", comboOrganisateur.SelectedItem.ToString());
            }
            else
            {
                if (rdActiviteLoisir.Checked == true)
                {
                    ac.AjouterActivite(txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), txtDateDebut.Text.ToString(), txtDatefin.Text.ToString(), double.Parse(txtPrixUnitaire.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), "Activité de loisir", comboOrganisateur.SelectedItem.ToString());
                }
            }
        }

        private void AjouterActivite_Load(object sender, EventArgs e)
        {
            foreach (Organisateur o in oc.AllOrganisateur() )
            {
                comboOrganisateur.Items.Add(o.nom_organisateur);
            }

            comboNomActivite.Items.Add("Cours Anglais");
            comboNomActivite.Items.Add("Omra");
            comboNomActivite.Items.Add("Cours français");
            comboNomActivite.Items.Add("Excurssion");
            comboNomActivite.Items.Add("Cours Espagnole");
            comboNomActivite.Items.Add("Cours Italien");
            comboNomActivite.Items.Add("Théatre");
            comboNomActivite.Items.Add("Cours danse");
            comboNomActivite.Items.Add("Voyage");
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
                //ac.calculerMontant_prevu(txtCapacite.Text, txtPrixUnitaire.Text, txtPrixUnitaire.Text);
                //MessageBox.Show("" + (int.Parse(txtPrixUnitaire.Text) / 2) * int.Parse(txtPrixUnitaire.Text));
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
                //ac.calculerMontant_prevu(txtCapacite.Text, txtPrixUnitaire.Text, txtPrixUnitaire.Text);
                //MessageBox.Show("" + (int.Parse(txtPrixUnitaire.Text) / 2) * int.Parse(txtPrixUnitaire.Text));
                txtMontantPrevu.Text = "" + (int.Parse(txtPrixUnitaire.Text) / 2) * int.Parse(txtCapacite.Text);
            }

        }
    }
}
