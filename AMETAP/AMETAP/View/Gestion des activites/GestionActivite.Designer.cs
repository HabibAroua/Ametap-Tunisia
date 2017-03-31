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
            ((System.ComponentModel.ISupportInitialize)(this.dataActivite)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjouter
            // 
            this.btAjouter.ActiveControl = null;
            this.btAjouter.Location = new System.Drawing.Point(40, 78);
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
            this.btSupprimer.Location = new System.Drawing.Point(165, 78);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(84, 53);
            this.btSupprimer.TabIndex = 1;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseSelectable = true;
            // 
            // btModifier
            // 
            this.btModifier.ActiveControl = null;
            this.btModifier.Location = new System.Drawing.Point(292, 78);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 53);
            this.btModifier.TabIndex = 2;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseSelectable = true;
            // 
            // btRefresh
            // 
            this.btRefresh.ActiveControl = null;
            this.btRefresh.Location = new System.Drawing.Point(424, 78);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 53);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseSelectable = true;
            // 
            // dataActivite
            // 
            this.dataActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataActivite.Location = new System.Drawing.Point(40, 173);
            this.dataActivite.Name = "dataActivite";
            this.dataActivite.Size = new System.Drawing.Size(459, 194);
            this.dataActivite.TabIndex = 4;
            // 
            // GestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 409);
            this.Controls.Add(this.dataActivite);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Name = "GestionActivite";
            this.Text = "Gestion des activites";
            ((System.ComponentModel.ISupportInitialize)(this.dataActivite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btAjouter;
        private MetroFramework.Controls.MetroTile btSupprimer;
        private MetroFramework.Controls.MetroTile btModifier;
        private MetroFramework.Controls.MetroTile btRefresh;
        private System.Windows.Forms.DataGridView dataActivite;
    }
}