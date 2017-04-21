namespace AMETAP.View.Gestion_des_activites
{
    partial class GestionActivite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionActivite));
            this.btAjouter = new MetroFramework.Controls.MetroTile();
            this.btSupprimer = new MetroFramework.Controls.MetroTile();
            this.btModifier = new MetroFramework.Controls.MetroTile();
            this.btRefresh = new MetroFramework.Controls.MetroTile();
            this.dataActivite = new System.Windows.Forms.DataGridView();
            this.comboAnnee = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdActiviteCulturel = new MetroFramework.Controls.MetroRadioButton();
            this.rdActiviteLoisir = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataActivite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAjouter
            // 
            this.btAjouter.ActiveControl = null;
            this.btAjouter.Location = new System.Drawing.Point(122, 129);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 53);
            this.btAjouter.TabIndex = 0;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseSelectable = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.ActiveControl = null;
            this.btSupprimer.Location = new System.Drawing.Point(237, 129);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(82, 53);
            this.btSupprimer.TabIndex = 1;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseSelectable = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.ActiveControl = null;
            this.btModifier.Location = new System.Drawing.Point(367, 129);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 53);
            this.btModifier.TabIndex = 2;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseSelectable = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.ActiveControl = null;
            this.btRefresh.Location = new System.Drawing.Point(473, 129);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 53);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseSelectable = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // dataActivite
            // 
            this.dataActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataActivite.Location = new System.Drawing.Point(39, 254);
            this.dataActivite.Name = "dataActivite";
            this.dataActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataActivite.Size = new System.Drawing.Size(863, 262);
            this.dataActivite.TabIndex = 4;
            // 
            // comboAnnee
            // 
            this.comboAnnee.FormattingEnabled = true;
            this.comboAnnee.ItemHeight = 23;
            this.comboAnnee.Location = new System.Drawing.Point(199, 208);
            this.comboAnnee.Name = "comboAnnee";
            this.comboAnnee.Size = new System.Drawing.Size(196, 29);
            this.comboAnnee.TabIndex = 5;
            this.comboAnnee.UseSelectable = true;
            this.comboAnnee.TextChanged += new System.EventHandler(this.comboAnnee_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 208);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Séléctinner une année";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdActiviteCulturel);
            this.groupBox1.Controls.Add(this.rdActiviteLoisir);
            this.groupBox1.Location = new System.Drawing.Point(401, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rdActiviteCulturel
            // 
            this.rdActiviteCulturel.AutoSize = true;
            this.rdActiviteCulturel.Location = new System.Drawing.Point(163, 20);
            this.rdActiviteCulturel.Name = "rdActiviteCulturel";
            this.rdActiviteCulturel.Size = new System.Drawing.Size(106, 15);
            this.rdActiviteCulturel.TabIndex = 1;
            this.rdActiviteCulturel.Text = "Activité culturel";
            this.rdActiviteCulturel.UseSelectable = true;
            // 
            // rdActiviteLoisir
            // 
            this.rdActiviteLoisir.AutoSize = true;
            this.rdActiviteLoisir.Location = new System.Drawing.Point(28, 21);
            this.rdActiviteLoisir.Name = "rdActiviteLoisir";
            this.rdActiviteLoisir.Size = new System.Drawing.Size(107, 15);
            this.rdActiviteLoisir.TabIndex = 0;
            this.rdActiviteLoisir.Text = "Activité de loisir";
            this.rdActiviteLoisir.UseSelectable = true;
            // 
            // GestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboAnnee);
            this.Controls.Add(this.dataActivite);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestionActivite";
            this.Text = "Gestion des activites";
            this.Load += new System.EventHandler(this.GestionActivite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataActivite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btAjouter;
        private MetroFramework.Controls.MetroTile btSupprimer;
        private MetroFramework.Controls.MetroTile btModifier;
        private MetroFramework.Controls.MetroTile btRefresh;
        private System.Windows.Forms.DataGridView dataActivite;
        private MetroFramework.Controls.MetroComboBox comboAnnee;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdActiviteCulturel;
        private MetroFramework.Controls.MetroRadioButton rdActiviteLoisir;
    }
}