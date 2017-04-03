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
            ac.AjouterActivite(txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), txtDateDebut.Text.ToString(), txtDatefin.Text.ToString(), double.Parse(txtPrixUnitaire.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()), double.Parse(txtMontantPrevu.Text.ToString()),comboTypeActivite.SelectedItem.ToString(),comboOrganisateur.SelectedItem.ToString());
        }

        private void AjouterActivite_Load(object sender, EventArgs e)
        {
            foreach (TypeActivite at in taC.ListActiviteInComboBox())
            {
                comboTypeActivite.Items.Add(at.libelle.ToString());
            }
            foreach (Organisateur o in oc.AllOrganisateur() )
            {
                comboOrganisateur.Items.Add(o.nom_organisateur);
            }
        }
    }
}
