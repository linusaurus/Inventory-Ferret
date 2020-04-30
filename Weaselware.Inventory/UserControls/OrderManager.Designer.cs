namespace Weaselware.InventoryFerret.UserControls
{
    partial class OrderManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.colOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecieved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtSearchJobs = new System.Windows.Forms.TextBox();
            this.lbJobsList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgOrders, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 662);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_clear_black_24dp1;
            this.CloseBox.Location = new System.Drawing.Point(1024, 14);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 13;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // dgOrders
            // 
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNum,
            this.colOrderDate,
            this.colJobName,
            this.colPurchaser,
            this.colOrderTotal,
            this.colRecieved});
            this.dgOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrders.Location = new System.Drawing.Point(212, 42);
            this.dgOrders.Margin = new System.Windows.Forms.Padding(6);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(768, 528);
            this.dgOrders.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "All Orders";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtSearchSuppliers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbSuppliers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSearchJobs, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbJobsList, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.44162F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.55838F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 534);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtSearchSuppliers
            // 
            this.txtSearchSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchSuppliers.Location = new System.Drawing.Point(3, 3);
            this.txtSearchSuppliers.Name = "txtSearchSuppliers";
            this.txtSearchSuppliers.Size = new System.Drawing.Size(194, 20);
            this.txtSearchSuppliers.TabIndex = 0;
            this.txtSearchSuppliers.TextChanged += new System.EventHandler(this.txtSearchSuppliers_TextChanged);
            // 
            // lbSuppliers
            // 
            this.lbSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSuppliers.FormattingEnabled = true;
            this.lbSuppliers.Location = new System.Drawing.Point(3, 27);
            this.lbSuppliers.Name = "lbSuppliers";
            this.lbSuppliers.Size = new System.Drawing.Size(194, 244);
            this.lbSuppliers.TabIndex = 1;
            this.lbSuppliers.SelectedIndexChanged += new System.EventHandler(this.lbSuppliers_SelectedIndexChanged);
            // 
            // colOrderNum
            // 
            this.colOrderNum.DataPropertyName = "OrderNum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colOrderNum.DefaultCellStyle = dataGridViewCellStyle1;
            this.colOrderNum.HeaderText = "Order#";
            this.colOrderNum.Name = "colOrderNum";
            this.colOrderNum.Width = 80;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colOrderDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOrderDate.HeaderText = "Date";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Width = 80;
            // 
            // colJobName
            // 
            this.colJobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJobName.DataPropertyName = "JobName";
            this.colJobName.HeaderText = "Job";
            this.colJobName.Name = "colJobName";
            // 
            // colPurchaser
            // 
            this.colPurchaser.DataPropertyName = "Purchaser";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPurchaser.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPurchaser.HeaderText = "Purchaser";
            this.colPurchaser.Name = "colPurchaser";
            // 
            // colOrderTotal
            // 
            this.colOrderTotal.DataPropertyName = "OrderTotal";
            this.colOrderTotal.HeaderText = "Total";
            this.colOrderTotal.Name = "colOrderTotal";
            this.colOrderTotal.Width = 80;
            // 
            // colRecieved
            // 
            this.colRecieved.DataPropertyName = "Recieved";
            this.colRecieved.HeaderText = "Rev\'d";
            this.colRecieved.Name = "colRecieved";
            this.colRecieved.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRecieved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRecieved.Width = 50;
            // 
            // txtSearchJobs
            // 
            this.txtSearchJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchJobs.Location = new System.Drawing.Point(3, 277);
            this.txtSearchJobs.Name = "txtSearchJobs";
            this.txtSearchJobs.Size = new System.Drawing.Size(194, 20);
            this.txtSearchJobs.TabIndex = 2;
            this.txtSearchJobs.TextChanged += new System.EventHandler(this.txtSearchJobs_TextChanged);
            // 
            // lbJobsList
            // 
            this.lbJobsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbJobsList.FormattingEnabled = true;
            this.lbJobsList.Location = new System.Drawing.Point(3, 301);
            this.lbJobsList.Name = "lbJobsList";
            this.lbJobsList.Size = new System.Drawing.Size(194, 230);
            this.lbJobsList.TabIndex = 3;
            // 
            // OrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CloseBox);
            this.Name = "OrderManager";
            this.Size = new System.Drawing.Size(1062, 700);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSearchSuppliers;
        private System.Windows.Forms.ListBox lbSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRecieved;
        private System.Windows.Forms.TextBox txtSearchJobs;
        private System.Windows.Forms.ListBox lbJobsList;
    }
}
