namespace Weaselware.InventoryFerret
{
    partial class SupplierOrdersControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierOrdersControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lvSuppliersOrders = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgOrderItems = new System.Windows.Forms.DataGridView();
            this.btnRecieveOrderItems = new System.Windows.Forms.Button();
            this.txtItemNotes = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPurchaser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbShowRecieved = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrintSelectedItemsLabels = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printStockTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownCopies = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenOrder = new System.Windows.Forms.Button();
            this.LineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reject = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItems)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSuppliersOrders
            // 
            this.lvSuppliersOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvSuppliersOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.Date,
            this.Recv});
            this.lvSuppliersOrders.FullRowSelect = true;
            this.lvSuppliersOrders.HideSelection = false;
            this.lvSuppliersOrders.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvSuppliersOrders.Location = new System.Drawing.Point(9, 210);
            this.lvSuppliersOrders.MultiSelect = false;
            this.lvSuppliersOrders.Name = "lvSuppliersOrders";
            this.lvSuppliersOrders.ShowGroups = false;
            this.lvSuppliersOrders.Size = new System.Drawing.Size(210, 363);
            this.lvSuppliersOrders.TabIndex = 6;
            this.lvSuppliersOrders.UseCompatibleStateImageBehavior = false;
            this.lvSuppliersOrders.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 85;
            // 
            // Recv
            // 
            this.Recv.Text = "Recv";
            // 
            // txtSearchSuppliers
            // 
            this.txtSearchSuppliers.Location = new System.Drawing.Point(9, 23);
            this.txtSearchSuppliers.Name = "txtSearchSuppliers";
            this.txtSearchSuppliers.Size = new System.Drawing.Size(129, 20);
            this.txtSearchSuppliers.TabIndex = 5;
            // 
            // lbSuppliers
            // 
            this.lbSuppliers.FormattingEnabled = true;
            this.lbSuppliers.Location = new System.Drawing.Point(9, 52);
            this.lbSuppliers.Name = "lbSuppliers";
            this.lbSuppliers.Size = new System.Drawing.Size(210, 134);
            this.lbSuppliers.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Accept-icon.png");
            // 
            // dgOrderItems
            // 
            this.dgOrderItems.AllowUserToAddRows = false;
            this.dgOrderItems.AllowUserToDeleteRows = false;
            this.dgOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineID,
            this.PartID,
            this.Description,
            this.Qnty,
            this.Extended,
            this.Reject});
            this.dgOrderItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgOrderItems.Location = new System.Drawing.Point(234, 52);
            this.dgOrderItems.Name = "dgOrderItems";
            this.dgOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderItems.Size = new System.Drawing.Size(816, 233);
            this.dgOrderItems.TabIndex = 7;
            this.dgOrderItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderItems_CellClick);
            this.dgOrderItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderItems_CellContentClick);
            this.dgOrderItems.SelectionChanged += new System.EventHandler(this.dgOrderItems_SelectionChanged);
            // 
            // btnRecieveOrderItems
            // 
            this.btnRecieveOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecieveOrderItems.Location = new System.Drawing.Point(935, 20);
            this.btnRecieveOrderItems.Name = "btnRecieveOrderItems";
            this.btnRecieveOrderItems.Size = new System.Drawing.Size(115, 23);
            this.btnRecieveOrderItems.TabIndex = 8;
            this.btnRecieveOrderItems.Text = "Recieve Items";
            this.btnRecieveOrderItems.UseVisualStyleBackColor = true;
            this.btnRecieveOrderItems.Click += new System.EventHandler(this.btnRecieveOrderItems_Click);
            // 
            // txtItemNotes
            // 
            this.txtItemNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemNotes.Location = new System.Drawing.Point(572, 345);
            this.txtItemNotes.Multiline = true;
            this.txtItemNotes.Name = "txtItemNotes";
            this.txtItemNotes.Size = new System.Drawing.Size(478, 80);
            this.txtItemNotes.TabIndex = 9;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(234, 20);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(99, 23);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtJobName
            // 
            this.txtJobName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtJobName.Location = new System.Drawing.Point(297, 346);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(269, 20);
            this.txtJobName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Job name";
            // 
            // txtPurchaser
            // 
            this.txtPurchaser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPurchaser.Location = new System.Drawing.Point(297, 370);
            this.txtPurchaser.Margin = new System.Windows.Forms.Padding(1);
            this.txtPurchaser.Name = "txtPurchaser";
            this.txtPurchaser.Size = new System.Drawing.Size(137, 20);
            this.txtPurchaser.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Purchaser";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOrderDate.Location = new System.Drawing.Point(476, 370);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(1);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(90, 20);
            this.txtOrderDate.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date";
            // 
            // chbShowRecieved
            // 
            this.chbShowRecieved.AutoSize = true;
            this.chbShowRecieved.Location = new System.Drawing.Point(10, 189);
            this.chbShowRecieved.Name = "chbShowRecieved";
            this.chbShowRecieved.Size = new System.Drawing.Size(102, 17);
            this.chbShowRecieved.TabIndex = 14;
            this.chbShowRecieved.Text = "Show Recieved";
            this.chbShowRecieved.UseVisualStyleBackColor = true;
            this.chbShowRecieved.CheckedChanged += new System.EventHandler(this.chbShowRecieved_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "lbOrderNumber";
            // 
            // btnPrintSelectedItemsLabels
            // 
            this.btnPrintSelectedItemsLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintSelectedItemsLabels.Location = new System.Drawing.Point(234, 291);
            this.btnPrintSelectedItemsLabels.Name = "btnPrintSelectedItemsLabels";
            this.btnPrintSelectedItemsLabels.Size = new System.Drawing.Size(185, 23);
            this.btnPrintSelectedItemsLabels.TabIndex = 16;
            this.btnPrintSelectedItemsLabels.Text = "Print Selected Item Labels";
            this.btnPrintSelectedItemsLabels.UseVisualStyleBackColor = true;
            this.btnPrintSelectedItemsLabels.Click += new System.EventHandler(this.btnPrintSelectedItemsLabels_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printStockTagToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // printStockTagToolStripMenuItem
            // 
            this.printStockTagToolStripMenuItem.Name = "printStockTagToolStripMenuItem";
            this.printStockTagToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printStockTagToolStripMenuItem.Text = "Print Stock Tag";
            // 
            // numericUpDownCopies
            // 
            this.numericUpDownCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownCopies.Location = new System.Drawing.Point(477, 294);
            this.numericUpDownCopies.Name = "numericUpDownCopies";
            this.numericUpDownCopies.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownCopies.TabIndex = 19;
            this.numericUpDownCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Copies";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenOrder
            // 
            this.btnOpenOrder.Location = new System.Drawing.Point(144, 21);
            this.btnOpenOrder.Name = "btnOpenOrder";
            this.btnOpenOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOrder.TabIndex = 21;
            this.btnOpenOrder.Text = "Open Orders";
            this.btnOpenOrder.UseVisualStyleBackColor = true;
            this.btnOpenOrder.Click += new System.EventHandler(this.OnOpenOrdersCliecked);
            // 
            // LineID
            // 
            this.LineID.DataPropertyName = "LineID";
            this.LineID.HeaderText = "LineID";
            this.LineID.Name = "LineID";
            this.LineID.Width = 75;
            // 
            // PartID
            // 
            this.PartID.ActiveLinkColor = System.Drawing.Color.Gold;
            this.PartID.DataPropertyName = "PartID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = null;
            this.PartID.DefaultCellStyle = dataGridViewCellStyle1;
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            this.PartID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PartID.Width = 70;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Qnty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Qnty.HeaderText = "Qnty";
            this.Qnty.Name = "Qnty";
            this.Qnty.Width = 65;
            // 
            // Extended
            // 
            this.Extended.DataPropertyName = "Extended";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Extended.DefaultCellStyle = dataGridViewCellStyle3;
            this.Extended.HeaderText = "Extended";
            this.Extended.Name = "Extended";
            this.Extended.Width = 70;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // SupplierOrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOpenOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownCopies);
            this.Controls.Add(this.btnPrintSelectedItemsLabels);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbShowRecieved);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPurchaser);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtItemNotes);
            this.Controls.Add(this.btnRecieveOrderItems);
            this.Controls.Add(this.dgOrderItems);
            this.Controls.Add(this.lvSuppliersOrders);
            this.Controls.Add(this.txtSearchSuppliers);
            this.Controls.Add(this.lbSuppliers);
            this.Name = "SupplierOrdersControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1094, 601);
            this.Load += new System.EventHandler(this.SupplierOrdersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItems)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSuppliersOrders;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Recv;
        private System.Windows.Forms.TextBox txtSearchSuppliers;
        private System.Windows.Forms.ListBox lbSuppliers;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgOrderItems;
        private System.Windows.Forms.Button btnRecieveOrderItems;
        private System.Windows.Forms.TextBox txtItemNotes;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPurchaser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbShowRecieved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrintSelectedItemsLabels;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printStockTagToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownCopies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpenOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID;
        private System.Windows.Forms.DataGridViewLinkColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extended;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reject;
        private System.Windows.Forms.Label label6;
    }
}
