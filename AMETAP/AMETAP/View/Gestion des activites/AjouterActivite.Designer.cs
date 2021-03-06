﻿namespace AMETAP.View.Gestion_des_activites
{
    partial class AjouterActivite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCapacite = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDateDebut = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDatefin = new System.Windows.Forms.DateTimePicker();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtPrixUnitaire = new MetroFramework.Controls.MetroTextBox();
            this.btAjouter = new MetroFramework.Controls.MetroButton();
            this.btAnnuler = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMontantPrevu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.comboOrganisateur = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdActiviteLoisir = new MetroFramework.Controls.MetroRadioButton();
            this.rdActiviteCulturel = new MetroFramework.Controls.MetroRadioButton();
            this.comboNomActivite = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dateFinInscription = new System.Windows.Forms.DateTimePicker();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtDateDebutInscription = new System.Windows.Forms.DateTimePicker();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.viewMontant = new MetroFramework.Controls.MetroLabel();
            this.comboNbr_point = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.dt = new MetroFramework.Controls.MetroLabel();
            this.txtNomActivite = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdList = new MetroFramework.Controls.MetroRadioButton();
            this.rdManuel = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 151);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom activité";
            // 
            // txtCapacite
            // 
            this.txtCapacite.Location = new System.Drawing.Point(233, 219);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(288, 20);
            this.txtCapacite.TabIndex = 2;
            this.txtCapacite.ValueChanged += new System.EventHandler(this.txtCapacite_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 220);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Capacité";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateDebut.Location = new System.Drawing.Point(233, 343);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(288, 20);
            this.txtDateDebut.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 343);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Date début";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(8, 387);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Date fin";
            // 
            // txtDatefin
            // 
            this.txtDatefin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDatefin.Location = new System.Drawing.Point(233, 386);
            this.txtDatefin.Name = "txtDatefin";
            this.txtDatefin.Size = new System.Drawing.Size(288, 20);
            this.txtDatefin.TabIndex = 9;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(4, 436);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Prix unitaire";
            // 
            // txtPrixUnitaire
            // 
            // 
            // 
            // 
            this.txtPrixUnitaire.CustomButton.Image = null;
            this.txtPrixUnitaire.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.txtPrixUnitaire.CustomButton.Name = "";
            this.txtPrixUnitaire.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrixUnitaire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrixUnitaire.CustomButton.TabIndex = 1;
            this.txtPrixUnitaire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrixUnitaire.CustomButton.UseSelectable = true;
            this.txtPrixUnitaire.CustomButton.Visible = false;
            this.txtPrixUnitaire.Lines = new string[0];
            this.txtPrixUnitaire.Location = new System.Drawing.Point(233, 432);
            this.txtPrixUnitaire.MaxLength = 32767;
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.PasswordChar = '\0';
            this.txtPrixUnitaire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrixUnitaire.SelectedText = "";
            this.txtPrixUnitaire.SelectionLength = 0;
            this.txtPrixUnitaire.SelectionStart = 0;
            this.txtPrixUnitaire.ShortcutsEnabled = true;
            this.txtPrixUnitaire.Size = new System.Drawing.Size(288, 23);
            this.txtPrixUnitaire.TabIndex = 14;
            this.txtPrixUnitaire.UseSelectable = true;
            this.txtPrixUnitaire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrixUnitaire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrixUnitaire.TextChanged += new System.EventHandler(this.txtPrixUnitaire_TextChanged);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(46, 612);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 15;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseSelectable = true;
            this.btAjouter.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(150, 612);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 16;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseSelectable = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 479);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Montant prévu";
            // 
            // txtMontantPrevu
            // 
            // 
            // 
            // 
            this.txtMontantPrevu.CustomButton.Image = null;
            this.txtMontantPrevu.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.txtMontantPrevu.CustomButton.Name = "";
            this.txtMontantPrevu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontantPrevu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontantPrevu.CustomButton.TabIndex = 1;
            this.txtMontantPrevu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontantPrevu.CustomButton.UseSelectable = true;
            this.txtMontantPrevu.CustomButton.Visible = false;
            this.txtMontantPrevu.Lines = new string[0];
            this.txtMontantPrevu.Location = new System.Drawing.Point(233, 475);
            this.txtMontantPrevu.MaxLength = 32767;
            this.txtMontantPrevu.Name = "txtMontantPrevu";
            this.txtMontantPrevu.PasswordChar = '\0';
            this.txtMontantPrevu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontantPrevu.SelectedText = "";
            this.txtMontantPrevu.SelectionLength = 0;
            this.txtMontantPrevu.SelectionStart = 0;
            this.txtMontantPrevu.ShortcutsEnabled = true;
            this.txtMontantPrevu.Size = new System.Drawing.Size(288, 23);
            this.txtMontantPrevu.TabIndex = 18;
            this.txtMontantPrevu.UseSelectable = true;
            this.txtMontantPrevu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontantPrevu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 78);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Catégorie";
            // 
            // comboOrganisateur
            // 
            this.comboOrganisateur.FormattingEnabled = true;
            this.comboOrganisateur.ItemHeight = 23;
            this.comboOrganisateur.Location = new System.Drawing.Point(233, 522);
            this.comboOrganisateur.Name = "comboOrganisateur";
            this.comboOrganisateur.Size = new System.Drawing.Size(288, 29);
            this.comboOrganisateur.TabIndex = 21;
            this.comboOrganisateur.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 532);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Organisateur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdActiviteLoisir);
            this.groupBox1.Controls.Add(this.rdActiviteCulturel);
            this.groupBox1.Location = new System.Drawing.Point(233, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 40);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // rdActiviteLoisir
            // 
            this.rdActiviteLoisir.AutoSize = true;
            this.rdActiviteLoisir.Location = new System.Drawing.Point(138, 15);
            this.rdActiviteLoisir.Name = "rdActiviteLoisir";
            this.rdActiviteLoisir.Size = new System.Drawing.Size(107, 15);
            this.rdActiviteLoisir.TabIndex = 1;
            this.rdActiviteLoisir.Text = "Activité de loisir";
            this.rdActiviteLoisir.UseSelectable = true;
            this.rdActiviteLoisir.CheckedChanged += new System.EventHandler(this.rdActiviteLoisir_CheckedChanged);
            this.rdActiviteLoisir.Click += new System.EventHandler(this.rdActiviteLoisir_Click);
            // 
            // rdActiviteCulturel
            // 
            this.rdActiviteCulturel.AutoSize = true;
            this.rdActiviteCulturel.Location = new System.Drawing.Point(6, 15);
            this.rdActiviteCulturel.Name = "rdActiviteCulturel";
            this.rdActiviteCulturel.Size = new System.Drawing.Size(115, 15);
            this.rdActiviteCulturel.TabIndex = 0;
            this.rdActiviteCulturel.Text = "Activité culturelle";
            this.rdActiviteCulturel.UseSelectable = true;
            this.rdActiviteCulturel.CheckedChanged += new System.EventHandler(this.rdActiviteCulturel_CheckedChanged);
            this.rdActiviteCulturel.Click += new System.EventHandler(this.rdActiviteCulturel_Click);
            // 
            // comboNomActivite
            // 
            this.comboNomActivite.FormattingEnabled = true;
            this.comboNomActivite.ItemHeight = 23;
            this.comboNomActivite.Location = new System.Drawing.Point(384, 176);
            this.comboNomActivite.Name = "comboNomActivite";
            this.comboNomActivite.Size = new System.Drawing.Size(137, 29);
            this.comboNomActivite.TabIndex = 24;
            this.comboNomActivite.UseSelectable = true;
            this.comboNomActivite.Click += new System.EventHandler(this.comboNomActivite_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(8, 302);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(128, 19);
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Date fin d\'inscription";
            // 
            // dateFinInscription
            // 
            this.dateFinInscription.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinInscription.Location = new System.Drawing.Point(233, 302);
            this.dateFinInscription.Name = "dateFinInscription";
            this.dateFinInscription.Size = new System.Drawing.Size(288, 20);
            this.dateFinInscription.TabIndex = 27;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(7, 260);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(148, 19);
            this.metroLabel10.TabIndex = 26;
            this.metroLabel10.Text = "Date début d\'inscription";
            // 
            // txtDateDebutInscription
            // 
            this.txtDateDebutInscription.Enabled = false;
            this.txtDateDebutInscription.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateDebutInscription.Location = new System.Drawing.Point(233, 259);
            this.txtDateDebutInscription.Name = "txtDateDebutInscription";
            this.txtDateDebutInscription.Size = new System.Drawing.Size(288, 20);
            this.txtDateDebutInscription.TabIndex = 25;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(7, 111);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(113, 19);
            this.metroLabel11.TabIndex = 29;
            this.metroLabel11.Text = "Budget Catégorie";
            // 
            // viewMontant
            // 
            this.viewMontant.AutoSize = true;
            this.viewMontant.Location = new System.Drawing.Point(294, 111);
            this.viewMontant.Name = "viewMontant";
            this.viewMontant.Size = new System.Drawing.Size(0, 0);
            this.viewMontant.TabIndex = 30;
            // 
            // comboNbr_point
            // 
            this.comboNbr_point.FormattingEnabled = true;
            this.comboNbr_point.ItemHeight = 23;
            this.comboNbr_point.Location = new System.Drawing.Point(233, 580);
            this.comboNbr_point.Name = "comboNbr_point";
            this.comboNbr_point.Size = new System.Drawing.Size(288, 29);
            this.comboNbr_point.TabIndex = 31;
            this.comboNbr_point.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(15, 580);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(112, 19);
            this.metroLabel12.TabIndex = 32;
            this.metroLabel12.Text = "Nombre de point";
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Location = new System.Drawing.Point(344, 111);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(24, 19);
            this.dt.TabIndex = 33;
            this.dt.Text = "DT";
            // 
            // txtNomActivite
            // 
            // 
            // 
            // 
            this.txtNomActivite.CustomButton.Image = null;
            this.txtNomActivite.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtNomActivite.CustomButton.Name = "";
            this.txtNomActivite.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomActivite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomActivite.CustomButton.TabIndex = 1;
            this.txtNomActivite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomActivite.CustomButton.UseSelectable = true;
            this.txtNomActivite.CustomButton.Visible = false;
            this.txtNomActivite.Lines = new string[0];
            this.txtNomActivite.Location = new System.Drawing.Point(233, 182);
            this.txtNomActivite.MaxLength = 32767;
            this.txtNomActivite.Name = "txtNomActivite";
            this.txtNomActivite.PasswordChar = '\0';
            this.txtNomActivite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomActivite.SelectedText = "";
            this.txtNomActivite.SelectionLength = 0;
            this.txtNomActivite.SelectionStart = 0;
            this.txtNomActivite.ShortcutsEnabled = true;
            this.txtNomActivite.Size = new System.Drawing.Size(117, 23);
            this.txtNomActivite.TabIndex = 34;
            this.txtNomActivite.UseSelectable = true;
            this.txtNomActivite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomActivite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdList);
            this.groupBox2.Controls.Add(this.rdManuel);
            this.groupBox2.Location = new System.Drawing.Point(233, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 37);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // rdList
            // 
            this.rdList.AutoSize = true;
            this.rdList.Location = new System.Drawing.Point(125, 14);
            this.rdList.Name = "rdList";
            this.rdList.Size = new System.Drawing.Size(41, 15);
            this.rdList.TabIndex = 1;
            this.rdList.Text = "List";
            this.rdList.UseSelectable = true;
            this.rdList.Click += new System.EventHandler(this.rdList_Click);
            // 
            // rdManuel
            // 
            this.rdManuel.AutoSize = true;
            this.rdManuel.Location = new System.Drawing.Point(6, 14);
            this.rdManuel.Name = "rdManuel";
            this.rdManuel.Size = new System.Drawing.Size(63, 15);
            this.rdManuel.TabIndex = 0;
            this.rdManuel.Text = "Manuel";
            this.rdManuel.UseSelectable = true;
            this.rdManuel.Click += new System.EventHandler(this.rdManuel_Click);
            // 
            // AjouterActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNomActivite);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.comboNbr_point);
            this.Controls.Add(this.viewMontant);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dateFinInscription);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtDateDebutInscription);
            this.Controls.Add(this.comboNomActivite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.comboOrganisateur);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtMontantPrevu);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.txtPrixUnitaire);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtDatefin);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjouterActivite";
            this.Text = "Ajouter une activité";
            this.Load += new System.EventHandler(this.AjouterActivite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NumericUpDown txtCapacite;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker txtDateDebut;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DateTimePicker txtDatefin;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtPrixUnitaire;
        private MetroFramework.Controls.MetroButton btAjouter;
        private MetroFramework.Controls.MetroButton btAnnuler;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMontantPrevu;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox comboOrganisateur;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdActiviteLoisir;
        private MetroFramework.Controls.MetroRadioButton rdActiviteCulturel;
        private MetroFramework.Controls.MetroComboBox comboNomActivite;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DateTimePicker dateFinInscription;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.DateTimePicker txtDateDebutInscription;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel viewMontant;
        private MetroFramework.Controls.MetroComboBox comboNbr_point;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel dt;
        private MetroFramework.Controls.MetroTextBox txtNomActivite;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroRadioButton rdList;
        private MetroFramework.Controls.MetroRadioButton rdManuel;
    }
}