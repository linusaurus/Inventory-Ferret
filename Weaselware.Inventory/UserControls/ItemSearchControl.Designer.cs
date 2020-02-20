namespace Weaselware.InventoryFerret {
    partial class ItemSearchControl {
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
            this.btnScanToFind = new System.Windows.Forms.Button();
            this.txtScannerOutput = new System.Windows.Forms.TextBox();
            this.bntStopScan = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScanToFind
            // 
            this.btnScanToFind.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnScanToFind.Location = new System.Drawing.Point(45, 49);
            this.btnScanToFind.Name = "btnScanToFind";
            this.btnScanToFind.Size = new System.Drawing.Size(124, 39);
            this.btnScanToFind.TabIndex = 0;
            this.btnScanToFind.Text = " Scan Part Label";
            this.btnScanToFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScanToFind.UseVisualStyleBackColor = false;
            this.btnScanToFind.Click += new System.EventHandler(this.btnScanToFind_Click);
            // 
            // txtScannerOutput
            // 
            this.txtScannerOutput.Location = new System.Drawing.Point(706, 49);
            this.txtScannerOutput.Name = "txtScannerOutput";
            this.txtScannerOutput.Size = new System.Drawing.Size(168, 20);
            this.txtScannerOutput.TabIndex = 2;
            // 
            // bntStopScan
            // 
            this.bntStopScan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntStopScan.Location = new System.Drawing.Point(175, 49);
            this.bntStopScan.Name = "bntStopScan";
            this.bntStopScan.Size = new System.Drawing.Size(87, 39);
            this.bntStopScan.TabIndex = 0;
            this.bntStopScan.Text = "Stop Scan";
            this.bntStopScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntStopScan.UseVisualStyleBackColor = false;
            this.bntStopScan.Click += new System.EventHandler(this.bntStopScan_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(82, 420);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(840, 352);
            this.propertyGrid1.TabIndex = 4;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Result";
            // 
            // CloseBox
            // 
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(850, 19);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 8;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // ItemSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.txtScannerOutput);
            this.Controls.Add(this.bntStopScan);
            this.Controls.Add(this.btnScanToFind);
            this.Name = "ItemSearchControl";
            this.Size = new System.Drawing.Size(1000, 817);
            this.Load += new System.EventHandler(this.OrderReceiptSearchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScanToFind;
        private System.Windows.Forms.TextBox txtScannerOutput;
        private System.Windows.Forms.Button bntStopScan;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CloseBox;
    }
}
