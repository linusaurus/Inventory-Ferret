namespace Weaselware.InventoryFerret {
    partial class JobOrdersControl {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtJobNameSearch = new System.Windows.Forms.TextBox();
            this.txtJobItemSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgJobOrders = new System.Windows.Forms.DataGridView();
            this.lbJobsList = new System.Windows.Forms.ListBox();
            this.dgJobOrderItems = new System.Windows.Forms.DataGridView();
            this.LineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJobNameSearch
            // 
            this.txtJobNameSearch.Location = new System.Drawing.Point(15, 29);
            this.txtJobNameSearch.Name = "txtJobNameSearch";
            this.txtJobNameSearch.Size = new System.Drawing.Size(347, 20);
            this.txtJobNameSearch.TabIndex = 0;
            this.txtJobNameSearch.TextChanged += new System.EventHandler(this.txtJobNameSearch_TextChanged);
            // 
            // txtJobItemSearch
            // 
            this.txtJobItemSearch.Location = new System.Drawing.Point(381, 29);
            this.txtJobItemSearch.Name = "txtJobItemSearch";
            this.txtJobItemSearch.Size = new System.Drawing.Size(313, 20);
            this.txtJobItemSearch.TabIndex = 1;
            this.txtJobItemSearch.TextChanged += new System.EventHandler(this.txtJobItemSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Item Search";
            // 
            // dgJobOrders
            // 
            this.dgJobOrders.AllowUserToAddRows = false;
            this.dgJobOrders.AllowUserToDeleteRows = false;
            this.dgJobOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgJobOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.OrderDate});
            this.dgJobOrders.Location = new System.Drawing.Point(15, 182);
            this.dgJobOrders.Name = "dgJobOrders";
            this.dgJobOrders.ReadOnly = true;
            this.dgJobOrders.RowHeadersVisible = false;
            this.dgJobOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgJobOrders.Size = new System.Drawing.Size(347, 565);
            this.dgJobOrders.TabIndex = 3;
            this.dgJobOrders.SelectionChanged += new System.EventHandler(this.dgJobOrders_SelectionChanged);
            // 
            // lbJobsList
            // 
            this.lbJobsList.FormattingEnabled = true;
            this.lbJobsList.Location = new System.Drawing.Point(15, 55);
            this.lbJobsList.Name = "lbJobsList";
            this.lbJobsList.Size = new System.Drawing.Size(347, 121);
            this.lbJobsList.TabIndex = 4;
            this.lbJobsList.SelectedIndexChanged += new System.EventHandler(this.lbJobsList_SelectedIndexChanged);
            // 
            // dgJobOrderItems
            // 
            this.dgJobOrderItems.AllowUserToAddRows = false;
            this.dgJobOrderItems.AllowUserToDeleteRows = false;
            this.dgJobOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgJobOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineID,
            this.PartID,
            this.Qnty,
            this.Description,
            this.UnitCost});
            this.dgJobOrderItems.Location = new System.Drawing.Point(381, 55);
            this.dgJobOrderItems.Name = "dgJobOrderItems";
            this.dgJobOrderItems.ReadOnly = true;
            this.dgJobOrderItems.Size = new System.Drawing.Size(889, 692);
            this.dgJobOrderItems.TabIndex = 5;
            // 
            // LineID
            // 
            this.LineID.DataPropertyName = "LineID";
            this.LineID.HeaderText = "LineID";
            this.LineID.Name = "LineID";
            this.LineID.ReadOnly = true;
            this.LineID.Width = 70;
            // 
            // PartID
            // 
            this.PartID.DataPropertyName = "PartID";
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            this.PartID.Width = 70;
            // 
            // Qnty
            // 
            this.Qnty.DataPropertyName = "Qnty";
            this.Qnty.HeaderText = "Qnty";
            this.Qnty.Name = "Qnty";
            this.Qnty.ReadOnly = true;
            this.Qnty.Width = 70;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // UnitCost
            // 
            this.UnitCost.DataPropertyName = "UnitCost";
            this.UnitCost.HeaderText = "UnitCost";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.ReadOnly = true;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNum";
            this.OrderNumber.HeaderText = "PO";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            this.OrderNumber.Width = 75;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.OrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDate.HeaderText = "Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // JobOrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgJobOrderItems);
            this.Controls.Add(this.lbJobsList);
            this.Controls.Add(this.dgJobOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJobItemSearch);
            this.Controls.Add(this.txtJobNameSearch);
            this.Name = "JobOrdersControl";
            this.Size = new System.Drawing.Size(1288, 796);
            this.Load += new System.EventHandler(this.JobOrdersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgJobOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJobNameSearch;
        private System.Windows.Forms.TextBox txtJobItemSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgJobOrders;
        private System.Windows.Forms.ListBox lbJobsList;
        private System.Windows.Forms.DataGridView dgJobOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
    }
}
