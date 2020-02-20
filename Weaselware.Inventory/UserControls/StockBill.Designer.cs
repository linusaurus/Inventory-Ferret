namespace Weaselware.InventoryFerret {
    partial class StockBill {
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
            this.btnAddScannedItem = new System.Windows.Forms.Button();
            this.btnStopScanner = new System.Windows.Forms.Button();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntAddManual = new System.Windows.Forms.Button();
            this.txtLineID = new System.Windows.Forms.TextBox();
            this.bntAddPartID = new System.Windows.Forms.Button();
            this.txtPartID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddScannedItem
            // 
            this.btnAddScannedItem.Location = new System.Drawing.Point(24, 17);
            this.btnAddScannedItem.Name = "btnAddScannedItem";
            this.btnAddScannedItem.Size = new System.Drawing.Size(99, 23);
            this.btnAddScannedItem.TabIndex = 0;
            this.btnAddScannedItem.Text = "Scan Items";
            this.btnAddScannedItem.UseVisualStyleBackColor = true;
            this.btnAddScannedItem.Click += new System.EventHandler(this.btnAddScannedItem_Click);
            // 
            // btnStopScanner
            // 
            this.btnStopScanner.Location = new System.Drawing.Point(129, 17);
            this.btnStopScanner.Name = "btnStopScanner";
            this.btnStopScanner.Size = new System.Drawing.Size(99, 23);
            this.btnStopScanner.TabIndex = 1;
            this.btnStopScanner.Text = "Stop Scanning";
            this.btnStopScanner.UseVisualStyleBackColor = true;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(832, 16);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 8;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 368);
            this.dataGridView1.TabIndex = 9;
            // 
            // bntAddManual
            // 
            this.bntAddManual.Location = new System.Drawing.Point(590, 14);
            this.bntAddManual.Name = "bntAddManual";
            this.bntAddManual.Size = new System.Drawing.Size(75, 23);
            this.bntAddManual.TabIndex = 10;
            this.bntAddManual.Text = "Add LineID";
            this.bntAddManual.UseVisualStyleBackColor = true;
            // 
            // txtLineID
            // 
            this.txtLineID.Location = new System.Drawing.Point(672, 16);
            this.txtLineID.Name = "txtLineID";
            this.txtLineID.Size = new System.Drawing.Size(122, 20);
            this.txtLineID.TabIndex = 11;
            // 
            // bntAddPartID
            // 
            this.bntAddPartID.Location = new System.Drawing.Point(369, 14);
            this.bntAddPartID.Name = "bntAddPartID";
            this.bntAddPartID.Size = new System.Drawing.Size(75, 23);
            this.bntAddPartID.TabIndex = 10;
            this.bntAddPartID.Text = "PartID";
            this.bntAddPartID.UseVisualStyleBackColor = true;
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(451, 16);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(122, 20);
            this.txtPartID.TabIndex = 11;
            // 
            // StockBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.bntAddPartID);
            this.Controls.Add(this.txtLineID);
            this.Controls.Add(this.bntAddManual);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.btnStopScanner);
            this.Controls.Add(this.btnAddScannedItem);
            this.Name = "StockBill";
            this.Size = new System.Drawing.Size(869, 471);
            this.Load += new System.EventHandler(this.StockBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddScannedItem;
        private System.Windows.Forms.Button btnStopScanner;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntAddManual;
        private System.Windows.Forms.TextBox txtLineID;
        private System.Windows.Forms.Button bntAddPartID;
        private System.Windows.Forms.TextBox txtPartID;
    }
}
