namespace Weaselware.InventoryFerret
{
    partial class OrderReceiptControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtOrderReceiptID = new System.Windows.Forms.TextBox();
            this.txtReciptDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.dgOrderReceiptItems = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.StockTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QntyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsRecieved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Qnty_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderReceiptID
            // 
            this.txtOrderReceiptID.Location = new System.Drawing.Point(12, 27);
            this.txtOrderReceiptID.Name = "txtOrderReceiptID";
            this.txtOrderReceiptID.Size = new System.Drawing.Size(119, 20);
            this.txtOrderReceiptID.TabIndex = 2;
            // 
            // txtReciptDate
            // 
            this.txtReciptDate.Location = new System.Drawing.Point(137, 27);
            this.txtReciptDate.Name = "txtReciptDate";
            this.txtReciptDate.Size = new System.Drawing.Size(100, 20);
            this.txtReciptDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order Receipt ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Receipt Date";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(243, 27);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNo.TabIndex = 5;
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.Location = new System.Drawing.Point(349, 27);
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.Size = new System.Drawing.Size(94, 20);
            this.txtReceivedBy.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Recieved By";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Weaselware.InventoryFerret.Properties.Resources.RecivedUnit;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CloseBox
            // 
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(867, 12);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 7;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(532, 27);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(329, 48);
            this.txtNotes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Attach LineItem Notes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(748, 90);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(113, 23);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // dgOrderReceiptItems
            // 
            this.dgOrderReceiptItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderReceiptItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockTransactionID,
            this.LineID,
            this.PartID,
            this.QntyColumn,
            this.UnitsRecieved,
            this.Description,
            this.LB_Qnty_col,
            this.LocationColumn});
            this.dgOrderReceiptItems.Location = new System.Drawing.Point(12, 153);
            this.dgOrderReceiptItems.Name = "dgOrderReceiptItems";
            this.dgOrderReceiptItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderReceiptItems.Size = new System.Drawing.Size(879, 358);
            this.dgOrderReceiptItems.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Print Stock Label";
            // 
            // StockTransactionID
            // 
            this.StockTransactionID.DataPropertyName = "StockTransactionID";
            this.StockTransactionID.HeaderText = "StockID";
            this.StockTransactionID.Name = "StockTransactionID";
            this.StockTransactionID.Width = 60;
            // 
            // LineID
            // 
            this.LineID.DataPropertyName = "LineID";
            this.LineID.HeaderText = "LineID";
            this.LineID.Name = "LineID";
            this.LineID.Width = 60;
            // 
            // PartID
            // 
            this.PartID.DataPropertyName = "PartID";
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            this.PartID.Width = 60;
            // 
            // QntyColumn
            // 
            this.QntyColumn.DataPropertyName = "Qnty";
            this.QntyColumn.HeaderText = "Qnty";
            this.QntyColumn.Name = "QntyColumn";
            this.QntyColumn.Width = 60;
            // 
            // UnitsRecieved
            // 
            this.UnitsRecieved.DataPropertyName = "UoP";
            this.UnitsRecieved.HeaderText = "Units Recieved";
            this.UnitsRecieved.Name = "UnitsRecieved";
            this.UnitsRecieved.Width = 120;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // LB_Qnty_col
            // 
            dataGridViewCellStyle1.NullValue = "1";
            this.LB_Qnty_col.DefaultCellStyle = dataGridViewCellStyle1;
            this.LB_Qnty_col.HeaderText = "Copies";
            this.LB_Qnty_col.Name = "LB_Qnty_col";
            this.LB_Qnty_col.Width = 60;
            // 
            // LocationColumn
            // 
            this.LocationColumn.DataPropertyName = "Location";
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            // 
            // OrderReceiptControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgOrderReceiptItems);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.txtReceivedBy);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReciptDate);
            this.Controls.Add(this.txtOrderReceiptID);
            this.MinimumSize = new System.Drawing.Size(900, 250);
            this.Name = "OrderReceiptControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(905, 540);
            this.Load += new System.EventHandler(this.OrderReceiptControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReceiptItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOrderReceiptID;
        private System.Windows.Forms.TextBox txtReciptDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.TextBox txtReceivedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.DataGridView dgOrderReceiptItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QntyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsRecieved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn LB_Qnty_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
    }
}
