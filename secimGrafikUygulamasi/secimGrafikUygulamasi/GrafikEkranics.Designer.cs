namespace secimGrafikUygulamasi
{
    partial class GrafikEkranics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpBoxGrafik = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBoxİlceDegerleri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxİlceSec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpBoxGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grpBoxİlceDegerleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGrafik
            // 
            this.grpBoxGrafik.Controls.Add(this.chart1);
            this.grpBoxGrafik.Location = new System.Drawing.Point(1, 3);
            this.grpBoxGrafik.Name = "grpBoxGrafik";
            this.grpBoxGrafik.Size = new System.Drawing.Size(690, 268);
            this.grpBoxGrafik.TabIndex = 0;
            this.grpBoxGrafik.TabStop = false;
            this.grpBoxGrafik.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 18);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(684, 247);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // grpBoxİlceDegerleri
            // 
            this.grpBoxİlceDegerleri.Controls.Add(this.label11);
            this.grpBoxİlceDegerleri.Controls.Add(this.label10);
            this.grpBoxİlceDegerleri.Controls.Add(this.label9);
            this.grpBoxİlceDegerleri.Controls.Add(this.label8);
            this.grpBoxİlceDegerleri.Controls.Add(this.label7);
            this.grpBoxİlceDegerleri.Controls.Add(this.progressBar5);
            this.grpBoxİlceDegerleri.Controls.Add(this.progressBar4);
            this.grpBoxİlceDegerleri.Controls.Add(this.progressBar3);
            this.grpBoxİlceDegerleri.Controls.Add(this.progressBar2);
            this.grpBoxİlceDegerleri.Controls.Add(this.progressBar1);
            this.grpBoxİlceDegerleri.Controls.Add(this.label6);
            this.grpBoxİlceDegerleri.Controls.Add(this.label5);
            this.grpBoxİlceDegerleri.Controls.Add(this.label4);
            this.grpBoxİlceDegerleri.Controls.Add(this.label3);
            this.grpBoxİlceDegerleri.Controls.Add(this.label2);
            this.grpBoxİlceDegerleri.Controls.Add(this.cmbBoxİlceSec);
            this.grpBoxİlceDegerleri.Controls.Add(this.label1);
            this.grpBoxİlceDegerleri.Location = new System.Drawing.Point(1, 277);
            this.grpBoxİlceDegerleri.Name = "grpBoxİlceDegerleri";
            this.grpBoxİlceDegerleri.Size = new System.Drawing.Size(687, 290);
            this.grpBoxİlceDegerleri.TabIndex = 1;
            this.grpBoxİlceDegerleri.TabStop = false;
            this.grpBoxİlceDegerleri.Text = "İlçe Değerleri";
            this.grpBoxİlceDegerleri.Enter += new System.EventHandler(this.grpBoxİlceDegerleri_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(177, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // cmbBoxİlceSec
            // 
            this.cmbBoxİlceSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxİlceSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxİlceSec.FormattingEnabled = true;
            this.cmbBoxİlceSec.Location = new System.Drawing.Point(275, 19);
            this.cmbBoxİlceSec.Name = "cmbBoxİlceSec";
            this.cmbBoxİlceSec.Size = new System.Drawing.Size(209, 33);
            this.cmbBoxİlceSec.TabIndex = 1;
            this.cmbBoxİlceSec.SelectedIndexChanged += new System.EventHandler(this.cmbBoxİlceSec_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(198, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "E Parti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(197, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "D Parti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(199, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "C Parti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(198, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "B Parti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(198, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "A Parti:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(275, 61);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 31);
            this.progressBar1.TabIndex = 11;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(275, 101);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(209, 31);
            this.progressBar2.TabIndex = 12;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(275, 141);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(209, 31);
            this.progressBar3.TabIndex = 13;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(275, 181);
            this.progressBar4.Maximum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(209, 31);
            this.progressBar4.TabIndex = 14;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(275, 221);
            this.progressBar5.Maximum = 200;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(209, 31);
            this.progressBar5.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(490, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(490, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(490, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(490, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(490, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "0";
            // 
            // GrafikEkranics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 579);
            this.Controls.Add(this.grpBoxİlceDegerleri);
            this.Controls.Add(this.grpBoxGrafik);
            this.Name = "GrafikEkranics";
            this.Text = "GrafikEkranics";
            this.Load += new System.EventHandler(this.GrafikEkranics_Load);
            this.grpBoxGrafik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.grpBoxİlceDegerleri.ResumeLayout(false);
            this.grpBoxİlceDegerleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGrafik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox grpBoxİlceDegerleri;
        private System.Windows.Forms.ComboBox cmbBoxİlceSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}