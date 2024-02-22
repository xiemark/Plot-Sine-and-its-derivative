namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ch_pos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_plot = new System.Windows.Forms.Button();
            this.tb_debug = new System.Windows.Forms.TextBox();
            this.bt_load = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_save = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ch_pos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ch_pos
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_pos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_pos.Legends.Add(legend1);
            this.ch_pos.Location = new System.Drawing.Point(86, 35);
            this.ch_pos.Name = "ch_pos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "s0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.ch_pos.Series.Add(series1);
            this.ch_pos.Series.Add(series2);
            this.ch_pos.Size = new System.Drawing.Size(566, 385);
            this.ch_pos.TabIndex = 0;
            this.ch_pos.Text = "ch_pos";
            // 
            // bt_plot
            // 
            this.bt_plot.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.bt_plot.Location = new System.Drawing.Point(685, 393);
            this.bt_plot.Name = "bt_plot";
            this.bt_plot.Size = new System.Drawing.Size(75, 25);
            this.bt_plot.TabIndex = 2;
            this.bt_plot.Text = "Plot";
            this.bt_plot.UseVisualStyleBackColor = true;
            this.bt_plot.Click += new System.EventHandler(this.bt_plot_Click);
            // 
            // tb_debug
            // 
            this.tb_debug.Location = new System.Drawing.Point(86, 463);
            this.tb_debug.Multiline = true;
            this.tb_debug.Name = "tb_debug";
            this.tb_debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_debug.Size = new System.Drawing.Size(566, 154);
            this.tb_debug.TabIndex = 3;
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(685, 77);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(75, 25);
            this.bt_load.TabIndex = 4;
            this.bt_load.Text = "Load";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(685, 225);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 25);
            this.bt_clear.TabIndex = 5;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_save);
            this.panel1.Location = new System.Drawing.Point(671, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 147);
            this.panel1.TabIndex = 6;
            // 
            // cb_save
            // 
            this.cb_save.AutoSize = true;
            this.cb_save.Location = new System.Drawing.Point(95, 46);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(50, 17);
            this.cb_save.TabIndex = 0;
            this.cb_save.Text = "Save";
            this.cb_save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 670);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.tb_debug);
            this.Controls.Add(this.bt_plot);
            this.Controls.Add(this.ch_pos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ch_pos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_pos;
        private System.Windows.Forms.Button bt_plot;
        private System.Windows.Forms.TextBox tb_debug;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_save;
    }
}

