namespace graph_solver
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
            this.chart_display = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.solution_listbox = new System.Windows.Forms.ListBox();
            this.constraints_listbox = new System.Windows.Forms.ListBox();
            this.coords_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rhs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_sign = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_display)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_display
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_display.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_display.Legends.Add(legend1);
            this.chart_display.Location = new System.Drawing.Point(39, 36);
            this.chart_display.Name = "chart_display";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_display.Series.Add(series1);
            this.chart_display.Size = new System.Drawing.Size(300, 300);
            this.chart_display.TabIndex = 0;
            this.chart_display.Text = "chart1";
            // 
            // solution_listbox
            // 
            this.solution_listbox.FormattingEnabled = true;
            this.solution_listbox.Location = new System.Drawing.Point(397, 36);
            this.solution_listbox.Name = "solution_listbox";
            this.solution_listbox.Size = new System.Drawing.Size(120, 303);
            this.solution_listbox.TabIndex = 1;
            // 
            // constraints_listbox
            // 
            this.constraints_listbox.FormattingEnabled = true;
            this.constraints_listbox.Location = new System.Drawing.Point(578, 36);
            this.constraints_listbox.Name = "constraints_listbox";
            this.constraints_listbox.Size = new System.Drawing.Size(120, 303);
            this.constraints_listbox.TabIndex = 2;
            // 
            // coords_listbox
            // 
            this.coords_listbox.FormattingEnabled = true;
            this.coords_listbox.Location = new System.Drawing.Point(756, 36);
            this.coords_listbox.Name = "coords_listbox";
            this.coords_listbox.Size = new System.Drawing.Size(120, 303);
            this.coords_listbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(960, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X1";
            // 
            // txt_x1
            // 
            this.txt_x1.Location = new System.Drawing.Point(1012, 80);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(100, 20);
            this.txt_x1.TabIndex = 5;
            // 
            // txt_x2
            // 
            this.txt_x2.Location = new System.Drawing.Point(1012, 116);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.Size = new System.Drawing.Size(100, 20);
            this.txt_x2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(960, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sign";
            // 
            // txt_rhs
            // 
            this.txt_rhs.Location = new System.Drawing.Point(1012, 192);
            this.txt_rhs.Name = "txt_rhs";
            this.txt_rhs.Size = new System.Drawing.Size(100, 20);
            this.txt_rhs.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(960, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "RHS";
            // 
            // cmb_sign
            // 
            this.cmb_sign.FormattingEnabled = true;
            this.cmb_sign.Location = new System.Drawing.Point(1012, 152);
            this.cmb_sign.Name = "cmb_sign";
            this.cmb_sign.Size = new System.Drawing.Size(100, 21);
            this.cmb_sign.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(963, 236);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(39, 358);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 603);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_sign);
            this.Controls.Add(this.txt_rhs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_x2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_x1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coords_listbox);
            this.Controls.Add(this.constraints_listbox);
            this.Controls.Add(this.solution_listbox);
            this.Controls.Add(this.chart_display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_display;
        private System.Windows.Forms.ListBox solution_listbox;
        private System.Windows.Forms.ListBox constraints_listbox;
        private System.Windows.Forms.ListBox coords_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rhs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_sign;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Refresh;
    }
}

