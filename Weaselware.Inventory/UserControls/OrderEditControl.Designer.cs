namespace Weaselware.InventoryFerret.UserControls
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
            this.txtLoadOrder = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.purchaseOrderHeaderControl1 = new Weaselware.InventoryFerret.PurchaseOrderHeaderControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrderLineItem
            // 
            this.dgOrderLineItem.AllowUserToAddRows = false;
            this.dgOrderLineItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderLineItem.Location = new System.Drawing.Point(20, 165);
            this.dgOrderLineItem.Name = "dgOrderLineItem";
            this.dgOrderLineItem.Size = new System.Drawing.Size(925, 395);
            this.dgOrderLineItem.TabIndex = 0;
            // 
            // txtLoadOrder
            // 
            this.txtLoadOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLoadOrder.Location = new System.Drawing.Point(110, 575);
            this.txtLoadOrder.Name = "txtLoadOrder";
            this.txtLoadOrder.Size = new System.Drawing.Size(86, 20);
            this.txtLoadOrder.TabIndex = 1;
            this.txtLoadOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(870, 575);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadOrder.Location = new System.Drawing.Point(20, 573);
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.Size = new System.Drawing.Size(84, 23);
            this.btnLoadOrder.TabIndex = 6;
            this.btnLoadOrder.Text = "Load Order";
            this.btnLoadOrder.UseVisualStyleBackColor = true;
            this.btnLoadOrder.Click += new System.EventHandler(this.btnLoadOrder_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(789, 575);
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
            this.purchaseOrderHeaderControl1.Size = new System.Drawing.Size(925, 145);
            this.purchaseOrderHeaderControl1.TabIndex = 7;
            this.purchaseOrderHeaderControl1.Load += new System.EventHandler(this.purchaseOrderHeaderControl1_Load);
            // 
            // OrderEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.purchaseOrderHeaderControl1);
            this.Controls.Add(this.btnLoadOrder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLoadOrder);
            this.Controls.Add(this.dgOrderLineItem);
            this.MaximumSize = new System.Drawing.Size(1900, 800);
            this.MinimumSize = new System.Drawing.Size(970, 0);
            this.Name = "OrderEditControl";
            this.Size = new System.Drawing.Size(971, 617);
            this.Load += new System.EventHandler(this.OrderEditControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrderLineItem;
        private System.Windows.Forms.TextBox txtLoadOrder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadOrder;
        private PurchaseOrderHeaderControl purchaseOrderHeaderControl1;
        private System.Windows.Forms.Button button1;
    }
}
