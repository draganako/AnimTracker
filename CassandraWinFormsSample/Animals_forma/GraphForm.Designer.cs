namespace Animals_forma
{
    partial class GraphForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbDispColumns = new System.Windows.Forms.RadioButton();
            this.rbDispPoints = new System.Windows.Forms.RadioButton();
            this.rbDispLines = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbWeight = new System.Windows.Forms.RadioButton();
            this.rbFood = new System.Windows.Forms.RadioButton();
            this.rbWater = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxReasons = new System.Windows.Forms.ListBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbDispColumns);
            this.groupBox5.Controls.Add(this.rbDispPoints);
            this.groupBox5.Controls.Add(this.rbDispLines);
            this.groupBox5.Location = new System.Drawing.Point(50, 199);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(485, 61);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type of chart";
            // 
            // rbDispColumns
            // 
            this.rbDispColumns.AutoSize = true;
            this.rbDispColumns.Location = new System.Drawing.Point(376, 21);
            this.rbDispColumns.Name = "rbDispColumns";
            this.rbDispColumns.Size = new System.Drawing.Size(75, 21);
            this.rbDispColumns.TabIndex = 2;
            this.rbDispColumns.Text = "Colums";
            this.rbDispColumns.UseVisualStyleBackColor = true;
            this.rbDispColumns.CheckedChanged += new System.EventHandler(this.rbPrikazTacke_CheckedChanged);
            // 
            // rbDispPoints
            // 
            this.rbDispPoints.AutoSize = true;
            this.rbDispPoints.Location = new System.Drawing.Point(203, 21);
            this.rbDispPoints.Name = "rbDispPoints";
            this.rbDispPoints.Size = new System.Drawing.Size(68, 21);
            this.rbDispPoints.TabIndex = 1;
            this.rbDispPoints.Text = "Points";
            this.rbDispPoints.UseVisualStyleBackColor = true;
            this.rbDispPoints.CheckedChanged += new System.EventHandler(this.rbPrikazTacke_CheckedChanged);
            // 
            // rbDispLines
            // 
            this.rbDispLines.AutoSize = true;
            this.rbDispLines.Checked = true;
            this.rbDispLines.Location = new System.Drawing.Point(45, 19);
            this.rbDispLines.Name = "rbDispLines";
            this.rbDispLines.Size = new System.Drawing.Size(63, 21);
            this.rbDispLines.TabIndex = 0;
            this.rbDispLines.TabStop = true;
            this.rbDispLines.Text = "Lines";
            this.rbDispLines.UseVisualStyleBackColor = true;
            this.rbDispLines.CheckedChanged += new System.EventHandler(this.rbPrikazTacke_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Possible reasons:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbWeight);
            this.groupBox4.Controls.Add(this.rbFood);
            this.groupBox4.Controls.Add(this.rbWater);
            this.groupBox4.Location = new System.Drawing.Point(577, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 61);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type of chart";
            // 
            // rbWeight
            // 
            this.rbWeight.AutoSize = true;
            this.rbWeight.Location = new System.Drawing.Point(344, 21);
            this.rbWeight.Name = "rbWeight";
            this.rbWeight.Size = new System.Drawing.Size(73, 21);
            this.rbWeight.TabIndex = 2;
            this.rbWeight.Text = "Weight";
            this.rbWeight.UseVisualStyleBackColor = true;
            this.rbWeight.CheckedChanged += new System.EventHandler(this.rbTip1_CheckedChanged);
            // 
            // rbFood
            // 
            this.rbFood.AutoSize = true;
            this.rbFood.Location = new System.Drawing.Point(194, 21);
            this.rbFood.Name = "rbFood";
            this.rbFood.Size = new System.Drawing.Size(61, 21);
            this.rbFood.TabIndex = 1;
            this.rbFood.Text = "Food";
            this.rbFood.UseVisualStyleBackColor = true;
            this.rbFood.CheckedChanged += new System.EventHandler(this.rbTip1_CheckedChanged);
            // 
            // rbWater
            // 
            this.rbWater.AutoSize = true;
            this.rbWater.Checked = true;
            this.rbWater.Location = new System.Drawing.Point(45, 19);
            this.rbWater.Name = "rbWater";
            this.rbWater.Size = new System.Drawing.Size(67, 21);
            this.rbWater.TabIndex = 0;
            this.rbWater.TabStop = true;
            this.rbWater.Text = "Water";
            this.rbWater.UseVisualStyleBackColor = true;
            this.rbWater.CheckedChanged += new System.EventHandler(this.rbTip1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartMain);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(50, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 371);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Intake";
            // 
            // chartMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(25, 37);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series1.Legend = "Legend1";
            series1.Name = "Voda";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Hrana";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Tezina";
            this.chartMain.Series.Add(series1);
            this.chartMain.Series.Add(series2);
            this.chartMain.Series.Add(series3);
            this.chartMain.Size = new System.Drawing.Size(936, 328);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(179, 155);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(254, 22);
            this.dtpFrom.TabIndex = 19;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(641, 155);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(244, 22);
            this.dtpTo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "from:";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(535, 160);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(24, 17);
            this.to.TabIndex = 22;
            this.to.Text = "to:";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(958, 155);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(88, 25);
            this.btnGet.TabIndex = 23;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Enabled = false;
            this.tbxDescription.Location = new System.Drawing.Point(538, 32);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(508, 100);
            this.tbxDescription.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Description:";
            // 
            // lbxReasons
            // 
            this.lbxReasons.FormattingEnabled = true;
            this.lbxReasons.ItemHeight = 16;
            this.lbxReasons.Location = new System.Drawing.Point(188, 32);
            this.lbxReasons.Name = "lbxReasons";
            this.lbxReasons.Size = new System.Drawing.Size(216, 100);
            this.lbxReasons.TabIndex = 26;
            this.lbxReasons.SelectedIndexChanged += new System.EventHandler(this.lbxReasons_SelectedIndexChanged);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 677);
            this.Controls.Add(this.lbxReasons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Name = "GraphForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Grafoviforma_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbDispColumns;
        private System.Windows.Forms.RadioButton rbDispPoints;
        private System.Windows.Forms.RadioButton rbDispLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbWeight;
        private System.Windows.Forms.RadioButton rbFood;
        private System.Windows.Forms.RadioButton rbWater;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxReasons;
    }
}