﻿namespace Weaselware.InventoryFerret.UserControls
{
    partial class OrderHeaderVerticalControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPurchaser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAttention = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOtherFees = new System.Windows.Forms.TextBox();
            this.NetTotalLabel = new System.Windows.Forms.Label();
            this.cbTaxable = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.POLabel = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.lbTaxRate = new System.Windows.Forms.Label();
            this.gbCOst = new System.Windows.Forms.GroupBox();
            this.gbSpecialnstruction = new System.Windows.Forms.GroupBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFax = new System.Windows.Forms.MaskedTextBox();
            this.gbCOst.SuspendLayout();
            this.gbSpecialnstruction.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(14, 19);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.ReadOnly = true;
            this.txtJobName.Size = new System.Drawing.Size(258, 20);
            this.txtJobName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phone#";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(218, 73);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(89, 20);
            this.txtZip.TabIndex = 11;
            this.txtZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(177, 73);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(37, 20);
            this.txtState.TabIndex = 13;
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(18, 73);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(155, 20);
            this.txtCity.TabIndex = 14;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(18, 49);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.ReadOnly = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(289, 20);
            this.txtSupplierAddress.TabIndex = 15;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(18, 25);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(289, 20);
            this.txtSupplierName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Purchased By";
            // 
            // txtPurchaser
            // 
            this.txtPurchaser.Location = new System.Drawing.Point(121, 75);
            this.txtPurchaser.Name = "txtPurchaser";
            this.txtPurchaser.Size = new System.Drawing.Size(151, 20);
            this.txtPurchaser.TabIndex = 20;
            this.txtPurchaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Attention";
            // 
            // txtAttention
            // 
            this.txtAttention.Location = new System.Drawing.Point(120, 100);
            this.txtAttention.Name = "txtAttention";
            this.txtAttention.Size = new System.Drawing.Size(152, 20);
            this.txtAttention.TabIndex = 22;
            this.txtAttention.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(7, 17);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(268, 85);
            this.txtMemo.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Other Cost/Fees";
            // 
            // txtOtherFees
            // 
            this.txtOtherFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOtherFees.Location = new System.Drawing.Point(173, 85);
            this.txtOtherFees.Margin = new System.Windows.Forms.Padding(2);
            this.txtOtherFees.Name = "txtOtherFees";
            this.txtOtherFees.Size = new System.Drawing.Size(100, 20);
            this.txtOtherFees.TabIndex = 26;
            this.txtOtherFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NetTotalLabel
            // 
            this.NetTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NetTotalLabel.AutoSize = true;
            this.NetTotalLabel.Location = new System.Drawing.Point(87, 19);
            this.NetTotalLabel.Name = "NetTotalLabel";
            this.NetTotalLabel.Size = new System.Drawing.Size(82, 13);
            this.NetTotalLabel.TabIndex = 37;
            this.NetTotalLabel.Text = "Line Items Total";
            // 
            // cbTaxable
            // 
            this.cbTaxable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTaxable.AutoSize = true;
            this.cbTaxable.Location = new System.Drawing.Point(105, 40);
            this.cbTaxable.Name = "cbTaxable";
            this.cbTaxable.Size = new System.Drawing.Size(64, 17);
            this.cbTaxable.TabIndex = 36;
            this.cbTaxable.Text = "Taxable";
            this.cbTaxable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Order Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date";
            // 
            // POLabel
            // 
            this.POLabel.AutoSize = true;
            this.POLabel.Location = new System.Drawing.Point(12, 51);
            this.POLabel.Name = "POLabel";
            this.POLabel.Size = new System.Drawing.Size(29, 13);
            this.POLabel.TabIndex = 35;
            this.POLabel.Text = "PO#";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubTotal.Location = new System.Drawing.Point(173, 16);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 28;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderTotal.Location = new System.Drawing.Point(173, 108);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrderTotal.TabIndex = 29;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTax.Location = new System.Drawing.Point(173, 39);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 30;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(175, 48);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(97, 20);
            this.txtOrderDate.TabIndex = 31;
            this.txtOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(45, 48);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(93, 20);
            this.txtOrderNumber.TabIndex = 32;
            this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaxRate.Location = new System.Drawing.Point(173, 62);
            this.txtTaxRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 38;
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTaxRate
            // 
            this.lbTaxRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTaxRate.AutoSize = true;
            this.lbTaxRate.Location = new System.Drawing.Point(118, 65);
            this.lbTaxRate.Name = "lbTaxRate";
            this.lbTaxRate.Size = new System.Drawing.Size(51, 13);
            this.lbTaxRate.TabIndex = 39;
            this.lbTaxRate.Text = "Tax Rate";
            // 
            // gbCOst
            // 
            this.gbCOst.BackColor = System.Drawing.Color.Transparent;
            this.gbCOst.Controls.Add(this.txtSubTotal);
            this.gbCOst.Controls.Add(this.lbTaxRate);
            this.gbCOst.Controls.Add(this.txtOtherFees);
            this.gbCOst.Controls.Add(this.txtTaxRate);
            this.gbCOst.Controls.Add(this.label10);
            this.gbCOst.Controls.Add(this.NetTotalLabel);
            this.gbCOst.Controls.Add(this.txtTax);
            this.gbCOst.Controls.Add(this.cbTaxable);
            this.gbCOst.Controls.Add(this.txtOrderTotal);
            this.gbCOst.Controls.Add(this.label8);
            this.gbCOst.Location = new System.Drawing.Point(18, 444);
            this.gbCOst.Name = "gbCOst";
            this.gbCOst.Size = new System.Drawing.Size(286, 155);
            this.gbCOst.TabIndex = 40;
            this.gbCOst.TabStop = false;
            this.gbCOst.Text = "Cost Factors";
            // 
            // gbSpecialnstruction
            // 
            this.gbSpecialnstruction.Controls.Add(this.txtMemo);
            this.gbSpecialnstruction.Location = new System.Drawing.Point(18, 327);
            this.gbSpecialnstruction.Name = "gbSpecialnstruction";
            this.gbSpecialnstruction.Padding = new System.Windows.Forms.Padding(6);
            this.gbSpecialnstruction.Size = new System.Drawing.Size(286, 111);
            this.gbSpecialnstruction.TabIndex = 41;
            this.gbSpecialnstruction.TabStop = false;
            this.gbSpecialnstruction.Text = "Special Instruction";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtOrderDate);
            this.gbDetails.Controls.Add(this.txtPurchaser);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.txtAttention);
            this.gbDetails.Controls.Add(this.txtJobName);
            this.gbDetails.Controls.Add(this.POLabel);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.txtOrderNumber);
            this.gbDetails.Location = new System.Drawing.Point(18, 183);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(285, 137);
            this.gbDetails.TabIndex = 42;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Order Details";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(82, 124);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(225, 20);
            this.txtAccountNumber.TabIndex = 43;
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Acct. No";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(18, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
            this.button1.TabIndex = 47;
            this.button1.Text = "Clone";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupplier.Image = global::Weaselware.InventoryFerret.Properties.Resources.outline_message_black_24dp2;
            this.btnEditSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSupplier.Location = new System.Drawing.Point(193, 150);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(114, 27);
            this.btnEditSupplier.TabIndex = 48;
            this.btnEditSupplier.Text = "Edit Supplier";
            this.btnEditSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_save_black_24dp1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(177, 616);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 29);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save Changes";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::Weaselware.InventoryFerret.Properties.Resources.round_print_black_24dp;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(101, 616);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(71, 29);
            this.btnPrint.TabIndex = 45;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(89, 97);
            this.mtxtPhone.Mask = "(999) 000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.ReadOnly = true;
            this.mtxtPhone.Size = new System.Drawing.Size(83, 20);
            this.mtxtPhone.TabIndex = 49;
            // 
            // mtxtFax
            // 
            this.mtxtFax.Location = new System.Drawing.Point(218, 97);
            this.mtxtFax.Mask = "(999) 000-0000";
            this.mtxtFax.Name = "mtxtFax";
            this.mtxtFax.ReadOnly = true;
            this.mtxtFax.Size = new System.Drawing.Size(89, 20);
            this.mtxtFax.TabIndex = 50;
            // 
            // OrderHeaderVerticalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtxtFax);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbSpecialnstruction);
            this.Controls.Add(this.gbCOst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.MinimumSize = new System.Drawing.Size(325, 0);
            this.Name = "OrderHeaderVerticalControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(325, 711);
            this.Load += new System.EventHandler(this.OrderHeaderVerticalControl_Load);
            this.gbCOst.ResumeLayout(false);
            this.gbCOst.PerformLayout();
            this.gbSpecialnstruction.ResumeLayout(false);
            this.gbSpecialnstruction.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPurchaser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAttention;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOtherFees;
        private System.Windows.Forms.Label NetTotalLabel;
        private System.Windows.Forms.CheckBox cbTaxable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label POLabel;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label lbTaxRate;
        private System.Windows.Forms.GroupBox gbCOst;
        private System.Windows.Forms.GroupBox gbSpecialnstruction;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.MaskedTextBox mtxtFax;
    }
}
