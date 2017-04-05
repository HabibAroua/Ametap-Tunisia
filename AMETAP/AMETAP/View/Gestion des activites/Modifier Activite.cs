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
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public String TypeActivite;
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

        public String getTypeActivite()
        {
            return TypeActivite;
        }

        public void setTypeActivite(String TypeActivite)
        {
            this.TypeActivite = TypeActivite;
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
        TypeActiviteController taC;
        OrganisateurController oc;
        public Modifier_Activite()
        {
            InitializeComponent();
            ac = new ActiviteController();
            taC = new TypeActiviteController();
            oc = new OrganisateurController();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modifier_Activite_Load(object sender, EventArgs e)
        {
            foreach (TypeActivite at in taC.ListActiviteInComboBox())
            {
                comboTypeActivite.Items.Add(at.libelle.ToString());
            }
            foreach (Organisateur o in oc.AllOrganisateur())
            {
                comboOrganisateur.Items.Add(o.nom_organisateur);
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboTypeActivite.SelectedItem.ToString() + " " + comboOrganisateur.SelectedItem.ToString());
            try
            {
                if ((!getOrganisateur().Equals(comboOrganisateur.SelectedItem.ToString())) && ((!getTypeActivite().Equals(comboTypeActivite.SelectedItem.ToString()))))
                {
                    setOrganisateur(comboOrganisateur.SelectedItem.ToString());
                    setTypeActivite(comboTypeActivite.SelectedItem.ToString());
                    ac.ModifierActivite(getId(), txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), getTypeActivite(), getOrganisateur());
                }
                else
                {
                    if (!getOrganisateur().Equals(comboOrganisateur.SelectedItem.ToString()))
                    {
                        setOrganisateur(comboOrganisateur.SelectedItem.ToString());
                        ac.ModifierActivite(getId(), txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), getTypeActivite(), getOrganisateur());
                    }
                    else
                    {
                        if (!getTypeActivite().Equals(comboTypeActivite.SelectedItem.ToString()))
                        {
                            setTypeActivite(comboTypeActivite.SelectedItem.ToString());
                            ac.ModifierActivite(getId(), txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), getTypeActivite(), getOrganisateur());
                        }
                        else
                        {
                            ac.ModifierActivite(getId(), txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), comboTypeActivite.SelectedItem.ToString(), comboOrganisateur.SelectedItem.ToString());
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                ac.ModifierActivite(getId(), txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), getTypeActivite(), getOrganisateur());
                try
                {
                    ac.ModifierActivite(getId(), txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), comboTypeActivite.SelectedItem.ToString(), getOrganisateur());
                }
                catch (NullReferenceException)
                {
                    try
                    {
                        ac.ModifierActivite(getId(), txtNomActivite.Text.ToString(), int.Parse(txtCapacite.Text.ToString()), getTypeActivite(), comboOrganisateur.SelectedItem.ToString());
                    }
                    catch (NullReferenceException)
                    {

                    }
                }
            }
        }
    }
}
