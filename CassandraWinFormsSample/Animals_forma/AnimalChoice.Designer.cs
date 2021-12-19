namespace Animals_forma
{
    partial class AnimalChoice
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
            this.comboAnimals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateTracker = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddToday = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxWater = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbType3 = new System.Windows.Forms.RadioButton();
            this.rbType2 = new System.Windows.Forms.RadioButton();
            this.rbType1 = new System.Windows.Forms.RadioButton();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboAnimals
            // 
            this.comboAnimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboAnimals.FormattingEnabled = true;
            this.comboAnimals.Location = new System.Drawing.Point(241, 6);
            this.comboAnimals.Name = "comboAnimals";
            this.comboAnimals.Size = new System.Drawing.Size(233, 24);
            this.comboAnimals.TabIndex = 0;
            this.comboAnimals.SelectedIndexChanged += new System.EventHandler(this.comboZivotinje_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose from one of your pets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Or create new tracker!";
            // 
            // btnCreateTracker
            // 
            this.btnCreateTracker.Location = new System.Drawing.Point(870, 6);
            this.btnCreateTracker.Name = "btnCreateTracker";
            this.btnCreateTracker.Size = new System.Drawing.Size(157, 24);
            this.btnCreateTracker.TabIndex = 3;
            this.btnCreateTracker.Text = "Create new";
            this.btnCreateTracker.UseVisualStyleBackColor = true;
            this.btnCreateTracker.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFinish);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnAddToday);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbxWeight);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbxFood);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbxWater);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(15, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1012, 239);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Today\'s intake";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(536, 36);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(330, 35);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(406, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Based on todays intake, there is no concern/ animal might be ill";
            // 
            // btnAddToday
            // 
            this.btnAddToday.Location = new System.Drawing.Point(129, 36);
            this.btnAddToday.Name = "btnAddToday";
            this.btnAddToday.Size = new System.Drawing.Size(330, 35);
            this.btnAddToday.TabIndex = 7;
            this.btnAddToday.Text = "Add today\'s stats";
            this.btnAddToday.UseVisualStyleBackColor = true;
            this.btnAddToday.Click += new System.EventHandler(this.btnAddToday_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "*All measurements in \" \", based on animal type";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Location = new System.Drawing.Point(714, 139);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(100, 22);
            this.tbxWeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight";
            // 
            // tbxFood
            // 
            this.tbxFood.Location = new System.Drawing.Point(384, 139);
            this.tbxFood.Name = "tbxFood";
            this.tbxFood.Size = new System.Drawing.Size(100, 22);
            this.tbxFood.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Food";
            // 
            // tbxWater
            // 
            this.tbxWater.Location = new System.Drawing.Point(77, 139);
            this.tbxWater.Name = "tbxWater";
            this.tbxWater.Size = new System.Drawing.Size(100, 22);
            this.tbxWater.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Water";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(793, 326);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(165, 49);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "See more detailed chart";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbType3);
            this.groupBox5.Controls.Add(this.rbType2);
            this.groupBox5.Controls.Add(this.rbType1);
            this.groupBox5.Location = new System.Drawing.Point(63, 314);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(599, 61);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type of chart";
            // 
            // rbType3
            // 
            this.rbType3.AutoSize = true;
            this.rbType3.Location = new System.Drawing.Point(436, 21);
            this.rbType3.Name = "rbType3";
            this.rbType3.Size = new System.Drawing.Size(73, 21);
            this.rbType3.TabIndex = 2;
            this.rbType3.Text = "Weight";
            this.rbType3.UseVisualStyleBackColor = true;
            this.rbType3.CheckedChanged += new System.EventHandler(this.rbTip2_CheckedChanged);
            // 
            // rbType2
            // 
            this.rbType2.AutoSize = true;
            this.rbType2.Location = new System.Drawing.Point(228, 21);
            this.rbType2.Name = "rbType2";
            this.rbType2.Size = new System.Drawing.Size(61, 21);
            this.rbType2.TabIndex = 1;
            this.rbType2.Text = "Food";
            this.rbType2.UseVisualStyleBackColor = true;
            this.rbType2.CheckedChanged += new System.EventHandler(this.rbTip2_CheckedChanged);
            // 
            // rbType1
            // 
            this.rbType1.AutoSize = true;
            this.rbType1.Checked = true;
            this.rbType1.Location = new System.Drawing.Point(45, 19);
            this.rbType1.Name = "rbType1";
            this.rbType1.Size = new System.Drawing.Size(67, 21);
            this.rbType1.TabIndex = 0;
            this.rbType1.TabStop = true;
            this.rbType1.Text = "Water";
            this.rbType1.UseVisualStyleBackColor = true;
            this.rbType1.CheckedChanged += new System.EventHandler(this.rbTip2_CheckedChanged);
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
            this.chartMain.Size = new System.Drawing.Size(918, 172);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartMain);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(15, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(977, 231);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Intake";
            // 
            // AnimalChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 956);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCreateTracker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAnimals);
            this.Name = "AnimalChoice";
            this.Text = "Manage animal data";
            this.Load += new System.EventHandler(this.OdabirZivotinje_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAnimals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateTracker;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddToday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxWater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbType3;
        private System.Windows.Forms.RadioButton rbType2;
        private System.Windows.Forms.RadioButton rbType1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinish;
    }
}