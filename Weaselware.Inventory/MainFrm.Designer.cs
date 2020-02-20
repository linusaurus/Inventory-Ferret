namespace Weaselware.InventoryFerret
{
    partial class MainFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.dgLineItems = new System.Windows.Forms.DataGridView();
            this.Lineid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QntyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QntyRecieved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdbPrinter = new System.Windows.Forms.ToolStripDropDownButton();
            this.printSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbOrderItems = new System.Windows.Forms.TabPage();
            this.tbFilterOrders = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbToInventory = new System.Windows.Forms.RadioButton();
            this.rbConsume = new System.Windows.Forms.RadioButton();
            this.btnBlowNGo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRecieve = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.tbJobItem = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbJobs = new System.Windows.Forms.ListBox();
            this.chkJobShowRecived = new System.Windows.Forms.CheckBox();
            this.txtJobSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchInDescription = new System.Windows.Forms.TextBox();
            this.dgJobItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobOrderReciept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbOrderReciepts = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbOrderItems.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbJobItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJobItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLineItems
            // 
            this.dgLineItems.AllowUserToAddRows = false;
            this.dgLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lineid,
            this.PartNumber,
            this.Description,
            this.UoM,
            this.QntyOrdered,
            this.QntyRecieved});
            this.dgLineItems.Location = new System.Drawing.Point(100, 135);
            this.dgLineItems.Name = "dgLineItems";
            this.dgLineItems.Size = new System.Drawing.Size(873, 329);
            this.dgLineItems.TabIndex = 0;
            // 
            // Lineid
            // 
            this.Lineid.DataPropertyName = "LineID";
            this.Lineid.HeaderText = "LineID";
            this.Lineid.Name = "Lineid";
            this.Lineid.Width = 70;
            // 
            // PartNumber
            // 
            this.PartNumber.DataPropertyName = "PartID";
            this.PartNumber.HeaderText = "PartID";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Width = 70;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // UoM
            // 
            this.UoM.DataPropertyName = "Uom";
            this.UoM.HeaderText = "UOM";
            this.UoM.Name = "UoM";
            this.UoM.Width = 50;
            // 
            // QntyOrdered
            // 
            this.QntyOrdered.DataPropertyName = "Qnty";
            this.QntyOrdered.HeaderText = "Qnty Ordered";
            this.QntyOrdered.Name = "QntyOrdered";
            this.QntyOrdered.Width = 80;
            // 
            // QntyRecieved
            // 
            this.QntyRecieved.DataPropertyName = "AmountReceived";
            this.QntyRecieved.HeaderText = "Qnty Received";
            this.QntyRecieved.Name = "QntyRecieved";
            this.QntyRecieved.Width = 80;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(898, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.tsdbPrinter,
            this.toolStripButton1});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1002, 25);
            this.tsMain.TabIndex = 5;
            this.tsMain.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "fileDropDownMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem1.Text = "Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsdbPrinter
            // 
            this.tsdbPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsdbPrinter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSettingsToolStripMenuItem,
            this.printSelectedLabelToolStripMenuItem});
            this.tsdbPrinter.Image = ((System.Drawing.Image)(resources.GetObject("tsdbPrinter.Image")));
            this.tsdbPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdbPrinter.Name = "tsdbPrinter";
            this.tsdbPrinter.Size = new System.Drawing.Size(29, 22);
            this.tsdbPrinter.Text = "toolStripDropDownButton2";
            this.tsdbPrinter.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsdbPrinter_DropDownItemClicked);
            // 
            // printSettingsToolStripMenuItem
            // 
            this.printSettingsToolStripMenuItem.Name = "printSettingsToolStripMenuItem";
            this.printSettingsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.printSettingsToolStripMenuItem.Text = "Print Settings";
            // 
            // printSelectedLabelToolStripMenuItem
            // 
            this.printSelectedLabelToolStripMenuItem.Name = "printSelectedLabelToolStripMenuItem";
            this.printSelectedLabelToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.printSelectedLabelToolStripMenuItem.Text = "Print Selected Label";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbOrderItems);
            this.tabMain.Controls.Add(this.tbJobItem);
            this.tabMain.Controls.Add(this.tbOrderReciepts);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 25);
            this.tabMain.MinimumSize = new System.Drawing.Size(800, 300);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1002, 529);
            this.tabMain.TabIndex = 7;
            // 
            // tbOrderItems
            // 
            this.tbOrderItems.Controls.Add(this.tbFilterOrders);
            this.tbOrderItems.Controls.Add(this.groupBox1);
            this.tbOrderItems.Controls.Add(this.button2);
            this.tbOrderItems.Controls.Add(this.btnRecieve);
            this.tbOrderItems.Controls.Add(this.lbOrders);
            this.tbOrderItems.Controls.Add(this.dgLineItems);
            this.tbOrderItems.Controls.Add(this.btnSave);
            this.tbOrderItems.Location = new System.Drawing.Point(4, 22);
            this.tbOrderItems.Name = "tbOrderItems";
            this.tbOrderItems.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrderItems.Size = new System.Drawing.Size(994, 503);
            this.tbOrderItems.TabIndex = 0;
            this.tbOrderItems.Text = "Purchase Orders";
            this.tbOrderItems.UseVisualStyleBackColor = true;
            // 
            // tbFilterOrders
            // 
            this.tbFilterOrders.Location = new System.Drawing.Point(8, 109);
            this.tbFilterOrders.Name = "tbFilterOrders";
            this.tbFilterOrders.Size = new System.Drawing.Size(86, 20);
            this.tbFilterOrders.TabIndex = 9;
            this.tbFilterOrders.TextChanged += new System.EventHandler(this.tbFilterOrders_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbToInventory);
            this.groupBox1.Controls.Add(this.rbConsume);
            this.groupBox1.Controls.Add(this.btnBlowNGo);
            this.groupBox1.Location = new System.Drawing.Point(746, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick and Dirty";
            // 
            // rbToInventory
            // 
            this.rbToInventory.AutoSize = true;
            this.rbToInventory.Location = new System.Drawing.Point(122, 42);
            this.rbToInventory.Name = "rbToInventory";
            this.rbToInventory.Size = new System.Drawing.Size(85, 17);
            this.rbToInventory.TabIndex = 7;
            this.rbToInventory.TabStop = true;
            this.rbToInventory.Text = "To Inventory";
            this.rbToInventory.UseVisualStyleBackColor = true;
            // 
            // rbConsume
            // 
            this.rbConsume.AutoSize = true;
            this.rbConsume.Location = new System.Drawing.Point(122, 19);
            this.rbConsume.Name = "rbConsume";
            this.rbConsume.Size = new System.Drawing.Size(94, 17);
            this.rbConsume.TabIndex = 6;
            this.rbConsume.TabStop = true;
            this.rbConsume.Text = "Consume Now";
            this.rbConsume.UseVisualStyleBackColor = true;
            // 
            // btnBlowNGo
            // 
            this.btnBlowNGo.Location = new System.Drawing.Point(18, 19);
            this.btnBlowNGo.Name = "btnBlowNGo";
            this.btnBlowNGo.Size = new System.Drawing.Size(87, 23);
            this.btnBlowNGo.TabIndex = 5;
            this.btnBlowNGo.Text = "Blow n\' Go";
            this.btnBlowNGo.UseVisualStyleBackColor = true;
            this.btnBlowNGo.Click += new System.EventHandler(this.btnBlowNGo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Push Ad Hoc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRecieve
            // 
            this.btnRecieve.Location = new System.Drawing.Point(36, 14);
            this.btnRecieve.Name = "btnRecieve";
            this.btnRecieve.Size = new System.Drawing.Size(117, 23);
            this.btnRecieve.TabIndex = 6;
            this.btnRecieve.Text = "Recieve Order";
            this.btnRecieve.UseVisualStyleBackColor = true;
            this.btnRecieve.Click += new System.EventHandler(this.btnRecieve_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(8, 135);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(86, 329);
            this.lbOrders.TabIndex = 4;
            this.lbOrders.SelectedIndexChanged += new System.EventHandler(this.lbOrders_SelectedIndexChanged_1);
            // 
            // tbJobItem
            // 
            this.tbJobItem.Controls.Add(this.splitContainer1);
            this.tbJobItem.Location = new System.Drawing.Point(4, 22);
            this.tbJobItem.Name = "tbJobItem";
            this.tbJobItem.Padding = new System.Windows.Forms.Padding(3);
            this.tbJobItem.Size = new System.Drawing.Size(994, 503);
            this.tbJobItem.TabIndex = 1;
            this.tbJobItem.Text = "Job Items";
            this.tbJobItem.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbJobs);
            this.splitContainer1.Panel1.Controls.Add(this.chkJobShowRecived);
            this.splitContainer1.Panel1.Controls.Add(this.txtJobSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtSearchInDescription);
            this.splitContainer1.Panel2.Controls.Add(this.dgJobItems);
            this.splitContainer1.Size = new System.Drawing.Size(988, 497);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 6;
            // 
            // lbJobs
            // 
            this.lbJobs.FormattingEnabled = true;
            this.lbJobs.Location = new System.Drawing.Point(22, 114);
            this.lbJobs.Name = "lbJobs";
            this.lbJobs.Size = new System.Drawing.Size(153, 160);
            this.lbJobs.TabIndex = 0;
            this.lbJobs.SelectedIndexChanged += new System.EventHandler(this.lbJobs_SelectedIndexChanged);
            // 
            // chkJobShowRecived
            // 
            this.chkJobShowRecived.AutoSize = true;
            this.chkJobShowRecived.Location = new System.Drawing.Point(22, 280);
            this.chkJobShowRecived.Name = "chkJobShowRecived";
            this.chkJobShowRecived.Size = new System.Drawing.Size(102, 17);
            this.chkJobShowRecived.TabIndex = 5;
            this.chkJobShowRecived.Text = "Show Recieved";
            this.chkJobShowRecived.UseVisualStyleBackColor = true;
            this.chkJobShowRecived.CheckedChanged += new System.EventHandler(this.chkJobHideRecived_CheckedChanged);
            // 
            // txtJobSearch
            // 
            this.txtJobSearch.Location = new System.Drawing.Point(22, 88);
            this.txtJobSearch.Name = "txtJobSearch";
            this.txtJobSearch.Size = new System.Drawing.Size(153, 20);
            this.txtJobSearch.TabIndex = 1;
            this.txtJobSearch.TextChanged += new System.EventHandler(this.txtJobSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Description";
            // 
            // txtSearchInDescription
            // 
            this.txtSearchInDescription.Location = new System.Drawing.Point(490, 34);
            this.txtSearchInDescription.Name = "txtSearchInDescription";
            this.txtSearchInDescription.Size = new System.Drawing.Size(256, 20);
            this.txtSearchInDescription.TabIndex = 3;
            this.txtSearchInDescription.TextChanged += new System.EventHandler(this.txtSearchInDescription_TextChanged);
            // 
            // dgJobItems
            // 
            this.dgJobItems.AllowUserToAddRows = false;
            this.dgJobItems.AllowUserToDeleteRows = false;
            this.dgJobItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJobItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PO,
            this.jobPartID,
            this.jobDescription,
            this.jobOrderReciept});
            this.dgJobItems.Location = new System.Drawing.Point(23, 88);
            this.dgJobItems.Name = "dgJobItems";
            this.dgJobItems.ReadOnly = true;
            this.dgJobItems.Size = new System.Drawing.Size(723, 389);
            this.dgJobItems.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "LineID";
            this.ID.HeaderText = "LineID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // PO
            // 
            this.PO.DataPropertyName = "PurchaseOrderID";
            this.PO.HeaderText = "PO";
            this.PO.Name = "PO";
            this.PO.ReadOnly = true;
            this.PO.Width = 60;
            // 
            // jobPartID
            // 
            this.jobPartID.DataPropertyName = "PartID";
            this.jobPartID.HeaderText = "PartID";
            this.jobPartID.Name = "jobPartID";
            this.jobPartID.ReadOnly = true;
            this.jobPartID.Width = 70;
            // 
            // jobDescription
            // 
            this.jobDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobDescription.DataPropertyName = "Description";
            this.jobDescription.HeaderText = "Description";
            this.jobDescription.Name = "jobDescription";
            this.jobDescription.ReadOnly = true;
            // 
            // jobOrderReciept
            // 
            this.jobOrderReciept.DataPropertyName = "OrderReceiptID";
            this.jobOrderReciept.HeaderText = "Order Receipt";
            this.jobOrderReciept.Name = "jobOrderReciept";
            this.jobOrderReciept.ReadOnly = true;
            // 
            // tbOrderReciepts
            // 
            this.tbOrderReciepts.Location = new System.Drawing.Point(4, 22);
            this.tbOrderReciepts.Name = "tbOrderReciepts";
            this.tbOrderReciepts.Size = new System.Drawing.Size(994, 503);
            this.tbOrderReciepts.TabIndex = 2;
            this.tbOrderReciepts.Text = "Order Reciepts";
            this.tbOrderReciepts.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 576);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tbOrderItems.ResumeLayout(false);
            this.tbOrderItems.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbJobItem.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgJobItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLineItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.TabPage tbOrderItems;
        private System.Windows.Forms.TabPage tbJobItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lineid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QntyOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn QntyRecieved;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRecieve;
        private System.Windows.Forms.Button btnBlowNGo;
        private System.Windows.Forms.TabPage tbOrderReciepts;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbToInventory;
        private System.Windows.Forms.RadioButton rbConsume;
        private System.Windows.Forms.TextBox txtJobSearch;
        private System.Windows.Forms.ListBox lbJobs;
        private System.Windows.Forms.DataGridView dgJobItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchInDescription;
        private System.Windows.Forms.CheckBox chkJobShowRecived;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobOrderReciept;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbFilterOrders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsdbPrinter;
        private System.Windows.Forms.ToolStripMenuItem printSettingsToolStripMenuItem;
        private PitemsGrid pitemsGrid1;
        private System.Windows.Forms.ToolStripMenuItem printSelectedLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

