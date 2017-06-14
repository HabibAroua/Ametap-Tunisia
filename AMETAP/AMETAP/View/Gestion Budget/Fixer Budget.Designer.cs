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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fixer_Budget));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboAnnee = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMontantFinal = new MetroFramework.Controls.MetroTextBox();
            this.btFixer = new MetroFramework.Controls.MetroButton();
            this.btAnnuler = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMontantProvisoire = new MetroFramework.Controls.MetroTextBox();
            this.txtBudgetCulturel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtBudgetLoisir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.viewResteBudget = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(84, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Annee";
            // 
            // comboAnnee
            // 
            this.comboAnnee.FormattingEnabled = true;
            this.comboAnnee.ItemHeight = 23;
            this.comboAnnee.Location = new System.Drawing.Point(372, 63);
            this.comboAnnee.Name = "comboAnnee";
            this.comboAnnee.Size = new System.Drawing.Size(227, 29);
            this.comboAnnee.TabIndex = 2;
            this.comboAnnee.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(84, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Budget accordé";
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
            this.txtMontantFinal.Location = new System.Drawing.Point(372, 143);
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
            this.btFixer.Location = new System.Drawing.Point(84, 350);
            this.btFixer.Name = "btFixer";
            this.btFixer.Size = new System.Drawing.Size(75, 23);
            this.btFixer.TabIndex = 5;
            this.btFixer.Text = "Fixer";
            this.btFixer.UseSelectable = true;
            this.btFixer.Click += new System.EventHandler(this.btFixer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(183, 350);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 6;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseSelectable = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(84, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Budget actuel";
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
            this.txtMontantProvisoire.Location = new System.Drawing.Point(372, 192);
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
            // txtBudgetCulturel
            // 
            // 
            // 
            // 
            this.txtBudgetCulturel.CustomButton.Image = null;
            this.txtBudgetCulturel.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtBudgetCulturel.CustomButton.Name = "";
            this.txtBudgetCulturel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBudgetCulturel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBudgetCulturel.CustomButton.TabIndex = 1;
            this.txtBudgetCulturel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBudgetCulturel.CustomButton.UseSelectable = true;
            this.txtBudgetCulturel.CustomButton.Visible = false;
            this.txtBudgetCulturel.Lines = new string[0];
            this.txtBudgetCulturel.Location = new System.Drawing.Point(372, 246);
            this.txtBudgetCulturel.MaxLength = 32767;
            this.txtBudgetCulturel.Name = "txtBudgetCulturel";
            this.txtBudgetCulturel.PasswordChar = '\0';
            this.txtBudgetCulturel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBudgetCulturel.SelectedText = "";
            this.txtBudgetCulturel.SelectionLength = 0;
            this.txtBudgetCulturel.SelectionStart = 0;
            this.txtBudgetCulturel.ShortcutsEnabled = true;
            this.txtBudgetCulturel.Size = new System.Drawing.Size(227, 23);
            this.txtBudgetCulturel.TabIndex = 11;
            this.txtBudgetCulturel.UseSelectable = true;
            this.txtBudgetCulturel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBudgetCulturel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBudgetCulturel.TextChanged += new System.EventHandler(this.txtBudgetCulturel_TextChanged);
            this.txtBudgetCulturel.Click += new System.EventHandler(this.txtBudgetCulturel_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(71, 250);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(201, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Budget Pour les activités culturels";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(71, 296);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(200, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Budget Pour les activités de loisir";
            // 
            // txtBudgetLoisir
            // 
            // 
            // 
            // 
            this.txtBudgetLoisir.CustomButton.Image = null;
            this.txtBudgetLoisir.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtBudgetLoisir.CustomButton.Name = "";
            this.txtBudgetLoisir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBudgetLoisir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBudgetLoisir.CustomButton.TabIndex = 1;
            this.txtBudgetLoisir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBudgetLoisir.CustomButton.UseSelectable = true;
            this.txtBudgetLoisir.CustomButton.Visible = false;
            this.txtBudgetLoisir.Lines = new string[0];
            this.txtBudgetLoisir.Location = new System.Drawing.Point(372, 292);
            this.txtBudgetLoisir.MaxLength = 32767;
            this.txtBudgetLoisir.Name = "txtBudgetLoisir";
            this.txtBudgetLoisir.PasswordChar = '\0';
            this.txtBudgetLoisir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBudgetLoisir.SelectedText = "";
            this.txtBudgetLoisir.SelectionLength = 0;
            this.txtBudgetLoisir.SelectionStart = 0;
            this.txtBudgetLoisir.ShortcutsEnabled = true;
            this.txtBudgetLoisir.Size = new System.Drawing.Size(227, 23);
            this.txtBudgetLoisir.TabIndex = 13;
            this.txtBudgetLoisir.UseSelectable = true;
            this.txtBudgetLoisir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBudgetLoisir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBudgetLoisir.TextChanged += new System.EventHandler(this.txtBudgetLoisir_TextChanged);
            this.txtBudgetLoisir.Click += new System.EventHandler(this.txtBudgetLoisir_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(84, 111);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(253, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Le reste du budget de l\'anneé précédente";
            // 
            // viewResteBudget
            // 
            this.viewResteBudget.AutoSize = true;
            this.viewResteBudget.Location = new System.Drawing.Point(372, 111);
            this.viewResteBudget.Name = "viewResteBudget";
            this.viewResteBudget.Size = new System.Drawing.Size(83, 19);
            this.viewResteBudget.TabIndex = 16;
            this.viewResteBudget.Text = "metroLabel7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "DT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(713, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Fixer_Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewResteBudget);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtBudgetLoisir);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtBudgetCulturel);
            this.Controls.Add(this.txtMontantProvisoire);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btFixer);
            this.Controls.Add(this.txtMontantFinal);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.comboAnnee);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fixer_Budget";
            this.Text = "Fixer Budget";
            this.Load += new System.EventHandler(this.Fixer_Budget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox txtBudgetCulturel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtBudgetLoisir;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel viewResteBudget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}