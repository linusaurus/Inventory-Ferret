namespace Weaselware.InventoryFerret
{
    partial class ClaimControl
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
            this.dgClaimItems = new System.Windows.Forms.DataGridView();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.tbSupplierOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPurchaseOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.JobName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrderDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClaimDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDefectDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAttachDocument = new System.Windows.Forms.Button();
            this.btnShowDocuments = new System.Windows.Forms.Button();
            this.txtClaimID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCloseClaim = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ClaimItemID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bcode_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RejectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgClaimItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClaimItems
            // 
            this.dgClaimItems.AllowUserToAddRows = false;
            this.dgClaimItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClaimItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClaimItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaimItemID_col,
            this.LineID_col,
            this.Description_col,
            this.Bcode_col,
            this.PartID_col,
            this.RejectColumn});
            this.dgClaimItems.Location = new System.Drawing.Point(11, 124);
            this.dgClaimItems.Name = "dgClaimItems";
            this.dgClaimItems.Size = new System.Drawing.Size(810, 310);
            this.dgClaimItems.TabIndex = 0;
            this.dgClaimItems.SelectionChanged += new System.EventHandler(this.dgClaimItems_SelectionChanged);
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(797, 11);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 14;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(82, 30);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(230, 20);
            this.tbSupplierName.TabIndex = 0;
            // 
            // tbSupplierOrder
            // 
            this.tbSupplierOrder.BackColor = System.Drawing.SystemColors.Info;
            this.tbSupplierOrder.Location = new System.Drawing.Point(335, 30);
            this.tbSupplierOrder.Name = "tbSupplierOrder";
            this.tbSupplierOrder.Size = new System.Drawing.Size(98, 20);
            this.tbSupplierOrder.TabIndex = 0;
            this.tbSupplierOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Supplier Order#";
            // 
            // tbPurchaseOrder
            // 
            this.tbPurchaseOrder.Location = new System.Drawing.Point(439, 30);
            this.tbPurchaseOrder.Name = "tbPurchaseOrder";
            this.tbPurchaseOrder.ReadOnly = true;
            this.tbPurchaseOrder.Size = new System.Drawing.Size(98, 20);
            this.tbPurchaseOrder.TabIndex = 0;
            this.tbPurchaseOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Purchase Order#";
            // 
            // JobName
            // 
            this.JobName.Location = new System.Drawing.Point(82, 56);
            this.JobName.Name = "JobName";
            this.JobName.ReadOnly = true;
            this.JobName.Size = new System.Drawing.Size(230, 20);
            this.JobName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Job Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbOrderDate
            // 
            this.tbOrderDate.Location = new System.Drawing.Point(543, 30);
            this.tbOrderDate.Name = "tbOrderDate";
            this.tbOrderDate.ReadOnly = true;
            this.tbOrderDate.Size = new System.Drawing.Size(98, 20);
            this.tbOrderDate.TabIndex = 0;
            this.tbOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Order Date";
            // 
            // tbClaimDate
            // 
            this.tbClaimDate.Location = new System.Drawing.Point(227, 82);
            this.tbClaimDate.Name = "tbClaimDate";
            this.tbClaimDate.ReadOnly = true;
            this.tbClaimDate.Size = new System.Drawing.Size(85, 20);
            this.tbClaimDate.TabIndex = 0;
            this.tbClaimDate.Text = "ClaimDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Claim Date";
            // 
            // txtDefectDescription
            // 
            this.txtDefectDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefectDescription.Location = new System.Drawing.Point(150, 461);
            this.txtDefectDescription.Multiline = true;
            this.txtDefectDescription.Name = "txtDefectDescription";
            this.txtDefectDescription.Size = new System.Drawing.Size(392, 48);
            this.txtDefectDescription.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(687, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 47);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAttachDocument
            // 
            this.btnAttachDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttachDocument.Location = new System.Drawing.Point(564, 461);
            this.btnAttachDocument.Name = "btnAttachDocument";
            this.btnAttachDocument.Size = new System.Drawing.Size(118, 23);
            this.btnAttachDocument.TabIndex = 18;
            this.btnAttachDocument.Text = "Attach Document";
            this.btnAttachDocument.UseVisualStyleBackColor = true;
            // 
            // btnShowDocuments
            // 
            this.btnShowDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDocuments.Location = new System.Drawing.Point(564, 486);
            this.btnShowDocuments.Name = "btnShowDocuments";
            this.btnShowDocuments.Size = new System.Drawing.Size(117, 22);
            this.btnShowDocuments.TabIndex = 19;
            this.btnShowDocuments.Text = "Show Documents";
            this.btnShowDocuments.UseVisualStyleBackColor = true;
            // 
            // txtClaimID
            // 
            this.txtClaimID.Location = new System.Drawing.Point(82, 82);
            this.txtClaimID.Name = "txtClaimID";
            this.txtClaimID.ReadOnly = true;
            this.txtClaimID.Size = new System.Drawing.Size(75, 20);
            this.txtClaimID.TabIndex = 0;
            this.txtClaimID.Text = "ClaimID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Claim ID";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(442, 75);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 23);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCloseClaim
            // 
            this.btnCloseClaim.Location = new System.Drawing.Point(541, 75);
            this.btnCloseClaim.Name = "btnCloseClaim";
            this.btnCloseClaim.Size = new System.Drawing.Size(100, 23);
            this.btnCloseClaim.TabIndex = 20;
            this.btnCloseClaim.Text = "Close Claim";
            this.btnCloseClaim.UseVisualStyleBackColor = true;
            this.btnCloseClaim.Click += new System.EventHandler(this.btnCloseClaim_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Defect Description";
            // 
            // ClaimItemID_col
            // 
            this.ClaimItemID_col.DataPropertyName = "ClaimItemID";
            this.ClaimItemID_col.HeaderText = "ClaimItemID";
            this.ClaimItemID_col.Name = "ClaimItemID_col";
            this.ClaimItemID_col.Width = 70;
            // 
            // LineID_col
            // 
            this.LineID_col.DataPropertyName = "LineID";
            this.LineID_col.HeaderText = "LineID";
            this.LineID_col.Name = "LineID_col";
            this.LineID_col.Width = 80;
            // 
            // Description_col
            // 
            this.Description_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description_col.DataPropertyName = "Description";
            this.Description_col.HeaderText = "Description";
            this.Description_col.Name = "Description_col";
            // 
            // Bcode_col
            // 
            this.Bcode_col.DataPropertyName = "Bcode";
            this.Bcode_col.HeaderText = "Bcode";
            this.Bcode_col.Name = "Bcode_col";
            this.Bcode_col.Width = 90;
            // 
            // PartID_col
            // 
            this.PartID_col.DataPropertyName = "PartID";
            this.PartID_col.HeaderText = "PartID";
            this.PartID_col.Name = "PartID_col";
            this.PartID_col.Width = 70;
            // 
            // RejectColumn
            // 
            this.RejectColumn.HeaderText = "Reject";
            this.RejectColumn.Name = "RejectColumn";
            this.RejectColumn.Width = 50;
            // 
            // ClaimControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCloseClaim);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShowDocuments);
            this.Controls.Add(this.btnAttachDocument);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDefectDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.JobName);
            this.Controls.Add(this.txtClaimID);
            this.Controls.Add(this.tbClaimDate);
            this.Controls.Add(this.tbOrderDate);
            this.Controls.Add(this.tbPurchaseOrder);
            this.Controls.Add(this.tbSupplierOrder);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.dgClaimItems);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "ClaimControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(832, 520);
            this.Load += new System.EventHandler(this.ClaimControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClaimItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClaimItems;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.TextBox tbSupplierOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPurchaseOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox JobName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClaimDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDefectDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAttachDocument;
        private System.Windows.Forms.Button btnShowDocuments;
        private System.Windows.Forms.TextBox txtClaimID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCloseClaim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimItemID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bcode_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID_col;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RejectColumn;
    }
}
