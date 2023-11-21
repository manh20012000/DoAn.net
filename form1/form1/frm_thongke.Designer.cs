
namespace form1
{
    partial class frm_thongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_thongke = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_thongkeSanpham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbx_nam = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thongkeSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_thongke
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_thongke.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_thongke.Legends.Add(legend1);
            this.chart_thongke.Location = new System.Drawing.Point(1, 76);
            this.chart_thongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_thongke.Name = "chart_thongke";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_thongke.Series.Add(series1);
            this.chart_thongke.Size = new System.Drawing.Size(564, 474);
            this.chart_thongke.TabIndex = 0;
            this.chart_thongke.Text = "chart1";
            // 
            // chart_thongkeSanpham
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_thongkeSanpham.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_thongkeSanpham.Legends.Add(legend2);
            this.chart_thongkeSanpham.Location = new System.Drawing.Point(571, 76);
            this.chart_thongkeSanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_thongkeSanpham.Name = "chart_thongkeSanpham";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_thongkeSanpham.Series.Add(series2);
            this.chart_thongkeSanpham.Size = new System.Drawing.Size(443, 474);
            this.chart_thongkeSanpham.TabIndex = 1;
            this.chart_thongkeSanpham.Text = "chart1";
            // 
            // cbx_nam
            // 
            this.cbx_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nam.FormattingEnabled = true;
            this.cbx_nam.Location = new System.Drawing.Point(12, 12);
            this.cbx_nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_nam.Name = "cbx_nam";
            this.cbx_nam.Size = new System.Drawing.Size(149, 40);
            this.cbx_nam.TabIndex = 2;
            this.cbx_nam.SelectedIndexChanged += new System.EventHandler(this.cbx_nam_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = global::form1.Properties.Resources.back;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(842, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_nam);
            this.Controls.Add(this.chart_thongkeSanpham);
            this.Controls.Add(this.chart_thongke);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_thongke";
            this.Text = "frm_thongke";
            this.Load += new System.EventHandler(this.frm_thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_thongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thongkeSanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_thongke;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_thongkeSanpham;
        private System.Windows.Forms.ComboBox cbx_nam;
        private System.Windows.Forms.Button button1;
    }
}