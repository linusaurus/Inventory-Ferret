namespace Weaselware.InventoryFerret
{
    partial class PurchaseOrderDetailsControl
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
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.tbSupplierAddress1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(34, 29);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.ReadOnly = true;
            this.tbSupplierName.Size = new System.Drawing.Size(278, 20);
            this.tbSupplierName.TabIndex = 0;
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Location = new System.Drawing.Point(318, 29);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.ReadOnly = true;
            this.tbSupplierID.Size = new System.Drawing.Size(96, 20);
            this.tbSupplierID.TabIndex = 0;
            // 
            // tbSupplierAddress1
            // 
            this.tbSupplierAddress1.Location = new System.Drawing.Point(34, 55);
            this.tbSupplierAddress1.Name = "tbSupplierAddress1";
            this.tbSupplierAddress1.ReadOnly = true;
            this.tbSupplierAddress1.Size = new System.Drawing.Size(278, 20);
            this.tbSupplierAddress1.TabIndex = 0;
            // 
            // PurchaseOrderDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSupplierID);
            this.Controls.Add(this.tbSupplierAddress1);
            this.Controls.Add(this.tbSupplierName);
            this.Name = "PurchaseOrderDetailsControl";
            this.Size = new System.Drawing.Size(488, 233);
            this.Load += new System.EventHandler(this.PurchaseOrderDetailsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.TextBox tbSupplierID;
        private System.Windows.Forms.TextBox tbSupplierAddress1;
    }
}
