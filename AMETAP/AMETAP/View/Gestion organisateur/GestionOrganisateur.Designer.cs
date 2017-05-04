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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataOrganisation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAjouter
            // 
            this.btAjouter.ActiveControl = null;
            this.btAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAjouter.Location = new System.Drawing.Point(37, 84);
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
            this.btSupprimer.Location = new System.Drawing.Point(177, 84);
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
            this.btModifier.Location = new System.Drawing.Point(339, 84);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrganisation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataOrganisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOrganisation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataOrganisation.Location = new System.Drawing.Point(32, 304);
            this.dataOrganisation.Name = "dataOrganisation";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrganisation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataOrganisation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrganisation.Size = new System.Drawing.Size(538, 150);
            this.dataOrganisation.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 197);
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
            this.txtChercher.Location = new System.Drawing.Point(144, 193);
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
            this.groupBox1.Location = new System.Drawing.Point(53, 238);
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
            this.metroTile1.Location = new System.Drawing.Point(497, 87);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(61, 56);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // GestionOrganisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 500);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataOrganisation);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionOrganisateur";
            this.Text = "Gestion Organisateur";
            this.Load += new System.EventHandler(this.GestionOrganisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrganisation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}