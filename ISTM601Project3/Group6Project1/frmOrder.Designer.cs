namespace Group6Project1
{
    partial class frmOrder
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
            this.grpBillingAddress = new System.Windows.Forms.GroupBox();
            this.cboBillingState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillingName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillingStreetAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillingCity = new System.Windows.Forms.TextBox();
            this.txtBillingSubdivision = new System.Windows.Forms.TextBox();
            this.txtBillingPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBillingZipCode = new System.Windows.Forms.TextBox();
            this.grpDeliveryAddress = new System.Windows.Forms.GroupBox();
            this.cboDeliveryState = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeliveryName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDeliveryStreetAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDeliveryCity = new System.Windows.Forms.TextBox();
            this.txtDeliverySubdivision = new System.Windows.Forms.TextBox();
            this.txtDeliveryPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtDeliveryZipCode = new System.Windows.Forms.TextBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.txtVendor = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.picSandwichOrPizza = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.lblBreadCrust = new System.Windows.Forms.Label();
            this.cboBreadCrust = new System.Windows.Forms.ComboBox();
            this.chkDeliveryOrder = new System.Windows.Forms.CheckBox();
            this.grpBillingAddress.SuspendLayout();
            this.grpDeliveryAddress.SuspendLayout();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSandwichOrPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBillingAddress
            // 
            this.grpBillingAddress.Controls.Add(this.cboBillingState);
            this.grpBillingAddress.Controls.Add(this.label7);
            this.grpBillingAddress.Controls.Add(this.txtBillingName);
            this.grpBillingAddress.Controls.Add(this.label6);
            this.grpBillingAddress.Controls.Add(this.label1);
            this.grpBillingAddress.Controls.Add(this.label5);
            this.grpBillingAddress.Controls.Add(this.label2);
            this.grpBillingAddress.Controls.Add(this.label4);
            this.grpBillingAddress.Controls.Add(this.txtBillingStreetAddress);
            this.grpBillingAddress.Controls.Add(this.label3);
            this.grpBillingAddress.Controls.Add(this.txtBillingCity);
            this.grpBillingAddress.Controls.Add(this.txtBillingSubdivision);
            this.grpBillingAddress.Controls.Add(this.txtBillingPhoneNumber);
            this.grpBillingAddress.Controls.Add(this.txtBillingZipCode);
            this.grpBillingAddress.Location = new System.Drawing.Point(31, 36);
            this.grpBillingAddress.Name = "grpBillingAddress";
            this.grpBillingAddress.Size = new System.Drawing.Size(251, 227);
            this.grpBillingAddress.TabIndex = 1;
            this.grpBillingAddress.TabStop = false;
            this.grpBillingAddress.Text = "Billing Address";
            // 
            // cboBillingState
            // 
            this.cboBillingState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBillingState.FormattingEnabled = true;
            this.cboBillingState.Location = new System.Drawing.Point(105, 107);
            this.cboBillingState.Name = "cboBillingState";
            this.cboBillingState.Size = new System.Drawing.Size(100, 21);
            this.cboBillingState.TabIndex = 4;
            this.cboBillingState.Tag = "Billing State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subdivision:";
            // 
            // txtBillingName
            // 
            this.txtBillingName.Location = new System.Drawing.Point(105, 29);
            this.txtBillingName.Name = "txtBillingName";
            this.txtBillingName.Size = new System.Drawing.Size(100, 20);
            this.txtBillingName.TabIndex = 1;
            this.txtBillingName.Tag = "Billing Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Zip code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "State:";
            // 
            // txtBillingStreetAddress
            // 
            this.txtBillingStreetAddress.Location = new System.Drawing.Point(105, 55);
            this.txtBillingStreetAddress.Name = "txtBillingStreetAddress";
            this.txtBillingStreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBillingStreetAddress.TabIndex = 2;
            this.txtBillingStreetAddress.Tag = "Billing Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "City:";
            // 
            // txtBillingCity
            // 
            this.txtBillingCity.Location = new System.Drawing.Point(105, 81);
            this.txtBillingCity.Name = "txtBillingCity";
            this.txtBillingCity.Size = new System.Drawing.Size(100, 20);
            this.txtBillingCity.TabIndex = 3;
            this.txtBillingCity.Tag = "Billing City";
            // 
            // txtBillingSubdivision
            // 
            this.txtBillingSubdivision.Location = new System.Drawing.Point(105, 186);
            this.txtBillingSubdivision.Name = "txtBillingSubdivision";
            this.txtBillingSubdivision.Size = new System.Drawing.Size(100, 20);
            this.txtBillingSubdivision.TabIndex = 7;
            this.txtBillingSubdivision.Tag = "Billing Subdivision";
            // 
            // txtBillingPhoneNumber
            // 
            this.txtBillingPhoneNumber.Location = new System.Drawing.Point(105, 160);
            this.txtBillingPhoneNumber.MaxLength = 10;
            this.txtBillingPhoneNumber.Name = "txtBillingPhoneNumber";
            this.txtBillingPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBillingPhoneNumber.TabIndex = 6;
            this.txtBillingPhoneNumber.Tag = "Billing Phone Number";
            // 
            // txtBillingZipCode
            // 
            this.txtBillingZipCode.Location = new System.Drawing.Point(105, 134);
            this.txtBillingZipCode.MaxLength = 5;
            this.txtBillingZipCode.Name = "txtBillingZipCode";
            this.txtBillingZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtBillingZipCode.TabIndex = 5;
            this.txtBillingZipCode.Tag = "Billing Zip Code";
            // 
            // grpDeliveryAddress
            // 
            this.grpDeliveryAddress.Controls.Add(this.cboDeliveryState);
            this.grpDeliveryAddress.Controls.Add(this.label8);
            this.grpDeliveryAddress.Controls.Add(this.txtDeliveryName);
            this.grpDeliveryAddress.Controls.Add(this.label9);
            this.grpDeliveryAddress.Controls.Add(this.label10);
            this.grpDeliveryAddress.Controls.Add(this.label11);
            this.grpDeliveryAddress.Controls.Add(this.label12);
            this.grpDeliveryAddress.Controls.Add(this.label13);
            this.grpDeliveryAddress.Controls.Add(this.txtDeliveryStreetAddress);
            this.grpDeliveryAddress.Controls.Add(this.label14);
            this.grpDeliveryAddress.Controls.Add(this.txtDeliveryCity);
            this.grpDeliveryAddress.Controls.Add(this.txtDeliverySubdivision);
            this.grpDeliveryAddress.Controls.Add(this.txtDeliveryPhoneNumber);
            this.grpDeliveryAddress.Controls.Add(this.txtDeliveryZipCode);
            this.grpDeliveryAddress.Location = new System.Drawing.Point(327, 36);
            this.grpDeliveryAddress.Name = "grpDeliveryAddress";
            this.grpDeliveryAddress.Size = new System.Drawing.Size(251, 227);
            this.grpDeliveryAddress.TabIndex = 3;
            this.grpDeliveryAddress.TabStop = false;
            this.grpDeliveryAddress.Text = "Delivery Address";
            // 
            // cboDeliveryState
            // 
            this.cboDeliveryState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliveryState.FormattingEnabled = true;
            this.cboDeliveryState.Location = new System.Drawing.Point(105, 107);
            this.cboDeliveryState.Name = "cboDeliveryState";
            this.cboDeliveryState.Size = new System.Drawing.Size(100, 21);
            this.cboDeliveryState.TabIndex = 4;
            this.cboDeliveryState.Tag = "Delivery State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Subdivision:";
            // 
            // txtDeliveryName
            // 
            this.txtDeliveryName.Location = new System.Drawing.Point(105, 29);
            this.txtDeliveryName.Name = "txtDeliveryName";
            this.txtDeliveryName.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryName.TabIndex = 1;
            this.txtDeliveryName.Tag = "Delivery Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Phone number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Zip code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Street address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "State:";
            // 
            // txtDeliveryStreetAddress
            // 
            this.txtDeliveryStreetAddress.Location = new System.Drawing.Point(105, 55);
            this.txtDeliveryStreetAddress.Name = "txtDeliveryStreetAddress";
            this.txtDeliveryStreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryStreetAddress.TabIndex = 2;
            this.txtDeliveryStreetAddress.Tag = "Delivery Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "City:";
            // 
            // txtDeliveryCity
            // 
            this.txtDeliveryCity.Location = new System.Drawing.Point(105, 81);
            this.txtDeliveryCity.Name = "txtDeliveryCity";
            this.txtDeliveryCity.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryCity.TabIndex = 3;
            this.txtDeliveryCity.Tag = "Delivery City";
            // 
            // txtDeliverySubdivision
            // 
            this.txtDeliverySubdivision.Location = new System.Drawing.Point(105, 186);
            this.txtDeliverySubdivision.Name = "txtDeliverySubdivision";
            this.txtDeliverySubdivision.Size = new System.Drawing.Size(100, 20);
            this.txtDeliverySubdivision.TabIndex = 7;
            this.txtDeliverySubdivision.Tag = "Delivery Subdivision";
            // 
            // txtDeliveryPhoneNumber
            // 
            this.txtDeliveryPhoneNumber.Location = new System.Drawing.Point(105, 160);
            this.txtDeliveryPhoneNumber.MaxLength = 10;
            this.txtDeliveryPhoneNumber.Name = "txtDeliveryPhoneNumber";
            this.txtDeliveryPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryPhoneNumber.TabIndex = 6;
            this.txtDeliveryPhoneNumber.Tag = "Delivery Phone Number";
            // 
            // txtDeliveryZipCode
            // 
            this.txtDeliveryZipCode.Location = new System.Drawing.Point(105, 134);
            this.txtDeliveryZipCode.MaxLength = 5;
            this.txtDeliveryZipCode.Name = "txtDeliveryZipCode";
            this.txtDeliveryZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryZipCode.TabIndex = 5;
            this.txtDeliveryZipCode.Tag = "Delivery Zip Code";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.txtVendor);
            this.grpMenu.Controls.Add(this.label15);
            this.grpMenu.Controls.Add(this.txtTax);
            this.grpMenu.Controls.Add(this.label20);
            this.grpMenu.Controls.Add(this.txtOrderTotal);
            this.grpMenu.Controls.Add(this.label19);
            this.grpMenu.Controls.Add(this.label18);
            this.grpMenu.Controls.Add(this.txtSubtotal);
            this.grpMenu.Controls.Add(this.picSandwichOrPizza);
            this.grpMenu.Controls.Add(this.btnClose);
            this.grpMenu.Controls.Add(this.btnClear);
            this.grpMenu.Controls.Add(this.btnProcess);
            this.grpMenu.Controls.Add(this.btnAddItem);
            this.grpMenu.Controls.Add(this.label17);
            this.grpMenu.Controls.Add(this.txtQuantity);
            this.grpMenu.Controls.Add(this.lstOrder);
            this.grpMenu.Controls.Add(this.label16);
            this.grpMenu.Controls.Add(this.cboItem);
            this.grpMenu.Controls.Add(this.lblBreadCrust);
            this.grpMenu.Controls.Add(this.cboBreadCrust);
            this.grpMenu.Location = new System.Drawing.Point(31, 292);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(547, 267);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu";
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(466, 238);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(75, 23);
            this.txtVendor.TabIndex = 33;
            this.txtVendor.Text = "Vendor";
            this.txtVendor.UseVisualStyleBackColor = true;
            this.txtVendor.Click += new System.EventHandler(this.txtVendor_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(435, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Tax:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(469, 165);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(72, 20);
            this.txtTax.TabIndex = 0;
            this.txtTax.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(358, 196);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "Order Total:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(427, 193);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(114, 20);
            this.txtOrderTotal.TabIndex = 0;
            this.txtOrderTotal.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(277, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Order:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(343, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Order Total Before Tax: ";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(469, 139);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(72, 20);
            this.txtSubtotal.TabIndex = 0;
            this.txtSubtotal.TabStop = false;
            // 
            // picSandwichOrPizza
            // 
            this.picSandwichOrPizza.Location = new System.Drawing.Point(105, 33);
            this.picSandwichOrPizza.Name = "picSandwichOrPizza";
            this.picSandwichOrPizza.Size = new System.Drawing.Size(166, 95);
            this.picSandwichOrPizza.TabIndex = 26;
            this.picSandwichOrPizza.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(131, 231);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(131, 202);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(106, 23);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process Order";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(9, 202);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(106, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item To Order";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(61, 93);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(38, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Tag = "Quantity ";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(277, 33);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(264, 95);
            this.lstOrder.TabIndex = 0;
            this.lstOrder.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Item:";
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(50, 143);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(187, 21);
            this.cboItem.TabIndex = 2;
            this.cboItem.Tag = "Item ComboBox";
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // lblBreadCrust
            // 
            this.lblBreadCrust.AutoSize = true;
            this.lblBreadCrust.Location = new System.Drawing.Point(6, 174);
            this.lblBreadCrust.Name = "lblBreadCrust";
            this.lblBreadCrust.Size = new System.Drawing.Size(38, 13);
            this.lblBreadCrust.TabIndex = 17;
            this.lblBreadCrust.Text = "Bread:";
            // 
            // cboBreadCrust
            // 
            this.cboBreadCrust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBreadCrust.FormattingEnabled = true;
            this.cboBreadCrust.Location = new System.Drawing.Point(50, 171);
            this.cboBreadCrust.Name = "cboBreadCrust";
            this.cboBreadCrust.Size = new System.Drawing.Size(187, 21);
            this.cboBreadCrust.TabIndex = 3;
            this.cboBreadCrust.Tag = "Bread/Crust Combobox";
            // 
            // chkDeliveryOrder
            // 
            this.chkDeliveryOrder.AutoSize = true;
            this.chkDeliveryOrder.Location = new System.Drawing.Point(69, 269);
            this.chkDeliveryOrder.Name = "chkDeliveryOrder";
            this.chkDeliveryOrder.Size = new System.Drawing.Size(119, 17);
            this.chkDeliveryOrder.TabIndex = 2;
            this.chkDeliveryOrder.Tag = "Delivery Checkbox";
            this.chkDeliveryOrder.Text = "Delivery Requested";
            this.chkDeliveryOrder.UseVisualStyleBackColor = true;
            this.chkDeliveryOrder.CheckedChanged += new System.EventHandler(this.chkDeliveryOrder_CheckedChanged);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 570);
            this.Controls.Add(this.chkDeliveryOrder);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grpDeliveryAddress);
            this.Controls.Add(this.grpBillingAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirby\'s Deli Order Form";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpBillingAddress.ResumeLayout(false);
            this.grpBillingAddress.PerformLayout();
            this.grpDeliveryAddress.ResumeLayout(false);
            this.grpDeliveryAddress.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSandwichOrPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBillingAddress;
        private System.Windows.Forms.ComboBox cboBillingState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillingName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillingStreetAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillingCity;
        private System.Windows.Forms.TextBox txtBillingSubdivision;
        private System.Windows.Forms.GroupBox grpDeliveryAddress;
        private System.Windows.Forms.ComboBox cboDeliveryState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeliveryName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDeliveryStreetAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDeliveryCity;
        private System.Windows.Forms.TextBox txtDeliverySubdivision;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.PictureBox picSandwichOrPizza;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label lblBreadCrust;
        private System.Windows.Forms.ComboBox cboBreadCrust;
        private System.Windows.Forms.CheckBox chkDeliveryOrder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtBillingPhoneNumber;
        private System.Windows.Forms.TextBox txtBillingZipCode;
        private System.Windows.Forms.TextBox txtDeliveryPhoneNumber;
        private System.Windows.Forms.TextBox txtDeliveryZipCode;
        private System.Windows.Forms.Button txtVendor;
    }
}

