namespace AMETAP.View.Gestion_Budget
{
    partial class Information_chaque_année
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.viewAnnee = new System.Windows.Forms.Label();
            this.btAfficher = new MetroFramework.Controls.MetroButton();
            this.dataActivite = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Année :";
            // 
            // viewAnnee
            // 
            this.viewAnnee.AutoSize = true;
            this.viewAnnee.Location = new System.Drawing.Point(91, 72);
            this.viewAnnee.Name = "viewAnnee";
            this.viewAnnee.Size = new System.Drawing.Size(35, 13);
            this.viewAnnee.TabIndex = 1;
            this.viewAnnee.Text = "label2";
            // 
            // btAfficher
            // 
            this.btAfficher.Location = new System.Drawing.Point(130, 103);
            this.btAfficher.Name = "btAfficher";
            this.btAfficher.Size = new System.Drawing.Size(75, 23);
            this.btAfficher.TabIndex = 2;
            this.btAfficher.Text = "Afficher";
            this.btAfficher.UseSelectable = true;
            this.btAfficher.Click += new System.EventHandler(this.btAfficher_Click);
            // 
            // dataActivite
            // 
            this.dataActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataActivite.Location = new System.Drawing.Point(39, 165);
            this.dataActivite.Name = "dataActivite";
            this.dataActivite.Size = new System.Drawing.Size(300, 150);
            this.dataActivite.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(397, 33);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Activites";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(406, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chartActivites";
            title1.Name = "Activités";
            title1.Text = "Activites";
            this.chart1.Titles.Add(title1);
            // 
            // Information_chaque_année
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 368);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataActivite);
            this.Controls.Add(this.btAfficher);
            this.Controls.Add(this.viewAnnee);
            this.Controls.Add(this.label1);
            this.Name = "Information_chaque_année";
            this.Text = "Information chaque année";
            ((System.ComponentModel.ISupportInitialize)(this.dataActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btAfficher;
        private System.Windows.Forms.DataGridView dataActivite;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label viewAnnee;
    }
}