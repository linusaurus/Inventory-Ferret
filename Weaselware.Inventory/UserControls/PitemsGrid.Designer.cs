namespace Weaselware.InventoryFerret
{
    partial class PitemsGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgLineItems = new System.Windows.Forms.DataGridView();
            this.LineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.txtOrderReceipt = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtDateReceived = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLineItems
            // 
            this.dgLineItems.AllowUserToAddRows = false;
            this.dgLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineID,
            this.PartID,
            this.Revd,
            this.Description,
            this.Qnty,
            this.AmountReceived});
            this.dgLineItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgLineItems.Location = new System.Drawing.Point(6, 117);
            this.dgLineItems.Name = "dgLineItems";
            this.dgLineItems.Size = new System.Drawing.Size(905, 336);
            this.dgLineItems.TabIndex = 0;
            this.dgLineItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLineItems_CellEndEdit);
            // 
            // LineID
            // 
            this.LineID.DataPropertyName = "LineID";
            this.LineID.HeaderText = "LineID";
            this.LineID.Name = "LineID";
            this.LineID.Width = 70;
            // 
            // PartID
            // 
            this.PartID.DataPropertyName = "PartID";
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            // 
            // Revd
            // 
            this.Revd.DataPropertyName = "Recieved";
            this.Revd.HeaderText = "Recv\'d";
            this.Revd.Name = "Revd";
            this.Revd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Revd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Revd.Width = 50;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Qnty
            // 
            this.Qnty.DataPropertyName = "Qnty";
            this.Qnty.HeaderText = "Qnty";
            this.Qnty.Name = "Qnty";
            // 
            // AmountReceived
            // 
            this.AmountReceived.DataPropertyName = "AmountReceived";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AmountReceived.DefaultCellStyle = dataGridViewCellStyle2;
            this.AmountReceived.HeaderText = "Recv\'d";
            this.AmountReceived.Name = "AmountReceived";
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(378, 36);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(212, 20);
            this.txtReceived.TabIndex = 1;
            // 
            // txtOrderReceipt
            // 
            this.txtOrderReceipt.Location = new System.Drawing.Point(18, 36);
            this.txtOrderReceipt.Name = "txtOrderReceipt";
            this.txtOrderReceipt.Size = new System.Drawing.Size(106, 20);
            this.txtOrderReceipt.TabIndex = 1;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(324, 36);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(36, 20);
            this.txtEmpID.TabIndex = 1;
            // 
            // txtDateReceived
            // 
            this.txtDateReceived.Location = new System.Drawing.Point(171, 36);
            this.txtDateReceived.Name = "txtDateReceived";
            this.txtDateReceived.Size = new System.Drawing.Size(106, 20);
            this.txtDateReceived.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Received";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EmpID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Recieved By";
            // 
            // btnReceive
            // 
            this.btnReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceive.Location = new System.Drawing.Point(762, 33);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(136, 23);
            this.btnReceive.TabIndex = 3;
            this.btnReceive.Text = "Receive Order";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEdits.Location = new System.Drawing.Point(670, 33);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(86, 23);
            this.btnSaveEdits.TabIndex = 4;
            this.btnSaveEdits.Text = "Save Edits";
            this.btnSaveEdits.UseVisualStyleBackColor = true;
            this.btnSaveEdits.Click += new System.EventHandler(this.btnSaveEdits_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print Labels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTab.Location = new System.Drawing.Point(762, 70);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Size = new System.Drawing.Size(136, 23);
            this.btnCloseTab.TabIndex = 6;
            this.btnCloseTab.Text = "Close";
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.button2_Click);
            // 
            // CloseBox
            // 
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(639, 70);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(26, 23);
            this.CloseBox.TabIndex = 7;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // PitemsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveEdits);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateReceived);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtOrderReceipt);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.dgLineItems);
            this.Name = "PitemsGrid";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(917, 459);
            this.Load += new System.EventHandler(this.PitemsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLineItems;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.TextBox txtOrderReceipt;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtDateReceived;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Revd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountReceived;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCloseTab;
        private System.Windows.Forms.PictureBox CloseBox;
    }
}
