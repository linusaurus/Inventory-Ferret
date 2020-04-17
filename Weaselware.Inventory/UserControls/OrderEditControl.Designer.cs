﻿namespace Weaselware.InventoryFerret.UserControls
{
    partial class OrderEditControl
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
            this.dgOrderLineItem = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.purchaseOrderHeaderControl1 = new Weaselware.InventoryFerret.PurchaseOrderHeaderControl();
            this.partFinderControl1 = new Weaselware.InventoryFerret.PartFinderControl();
            this.dgOrderFees = new System.Windows.Forms.DataGridView();
            this.colFeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeQnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbOrderIncidentals = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemoveFee = new System.Windows.Forms.Button();
            this.btnAddOrderFee = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgAttachments = new System.Windows.Forms.DataGridView();
            this.btnAddAttachment = new System.Windows.Forms.Button();
            this.btnOpenAttachment = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteAttachment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderFees)).BeginInit();
            this.tbOrderIncidentals.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrderLineItem
            // 
            this.dgOrderLineItem.AllowUserToAddRows = false;
            this.dgOrderLineItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderLineItem.Location = new System.Drawing.Point(20, 166);
            this.dgOrderLineItem.Name = "dgOrderLineItem";
            this.dgOrderLineItem.Size = new System.Drawing.Size(1018, 330);
            this.dgOrderLineItem.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(918, 758);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(837, 758);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchaseOrderHeaderControl1
            // 
            this.purchaseOrderHeaderControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseOrderHeaderControl1.Location = new System.Drawing.Point(20, 15);
            this.purchaseOrderHeaderControl1.MinimumSize = new System.Drawing.Size(920, 145);
            this.purchaseOrderHeaderControl1.Name = "purchaseOrderHeaderControl1";
            this.purchaseOrderHeaderControl1.PurchaseOrder = null;
            this.purchaseOrderHeaderControl1.Size = new System.Drawing.Size(1018, 145);
            this.purchaseOrderHeaderControl1.TabIndex = 7;
            this.purchaseOrderHeaderControl1.Load += new System.EventHandler(this.purchaseOrderHeaderControl1_Load);
            // 
            // partFinderControl1
            // 
            this.partFinderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partFinderControl1.Location = new System.Drawing.Point(3, 3);
            this.partFinderControl1.Name = "partFinderControl1";
            this.partFinderControl1.SelectedPart = null;
            this.partFinderControl1.Size = new System.Drawing.Size(1009, 223);
            this.partFinderControl1.TabIndex = 9;
            // 
            // dgOrderFees
            // 
            this.dgOrderFees.AllowUserToAddRows = false;
            this.dgOrderFees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrderFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFeeID,
            this.colFeeDescription,
            this.colFeeQnty,
            this.colFeeCost,
            this.colFeeExtension});
            this.dgOrderFees.Location = new System.Drawing.Point(10, 63);
            this.dgOrderFees.Name = "dgOrderFees";
            this.dgOrderFees.Size = new System.Drawing.Size(974, 173);
            this.dgOrderFees.TabIndex = 10;
            // 
            // colFeeID
            // 
            this.colFeeID.HeaderText = "ID";
            this.colFeeID.Name = "colFeeID";
            this.colFeeID.Width = 75;
            // 
            // colFeeDescription
            // 
            this.colFeeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFeeDescription.HeaderText = "Description";
            this.colFeeDescription.Name = "colFeeDescription";
            // 
            // colFeeQnty
            // 
            this.colFeeQnty.HeaderText = "Qnty";
            this.colFeeQnty.Name = "colFeeQnty";
            this.colFeeQnty.Width = 60;
            // 
            // colFeeCost
            // 
            this.colFeeCost.HeaderText = "Cost";
            this.colFeeCost.Name = "colFeeCost";
            this.colFeeCost.Width = 60;
            // 
            // colFeeExtension
            // 
            this.colFeeExtension.HeaderText = "Ext";
            this.colFeeExtension.Name = "colFeeExtension";
            this.colFeeExtension.Width = 75;
            // 
            // tbOrderIncidentals
            // 
            this.tbOrderIncidentals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderIncidentals.Controls.Add(this.tabPage1);
            this.tbOrderIncidentals.Controls.Add(this.tabPage2);
            this.tbOrderIncidentals.Controls.Add(this.tabPage3);
            this.tbOrderIncidentals.Location = new System.Drawing.Point(20, 513);
            this.tbOrderIncidentals.Name = "tbOrderIncidentals";
            this.tbOrderIncidentals.SelectedIndex = 0;
            this.tbOrderIncidentals.Size = new System.Drawing.Size(1023, 229);
            this.tbOrderIncidentals.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.partFinderControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Part Lookup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddOrderFee);
            this.tabPage2.Controls.Add(this.btnRemoveFee);
            this.tabPage2.Controls.Add(this.dgOrderFees);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(1015, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fees and Charges";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFee
            // 
            this.btnRemoveFee.Location = new System.Drawing.Point(160, 17);
            this.btnRemoveFee.Name = "btnRemoveFee";
            this.btnRemoveFee.Size = new System.Drawing.Size(104, 23);
            this.btnRemoveFee.TabIndex = 11;
            this.btnRemoveFee.Text = "RemoveFee";
            this.btnRemoveFee.UseVisualStyleBackColor = true;
            // 
            // btnAddOrderFee
            // 
            this.btnAddOrderFee.Location = new System.Drawing.Point(10, 17);
            this.btnAddOrderFee.Name = "btnAddOrderFee";
            this.btnAddOrderFee.Size = new System.Drawing.Size(144, 23);
            this.btnAddOrderFee.TabIndex = 11;
            this.btnAddOrderFee.Text = "Add Fee / Surcharge";
            this.btnAddOrderFee.UseVisualStyleBackColor = true;
            this.btnAddOrderFee.Click += new System.EventHandler(this.btnAddOrderFee_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteAttachment);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.btnOpenAttachment);
            this.tabPage3.Controls.Add(this.btnAddAttachment);
            this.tabPage3.Controls.Add(this.dgAttachments);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage3.Size = new System.Drawing.Size(1015, 203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Attachments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgAttachments
            // 
            this.dgAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttachments.Location = new System.Drawing.Point(10, 68);
            this.dgAttachments.Name = "dgAttachments";
            this.dgAttachments.Size = new System.Drawing.Size(995, 128);
            this.dgAttachments.TabIndex = 0;
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.Location = new System.Drawing.Point(13, 24);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(105, 23);
            this.btnAddAttachment.TabIndex = 1;
            this.btnAddAttachment.Text = "Add Attachment";
            this.btnAddAttachment.UseVisualStyleBackColor = true;
            // 
            // btnOpenAttachment
            // 
            this.btnOpenAttachment.Location = new System.Drawing.Point(124, 24);
            this.btnOpenAttachment.Name = "btnOpenAttachment";
            this.btnOpenAttachment.Size = new System.Drawing.Size(105, 23);
            this.btnOpenAttachment.TabIndex = 1;
            this.btnOpenAttachment.Text = "Open Attachment";
            this.btnOpenAttachment.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(235, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Attachment";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAttachment
            // 
            this.btnDeleteAttachment.Location = new System.Drawing.Point(882, 24);
            this.btnDeleteAttachment.Name = "btnDeleteAttachment";
            this.btnDeleteAttachment.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteAttachment.TabIndex = 1;
            this.btnDeleteAttachment.Text = "Delete Attachment";
            this.btnDeleteAttachment.UseVisualStyleBackColor = true;
            // 
            // OrderEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbOrderIncidentals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.purchaseOrderHeaderControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgOrderLineItem);
            this.MaximumSize = new System.Drawing.Size(1900, 800);
            this.MinimumSize = new System.Drawing.Size(970, 0);
            this.Name = "OrderEditControl";
            this.Size = new System.Drawing.Size(1064, 800);
            this.Load += new System.EventHandler(this.OrderEditControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderFees)).EndInit();
            this.tbOrderIncidentals.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAttachments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrderLineItem;
        private System.Windows.Forms.Button btnSave;
        private PurchaseOrderHeaderControl purchaseOrderHeaderControl1;
        private System.Windows.Forms.Button button1;
        private PartFinderControl partFinderControl1;
        private System.Windows.Forms.DataGridView dgOrderFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeQnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeExtension;
        private System.Windows.Forms.TabControl tbOrderIncidentals;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddOrderFee;
        private System.Windows.Forms.Button btnRemoveFee;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDeleteAttachment;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOpenAttachment;
        private System.Windows.Forms.Button btnAddAttachment;
        private System.Windows.Forms.DataGridView dgAttachments;
    }
}
