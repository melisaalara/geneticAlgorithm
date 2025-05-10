namespace GenetikAlgoritma
{
    partial class Form1
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
            this.txtPopulasyon = new System.Windows.Forms.TextBox();
            this.txtCrossover = new System.Windows.Forms.TextBox();
            this.txtMutation = new System.Windows.Forms.TextBox();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblBestSolution = new System.Windows.Forms.Label();
            this.txtElitism = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPopulasyon
            // 
            this.txtPopulasyon.BackColor = System.Drawing.Color.MediumPurple;
            this.txtPopulasyon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPopulasyon.Location = new System.Drawing.Point(204, 46);
            this.txtPopulasyon.Multiline = true;
            this.txtPopulasyon.Name = "txtPopulasyon";
            this.txtPopulasyon.Size = new System.Drawing.Size(174, 31);
            this.txtPopulasyon.TabIndex = 0;
            // 
            // txtCrossover
            // 
            this.txtCrossover.BackColor = System.Drawing.Color.MediumPurple;
            this.txtCrossover.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCrossover.Location = new System.Drawing.Point(204, 89);
            this.txtCrossover.Multiline = true;
            this.txtCrossover.Name = "txtCrossover";
            this.txtCrossover.Size = new System.Drawing.Size(174, 31);
            this.txtCrossover.TabIndex = 2;
            // 
            // txtMutation
            // 
            this.txtMutation.BackColor = System.Drawing.Color.MediumPurple;
            this.txtMutation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMutation.Location = new System.Drawing.Point(204, 132);
            this.txtMutation.Multiline = true;
            this.txtMutation.Name = "txtMutation";
            this.txtMutation.Size = new System.Drawing.Size(174, 31);
            this.txtMutation.TabIndex = 3;
            // 
            // txtGenerations
            // 
            this.txtGenerations.BackColor = System.Drawing.Color.MediumPurple;
            this.txtGenerations.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenerations.Location = new System.Drawing.Point(204, 179);
            this.txtGenerations.Multiline = true;
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(174, 31);
            this.txtGenerations.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Popülasyon Boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Çaprazlama Oranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mutasyon Oranı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jenerasyon Sayısı";
            // 
            // chartGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraph.Legends.Add(legend2);
            this.chartGraph.Location = new System.Drawing.Point(384, 15);
            this.chartGraph.Name = "chartGraph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Yakınsama ";
            this.chartGraph.Series.Add(series2);
            this.chartGraph.Size = new System.Drawing.Size(407, 300);
            this.chartGraph.TabIndex = 9;
            this.chartGraph.Text = "chart1";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumPurple;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(204, 279);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(174, 36);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // lblBestSolution
            // 
            this.lblBestSolution.AutoSize = true;
            this.lblBestSolution.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBestSolution.Location = new System.Drawing.Point(129, 347);
            this.lblBestSolution.Name = "lblBestSolution";
            this.lblBestSolution.Size = new System.Drawing.Size(0, 20);
            this.lblBestSolution.TabIndex = 12;
            // 
            // txtElitism
            // 
            this.txtElitism.AutoSize = true;
            this.txtElitism.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElitism.Location = new System.Drawing.Point(41, 228);
            this.txtElitism.Name = "txtElitism";
            this.txtElitism.Size = new System.Drawing.Size(102, 16);
            this.txtElitism.TabIndex = 14;
            this.txtElitism.Text = "Seçkinlik Oranı";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(204, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 31);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(767, 396);
            this.Controls.Add(this.txtElitism);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBestSolution);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chartGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenerations);
            this.Controls.Add(this.txtMutation);
            this.Controls.Add(this.txtCrossover);
            this.Controls.Add(this.txtPopulasyon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPopulasyon;
        private System.Windows.Forms.TextBox txtCrossover;
        private System.Windows.Forms.TextBox txtMutation;
        private System.Windows.Forms.TextBox txtGenerations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBestSolution;
        private System.Windows.Forms.Label txtElitism;
        private System.Windows.Forms.TextBox textBox1;
    }
}

