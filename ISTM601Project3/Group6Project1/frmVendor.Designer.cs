namespace Group6Project1
{
    partial class frmVendor
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
            this.btnNextVendor = new System.Windows.Forms.Button();
            this.btnPreviousVendor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtYTDSales = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalesRep = new System.Windows.Forms.TextBox();
            this.grpVendor = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.grpDiscount = new System.Windows.Forms.GroupBox();
            this.rdo10Days = new System.Windows.Forms.RadioButton();
            this.rdo20Days = new System.Windows.Forms.RadioButton();
            this.rdo15Days = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpVendor.SuspendLayout();
            this.grpDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNextVendor
            // 
            this.btnNextVendor.Location = new System.Drawing.Point(195, 12);
            this.btnNextVendor.Name = "btnNextVendor";
            this.btnNextVendor.Size = new System.Drawing.Size(94, 23);
            this.btnNextVendor.TabIndex = 1;
            this.btnNextVendor.Text = "Next Vendor";
            this.btnNextVendor.UseVisualStyleBackColor = true;
            this.btnNextVendor.Click += new System.EventHandler(this.btnNextVendor_Click);
            // 
            // btnPreviousVendor
            // 
            this.btnPreviousVendor.Location = new System.Drawing.Point(95, 12);
            this.btnPreviousVendor.Name = "btnPreviousVendor";
            this.btnPreviousVendor.Size = new System.Drawing.Size(94, 23);
            this.btnPreviousVendor.TabIndex = 0;
            this.btnPreviousVendor.Text = "Previous Vendor";
            this.btnPreviousVendor.UseVisualStyleBackColor = true;
            this.btnPreviousVendor.Click += new System.EventHandler(this.btnPreviousVendor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Street Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zip Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "YTD Sales:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Comments:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "Name";
            this.txtName.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(95, 45);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(252, 20);
            this.txtStreetAddress.TabIndex = 1;
            this.txtStreetAddress.Tag = "Street Address";
            this.txtStreetAddress.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(95, 71);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(252, 20);
            this.txtCity.TabIndex = 2;
            this.txtCity.Tag = "City";
            this.txtCity.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(95, 97);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(252, 20);
            this.txtState.TabIndex = 3;
            this.txtState.Tag = "State";
            this.txtState.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtYTDSales
            // 
            this.txtYTDSales.Location = new System.Drawing.Point(95, 203);
            this.txtYTDSales.Name = "txtYTDSales";
            this.txtYTDSales.Size = new System.Drawing.Size(252, 20);
            this.txtYTDSales.TabIndex = 7;
            this.txtYTDSales.Tag = "YTD Sales";
            this.txtYTDSales.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(95, 229);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(252, 20);
            this.txtComments.TabIndex = 8;
            this.txtComments.Tag = "Comments";
            this.txtComments.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sales Rep:";
            // 
            // txtSalesRep
            // 
            this.txtSalesRep.Location = new System.Drawing.Point(95, 149);
            this.txtSalesRep.Name = "txtSalesRep";
            this.txtSalesRep.Size = new System.Drawing.Size(252, 20);
            this.txtSalesRep.TabIndex = 5;
            this.txtSalesRep.Tag = "Sales Rep";
            this.txtSalesRep.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // grpVendor
            // 
            this.grpVendor.Controls.Add(this.txtPhoneNumber);
            this.grpVendor.Controls.Add(this.txtZipCode);
            this.grpVendor.Controls.Add(this.grpDiscount);
            this.grpVendor.Controls.Add(this.txtName);
            this.grpVendor.Controls.Add(this.txtSalesRep);
            this.grpVendor.Controls.Add(this.label1);
            this.grpVendor.Controls.Add(this.label9);
            this.grpVendor.Controls.Add(this.label2);
            this.grpVendor.Controls.Add(this.txtComments);
            this.grpVendor.Controls.Add(this.label3);
            this.grpVendor.Controls.Add(this.txtYTDSales);
            this.grpVendor.Controls.Add(this.label4);
            this.grpVendor.Controls.Add(this.label5);
            this.grpVendor.Controls.Add(this.label6);
            this.grpVendor.Controls.Add(this.txtState);
            this.grpVendor.Controls.Add(this.label7);
            this.grpVendor.Controls.Add(this.txtCity);
            this.grpVendor.Controls.Add(this.label8);
            this.grpVendor.Controls.Add(this.txtStreetAddress);
            this.grpVendor.Location = new System.Drawing.Point(12, 41);
            this.grpVendor.Name = "grpVendor";
            this.grpVendor.Size = new System.Drawing.Size(374, 317);
            this.grpVendor.TabIndex = 2;
            this.grpVendor.TabStop = false;
            this.grpVendor.Text = "Vendor";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(95, 175);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(252, 20);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.Tag = "Phone Number";
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(95, 123);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(252, 20);
            this.txtZipCode.TabIndex = 4;
            this.txtZipCode.Tag = "Zip Code";
            this.txtZipCode.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // grpDiscount
            // 
            this.grpDiscount.Controls.Add(this.rdo10Days);
            this.grpDiscount.Controls.Add(this.rdo20Days);
            this.grpDiscount.Controls.Add(this.rdo15Days);
            this.grpDiscount.Location = new System.Drawing.Point(33, 255);
            this.grpDiscount.Name = "grpDiscount";
            this.grpDiscount.Size = new System.Drawing.Size(297, 49);
            this.grpDiscount.TabIndex = 26;
            this.grpDiscount.TabStop = false;
            this.grpDiscount.Text = "Discount Period";
            // 
            // rdo10Days
            // 
            this.rdo10Days.AutoSize = true;
            this.rdo10Days.Location = new System.Drawing.Point(33, 19);
            this.rdo10Days.Name = "rdo10Days";
            this.rdo10Days.Size = new System.Drawing.Size(64, 17);
            this.rdo10Days.TabIndex = 0;
            this.rdo10Days.TabStop = true;
            this.rdo10Days.Text = "10 Days";
            this.rdo10Days.UseVisualStyleBackColor = true;
            this.rdo10Days.CheckedChanged += new System.EventHandler(this.rdo10Days_CheckedChanged);
            // 
            // rdo20Days
            // 
            this.rdo20Days.AutoSize = true;
            this.rdo20Days.Location = new System.Drawing.Point(203, 19);
            this.rdo20Days.Name = "rdo20Days";
            this.rdo20Days.Size = new System.Drawing.Size(64, 17);
            this.rdo20Days.TabIndex = 2;
            this.rdo20Days.TabStop = true;
            this.rdo20Days.Text = "20 Days";
            this.rdo20Days.UseVisualStyleBackColor = true;
            this.rdo20Days.CheckedChanged += new System.EventHandler(this.rdo20Days_CheckedChanged);
            // 
            // rdo15Days
            // 
            this.rdo15Days.AutoSize = true;
            this.rdo15Days.Location = new System.Drawing.Point(119, 19);
            this.rdo15Days.Name = "rdo15Days";
            this.rdo15Days.Size = new System.Drawing.Size(64, 17);
            this.rdo15Days.TabIndex = 1;
            this.rdo15Days.TabStop = true;
            this.rdo15Days.Text = "15 Days";
            this.rdo15Days.UseVisualStyleBackColor = true;
            this.rdo15Days.CheckedChanged += new System.EventHandler(this.rdo15Days_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(225, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(408, 418);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpVendor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPreviousVendor);
            this.Controls.Add(this.btnNextVendor);
            this.Name = "frmVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVendor_FormClosing);
            this.grpVendor.ResumeLayout(false);
            this.grpVendor.PerformLayout();
            this.grpDiscount.ResumeLayout(false);
            this.grpDiscount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNextVendor;
        private System.Windows.Forms.Button btnPreviousVendor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtYTDSales;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalesRep;
        private System.Windows.Forms.GroupBox grpVendor;
        private System.Windows.Forms.GroupBox grpDiscount;
        private System.Windows.Forms.RadioButton rdo10Days;
        private System.Windows.Forms.RadioButton rdo20Days;
        private System.Windows.Forms.RadioButton rdo15Days;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}