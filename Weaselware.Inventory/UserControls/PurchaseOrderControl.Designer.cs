namespace Weaselware.InventoryFerret
{
    partial class PurchaseOrderControl
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
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.view = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.purchaseOrderHeaderControl1 = new Weaselware.InventoryFerret.PurchaseOrderHeaderControl();
            this.partFinderControl1 = new Weaselware.InventoryFerret.PartFinderControl();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(1003, 10);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 8;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // view
            // 
            this.view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Location = new System.Drawing.Point(11, 193);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(1016, 261);
            this.view.TabIndex = 11;
            this.view.SelectionChanged += new System.EventHandler(this.view_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(11, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(11, 161);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(124, 23);
            this.btnRemoveItem.TabIndex = 14;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // purchaseOrderHeaderControl1
            // 
            this.purchaseOrderHeaderControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseOrderHeaderControl1.Location = new System.Drawing.Point(11, 11);
            this.purchaseOrderHeaderControl1.MinimumSize = new System.Drawing.Size(920, 145);
            this.purchaseOrderHeaderControl1.Name = "purchaseOrderHeaderControl1";
            this.purchaseOrderHeaderControl1.PurchaseOrder = null;
            this.purchaseOrderHeaderControl1.Size = new System.Drawing.Size(986, 145);
            this.purchaseOrderHeaderControl1.TabIndex = 15;
            this.purchaseOrderHeaderControl1.Load += new System.EventHandler(this.purchaseOrderHeaderControl1_Load);
            // 
            // partFinderControl1
            // 
            this.partFinderControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partFinderControl1.Location = new System.Drawing.Point(20, 499);
            this.partFinderControl1.Name = "partFinderControl1";
            this.partFinderControl1.SelectedPart = null;
            this.partFinderControl1.Size = new System.Drawing.Size(1007, 229);
            this.partFinderControl1.TabIndex = 16;
            // 
            // PurchaseOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.partFinderControl1);
            this.Controls.Add(this.purchaseOrderHeaderControl1);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.view);
            this.Controls.Add(this.CloseBox);
            this.MinimumSize = new System.Drawing.Size(0, 760);
            this.Name = "PurchaseOrderControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1039, 760);
            this.Load += new System.EventHandler(this.PurchaseOrderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveItem;
        private PurchaseOrderHeaderControl purchaseOrderHeaderControl1;
        private PartFinderControl partFinderControl1;
    }
}
