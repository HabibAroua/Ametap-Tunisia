namespace AMETAP.View.Gestion_des_activites
{
    partial class Modifier_Activite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier_Activite));
            this.dt = new MetroFramework.Controls.MetroLabel();
            this.comboNbr_point = new MetroFramework.Controls.MetroComboBox();
            this.viewMontant = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dateFinInscription = new System.Windows.Forms.DateTimePicker();
            this.rdActiviteLoisir = new MetroFramework.Controls.MetroRadioButton();
            this.rdActiviteCulturel = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtMontantPrevu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btAnnuler = new MetroFramework.Controls.MetroButton();
            this.btModifier = new MetroFramework.Controls.MetroButton();
            this.txtPrixUnitaire = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDatefin = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDateDebut = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCapacite = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNomActivite = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacite)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Location = new System.Drawing.Point(345, 128);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(24, 19);
            this.dt.TabIndex = 60;
            this.dt.Text = "DT";
            // 
            // comboNbr_point
            // 
            this.comboNbr_point.FormattingEnabled = true;
            this.comboNbr_point.ItemHeight = 23;
            this.comboNbr_point.Location = new System.Drawing.Point(207, 490);
            this.comboNbr_point.Name = "comboNbr_point";
            this.comboNbr_point.Size = new System.Drawing.Size(264, 29);
            this.comboNbr_point.TabIndex = 58;
            this.comboNbr_point.UseSelectable = true;
            // 
            // viewMontant
            // 
            this.viewMontant.AutoSize = true;
            this.viewMontant.Location = new System.Drawing.Point(280, 129);
            this.viewMontant.Name = "viewMontant";
            this.viewMontant.Size = new System.Drawing.Size(0, 0);
            this.viewMontant.TabIndex = 57;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(19, 129);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(113, 19);
            this.metroLabel11.TabIndex = 56;
            this.metroLabel11.Text = "Budget Catégorie";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(19, 256);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(128, 19);
            this.metroLabel9.TabIndex = 55;
            this.metroLabel9.Text = "Date fin d\'inscription";
            // 
            // dateFinInscription
            // 
            this.dateFinInscription.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinInscription.Location = new System.Drawing.Point(207, 256);
            this.dateFinInscription.Name = "dateFinInscription";
            this.dateFinInscription.Size = new System.Drawing.Size(264, 20);
            this.dateFinInscription.TabIndex = 54;
            // 
            // rdActiviteLoisir
            // 
            this.rdActiviteLoisir.AutoSize = true;
            this.rdActiviteLoisir.Location = new System.Drawing.Point(151, 15);
            this.rdActiviteLoisir.Name = "rdActiviteLoisir";
            this.rdActiviteLoisir.Size = new System.Drawing.Size(107, 15);
            this.rdActiviteLoisir.TabIndex = 1;
            this.rdActiviteLoisir.Text = "Activité de loisir";
            this.rdActiviteLoisir.UseSelectable = true;
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
            this.rdActiviteCulturel.Click += new System.EventHandler(this.rdActiviteCulturel_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(15, 490);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(112, 19);
            this.metroLabel12.TabIndex = 59;
            this.metroLabel12.Text = "Nombre de point";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdActiviteLoisir);
            this.groupBox1.Controls.Add(this.rdActiviteCulturel);
            this.groupBox1.Location = new System.Drawing.Point(207, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 40);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(26, 96);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 47;
            this.metroLabel6.Text = "Catégorie";
            // 
            // txtMontantPrevu
            // 
            // 
            // 
            // 
            this.txtMontantPrevu.CustomButton.Image = null;
            this.txtMontantPrevu.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtMontantPrevu.CustomButton.Name = "";
            this.txtMontantPrevu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontantPrevu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontantPrevu.CustomButton.TabIndex = 1;
            this.txtMontantPrevu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontantPrevu.CustomButton.UseSelectable = true;
            this.txtMontantPrevu.CustomButton.Visible = false;
            this.txtMontantPrevu.Enabled = false;
            this.txtMontantPrevu.Lines = new string[0];
            this.txtMontantPrevu.Location = new System.Drawing.Point(207, 426);
            this.txtMontantPrevu.MaxLength = 32767;
            this.txtMontantPrevu.Name = "txtMontantPrevu";
            this.txtMontantPrevu.PasswordChar = '\0';
            this.txtMontantPrevu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontantPrevu.SelectedText = "";
            this.txtMontantPrevu.SelectionLength = 0;
            this.txtMontantPrevu.SelectionStart = 0;
            this.txtMontantPrevu.ShortcutsEnabled = true;
            this.txtMontantPrevu.Size = new System.Drawing.Size(264, 23);
            this.txtMontantPrevu.TabIndex = 46;
            this.txtMontantPrevu.UseSelectable = true;
            this.txtMontantPrevu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontantPrevu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 430);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "Montant prévu";
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(162, 550);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 44;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseSelectable = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click_1);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(52, 550);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 23);
            this.btModifier.TabIndex = 43;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseSelectable = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click_1);
            // 
            // txtPrixUnitaire
            // 
            // 
            // 
            // 
            this.txtPrixUnitaire.CustomButton.Image = null;
            this.txtPrixUnitaire.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtPrixUnitaire.CustomButton.Name = "";
            this.txtPrixUnitaire.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrixUnitaire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrixUnitaire.CustomButton.TabIndex = 1;
            this.txtPrixUnitaire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrixUnitaire.CustomButton.UseSelectable = true;
            this.txtPrixUnitaire.CustomButton.Visible = false;
            this.txtPrixUnitaire.Lines = new string[0];
            this.txtPrixUnitaire.Location = new System.Drawing.Point(207, 378);
            this.txtPrixUnitaire.MaxLength = 32767;
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.PasswordChar = '\0';
            this.txtPrixUnitaire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrixUnitaire.SelectedText = "";
            this.txtPrixUnitaire.SelectionLength = 0;
            this.txtPrixUnitaire.SelectionStart = 0;
            this.txtPrixUnitaire.ShortcutsEnabled = true;
            this.txtPrixUnitaire.Size = new System.Drawing.Size(264, 23);
            this.txtPrixUnitaire.TabIndex = 42;
            this.txtPrixUnitaire.UseSelectable = true;
            this.txtPrixUnitaire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrixUnitaire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrixUnitaire.TextChanged += new System.EventHandler(this.txtPrixUnitaire_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 382);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 19);
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Prix unitaire";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 337);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 40;
            this.metroLabel5.Text = "Date fin";
            // 
            // txtDatefin
            // 
            this.txtDatefin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDatefin.Location = new System.Drawing.Point(207, 337);
            this.txtDatefin.Name = "txtDatefin";
            this.txtDatefin.Size = new System.Drawing.Size(264, 20);
            this.txtDatefin.TabIndex = 39;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 298);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Date début";
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateDebut.Location = new System.Drawing.Point(207, 298);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(264, 20);
            this.txtDateDebut.TabIndex = 37;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 210);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "Capacité";
            // 
            // txtCapacite
            // 
            this.txtCapacite.Location = new System.Drawing.Point(207, 209);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(264, 20);
            this.txtCapacite.TabIndex = 35;
            this.txtCapacite.ValueChanged += new System.EventHandler(this.txtCapacite_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 169);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Nom activité";
            // 
            // txtNomActivite
            // 
            // 
            // 
            // 
            this.txtNomActivite.CustomButton.Image = null;
            this.txtNomActivite.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtNomActivite.CustomButton.Name = "";
            this.txtNomActivite.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomActivite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomActivite.CustomButton.TabIndex = 1;
            this.txtNomActivite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomActivite.CustomButton.UseSelectable = true;
            this.txtNomActivite.CustomButton.Visible = false;
            this.txtNomActivite.Lines = new string[0];
            this.txtNomActivite.Location = new System.Drawing.Point(207, 165);
            this.txtNomActivite.MaxLength = 32767;
            this.txtNomActivite.Name = "txtNomActivite";
            this.txtNomActivite.PasswordChar = '\0';
            this.txtNomActivite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomActivite.SelectedText = "";
            this.txtNomActivite.SelectionLength = 0;
            this.txtNomActivite.SelectionStart = 0;
            this.txtNomActivite.ShortcutsEnabled = true;
            this.txtNomActivite.Size = new System.Drawing.Size(264, 23);
            this.txtNomActivite.TabIndex = 61;
            this.txtNomActivite.UseSelectable = true;
            this.txtNomActivite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomActivite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Modifier_Activite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 582);
            this.Controls.Add(this.txtNomActivite);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.comboNbr_point);
            this.Controls.Add(this.viewMontant);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dateFinInscription);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtMontantPrevu);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.txtPrixUnitaire);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtDatefin);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modifier_Activite";
            this.Text = "Modifier Activité";
            this.Load += new System.EventHandler(this.Modifier_Activite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel dt;
        private MetroFramework.Controls.MetroLabel viewMontant;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroRadioButton rdActiviteLoisir;
        private MetroFramework.Controls.MetroRadioButton rdActiviteCulturel;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btAnnuler;
        private MetroFramework.Controls.MetroButton btModifier;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.NumericUpDown txtCapacite;
        public MetroFramework.Controls.MetroTextBox txtNomActivite;
        public System.Windows.Forms.DateTimePicker dateFinInscription;
        public System.Windows.Forms.DateTimePicker txtDatefin;
        public System.Windows.Forms.DateTimePicker txtDateDebut;
        public MetroFramework.Controls.MetroComboBox comboNbr_point;
        public MetroFramework.Controls.MetroTextBox txtMontantPrevu;
        public MetroFramework.Controls.MetroTextBox txtPrixUnitaire;
    }
}