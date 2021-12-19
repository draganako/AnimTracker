namespace Animals_forma
{
    partial class RiskAddition
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
            this.btnAddRisk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRiskName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxDailyWater = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDailyFood = new System.Windows.Forms.TextBox();
            this.gbxOpisBolesti = new System.Windows.Forms.GroupBox();
            this.tbxRiskDesc = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.gbxOpisBolesti.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRisk
            // 
            this.btnAddRisk.Location = new System.Drawing.Point(128, 493);
            this.btnAddRisk.Name = "btnAddRisk";
            this.btnAddRisk.Size = new System.Drawing.Size(240, 54);
            this.btnAddRisk.TabIndex = 2;
            this.btnAddRisk.Text = "Add risk";
            this.btnAddRisk.UseVisualStyleBackColor = true;
            this.btnAddRisk.Click += new System.EventHandler(this.btnDodajBolest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxRiskName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbxDailyWater);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxWeight);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxDailyFood);
            this.groupBox2.Location = new System.Drawing.Point(34, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 225);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Values that cause health risk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Risk name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "*";
            // 
            // tbxRiskName
            // 
            this.tbxRiskName.Location = new System.Drawing.Point(233, 47);
            this.tbxRiskName.Name = "tbxRiskName";
            this.tbxRiskName.Size = new System.Drawing.Size(134, 22);
            this.tbxRiskName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Daily water intake:";
            // 
            // tbxDailyWater
            // 
            this.tbxDailyWater.Location = new System.Drawing.Point(233, 167);
            this.tbxDailyWater.Name = "tbxDailyWater";
            this.tbxDailyWater.Size = new System.Drawing.Size(134, 22);
            this.tbxDailyWater.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight:";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Location = new System.Drawing.Point(233, 84);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(134, 22);
            this.tbxWeight.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Daily food intake:";
            // 
            // tbxDailyFood
            // 
            this.tbxDailyFood.Location = new System.Drawing.Point(233, 125);
            this.tbxDailyFood.Name = "tbxDailyFood";
            this.tbxDailyFood.Size = new System.Drawing.Size(134, 22);
            this.tbxDailyFood.TabIndex = 2;
            // 
            // gbxOpisBolesti
            // 
            this.gbxOpisBolesti.Controls.Add(this.tbxRiskDesc);
            this.gbxOpisBolesti.Location = new System.Drawing.Point(34, 275);
            this.gbxOpisBolesti.Name = "gbxOpisBolesti";
            this.gbxOpisBolesti.Size = new System.Drawing.Size(425, 196);
            this.gbxOpisBolesti.TabIndex = 1;
            this.gbxOpisBolesti.TabStop = false;
            this.gbxOpisBolesti.Text = "Description:";
            // 
            // tbxRiskDesc
            // 
            this.tbxRiskDesc.Location = new System.Drawing.Point(6, 37);
            this.tbxRiskDesc.Multiline = true;
            this.tbxRiskDesc.Name = "tbxRiskDesc";
            this.tbxRiskDesc.Size = new System.Drawing.Size(413, 146);
            this.tbxRiskDesc.TabIndex = 0;
            // 
            // RiskAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 575);
            this.Controls.Add(this.btnAddRisk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxOpisBolesti);
            this.Name = "RiskAddition";
            this.Text = "Add a risk";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxOpisBolesti.ResumeLayout(false);
            this.gbxOpisBolesti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRisk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxRiskName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxDailyWater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDailyFood;
        private System.Windows.Forms.GroupBox gbxOpisBolesti;
        private System.Windows.Forms.TextBox tbxRiskDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}