namespace Animals_forma
{
    partial class AdminOptionsRisks
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
            this.dgvRisks = new System.Windows.Forms.DataGridView();
            this.menuStripBolesti = new System.Windows.Forms.MenuStrip();
            this.addNewRiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSelectedRiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedRiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisks)).BeginInit();
            this.menuStripBolesti.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRisks
            // 
            this.dgvRisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRisks.Location = new System.Drawing.Point(10, 41);
            this.dgvRisks.MultiSelect = false;
            this.dgvRisks.Name = "dgvRisks";
            this.dgvRisks.RowHeadersWidth = 51;
            this.dgvRisks.RowTemplate.Height = 24;
            this.dgvRisks.Size = new System.Drawing.Size(1030, 393);
            this.dgvRisks.TabIndex = 7;
            // 
            // menuStripBolesti
            // 
            this.menuStripBolesti.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripBolesti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRiskToolStripMenuItem,
            this.changeSelectedRiskToolStripMenuItem,
            this.deleteSelectedRiskToolStripMenuItem});
            this.menuStripBolesti.Location = new System.Drawing.Point(0, 0);
            this.menuStripBolesti.Name = "menuStripBolesti";
            this.menuStripBolesti.Size = new System.Drawing.Size(1052, 28);
            this.menuStripBolesti.TabIndex = 6;
            this.menuStripBolesti.Text = "menuStrip1";
            // 
            // addNewRiskToolStripMenuItem
            // 
            this.addNewRiskToolStripMenuItem.Name = "addNewRiskToolStripMenuItem";
            this.addNewRiskToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.addNewRiskToolStripMenuItem.Text = "Add new risk";
            this.addNewRiskToolStripMenuItem.Click += new System.EventHandler(this.addNewRiskToolStripMenuItem_Click);
            // 
            // changeSelectedRiskToolStripMenuItem
            // 
            this.changeSelectedRiskToolStripMenuItem.Name = "changeSelectedRiskToolStripMenuItem";
            this.changeSelectedRiskToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.changeSelectedRiskToolStripMenuItem.Text = "Change selected risk";
            this.changeSelectedRiskToolStripMenuItem.Click += new System.EventHandler(this.changeSelectedRiskToolStripMenuItem_Click);
            // 
            // deleteSelectedRiskToolStripMenuItem
            // 
            this.deleteSelectedRiskToolStripMenuItem.Name = "deleteSelectedRiskToolStripMenuItem";
            this.deleteSelectedRiskToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.deleteSelectedRiskToolStripMenuItem.Text = "Delete selected risk";
            this.deleteSelectedRiskToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedRiskToolStripMenuItem_Click);
            // 
            // AdminOptionsRisks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 449);
            this.Controls.Add(this.dgvRisks);
            this.Controls.Add(this.menuStripBolesti);
            this.Name = "AdminOptionsRisks";
            this.Text = "Risks";
            this.Load += new System.EventHandler(this.AdminOpcijeBolesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisks)).EndInit();
            this.menuStripBolesti.ResumeLayout(false);
            this.menuStripBolesti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRisks;
        private System.Windows.Forms.MenuStrip menuStripBolesti;
        private System.Windows.Forms.ToolStripMenuItem addNewRiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSelectedRiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedRiskToolStripMenuItem;
    }
}