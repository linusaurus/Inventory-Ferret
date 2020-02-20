namespace Weaselware.InventoryFerret {
    partial class InventoryDetailViewControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQnty = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtReceivedDate = new System.Windows.Forms.TextBox();
            this.txtInventoryTag = new System.Windows.Forms.TextBox();
            this.txtOrderedBy = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(33, 27);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(93, 20);
            this.txtOrderNum.TabIndex = 0;
            this.txtOrderNum.Text = "{{OrderNum}}";
            this.txtOrderNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(190, 67);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(92, 20);
            this.txtUnitPrice.TabIndex = 0;
            this.txtUnitPrice.Text = "{{UnitCost}}";
            // 
            // txtQnty
            // 
            this.txtQnty.Location = new System.Drawing.Point(72, 67);
            this.txtQnty.Name = "txtQnty";
            this.txtQnty.Size = new System.Drawing.Size(54, 20);
            this.txtQnty.TabIndex = 0;
            this.txtQnty.Text = "{{Qnty}}";
            this.txtQnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(96, 106);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(391, 20);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "{{Description}}";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(96, 132);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(283, 20);
            this.txtSupplierName.TabIndex = 0;
            this.txtSupplierName.Text = "{{Supplier Name}}";
            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.Location = new System.Drawing.Point(33, 169);
            this.txtReceivedDate.Name = "txtReceivedDate";
            this.txtReceivedDate.Size = new System.Drawing.Size(109, 20);
            this.txtReceivedDate.TabIndex = 0;
            this.txtReceivedDate.Text = "{{Received Date}}";
            // 
            // txtInventoryTag
            // 
            this.txtInventoryTag.Location = new System.Drawing.Point(148, 169);
            this.txtInventoryTag.Name = "txtInventoryTag";
            this.txtInventoryTag.Size = new System.Drawing.Size(152, 20);
            this.txtInventoryTag.TabIndex = 0;
            this.txtInventoryTag.Text = "{{Recieved By}}";
            // 
            // txtOrderedBy
            // 
            this.txtOrderedBy.Location = new System.Drawing.Point(306, 169);
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.Size = new System.Drawing.Size(181, 20);
            this.txtOrderedBy.TabIndex = 0;
            this.txtOrderedBy.Text = "{{OrderedBy}}";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(132, 27);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(92, 20);
            this.txtOrderDate.TabIndex = 0;
            this.txtOrderDate.Text = "{{Order Date}}";
            this.txtOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(230, 27);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(264, 20);
            this.txtJobName.TabIndex = 0;
            this.txtJobName.Text = "{{JobName}}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qnty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unit Cost";
            // 
            // InventoryDetailViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderedBy);
            this.Controls.Add(this.txtInventoryTag);
            this.Controls.Add(this.txtReceivedDate);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtQnty);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtOrderNum);
            this.Name = "InventoryDetailViewControl";
            this.Size = new System.Drawing.Size(517, 215);
            this.Load += new System.EventHandler(this.InventoryDetailViewControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQnty;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtReceivedDate;
        private System.Windows.Forms.TextBox txtInventoryTag;
        private System.Windows.Forms.TextBox txtOrderedBy;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
