namespace Weaselware.InventoryFerret
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsOrderButton = new System.Windows.Forms.ToolStripButton();
            this.tsbFindOrder = new System.Windows.Forms.ToolStripButton();
            this.tsbReceiveOrder = new System.Windows.Forms.ToolStripButton();
            this.tsPartEditor = new System.Windows.Forms.ToolStripButton();
            this.tsbJobItems = new System.Windows.Forms.ToolStripButton();
            this.tsScanBarCode = new System.Windows.Forms.ToolStripLabel();
            this.tsbJobOrders = new System.Windows.Forms.ToolStripButton();
            this.tsSettingsButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.mainToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOrderButton,
            this.tsbFindOrder,
            this.tsbReceiveOrder,
            this.tsPartEditor,
            this.tsbJobItems,
            this.tsScanBarCode,
            this.tsbJobOrders,
            this.tsSettingsButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1116, 55);
            this.mainToolStrip.TabIndex = 0;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // tsOrderButton
            // 
            this.tsOrderButton.Image = global::Weaselware.InventoryFerret.Properties.Resources.stamped_document;
            this.tsOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOrderButton.Name = "tsOrderButton";
            this.tsOrderButton.Size = new System.Drawing.Size(68, 52);
            this.tsOrderButton.Text = "New Order";
            this.tsOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsOrderButton.ToolTipText = "New Order";
            this.tsOrderButton.Click += new System.EventHandler(this.tsOrderButton_Click);
            // 
            // tsbFindOrder
            // 
            this.tsbFindOrder.Enabled = false;
            this.tsbFindOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsbFindOrder.Image")));
            this.tsbFindOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFindOrder.Name = "tsbFindOrder";
            this.tsbFindOrder.Size = new System.Drawing.Size(67, 52);
            this.tsbFindOrder.Text = "Find Order";
            this.tsbFindOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbReceiveOrder
            // 
            this.tsbReceiveOrder.Image = global::Weaselware.InventoryFerret.Properties.Resources.edit;
            this.tsbReceiveOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReceiveOrder.Name = "tsbReceiveOrder";
            this.tsbReceiveOrder.Size = new System.Drawing.Size(89, 52);
            this.tsbReceiveOrder.Text = "Recieve Orders";
            this.tsbReceiveOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbReceiveOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbReceiveOrder.Click += new System.EventHandler(this.tsbReceiveOrder_Click);
            // 
            // tsPartEditor
            // 
            this.tsPartEditor.Image = global::Weaselware.InventoryFerret.Properties.Resources.gear;
            this.tsPartEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPartEditor.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.tsPartEditor.Name = "tsPartEditor";
            this.tsPartEditor.Size = new System.Drawing.Size(66, 51);
            this.tsPartEditor.Text = "Part Editor";
            this.tsPartEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPartEditor.ToolTipText = "Parts Manager";
            this.tsPartEditor.Click += new System.EventHandler(this.tsPartEditor_Click);
            // 
            // tsbJobItems
            // 
            this.tsbJobItems.Image = global::Weaselware.InventoryFerret.Properties.Resources.product_in_progress;
            this.tsbJobItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJobItems.Name = "tsbJobItems";
            this.tsbJobItems.Size = new System.Drawing.Size(61, 52);
            this.tsbJobItems.Text = "Job Items";
            this.tsbJobItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbJobItems.ToolTipText = "Pull Stock";
            this.tsbJobItems.Click += new System.EventHandler(this.tsbJobItems_OnClick);
            // 
            // tsScanBarCode
            // 
            this.tsScanBarCode.Image = global::Weaselware.InventoryFerret.Properties.Resources.barcode;
            this.tsScanBarCode.Margin = new System.Windows.Forms.Padding(15, 1, 15, 2);
            this.tsScanBarCode.Name = "tsScanBarCode";
            this.tsScanBarCode.Size = new System.Drawing.Size(79, 52);
            this.tsScanBarCode.Text = "Stock Actions";
            this.tsScanBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsScanBarCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsScanBarCode.ToolTipText = "Lookup Stock Tag";
            this.tsScanBarCode.Click += new System.EventHandler(this.tsScanBarCode_Click);
            // 
            // tsbJobOrders
            // 
            this.tsbJobOrders.Image = ((System.Drawing.Image)(resources.GetObject("tsbJobOrders.Image")));
            this.tsbJobOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJobOrders.Name = "tsbJobOrders";
            this.tsbJobOrders.Size = new System.Drawing.Size(67, 52);
            this.tsbJobOrders.Text = "Job Orders";
            this.tsbJobOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsSettingsButton
            // 
            this.tsSettingsButton.CheckOnClick = true;
            this.tsSettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSettingsButton.Image = global::Weaselware.InventoryFerret.Properties.Resources.printer;
            this.tsSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSettingsButton.Name = "tsSettingsButton";
            this.tsSettingsButton.Size = new System.Drawing.Size(36, 52);
            this.tsSettingsButton.Text = "search";
            this.tsSettingsButton.Click += new System.EventHandler(this.tsSettingsButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1116, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "{{Current Tab}}";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ItemSize = new System.Drawing.Size(58, 24);
            this.MainTabControl.Location = new System.Drawing.Point(0, 55);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.ShowToolTips = true;
            this.MainTabControl.Size = new System.Drawing.Size(1116, 559);
            this.MainTabControl.TabIndex = 2;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MaintabControl_SelectedIndexChanged);
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 636);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1025, 420);
            this.Name = "Main";
            this.Text = "Inventory Ferrit";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripButton tsSettingsButton;
        private System.Windows.Forms.ToolStripLabel tsScanBarCode;
        private System.Windows.Forms.ToolStripButton tsbJobItems;
        private System.Windows.Forms.ToolStripButton tsPartEditor;
        private System.Windows.Forms.ToolStripButton tsOrderButton;
        private System.Windows.Forms.ToolStripButton tsbReceiveOrder;
        private System.Windows.Forms.ToolStripButton tsbJobOrders;
        private System.Windows.Forms.ToolStripButton tsbFindOrder;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}