namespace StockControl_GUI
{
    partial class frmDispStock
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
            this.btnDispFinish = new System.Windows.Forms.Button();
            this.tabDispStock = new System.Windows.Forms.TabControl();
            this.tabPgSoldStock = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lstDispStock = new System.Windows.Forms.ListBox();
            this.tabPgAvailStock = new System.Windows.Forms.TabPage();
            this.chkDispIncomeRecieved = new System.Windows.Forms.CheckBox();
            this.chkViewProjctedIncome = new System.Windows.Forms.CheckBox();
            this.chkDispUnitSold = new System.Windows.Forms.CheckBox();
            this.tabDispStock.SuspendLayout();
            this.tabPgSoldStock.SuspendLayout();
            this.tabPgAvailStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDispFinish
            // 
            this.btnDispFinish.Location = new System.Drawing.Point(573, 465);
            this.btnDispFinish.Name = "btnDispFinish";
            this.btnDispFinish.Size = new System.Drawing.Size(143, 30);
            this.btnDispFinish.TabIndex = 1;
            this.btnDispFinish.Text = "Done";
            this.btnDispFinish.UseVisualStyleBackColor = true;
            this.btnDispFinish.Click += new System.EventHandler(this.btnDispFinish_Click);
            // 
            // tabDispStock
            // 
            this.tabDispStock.Controls.Add(this.tabPgSoldStock);
            this.tabDispStock.Controls.Add(this.tabPgAvailStock);
            this.tabDispStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDispStock.Location = new System.Drawing.Point(0, 0);
            this.tabDispStock.Name = "tabDispStock";
            this.tabDispStock.SelectedIndex = 0;
            this.tabDispStock.Size = new System.Drawing.Size(719, 459);
            this.tabDispStock.TabIndex = 2;
            // 
            // tabPgSoldStock
            // 
            this.tabPgSoldStock.Controls.Add(this.label7);
            this.tabPgSoldStock.Controls.Add(this.lstDispStock);
            this.tabPgSoldStock.Location = new System.Drawing.Point(4, 22);
            this.tabPgSoldStock.Name = "tabPgSoldStock";
            this.tabPgSoldStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgSoldStock.Size = new System.Drawing.Size(711, 433);
            this.tabPgSoldStock.TabIndex = 0;
            this.tabPgSoldStock.Text = "Display Products";
            this.tabPgSoldStock.UseVisualStyleBackColor = true;
            this.tabPgSoldStock.Enter += new System.EventHandler(this.tabPgDisplayStock_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(705, 57);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stock Display";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDispStock
            // 
            this.lstDispStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDispStock.FormattingEnabled = true;
            this.lstDispStock.Location = new System.Drawing.Point(3, 58);
            this.lstDispStock.Name = "lstDispStock";
            this.lstDispStock.Size = new System.Drawing.Size(705, 364);
            this.lstDispStock.TabIndex = 0;
            // 
            // tabPgAvailStock
            // 
            this.tabPgAvailStock.Controls.Add(this.chkDispIncomeRecieved);
            this.tabPgAvailStock.Controls.Add(this.chkViewProjctedIncome);
            this.tabPgAvailStock.Controls.Add(this.chkDispUnitSold);
            this.tabPgAvailStock.Location = new System.Drawing.Point(4, 22);
            this.tabPgAvailStock.Name = "tabPgAvailStock";
            this.tabPgAvailStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgAvailStock.Size = new System.Drawing.Size(711, 433);
            this.tabPgAvailStock.TabIndex = 1;
            this.tabPgAvailStock.Text = "Product Display Options";
            this.tabPgAvailStock.UseVisualStyleBackColor = true;
            this.tabPgAvailStock.Enter += new System.EventHandler(this.tabPgDispStockOptions_Click);
            // 
            // chkDispIncomeRecieved
            // 
            this.chkDispIncomeRecieved.AutoSize = true;
            this.chkDispIncomeRecieved.Location = new System.Drawing.Point(27, 142);
            this.chkDispIncomeRecieved.Name = "chkDispIncomeRecieved";
            this.chkDispIncomeRecieved.Size = new System.Drawing.Size(186, 17);
            this.chkDispIncomeRecieved.TabIndex = 2;
            this.chkDispIncomeRecieved.Text = "Display income from sold products";
            this.chkDispIncomeRecieved.UseVisualStyleBackColor = true;
            // 
            // chkViewProjctedIncome
            // 
            this.chkViewProjctedIncome.AutoSize = true;
            this.chkViewProjctedIncome.Location = new System.Drawing.Point(27, 92);
            this.chkViewProjctedIncome.Name = "chkViewProjctedIncome";
            this.chkViewProjctedIncome.Size = new System.Drawing.Size(257, 17);
            this.chkViewProjctedIncome.TabIndex = 1;
            this.chkViewProjctedIncome.Text = "Display Expected income from available products";
            this.chkViewProjctedIncome.UseVisualStyleBackColor = true;
            // 
            // chkDispUnitSold
            // 
            this.chkDispUnitSold.AutoSize = true;
            this.chkDispUnitSold.Location = new System.Drawing.Point(27, 49);
            this.chkDispUnitSold.Name = "chkDispUnitSold";
            this.chkDispUnitSold.Size = new System.Drawing.Size(109, 17);
            this.chkDispUnitSold.TabIndex = 0;
            this.chkDispUnitSold.Text = "Display Units sold";
            this.chkDispUnitSold.UseVisualStyleBackColor = true;
            // 
            // frmDispStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 497);
            this.ControlBox = false;
            this.Controls.Add(this.tabDispStock);
            this.Controls.Add(this.btnDispFinish);
            this.Name = "frmDispStock";
            this.ShowInTaskbar = false;
            this.Text = "Stock Statistics";
            this.Load += new System.EventHandler(this.frnDispStock_Load);
            this.tabDispStock.ResumeLayout(false);
            this.tabPgSoldStock.ResumeLayout(false);
            this.tabPgAvailStock.ResumeLayout(false);
            this.tabPgAvailStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDispFinish;
        private System.Windows.Forms.TabControl tabDispStock;
        private System.Windows.Forms.TabPage tabPgSoldStock;
        private System.Windows.Forms.TabPage tabPgAvailStock;
        private System.Windows.Forms.CheckBox chkDispIncomeRecieved;
        private System.Windows.Forms.CheckBox chkViewProjctedIncome;
        private System.Windows.Forms.CheckBox chkDispUnitSold;
        private System.Windows.Forms.ListBox lstDispStock;
        private System.Windows.Forms.Label label7;
    }
}