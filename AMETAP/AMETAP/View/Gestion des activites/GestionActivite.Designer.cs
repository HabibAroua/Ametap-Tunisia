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
            this.btAjouter = new MetroFramework.Controls.MetroTile();
            this.btSupprimer = new MetroFramework.Controls.MetroTile();
            this.btModifier = new MetroFramework.Controls.MetroTile();
            this.btRefresh = new MetroFramework.Controls.MetroTile();
            this.dataActivite = new System.Windows.Forms.DataGridView();
            this.comboAnnee = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataActivite)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjouter
            // 
            this.btAjouter.ActiveControl = null;
            this.btAjouter.Location = new System.Drawing.Point(40, 73);
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
            this.btSupprimer.Location = new System.Drawing.Point(165, 73);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(84, 53);
            this.btSupprimer.TabIndex = 1;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseSelectable = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.ActiveControl = null;
            this.btModifier.Location = new System.Drawing.Point(292, 73);
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
            this.btRefresh.Location = new System.Drawing.Point(424, 73);
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
            this.dataActivite.Location = new System.Drawing.Point(40, 192);
            this.dataActivite.Name = "dataActivite";
            this.dataActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataActivite.Size = new System.Drawing.Size(759, 194);
            this.dataActivite.TabIndex = 4;
            // 
            // comboAnnee
            // 
            this.comboAnnee.FormattingEnabled = true;
            this.comboAnnee.ItemHeight = 23;
            this.comboAnnee.Location = new System.Drawing.Point(194, 157);
            this.comboAnnee.Name = "comboAnnee";
            this.comboAnnee.Size = new System.Drawing.Size(135, 29);
            this.comboAnnee.TabIndex = 5;
            this.comboAnnee.UseSelectable = true;
            this.comboAnnee.TextChanged += new System.EventHandler(this.comboAnnee_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Séléctinner une année";
            // 
            // GestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 409);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboAnnee);
            this.Controls.Add(this.dataActivite);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Name = "GestionActivite";
            this.Text = "Gestion des activites";
            this.Load += new System.EventHandler(this.GestionActivite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataActivite)).EndInit();
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
    }
}