namespace StockControl_GUI
{
    partial class frmMain
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
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.stockControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStockLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_strip
            // 
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockControlToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(982, 24);
            this.menu_strip.TabIndex = 1;
            this.menu_strip.Text = "menuStrip1";
            // 
            // stockControlToolStripMenuItem
            // 
            this.stockControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayStockLevelsToolStripMenuItem,
            this.updateStockToolStripMenuItem});
            this.stockControlToolStripMenuItem.Name = "stockControlToolStripMenuItem";
            this.stockControlToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.stockControlToolStripMenuItem.Text = "stock Control";
            // 
            // displayStockLevelsToolStripMenuItem
            // 
            this.displayStockLevelsToolStripMenuItem.Name = "displayStockLevelsToolStripMenuItem";
            this.displayStockLevelsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.displayStockLevelsToolStripMenuItem.Text = "Display Stock levels";
            this.displayStockLevelsToolStripMenuItem.Click += new System.EventHandler(this.displayStockLevelsToolStripMenuItem_Click);
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
            this.updateStockToolStripMenuItem.Click += new System.EventHandler(this.updateStockToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 411);
            this.Controls.Add(this.menu_strip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_strip;
            this.Name = "frmMain";
            this.Text = "MK super stores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem stockControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStockLevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

