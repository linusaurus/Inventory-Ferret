namespace Weaselware.InventoryFerret
{
    partial class ClaimDetailControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbOrdersList = new System.Windows.Forms.ListBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.tbSupplierSearch = new System.Windows.Forms.TextBox();
            this.tabClaims = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgSupplierOrders = new System.Windows.Forms.DataGridView();
            this.btbStartClaim = new System.Windows.Forms.Button();
            this.dgSupplierClaims = new System.Windows.Forms.DataGridView();
            this.ClaimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNum_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbShowInactive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaser_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.tabClaims.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierClaims)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrdersList
            // 
            this.lbOrdersList.FormattingEnabled = true;
            this.lbOrdersList.Location = new System.Drawing.Point(6, 67);
            this.lbOrdersList.Margin = new System.Windows.Forms.Padding(6);
            this.lbOrdersList.Name = "lbOrdersList";
            this.lbOrdersList.Size = new System.Drawing.Size(200, 160);
            this.lbOrdersList.TabIndex = 1;
            this.lbOrdersList.SelectedIndexChanged += new System.EventHandler(this.lbOrdersList_SelectedIndexChanged);
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(963, 12);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 13;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // tbSupplierSearch
            // 
            this.tbSupplierSearch.Location = new System.Drawing.Point(6, 38);
            this.tbSupplierSearch.Name = "tbSupplierSearch";
            this.tbSupplierSearch.Size = new System.Drawing.Size(200, 20);
            this.tbSupplierSearch.TabIndex = 14;
            this.tbSupplierSearch.TextChanged += new System.EventHandler(this.tbSupplierSearch_TextChanged);
            // 
            // tabClaims
            // 
            this.tabClaims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabClaims.Controls.Add(this.tabPage1);
            this.tabClaims.Location = new System.Drawing.Point(215, 64);
            this.tabClaims.Name = "tabClaims";
            this.tabClaims.SelectedIndex = 0;
            this.tabClaims.Size = new System.Drawing.Size(772, 567);
            this.tabClaims.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgSupplierOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Supplier Orders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgSupplierOrders
            // 
            this.dgSupplierOrders.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSupplierOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSupplierOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplierOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Job,
            this.Order,
            this.Order_Date,
            this.purchaser_col,
            this.received});
            this.dgSupplierOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSupplierOrders.Location = new System.Drawing.Point(3, 3);
            this.dgSupplierOrders.Name = "dgSupplierOrders";
            this.dgSupplierOrders.Size = new System.Drawing.Size(758, 535);
            this.dgSupplierOrders.TabIndex = 1;
            this.dgSupplierOrders.SelectionChanged += new System.EventHandler(this.dgSupplierOrders_SelectionChanged);
            // 
            // btbStartClaim
            // 
            this.btbStartClaim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btbStartClaim.FlatAppearance.BorderSize = 5;
            this.btbStartClaim.Location = new System.Drawing.Point(215, 20);
            this.btbStartClaim.Name = "btbStartClaim";
            this.btbStartClaim.Size = new System.Drawing.Size(115, 29);
            this.btbStartClaim.TabIndex = 16;
            this.btbStartClaim.Text = "New Claim";
            this.btbStartClaim.UseVisualStyleBackColor = true;
            this.btbStartClaim.Click += new System.EventHandler(this.btbStartClaim_Click);
            // 
            // dgSupplierClaims
            // 
            this.dgSupplierClaims.AllowUserToAddRows = false;
            this.dgSupplierClaims.AllowUserToDeleteRows = false;
            this.dgSupplierClaims.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgSupplierClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplierClaims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaimID,
            this.OrderNum_col,
            this.Date_col});
            this.dgSupplierClaims.Location = new System.Drawing.Point(6, 262);
            this.dgSupplierClaims.MultiSelect = false;
            this.dgSupplierClaims.Name = "dgSupplierClaims";
            this.dgSupplierClaims.ReadOnly = true;
            this.dgSupplierClaims.RowHeadersVisible = false;
            this.dgSupplierClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSupplierClaims.Size = new System.Drawing.Size(200, 365);
            this.dgSupplierClaims.TabIndex = 17;
            this.dgSupplierClaims.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSupplierClaims_CellDoubleClick);
            // 
            // ClaimID
            // 
            this.ClaimID.DataPropertyName = "ClaimID";
            this.ClaimID.HeaderText = "Claim#";
            this.ClaimID.Name = "ClaimID";
            this.ClaimID.ReadOnly = true;
            this.ClaimID.Width = 60;
            // 
            // OrderNum_col
            // 
            this.OrderNum_col.DataPropertyName = "OrderNum";
            this.OrderNum_col.HeaderText = "Order#";
            this.OrderNum_col.Name = "OrderNum_col";
            this.OrderNum_col.ReadOnly = true;
            this.OrderNum_col.Width = 65;
            // 
            // Date_col
            // 
            this.Date_col.DataPropertyName = "ClaimDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Date_col.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date_col.HeaderText = "Date";
            this.Date_col.Name = "Date_col";
            this.Date_col.ReadOnly = true;
            this.Date_col.Width = 70;
            // 
            // ckbShowInactive
            // 
            this.ckbShowInactive.AutoSize = true;
            this.ckbShowInactive.Location = new System.Drawing.Point(6, 236);
            this.ckbShowInactive.Name = "ckbShowInactive";
            this.ckbShowInactive.Size = new System.Drawing.Size(122, 17);
            this.ckbShowInactive.TabIndex = 18;
            this.ckbShowInactive.Text = "Show Inactive Claim";
            this.ckbShowInactive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search Suppliers";
            // 
            // Job
            // 
            this.Job.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Job.DataPropertyName = "JobName";
            this.Job.HeaderText = "Job";
            this.Job.Name = "Job";
            // 
            // Order
            // 
            this.Order.DataPropertyName = "OrderNum";
            this.Order.HeaderText = "OrderNum";
            this.Order.Name = "Order";
            this.Order.Width = 80;
            // 
            // Order_Date
            // 
            this.Order_Date.DataPropertyName = "OrderDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Order_Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Order_Date.HeaderText = "Order Date";
            this.Order_Date.Name = "Order_Date";
            this.Order_Date.Width = 90;
            // 
            // purchaser_col
            // 
            this.purchaser_col.DataPropertyName = "PurchaserName";
            this.purchaser_col.HeaderText = "Purchaser";
            this.purchaser_col.Name = "purchaser_col";
            // 
            // received
            // 
            this.received.DataPropertyName = "Received";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.NullValue = false;
            this.received.DefaultCellStyle = dataGridViewCellStyle3;
            this.received.HeaderText = "Recieved";
            this.received.Name = "received";
            this.received.ReadOnly = true;
            this.received.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.received.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.received.Width = 75;
            // 
            // ClaimDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbShowInactive);
            this.Controls.Add(this.dgSupplierClaims);
            this.Controls.Add(this.btbStartClaim);
            this.Controls.Add(this.tabClaims);
            this.Controls.Add(this.tbSupplierSearch);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.lbOrdersList);
            this.Name = "ClaimDetailControl";
            this.Size = new System.Drawing.Size(1000, 650);
            this.Load += new System.EventHandler(this.ClaimDetailControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.tabClaims.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierClaims)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbOrdersList;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.TextBox tbSupplierSearch;
        private System.Windows.Forms.TabControl tabClaims;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgSupplierOrders;
        private System.Windows.Forms.Button btbStartClaim;
        private System.Windows.Forms.DataGridView dgSupplierClaims;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNum_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_col;
        private System.Windows.Forms.CheckBox ckbShowInactive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaser_col;
        private System.Windows.Forms.DataGridViewCheckBoxColumn received;
    }
}
