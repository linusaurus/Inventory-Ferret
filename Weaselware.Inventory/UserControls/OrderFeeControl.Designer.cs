namespace Weaselware.InventoryFerret.UserControls
{
    partial class OrderFeeControl
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
            this.btnAddOrderFee = new System.Windows.Forms.Button();
            this.btnRemoveFee = new System.Windows.Forms.Button();
            this.dgOrderFees = new System.Windows.Forms.DataGridView();
            this.colFeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeQnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderFees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddOrderFee
            // 
            this.btnAddOrderFee.Location = new System.Drawing.Point(7, 7);
            this.btnAddOrderFee.Name = "btnAddOrderFee";
            this.btnAddOrderFee.Size = new System.Drawing.Size(122, 31);
            this.btnAddOrderFee.TabIndex = 14;
            this.btnAddOrderFee.Text = "Add Fee / Surcharge";
            this.btnAddOrderFee.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFee
            // 
            this.btnRemoveFee.Location = new System.Drawing.Point(135, 7);
            this.btnRemoveFee.Name = "btnRemoveFee";
            this.btnRemoveFee.Size = new System.Drawing.Size(126, 31);
            this.btnRemoveFee.TabIndex = 13;
            this.btnRemoveFee.Text = "RemoveFee";
            this.btnRemoveFee.UseVisualStyleBackColor = true;
            // 
            // dgOrderFees
            // 
            this.dgOrderFees.AllowUserToAddRows = false;
            this.dgOrderFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrderFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFeeID,
            this.colFeeDescription,
            this.colFeeQnty,
            this.colFeeCost,
            this.colFeeExtension});
            this.dgOrderFees.Location = new System.Drawing.Point(7, 44);
            this.dgOrderFees.Name = "dgOrderFees";
            this.dgOrderFees.Size = new System.Drawing.Size(786, 148);
            this.dgOrderFees.TabIndex = 12;
            // 
            // colFeeID
            // 
            this.colFeeID.DataPropertyName = "OrderFeeID";
            this.colFeeID.HeaderText = "ID";
            this.colFeeID.Name = "colFeeID";
            this.colFeeID.Width = 75;
            // 
            // colFeeDescription
            // 
            this.colFeeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFeeDescription.DataPropertyName = "FeeName";
            this.colFeeDescription.HeaderText = "Description";
            this.colFeeDescription.Name = "colFeeDescription";
            // 
            // colFeeQnty
            // 
            this.colFeeQnty.DataPropertyName = "Qnty";
            this.colFeeQnty.HeaderText = "Qnty";
            this.colFeeQnty.Name = "colFeeQnty";
            this.colFeeQnty.Width = 60;
            // 
            // colFeeCost
            // 
            this.colFeeCost.DataPropertyName = "Cost";
            this.colFeeCost.HeaderText = "Cost";
            this.colFeeCost.Name = "colFeeCost";
            this.colFeeCost.Width = 60;
            // 
            // colFeeExtension
            // 
            this.colFeeExtension.DataPropertyName = "Extension";
            this.colFeeExtension.HeaderText = "Ext";
            this.colFeeExtension.Name = "colFeeExtension";
            this.colFeeExtension.Width = 75;
            // 
            // OrderFeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddOrderFee);
            this.Controls.Add(this.btnRemoveFee);
            this.Controls.Add(this.dgOrderFees);
            this.Name = "OrderFeeControl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(800, 199);
            this.Load += new System.EventHandler(this.OrderFeeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrderFee;
        private System.Windows.Forms.Button btnRemoveFee;
        private System.Windows.Forms.DataGridView dgOrderFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeQnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeExtension;
    }
}
