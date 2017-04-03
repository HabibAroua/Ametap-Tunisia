namespace AMETAP.View.Gestion_Budget
{
    partial class Fixer_Budget
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
            this.comboAnnee = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMontantFinal = new MetroFramework.Controls.MetroTextBox();
            this.btFixer = new MetroFramework.Controls.MetroButton();
            this.btAnnuler = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMontantProvisoire = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Annee";
            // 
            // comboAnnee
            // 
            this.comboAnnee.FormattingEnabled = true;
            this.comboAnnee.ItemHeight = 23;
            this.comboAnnee.Location = new System.Drawing.Point(168, 79);
            this.comboAnnee.Name = "comboAnnee";
            this.comboAnnee.Size = new System.Drawing.Size(227, 29);
            this.comboAnnee.TabIndex = 2;
            this.comboAnnee.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Montant final";
            // 
            // txtMontantFinal
            // 
            // 
            // 
            // 
            this.txtMontantFinal.CustomButton.Image = null;
            this.txtMontantFinal.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtMontantFinal.CustomButton.Name = "";
            this.txtMontantFinal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontantFinal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontantFinal.CustomButton.TabIndex = 1;
            this.txtMontantFinal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontantFinal.CustomButton.UseSelectable = true;
            this.txtMontantFinal.CustomButton.Visible = false;
            this.txtMontantFinal.Lines = new string[0];
            this.txtMontantFinal.Location = new System.Drawing.Point(168, 140);
            this.txtMontantFinal.MaxLength = 32767;
            this.txtMontantFinal.Name = "txtMontantFinal";
            this.txtMontantFinal.PasswordChar = '\0';
            this.txtMontantFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontantFinal.SelectedText = "";
            this.txtMontantFinal.SelectionLength = 0;
            this.txtMontantFinal.SelectionStart = 0;
            this.txtMontantFinal.ShortcutsEnabled = true;
            this.txtMontantFinal.Size = new System.Drawing.Size(227, 23);
            this.txtMontantFinal.TabIndex = 4;
            this.txtMontantFinal.UseSelectable = true;
            this.txtMontantFinal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontantFinal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontantFinal.TextChanged += new System.EventHandler(this.txtMontantFinal_TextChanged);
            // 
            // btFixer
            // 
            this.btFixer.Location = new System.Drawing.Point(55, 254);
            this.btFixer.Name = "btFixer";
            this.btFixer.Size = new System.Drawing.Size(75, 23);
            this.btFixer.TabIndex = 5;
            this.btFixer.Text = "Fixer";
            this.btFixer.UseSelectable = true;
            this.btFixer.Click += new System.EventHandler(this.btFixer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(155, 254);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 6;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Montant provisoire";
            // 
            // txtMontantProvisoire
            // 
            // 
            // 
            // 
            this.txtMontantProvisoire.CustomButton.Image = null;
            this.txtMontantProvisoire.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtMontantProvisoire.CustomButton.Name = "";
            this.txtMontantProvisoire.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontantProvisoire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontantProvisoire.CustomButton.TabIndex = 1;
            this.txtMontantProvisoire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontantProvisoire.CustomButton.UseSelectable = true;
            this.txtMontantProvisoire.CustomButton.Visible = false;
            this.txtMontantProvisoire.Lines = new string[0];
            this.txtMontantProvisoire.Location = new System.Drawing.Point(168, 199);
            this.txtMontantProvisoire.MaxLength = 32767;
            this.txtMontantProvisoire.Name = "txtMontantProvisoire";
            this.txtMontantProvisoire.PasswordChar = '\0';
            this.txtMontantProvisoire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontantProvisoire.SelectedText = "";
            this.txtMontantProvisoire.SelectionLength = 0;
            this.txtMontantProvisoire.SelectionStart = 0;
            this.txtMontantProvisoire.ShortcutsEnabled = true;
            this.txtMontantProvisoire.Size = new System.Drawing.Size(227, 23);
            this.txtMontantProvisoire.TabIndex = 8;
            this.txtMontantProvisoire.UseSelectable = true;
            this.txtMontantProvisoire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontantProvisoire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Fixer_Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 327);
            this.Controls.Add(this.txtMontantProvisoire);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btFixer);
            this.Controls.Add(this.txtMontantFinal);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.comboAnnee);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Fixer_Budget";
            this.Text = "Fixer Budget";
            this.Load += new System.EventHandler(this.Fixer_Budget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboAnnee;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMontantFinal;
        private MetroFramework.Controls.MetroButton btFixer;
        private MetroFramework.Controls.MetroButton btAnnuler;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMontantProvisoire;
    }
}