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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_utilisateurs));
            this.dataUtilisateur = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRecherhce = new MetroFramework.Controls.MetroTextBox();
            this.btSupprimer = new MetroFramework.Controls.MetroTile();
            this.btRefresh = new MetroFramework.Controls.MetroTile();
            this.Accueil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUtilisateur
            // 
            this.dataUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUtilisateur.Location = new System.Drawing.Point(14, 180);
            this.dataUtilisateur.Name = "dataUtilisateur";
            this.dataUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUtilisateur.Size = new System.Drawing.Size(441, 217);
            this.dataUtilisateur.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 138);
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
            this.txtRecherhce.Location = new System.Drawing.Point(99, 134);
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
            this.btSupprimer.Location = new System.Drawing.Point(267, 111);
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
            this.btRefresh.Location = new System.Drawing.Point(374, 111);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(88, 63);
            this.btRefresh.TabIndex = 4;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseSelectable = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Accueil
            // 
            this.Accueil.AutoSize = true;
            this.Accueil.Location = new System.Drawing.Point(35, 111);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(42, 13);
            this.Accueil.TabIndex = 8;
            this.Accueil.Text = "Accueil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(422, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 68);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Gestion_des_utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 437);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Accueil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.txtRecherhce);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataUtilisateur);
            this.Name = "Gestion_des_utilisateurs";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.Gestion_des_utilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUtilisateur;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtRecherhce;
        private MetroFramework.Controls.MetroTile btSupprimer;
        private MetroFramework.Controls.MetroTile btRefresh;
        private System.Windows.Forms.Label Accueil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}