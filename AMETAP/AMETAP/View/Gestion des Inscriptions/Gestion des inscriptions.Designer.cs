namespace AMETAP.View.Gestion_des_Inscriptions
{
    partial class Gestion_des_inscriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_inscriptions));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btAccepter = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdEnfant = new MetroFramework.Controls.MetroRadioButton();
            this.rdConjoint = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(479, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Les demandes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(550, 151);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(480, 203);
            this.dataGridView2.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(560, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Les adhérent qui n\'ont pas payer";
            // 
            // btAccepter
            // 
            this.btAccepter.Location = new System.Drawing.Point(287, 86);
            this.btAccepter.Name = "btAccepter";
            this.btAccepter.Size = new System.Drawing.Size(75, 23);
            this.btAccepter.TabIndex = 4;
            this.btAccepter.Text = "Accepter";
            this.btAccepter.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(386, 86);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Refuser";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdEnfant);
            this.groupBox1.Controls.Add(this.rdConjoint);
            this.groupBox1.Location = new System.Drawing.Point(58, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 27);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rdEnfant
            // 
            this.rdEnfant.AutoSize = true;
            this.rdEnfant.Location = new System.Drawing.Point(127, 7);
            this.rdEnfant.Name = "rdEnfant";
            this.rdEnfant.Size = new System.Drawing.Size(82, 15);
            this.rdEnfant.TabIndex = 1;
            this.rdEnfant.Text = "Les enfants";
            this.rdEnfant.UseSelectable = true;
            // 
            // rdConjoint
            // 
            this.rdConjoint.AutoSize = true;
            this.rdConjoint.Location = new System.Drawing.Point(7, 7);
            this.rdConjoint.Name = "rdConjoint";
            this.rdConjoint.Size = new System.Drawing.Size(92, 15);
            this.rdConjoint.TabIndex = 0;
            this.rdConjoint.Text = "Les conjoints";
            this.rdConjoint.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(773, 90);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(171, 23);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Confirmation de payaiment";
            this.metroButton3.UseSelectable = true;
            // 
            // Gestion_des_inscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 435);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btAccepter);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestion_des_inscriptions";
            this.Text = "Gestion des inscriptions";
            this.Load += new System.EventHandler(this.Gestion_des_inscriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btAccepter;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdEnfant;
        private MetroFramework.Controls.MetroRadioButton rdConjoint;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}