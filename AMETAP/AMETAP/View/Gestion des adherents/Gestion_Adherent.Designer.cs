namespace AMETAP.View.Gestion_des_adherents
{
    partial class Gestion_Adherent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Adherent));
            this.btSupprimer = new MetroFramework.Controls.MetroTile();
            this.dataAdherent = new System.Windows.Forms.DataGridView();
            this.txtChercher = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btRefresh = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Accueil = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdherent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btSupprimer
            // 
            this.btSupprimer.ActiveControl = null;
            this.btSupprimer.Location = new System.Drawing.Point(394, 127);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(81, 68);
            this.btSupprimer.TabIndex = 0;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseSelectable = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // dataAdherent
            // 
            this.dataAdherent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAdherent.Location = new System.Drawing.Point(35, 211);
            this.dataAdherent.Name = "dataAdherent";
            this.dataAdherent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAdherent.Size = new System.Drawing.Size(541, 155);
            this.dataAdherent.TabIndex = 1;
            this.dataAdherent.DoubleClick += new System.EventHandler(this.dataAdherent_DoubleClick);
            // 
            // txtChercher
            // 
            // 
            // 
            // 
            this.txtChercher.CustomButton.Image = null;
            this.txtChercher.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtChercher.CustomButton.Name = "";
            this.txtChercher.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChercher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChercher.CustomButton.TabIndex = 1;
            this.txtChercher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChercher.CustomButton.UseSelectable = true;
            this.txtChercher.CustomButton.Visible = false;
            this.txtChercher.Lines = new string[0];
            this.txtChercher.Location = new System.Drawing.Point(109, 172);
            this.txtChercher.MaxLength = 32767;
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.PasswordChar = '\0';
            this.txtChercher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChercher.SelectedText = "";
            this.txtChercher.SelectionLength = 0;
            this.txtChercher.SelectionStart = 0;
            this.txtChercher.ShortcutsEnabled = true;
            this.txtChercher.Size = new System.Drawing.Size(153, 23);
            this.txtChercher.TabIndex = 2;
            this.txtChercher.UseSelectable = true;
            this.txtChercher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChercher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChercher.TextChanged += new System.EventHandler(this.txtChercher_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 172);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Recherche";
            // 
            // btRefresh
            // 
            this.btRefresh.ActiveControl = null;
            this.btRefresh.Location = new System.Drawing.Point(497, 127);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(79, 68);
            this.btRefresh.TabIndex = 4;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseSelectable = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Accueil
            // 
            this.Accueil.AutoSize = true;
            this.Accueil.Location = new System.Drawing.Point(35, 121);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(42, 13);
            this.Accueil.TabIndex = 6;
            this.Accueil.Text = "Accueil";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(535, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 70);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Gestion_Adherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 378);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Accueil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.dataAdherent);
            this.Controls.Add(this.btSupprimer);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "Gestion_Adherent";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Gestion Adherent";
            this.Load += new System.EventHandler(this.Gestion_Adherent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAdherent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btSupprimer;
        private System.Windows.Forms.DataGridView dataAdherent;
        private MetroFramework.Controls.MetroTextBox txtChercher;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Accueil;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}