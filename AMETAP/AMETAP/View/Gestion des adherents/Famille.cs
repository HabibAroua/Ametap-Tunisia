﻿using System;
using MetroFramework.Forms;
using AMETAP.Controller;

namespace AMETAP.View.Gestion_des_adherents
{
    public partial class Famille : MetroForm
    {
        public String matricule;
        EnfantController ec;
        ConjointController cc;
        ParticipantController pC;

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
            pC = new ParticipantController();
            InitializeComponent();
        }

        private void rdConjoint_Click(object sender, EventArgs e)
        {
            cc.afficherConjoint(dataFamille, matricule);
        }

        private void rdEnfant_Click(object sender, EventArgs e)
        {
            ec.afficheEnfant(dataFamille, matricule);
        }

        private void rdTous_Click(object sender, EventArgs e)
        {
            pC.getAllMembreFamilleByMatricule(dataFamille, int.Parse(matricule));
        }
    }
}
