namespace Animals_forma
{
    partial class AdminOptions
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewAnimalTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSelectedTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedTyoeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTheRisksForSelectedTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAnimalTypeToolStripMenuItem,
            this.changeSelectedTypeToolStripMenuItem,
            this.deleteSelectedTyoeToolStripMenuItem,
            this.manageTheRisksForSelectedTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewAnimalTypeToolStripMenuItem
            // 
            this.addNewAnimalTypeToolStripMenuItem.Name = "addNewAnimalTypeToolStripMenuItem";
            this.addNewAnimalTypeToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.addNewAnimalTypeToolStripMenuItem.Text = "Add new animal type";
            this.addNewAnimalTypeToolStripMenuItem.Click += new System.EventHandler(this.addNewAnimalTypeToolStripMenuItem_Click);
            // 
            // changeSelectedTypeToolStripMenuItem
            // 
            this.changeSelectedTypeToolStripMenuItem.Name = "changeSelectedTypeToolStripMenuItem";
            this.changeSelectedTypeToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.changeSelectedTypeToolStripMenuItem.Text = "Change selected type";
            this.changeSelectedTypeToolStripMenuItem.Click += new System.EventHandler(this.changeSelectedTypeToolStripMenuItem_Click);
            // 
            // deleteSelectedTyoeToolStripMenuItem
            // 
            this.deleteSelectedTyoeToolStripMenuItem.Name = "deleteSelectedTyoeToolStripMenuItem";
            this.deleteSelectedTyoeToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.deleteSelectedTyoeToolStripMenuItem.Text = "Delete selected type";
            this.deleteSelectedTyoeToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedTyoeToolStripMenuItem_Click);
            // 
            // manageTheRisksForSelectedTypeToolStripMenuItem
            // 
            this.manageTheRisksForSelectedTypeToolStripMenuItem.Name = "manageTheRisksForSelectedTypeToolStripMenuItem";
            this.manageTheRisksForSelectedTypeToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.manageTheRisksForSelectedTypeToolStripMenuItem.Text = "Manage the risks for selected type";
            this.manageTheRisksForSelectedTypeToolStripMenuItem.Click += new System.EventHandler(this.manageTheRisksForSelectedTypeToolStripMenuItem_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(12, 45);
            this.dgvDisplay.MultiSelect = false;
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(1060, 393);
            this.dgvDisplay.TabIndex = 1;
            // 
            // AdminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminOptions";
            this.Text = "Admin Options";
            this.Load += new System.EventHandler(this.AdminOpcije_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewAnimalTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSelectedTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedTyoeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.ToolStripMenuItem manageTheRisksForSelectedTypeToolStripMenuItem;
    }
}