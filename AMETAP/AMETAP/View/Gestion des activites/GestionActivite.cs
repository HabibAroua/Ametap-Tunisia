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

namespace AMETAP.View.Gestion_des_activites
{
    public partial class GestionActivite : MetroForm
    {
        public GestionActivite()
        {
            InitializeComponent();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            AjouterActivite a = new AjouterActivite();
            a.Show();
        }
    }
}
