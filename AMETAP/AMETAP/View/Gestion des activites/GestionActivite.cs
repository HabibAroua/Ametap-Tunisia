﻿using System;
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
namespace AMETAP.View.Gestion_des_activites
{
    public partial class GestionActivite : MetroForm
    {
        ActiviteController ac;
        public GestionActivite()
        {
            InitializeComponent();
            ac = new ActiviteController();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            AjouterActivite a = new AjouterActivite();
            a.Show();
        }

        private void GestionActivite_Load(object sender, EventArgs e)
        {
            for (int i = 2006; i < 2050; i++)
            {
                comboAnnee.Items.Add(i.ToString());
            }
        }

        private void comboAnnee_TextChanged(object sender, EventArgs e)
        {
            ac.findActivityByYear(dataActivite, comboAnnee.SelectedItem.ToString());
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                ac.SupprimerActivite(int.Parse(dataActivite.CurrentRow.Cells[0].Value.ToString()), double.Parse(dataActivite.CurrentRow.Cells[2].Value.ToString()));
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Il faut séléctionner une activité", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
