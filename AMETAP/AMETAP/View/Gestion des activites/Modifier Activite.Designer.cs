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
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.comboOrganisateur = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.comboTypeActivite = new MetroFramework.Controls.MetroComboBox();
            this.btAnnuler = new MetroFramework.Controls.MetroButton();
            this.btModifier = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCapacite = new System.Windows.Forms.NumericUpDown();
            this.txtNomActivite = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacite)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(56, 227);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 19);
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "Organisateur";
            // 
            // comboOrganisateur
            // 
            this.comboOrganisateur.FormattingEnabled = true;
            this.comboOrganisateur.ItemHeight = 23;
            this.comboOrganisateur.Location = new System.Drawing.Point(186, 217);
            this.comboOrganisateur.Name = "comboOrganisateur";
            this.comboOrganisateur.Size = new System.Drawing.Size(215, 29);
            this.comboOrganisateur.TabIndex = 39;
            this.comboOrganisateur.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(56, 181);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 19);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "Type Activité";
            // 
            // comboTypeActivite
            // 
            this.comboTypeActivite.FormattingEnabled = true;
            this.comboTypeActivite.ItemHeight = 23;
            this.comboTypeActivite.Location = new System.Drawing.Point(186, 171);
            this.comboTypeActivite.Name = "comboTypeActivite";
            this.comboTypeActivite.Size = new System.Drawing.Size(215, 29);
            this.comboTypeActivite.TabIndex = 37;
            this.comboTypeActivite.UseSelectable = true;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(186, 293);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 34;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseSelectable = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(79, 293);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 23);
            this.btModifier.TabIndex = 33;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseSelectable = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Capactité";
            // 
            // txtCapacite
            // 
            this.txtCapacite.Location = new System.Drawing.Point(186, 122);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(215, 20);
            this.txtCapacite.TabIndex = 25;
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
            this.txtNomActivite.Location = new System.Drawing.Point(186, 78);
            this.txtNomActivite.MaxLength = 32767;
            this.txtNomActivite.Name = "txtNomActivite";
            this.txtNomActivite.PasswordChar = '\0';
            this.txtNomActivite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomActivite.SelectedText = "";
            this.txtNomActivite.SelectionLength = 0;
            this.txtNomActivite.SelectionStart = 0;
            this.txtNomActivite.ShortcutsEnabled = true;
            this.txtNomActivite.Size = new System.Drawing.Size(215, 23);
            this.txtNomActivite.TabIndex = 24;
            this.txtNomActivite.UseSelectable = true;
            this.txtNomActivite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomActivite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Nom activité";
            // 
            // Modifier_Activite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 369);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.comboOrganisateur);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.comboTypeActivite);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.txtNomActivite);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Modifier_Activite";
            this.Text = "Modifier Activité";
            this.Load += new System.EventHandler(this.Modifier_Activite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox comboOrganisateur;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox comboTypeActivite;
        private MetroFramework.Controls.MetroButton btAnnuler;
        private MetroFramework.Controls.MetroButton btModifier;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.NumericUpDown txtCapacite;
        public MetroFramework.Controls.MetroTextBox txtNomActivite;
    }
}