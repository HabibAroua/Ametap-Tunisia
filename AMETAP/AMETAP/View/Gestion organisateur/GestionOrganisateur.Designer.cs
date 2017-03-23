namespace AMETAP.View.Gestion_organisateur
{
    partial class GestionOrganisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionOrganisateur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btAjouter = new MetroFramework.Controls.MetroTile();
            this.btSupprimer = new MetroFramework.Controls.MetroTile();
            this.btModifier = new MetroFramework.Controls.MetroTile();
            this.dataOrganisation = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtChercher = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r1 = new MetroFramework.Controls.MetroRadioButton();
            this.r2 = new MetroFramework.Controls.MetroRadioButton();
            this.r3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.Accueil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrganisation)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjouter
            // 
            this.btAjouter.ActiveControl = null;
            this.btAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAjouter.Location = new System.Drawing.Point(37, 154);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(68, 69);
            this.btAjouter.TabIndex = 0;
            this.btAjouter.TileImage = ((System.Drawing.Image)(resources.GetObject("btAjouter.TileImage")));
            this.btAjouter.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAjouter.UseSelectable = true;
            this.btAjouter.UseTileImage = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.ActiveControl = null;
            this.btSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupprimer.Location = new System.Drawing.Point(177, 154);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(79, 70);
            this.btSupprimer.TabIndex = 1;
            this.btSupprimer.TileImage = ((System.Drawing.Image)(resources.GetObject("btSupprimer.TileImage")));
            this.btSupprimer.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btSupprimer.UseSelectable = true;
            this.btSupprimer.UseTileImage = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.ActiveControl = null;
            this.btModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModifier.Location = new System.Drawing.Point(339, 154);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(84, 70);
            this.btModifier.Style = MetroFramework.MetroColorStyle.Blue;
            this.btModifier.TabIndex = 2;
            this.btModifier.TileImage = ((System.Drawing.Image)(resources.GetObject("btModifier.TileImage")));
            this.btModifier.UseSelectable = true;
            this.btModifier.UseTileImage = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // dataOrganisation
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrganisation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataOrganisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOrganisation.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataOrganisation.Location = new System.Drawing.Point(37, 353);
            this.dataOrganisation.Name = "dataOrganisation";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrganisation.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataOrganisation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrganisation.Size = new System.Drawing.Size(538, 150);
            this.dataOrganisation.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 264);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Chercher";
            // 
            // txtChercher
            // 
            // 
            // 
            // 
            this.txtChercher.CustomButton.Image = null;
            this.txtChercher.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtChercher.CustomButton.Name = "";
            this.txtChercher.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChercher.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChercher.CustomButton.TabIndex = 1;
            this.txtChercher.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChercher.CustomButton.UseSelectable = true;
            this.txtChercher.CustomButton.Visible = false;
            this.txtChercher.Lines = new string[0];
            this.txtChercher.Location = new System.Drawing.Point(121, 264);
            this.txtChercher.MaxLength = 32767;
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.PasswordChar = '\0';
            this.txtChercher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChercher.SelectedText = "";
            this.txtChercher.SelectionLength = 0;
            this.txtChercher.SelectionStart = 0;
            this.txtChercher.ShortcutsEnabled = true;
            this.txtChercher.Size = new System.Drawing.Size(175, 23);
            this.txtChercher.TabIndex = 5;
            this.txtChercher.UseSelectable = true;
            this.txtChercher.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChercher.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChercher.TextChanged += new System.EventHandler(this.txtChercher_TextChanged);
            this.txtChercher.Click += new System.EventHandler(this.txtChercher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r1);
            this.groupBox1.Controls.Add(this.r2);
            this.groupBox1.Controls.Add(this.r3);
            this.groupBox1.Location = new System.Drawing.Point(53, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 42);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(18, 19);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(120, 15);
            this.r1.TabIndex = 2;
            this.r1.TabStop = true;
            this.r1.Text = "Agence de voyage";
            this.r1.UseSelectable = true;
            this.r1.Click += new System.EventHandler(this.r1_Click);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(208, 19);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(58, 15);
            this.r2.TabIndex = 1;
            this.r2.TabStop = true;
            this.r2.Text = "Centre";
            this.r2.UseSelectable = true;
            this.r2.Click += new System.EventHandler(this.r2_Click);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(345, 19);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(48, 15);
            this.r3.TabIndex = 0;
            this.r3.TabStop = true;
            this.r3.Text = "Club";
            this.r3.UseSelectable = true;
            this.r3.Click += new System.EventHandler(this.r3_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(497, 157);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(61, 56);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Accueil
            // 
            this.Accueil.AutoSize = true;
            this.Accueil.Location = new System.Drawing.Point(49, 121);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(42, 13);
            this.Accueil.TabIndex = 9;
            this.Accueil.Text = "Accueil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(509, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 69);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // GestionOrganisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Accueil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataOrganisation);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionOrganisateur";
            this.Text = "Gestion Organisateur";
            this.Load += new System.EventHandler(this.GestionOrganisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrganisation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btAjouter;
        private MetroFramework.Controls.MetroTile btSupprimer;
        private MetroFramework.Controls.MetroTile btModifier;
        private System.Windows.Forms.DataGridView dataOrganisation;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtChercher;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton r1;
        private MetroFramework.Controls.MetroRadioButton r2;
        private MetroFramework.Controls.MetroRadioButton r3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Label Accueil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}