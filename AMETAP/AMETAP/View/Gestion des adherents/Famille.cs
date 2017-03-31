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
namespace AMETAP.View.Gestion_des_adherents
{
    public partial class Famille : MetroForm
    {
        public String matricule;
        EnfantController ec;
        ConjointController cc;

        public void setMatricule(String matricule)
        {
            this.matricule = matricule;
        }

        public String getMatricule()
        {
            return matricule;
        }
        public Famille()
        {
            ec = new EnfantController();
            cc = new ConjointController();
            InitializeComponent();
        }

        private void Famille_MouseLeave(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void rdConjoint_Click(object sender, EventArgs e)
        {
            cc.afficherConjoint(dataFamille, matricule);
        }

        private void rdEnfant_Click(object sender, EventArgs e)
        {
            ec.afficheEnfant(dataFamille, matricule);
        }
    }
}
