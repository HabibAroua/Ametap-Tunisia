namespace AMETAP.View.Gestion_des_utilisateurs
{
    partial class Gestion_des_utilisateurs
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
            this.dataUtilisateur = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRecherhce = new MetroFramework.Controls.MetroTextBox();
            this.btSupprimer = new MetroFramework.Controls.MetroTile();
            this.btRefresh = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUtilisateur
            // 
            this.dataUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUtilisateur.Location = new System.Drawing.Point(14, 166);
            this.dataUtilisateur.Name = "dataUtilisateur";
            this.dataUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUtilisateur.Size = new System.Drawing.Size(441, 217);
            this.dataUtilisateur.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Recherche";
            // 
            // txtRecherhce
            // 
            // 
            // 
            // 
            this.txtRecherhce.CustomButton.Image = null;
            this.txtRecherhce.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtRecherhce.CustomButton.Name = "";
            this.txtRecherhce.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRecherhce.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRecherhce.CustomButton.TabIndex = 1;
            this.txtRecherhce.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecherhce.CustomButton.UseSelectable = true;
            this.txtRecherhce.CustomButton.Visible = false;
            this.txtRecherhce.Lines = new string[0];
            this.txtRecherhce.Location = new System.Drawing.Point(99, 114);
            this.txtRecherhce.MaxLength = 32767;
            this.txtRecherhce.Name = "txtRecherhce";
            this.txtRecherhce.PasswordChar = '\0';
            this.txtRecherhce.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecherhce.SelectedText = "";
            this.txtRecherhce.SelectionLength = 0;
            this.txtRecherhce.SelectionStart = 0;
            this.txtRecherhce.ShortcutsEnabled = true;
            this.txtRecherhce.Size = new System.Drawing.Size(144, 23);
            this.txtRecherhce.TabIndex = 2;
            this.txtRecherhce.UseSelectable = true;
            this.txtRecherhce.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRecherhce.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRecherhce.TextChanged += new System.EventHandler(this.txtRecherhce_TextChanged);
            // 
            // btSupprimer
            // 
            this.btSupprimer.ActiveControl = null;
            this.btSupprimer.Location = new System.Drawing.Point(274, 74);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(87, 63);
            this.btSupprimer.TabIndex = 3;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseSelectable = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.ActiveControl = null;
            this.btRefresh.Location = new System.Drawing.Point(367, 74);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(88, 63);
            this.btRefresh.TabIndex = 4;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseSelectable = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Gestion_des_utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 437);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.txtRecherhce);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataUtilisateur);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestion_des_utilisateurs";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.Gestion_des_utilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUtilisateur;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtRecherhce;
        private MetroFramework.Controls.MetroTile btSupprimer;
        private MetroFramework.Controls.MetroTile btRefresh;
    }
}