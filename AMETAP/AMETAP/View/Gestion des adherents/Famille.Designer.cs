namespace AMETAP.View.Gestion_des_adherents
{
    partial class Famille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Famille));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTous = new MetroFramework.Controls.MetroRadioButton();
            this.rdConjoint = new MetroFramework.Controls.MetroRadioButton();
            this.rdEnfant = new MetroFramework.Controls.MetroRadioButton();
            this.dataFamille = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTous);
            this.groupBox1.Controls.Add(this.rdConjoint);
            this.groupBox1.Controls.Add(this.rdEnfant);
            this.groupBox1.Location = new System.Drawing.Point(41, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 35);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdTous
            // 
            this.rdTous.AutoSize = true;
            this.rdTous.Location = new System.Drawing.Point(29, 14);
            this.rdTous.Name = "rdTous";
            this.rdTous.Size = new System.Drawing.Size(48, 15);
            this.rdTous.TabIndex = 3;
            this.rdTous.Text = "Tous";
            this.rdTous.UseSelectable = true;
            this.rdTous.Click += new System.EventHandler(this.rdTous_Click);
            // 
            // rdConjoint
            // 
            this.rdConjoint.AutoSize = true;
            this.rdConjoint.Location = new System.Drawing.Point(104, 14);
            this.rdConjoint.Name = "rdConjoint";
            this.rdConjoint.Size = new System.Drawing.Size(69, 15);
            this.rdConjoint.TabIndex = 2;
            this.rdConjoint.Text = "Conjoint";
            this.rdConjoint.UseSelectable = true;
            this.rdConjoint.Click += new System.EventHandler(this.rdConjoint_Click);
            // 
            // rdEnfant
            // 
            this.rdEnfant.AutoSize = true;
            this.rdEnfant.Location = new System.Drawing.Point(209, 14);
            this.rdEnfant.Name = "rdEnfant";
            this.rdEnfant.Size = new System.Drawing.Size(57, 15);
            this.rdEnfant.TabIndex = 1;
            this.rdEnfant.Text = "Enfant";
            this.rdEnfant.UseSelectable = true;
            this.rdEnfant.Click += new System.EventHandler(this.rdEnfant_Click);
            // 
            // dataFamille
            // 
            this.dataFamille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFamille.Location = new System.Drawing.Point(41, 147);
            this.dataFamille.Name = "dataFamille";
            this.dataFamille.Size = new System.Drawing.Size(516, 150);
            this.dataFamille.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 101);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Famille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataFamille);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Famille";
            this.Text = "Famille";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdEnfant;
        private MetroFramework.Controls.MetroRadioButton rdConjoint;
        private System.Windows.Forms.DataGridView dataFamille;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroRadioButton rdTous;
    }
}