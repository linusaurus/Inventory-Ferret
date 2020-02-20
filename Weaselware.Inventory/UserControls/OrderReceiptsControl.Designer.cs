namespace Weaselware.InventoryFerret {
    partial class OrderReceiptsControl {
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbJobs = new System.Windows.Forms.TabPage();
            this.lvJobReciepts = new System.Windows.Forms.ListView();
            this.RiD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recieved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbJobListing = new System.Windows.Forms.ListBox();
            this.tbJobSearch = new System.Windows.Forms.TextBox();
            this.tbSuppliers = new System.Windows.Forms.TabPage();
            this.lvSuppliersReciept = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbSupplierList = new System.Windows.Forms.ListBox();
            this.tbSearchSuppliers = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLabelQnty = new System.Windows.Forms.TextBox();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtPurchaser = new System.Windows.Forms.TextBox();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.txtRecievedDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReciever = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtRecievedSupliertemSearch = new System.Windows.Forms.TextBox();
            this.dgRecieptItems = new System.Windows.Forms.DataGridView();
            this.ctxLineItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printSelectedLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPartFromLineitemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptsLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptsPartid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptQnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reject = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbJobs.SuspendLayout();
            this.tbSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecieptItems)).BeginInit();
            this.ctxLineItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1046, 575);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbJobs);
            this.tabControl1.Controls.Add(this.tbSuppliers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(208, 563);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tbJobs
            // 
            this.tbJobs.Controls.Add(this.lvJobReciepts);
            this.tbJobs.Controls.Add(this.lbJobListing);
            this.tbJobs.Controls.Add(this.tbJobSearch);
            this.tbJobs.Location = new System.Drawing.Point(4, 22);
            this.tbJobs.Name = "tbJobs";
            this.tbJobs.Padding = new System.Windows.Forms.Padding(10);
            this.tbJobs.Size = new System.Drawing.Size(200, 537);
            this.tbJobs.TabIndex = 0;
            this.tbJobs.Text = "Jobs";
            this.tbJobs.UseVisualStyleBackColor = true;
            // 
            // lvJobReciepts
            // 
            this.lvJobReciepts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RiD,
            this.Recieved});
            this.lvJobReciepts.FullRowSelect = true;
            this.lvJobReciepts.Location = new System.Drawing.Point(13, 155);
            this.lvJobReciepts.Name = "lvJobReciepts";
            this.lvJobReciepts.Size = new System.Drawing.Size(174, 244);
            this.lvJobReciepts.TabIndex = 3;
            this.lvJobReciepts.UseCompatibleStateImageBehavior = false;
            this.lvJobReciepts.View = System.Windows.Forms.View.Details;
            this.lvJobReciepts.SelectedIndexChanged += new System.EventHandler(this.lvJobReciepts_SelectedIndexChanged);
            // 
            // RiD
            // 
            this.RiD.Text = "RecvID";
            // 
            // Recieved
            // 
            this.Recieved.Text = "Recieved";
            this.Recieved.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Recieved.Width = 100;
            // 
            // lbJobListing
            // 
            this.lbJobListing.FormattingEnabled = true;
            this.lbJobListing.Location = new System.Drawing.Point(13, 40);
            this.lbJobListing.Name = "lbJobListing";
            this.lbJobListing.Size = new System.Drawing.Size(175, 95);
            this.lbJobListing.TabIndex = 1;
            this.lbJobListing.SelectedIndexChanged += new System.EventHandler(this.lbJobListing_SelectedIndexChanged);
            // 
            // tbJobSearch
            // 
            this.tbJobSearch.Location = new System.Drawing.Point(65, 13);
            this.tbJobSearch.Name = "tbJobSearch";
            this.tbJobSearch.Size = new System.Drawing.Size(122, 20);
            this.tbJobSearch.TabIndex = 0;
            this.tbJobSearch.TextChanged += new System.EventHandler(this.tbJobSearch_TextChanged);
            // 
            // tbSuppliers
            // 
            this.tbSuppliers.Controls.Add(this.lvSuppliersReciept);
            this.tbSuppliers.Controls.Add(this.lbSupplierList);
            this.tbSuppliers.Controls.Add(this.tbSearchSuppliers);
            this.tbSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tbSuppliers.Name = "tbSuppliers";
            this.tbSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tbSuppliers.Size = new System.Drawing.Size(200, 537);
            this.tbSuppliers.TabIndex = 1;
            this.tbSuppliers.Text = "Suppliers";
            this.tbSuppliers.UseVisualStyleBackColor = true;
            // 
            // lvSuppliersReciept
            // 
            this.lvSuppliersReciept.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSuppliersReciept.FullRowSelect = true;
            this.lvSuppliersReciept.HideSelection = false;
            this.lvSuppliersReciept.Location = new System.Drawing.Point(13, 144);
            this.lvSuppliersReciept.Name = "lvSuppliersReciept";
            this.lvSuppliersReciept.Size = new System.Drawing.Size(175, 249);
            this.lvSuppliersReciept.TabIndex = 4;
            this.lvSuppliersReciept.UseCompatibleStateImageBehavior = false;
            this.lvSuppliersReciept.View = System.Windows.Forms.View.Details;
            this.lvSuppliersReciept.SelectedIndexChanged += new System.EventHandler(this.lvSuppliersReciept_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RecvID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Recieve Date";
            this.columnHeader2.Width = 120;
            // 
            // lbSupplierList
            // 
            this.lbSupplierList.FormattingEnabled = true;
            this.lbSupplierList.Location = new System.Drawing.Point(13, 43);
            this.lbSupplierList.Name = "lbSupplierList";
            this.lbSupplierList.Size = new System.Drawing.Size(175, 95);
            this.lbSupplierList.TabIndex = 3;
            this.lbSupplierList.SelectedIndexChanged += new System.EventHandler(this.lbSupplierList_SelectedIndexChanged);
            // 
            // tbSearchSuppliers
            // 
            this.tbSearchSuppliers.Location = new System.Drawing.Point(65, 17);
            this.tbSearchSuppliers.Name = "tbSearchSuppliers";
            this.tbSearchSuppliers.Size = new System.Drawing.Size(123, 20);
            this.tbSearchSuppliers.TabIndex = 1;
            this.tbSearchSuppliers.TextChanged += new System.EventHandler(this.tbSearchSuppliers_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl2);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgRecieptItems);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Size = new System.Drawing.Size(822, 575);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(810, 118);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLabelQnty);
            this.tabPage1.Controls.Add(this.btnSaveEdits);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.txtPurchaser);
            this.tabPage1.Controls.Add(this.txtJobName);
            this.tabPage1.Controls.Add(this.txtRecievedDate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtOrderDate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtPoNumber);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtReciever);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtSupplier);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLabelQnty
            // 
            this.txtLabelQnty.Location = new System.Drawing.Point(581, 58);
            this.txtLabelQnty.Name = "txtLabelQnty";
            this.txtLabelQnty.Size = new System.Drawing.Size(61, 20);
            this.txtLabelQnty.TabIndex = 9;
            this.txtLabelQnty.Text = "1";
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.Location = new System.Drawing.Point(479, 56);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(90, 23);
            this.btnSaveEdits.TabIndex = 8;
            this.btnSaveEdits.Text = "Save Edits";
            this.btnSaveEdits.UseVisualStyleBackColor = true;
            this.btnSaveEdits.Click += new System.EventHandler(this.btnSaveEdits_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(581, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 22);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtPurchaser
            // 
            this.txtPurchaser.Location = new System.Drawing.Point(455, 20);
            this.txtPurchaser.Name = "txtPurchaser";
            this.txtPurchaser.Size = new System.Drawing.Size(114, 20);
            this.txtPurchaser.TabIndex = 6;
            // 
            // txtJobName
            // 
            this.txtJobName.Location = new System.Drawing.Point(18, 19);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(227, 20);
            this.txtJobName.TabIndex = 4;
            // 
            // txtRecievedDate
            // 
            this.txtRecievedDate.Location = new System.Drawing.Point(252, 59);
            this.txtRecievedDate.Name = "txtRecievedDate";
            this.txtRecievedDate.Size = new System.Drawing.Size(100, 20);
            this.txtRecievedDate.TabIndex = 5;
            this.txtRecievedDate.TextChanged += new System.EventHandler(this.txtRecievedDate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JobName";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(349, 20);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Supplier";
            // 
            // txtPoNumber
            // 
            this.txtPoNumber.Location = new System.Drawing.Point(252, 20);
            this.txtPoNumber.Name = "txtPoNumber";
            this.txtPoNumber.Size = new System.Drawing.Size(91, 20);
            this.txtPoNumber.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Receiver";
            // 
            // txtReciever
            // 
            this.txtReciever.Location = new System.Drawing.Point(359, 59);
            this.txtReciever.Name = "txtReciever";
            this.txtReciever.Size = new System.Drawing.Size(114, 20);
            this.txtReciever.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Receive Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(18, 59);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(227, 20);
            this.txtSupplier.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PO Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Purchaser";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelSearch);
            this.tabPage2.Controls.Add(this.txtRecievedSupliertemSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(18, 27);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(154, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Recieved Supplier Item Search";
            // 
            // txtRecievedSupliertemSearch
            // 
            this.txtRecievedSupliertemSearch.Location = new System.Drawing.Point(21, 43);
            this.txtRecievedSupliertemSearch.Name = "txtRecievedSupliertemSearch";
            this.txtRecievedSupliertemSearch.Size = new System.Drawing.Size(329, 20);
            this.txtRecievedSupliertemSearch.TabIndex = 0;
            this.txtRecievedSupliertemSearch.TabIndexChanged += new System.EventHandler(this.txtRecievedSupliertemSearch_TabIndexChanged);
            this.txtRecievedSupliertemSearch.TextChanged += new System.EventHandler(this.txtRecievedSupliertemSearch_TextChanged);
            // 
            // dgRecieptItems
            // 
            this.dgRecieptItems.AllowUserToAddRows = false;
            this.dgRecieptItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecieptsLineID,
            this.RecieptsPartid,
            this.RecieptQnty,
            this.RecieptsDescription,
            this.Bcode,
            this.Reject});
            this.dgRecieptItems.ContextMenuStrip = this.ctxLineItems;
            this.dgRecieptItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRecieptItems.Location = new System.Drawing.Point(6, 6);
            this.dgRecieptItems.Name = "dgRecieptItems";
            this.dgRecieptItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRecieptItems.Size = new System.Drawing.Size(810, 429);
            this.dgRecieptItems.TabIndex = 0;
            this.dgRecieptItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRecieptItems_CellDoubleClick);
            this.dgRecieptItems.SelectionChanged += new System.EventHandler(this.dgRecieptItems_SelectionChanged);
            // 
            // ctxLineItems
            // 
            this.ctxLineItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSelectedLabelToolStripMenuItem,
            this.openPurchaseOrderToolStripMenuItem,
            this.newPartFromLineitemToolStripMenuItem});
            this.ctxLineItems.Name = "ctxLineItems";
            this.ctxLineItems.Size = new System.Drawing.Size(188, 70);
            this.ctxLineItems.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxLineItems_ItemClicked);
            // 
            // printSelectedLabelToolStripMenuItem
            // 
            this.printSelectedLabelToolStripMenuItem.Name = "printSelectedLabelToolStripMenuItem";
            this.printSelectedLabelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.printSelectedLabelToolStripMenuItem.Text = "Print Selected Label";
            // 
            // openPurchaseOrderToolStripMenuItem
            // 
            this.openPurchaseOrderToolStripMenuItem.Name = "openPurchaseOrderToolStripMenuItem";
            this.openPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openPurchaseOrderToolStripMenuItem.Text = "Open Purchase Order";
            // 
            // newPartFromLineitemToolStripMenuItem
            // 
            this.newPartFromLineitemToolStripMenuItem.Name = "newPartFromLineitemToolStripMenuItem";
            this.newPartFromLineitemToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.newPartFromLineitemToolStripMenuItem.Text = "New Part From item";
            // 
            // StockID
            // 
            this.StockID.DataPropertyName = "StockTransactionID";
            this.StockID.HeaderText = "StockID";
            this.StockID.Name = "StockID";
            this.StockID.Width = 60;
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
            // Qnty
            // 
            this.Qnty.DataPropertyName = "Qnty";
            this.Qnty.HeaderText = "Qnty";
            this.Qnty.Name = "Qnty";
            this.Qnty.Width = 60;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // RecieptsLineID
            // 
            this.RecieptsLineID.DataPropertyName = "LineID";
            this.RecieptsLineID.HeaderText = "LineID";
            this.RecieptsLineID.Name = "RecieptsLineID";
            this.RecieptsLineID.Width = 50;
            // 
            // RecieptsPartid
            // 
            this.RecieptsPartid.DataPropertyName = "PartID";
            this.RecieptsPartid.HeaderText = "PartID";
            this.RecieptsPartid.Name = "RecieptsPartid";
            this.RecieptsPartid.Width = 50;
            // 
            // RecieptQnty
            // 
            this.RecieptQnty.DataPropertyName = "Qnty";
            this.RecieptQnty.HeaderText = "Qnty";
            this.RecieptQnty.Name = "RecieptQnty";
            this.RecieptQnty.Width = 50;
            // 
            // RecieptsDescription
            // 
            this.RecieptsDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RecieptsDescription.DataPropertyName = "Description";
            this.RecieptsDescription.HeaderText = "Description";
            this.RecieptsDescription.Name = "RecieptsDescription";
            // 
            // Bcode
            // 
            this.Bcode.HeaderText = "Bcode";
            this.Bcode.Name = "Bcode";
            this.Bcode.Width = 110;
            // 
            // Reject
            // 
            this.Reject.DataPropertyName = "Rejected";
            this.Reject.HeaderText = "Reject";
            this.Reject.Name = "Reject";
            this.Reject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reject.Width = 60;
            // 
            // OrderReceiptsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "OrderReceiptsControl";
            this.Size = new System.Drawing.Size(1046, 575);
            this.Load += new System.EventHandler(this.OrderReceiptsControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbJobs.ResumeLayout(false);
            this.tbJobs.PerformLayout();
            this.tbSuppliers.ResumeLayout(false);
            this.tbSuppliers.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecieptItems)).EndInit();
            this.ctxLineItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbJobs;
        private System.Windows.Forms.ListBox lbJobListing;
        private System.Windows.Forms.TextBox tbJobSearch;
        private System.Windows.Forms.TabPage tbSuppliers;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lbSupplierList;
        private System.Windows.Forms.TextBox tbSearchSuppliers;
        private System.Windows.Forms.DataGridView dgRecieptItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ListView lvJobReciepts;
        private System.Windows.Forms.ColumnHeader RiD;
        private System.Windows.Forms.ColumnHeader Recieved;
        private System.Windows.Forms.ListView lvSuppliersReciept;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtPurchaser;
        private System.Windows.Forms.TextBox txtRecievedDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtPoNumber;
        private System.Windows.Forms.TextBox txtReciever;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtRecievedSupliertemSearch;
        private System.Windows.Forms.ContextMenuStrip ctxLineItems;
        private System.Windows.Forms.ToolStripMenuItem printSelectedLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolStripMenuItem newPartFromLineitemToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.TextBox txtLabelQnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptsLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptsPartid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptQnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptsDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bcode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reject;
    }
}
