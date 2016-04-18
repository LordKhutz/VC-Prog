namespace StockControl_GUI
{
    partial class frmCaptureStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProd_ID = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitsRecieved = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.dtExpDate = new System.Windows.Forms.DateTimePicker();
            this.gbxVolitProd = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.cbxProdType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxVolitProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // txtProd_ID
            // 
            this.txtProd_ID.Location = new System.Drawing.Point(15, 111);
            this.txtProd_ID.Name = "txtProd_ID";
            this.txtProd_ID.Size = new System.Drawing.Size(204, 20);
            this.txtProd_ID.TabIndex = 1;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(15, 166);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(204, 20);
            this.txtProdName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expiry Date";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(15, 270);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(204, 20);
            this.txtUnitPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit Selling Price";
            // 
            // txtUnitsRecieved
            // 
            this.txtUnitsRecieved.Location = new System.Drawing.Point(15, 326);
            this.txtUnitsRecieved.Name = "txtUnitsRecieved";
            this.txtUnitsRecieved.Size = new System.Drawing.Size(204, 20);
            this.txtUnitsRecieved.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Units Recieved";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(478, 349);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtExpDate
            // 
            this.dtExpDate.Location = new System.Drawing.Point(15, 220);
            this.dtExpDate.Name = "dtExpDate";
            this.dtExpDate.Size = new System.Drawing.Size(200, 20);
            this.dtExpDate.TabIndex = 12;
            // 
            // gbxVolitProd
            // 
            this.gbxVolitProd.Controls.Add(this.radNo);
            this.gbxVolitProd.Controls.Add(this.radYes);
            this.gbxVolitProd.Location = new System.Drawing.Point(312, 94);
            this.gbxVolitProd.Name = "gbxVolitProd";
            this.gbxVolitProd.Size = new System.Drawing.Size(240, 100);
            this.gbxVolitProd.TabIndex = 13;
            this.gbxVolitProd.TabStop = false;
            this.gbxVolitProd.Text = "Voletile Product";
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(7, 55);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 1;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(7, 19);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 0;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // cbxProdType
            // 
            this.cbxProdType.FormattingEnabled = true;
            this.cbxProdType.Items.AddRange(new object[] {
            "Food",
            "Hygene",
            "Tools",
            "Kitchen Ware"});
            this.cbxProdType.Location = new System.Drawing.Point(312, 245);
            this.cbxProdType.Name = "cbxProdType";
            this.cbxProdType.Size = new System.Drawing.Size(240, 21);
            this.cbxProdType.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Product Type";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(565, 57);
            this.label7.TabIndex = 16;
            this.label7.Text = "Stock Capture";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCaptureStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 384);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxProdType);
            this.Controls.Add(this.gbxVolitProd);
            this.Controls.Add(this.dtExpDate);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnitsRecieved);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProd_ID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCaptureStock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Capture  Stock";
            this.Load += new System.EventHandler(this.frmCaptureStock_Load);
            this.gbxVolitProd.ResumeLayout(false);
            this.gbxVolitProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProd_ID;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitsRecieved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DateTimePicker dtExpDate;
        private System.Windows.Forms.GroupBox gbxVolitProd;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.ComboBox cbxProdType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}