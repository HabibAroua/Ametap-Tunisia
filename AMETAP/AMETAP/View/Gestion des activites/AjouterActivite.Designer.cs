namespace AMETAP.View.Gestion_des_activites
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
            this.txtNomActivite = new MetroFramework.Controls.MetroTextBox();
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
            this.comboTypeActivite = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.comboOrganisateur = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacite)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom activité";
            // 
            // txtNomActivite
            // 
            // 
            // 
            // 
            this.txtNomActivite.CustomButton.Image = null;
            this.txtNomActivite.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtNomActivite.CustomButton.Name = "";
            this.txtNomActivite.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomActivite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomActivite.CustomButton.TabIndex = 1;
            this.txtNomActivite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomActivite.CustomButton.UseSelectable = true;
            this.txtNomActivite.CustomButton.Visible = false;
            this.txtNomActivite.Lines = new string[0];
            this.txtNomActivite.Location = new System.Drawing.Point(164, 88);
            this.txtNomActivite.MaxLength = 32767;
            this.txtNomActivite.Name = "txtNomActivite";
            this.txtNomActivite.PasswordChar = '\0';
            this.txtNomActivite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomActivite.SelectedText = "";
            this.txtNomActivite.SelectionLength = 0;
            this.txtNomActivite.SelectionStart = 0;
            this.txtNomActivite.ShortcutsEnabled = true;
            this.txtNomActivite.Size = new System.Drawing.Size(215, 23);
            this.txtNomActivite.TabIndex = 1;
            this.txtNomActivite.UseSelectable = true;
            this.txtNomActivite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomActivite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCapacite
            // 
            this.txtCapacite.Location = new System.Drawing.Point(164, 132);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(215, 20);
            this.txtCapacite.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Capactité";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateDebut.Location = new System.Drawing.Point(164, 179);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(215, 20);
            this.txtDateDebut.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(33, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Date début";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Date fin";
            // 
            // txtDatefin
            // 
            this.txtDatefin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDatefin.Location = new System.Drawing.Point(164, 220);
            this.txtDatefin.Name = "txtDatefin";
            this.txtDatefin.Size = new System.Drawing.Size(215, 20);
            this.txtDatefin.TabIndex = 9;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 273);
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
            this.txtPrixUnitaire.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtPrixUnitaire.CustomButton.Name = "";
            this.txtPrixUnitaire.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrixUnitaire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrixUnitaire.CustomButton.TabIndex = 1;
            this.txtPrixUnitaire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrixUnitaire.CustomButton.UseSelectable = true;
            this.txtPrixUnitaire.CustomButton.Visible = false;
            this.txtPrixUnitaire.Lines = new string[0];
            this.txtPrixUnitaire.Location = new System.Drawing.Point(164, 273);
            this.txtPrixUnitaire.MaxLength = 32767;
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.PasswordChar = '\0';
            this.txtPrixUnitaire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrixUnitaire.SelectedText = "";
            this.txtPrixUnitaire.SelectionLength = 0;
            this.txtPrixUnitaire.SelectionStart = 0;
            this.txtPrixUnitaire.ShortcutsEnabled = true;
            this.txtPrixUnitaire.Size = new System.Drawing.Size(215, 23);
            this.txtPrixUnitaire.TabIndex = 14;
            this.txtPrixUnitaire.UseSelectable = true;
            this.txtPrixUnitaire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrixUnitaire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(59, 479);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 15;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseSelectable = true;
            this.btAjouter.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(164, 479);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 16;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 317);
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
            this.txtMontantPrevu.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtMontantPrevu.CustomButton.Name = "";
            this.txtMontantPrevu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontantPrevu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontantPrevu.CustomButton.TabIndex = 1;
            this.txtMontantPrevu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontantPrevu.CustomButton.UseSelectable = true;
            this.txtMontantPrevu.CustomButton.Visible = false;
            this.txtMontantPrevu.Lines = new string[0];
            this.txtMontantPrevu.Location = new System.Drawing.Point(164, 317);
            this.txtMontantPrevu.MaxLength = 32767;
            this.txtMontantPrevu.Name = "txtMontantPrevu";
            this.txtMontantPrevu.PasswordChar = '\0';
            this.txtMontantPrevu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontantPrevu.SelectedText = "";
            this.txtMontantPrevu.SelectionLength = 0;
            this.txtMontantPrevu.SelectionStart = 0;
            this.txtMontantPrevu.ShortcutsEnabled = true;
            this.txtMontantPrevu.Size = new System.Drawing.Size(215, 23);
            this.txtMontantPrevu.TabIndex = 18;
            this.txtMontantPrevu.UseSelectable = true;
            this.txtMontantPrevu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontantPrevu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboTypeActivite
            // 
            this.comboTypeActivite.FormattingEnabled = true;
            this.comboTypeActivite.ItemHeight = 23;
            this.comboTypeActivite.Location = new System.Drawing.Point(164, 368);
            this.comboTypeActivite.Name = "comboTypeActivite";
            this.comboTypeActivite.Size = new System.Drawing.Size(215, 29);
            this.comboTypeActivite.TabIndex = 19;
            this.comboTypeActivite.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(33, 377);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Type Activité";
            // 
            // comboOrganisateur
            // 
            this.comboOrganisateur.FormattingEnabled = true;
            this.comboOrganisateur.ItemHeight = 23;
            this.comboOrganisateur.Location = new System.Drawing.Point(164, 414);
            this.comboOrganisateur.Name = "comboOrganisateur";
            this.comboOrganisateur.Size = new System.Drawing.Size(215, 29);
            this.comboOrganisateur.TabIndex = 21;
            this.comboOrganisateur.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(33, 423);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Organisateur";
            // 
            // AjouterActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 532);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.comboOrganisateur);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.comboTypeActivite);
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
            this.Controls.Add(this.txtNomActivite);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AjouterActivite";
            this.Text = "Ajouter une activité";
            this.Load += new System.EventHandler(this.AjouterActivite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNomActivite;
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
        private MetroFramework.Controls.MetroComboBox comboTypeActivite;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox comboOrganisateur;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}