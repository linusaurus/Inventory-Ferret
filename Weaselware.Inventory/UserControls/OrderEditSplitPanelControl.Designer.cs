﻿namespace Weaselware.InventoryFerret.UserControls
{
    partial class OrderEditSplitPanelControl
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
            this.tsOrderEditToolBar = new System.Windows.Forms.ToolStrip();
            this.tsTooglePanels = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadPartFinder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbToogleOrderFee = new System.Windows.Forms.ToolStripButton();
            this.tsToogleHeader = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbToggleAttachment = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.orderHeaderVerticalControl1 = new Weaselware.InventoryFerret.UserControls.OrderHeaderVerticalControl();
            this.scLineItems = new System.Windows.Forms.SplitContainer();
            this.dgOrderLineItem = new System.Windows.Forms.DataGridView();
            this.tsOrderEditToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLineItems)).BeginInit();
            this.scLineItems.Panel1.SuspendLayout();
            this.scLineItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tsOrderEditToolBar
            // 
            this.tsOrderEditToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsOrderEditToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsOrderEditToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTooglePanels,
            this.toolStripSeparator3,
            this.tsbLoadPartFinder,
            this.toolStripSeparator2,
            this.tsbToogleOrderFee,
            this.tsToogleHeader,
            this.toolStripSeparator1,
            this.tsbToggleAttachment});
            this.tsOrderEditToolBar.Location = new System.Drawing.Point(6, 688);
            this.tsOrderEditToolBar.Name = "tsOrderEditToolBar";
            this.tsOrderEditToolBar.Size = new System.Drawing.Size(1149, 31);
            this.tsOrderEditToolBar.TabIndex = 0;
            this.tsOrderEditToolBar.Text = "Toogle Part Tools";
            // 
            // tsTooglePanels
            // 
            this.tsTooglePanels.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTooglePanels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTooglePanels.Image = global::Weaselware.InventoryFerret.Properties.Resources.round_keyboard_arrow_up_black_24dp;
            this.tsTooglePanels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTooglePanels.Name = "tsTooglePanels";
            this.tsTooglePanels.Size = new System.Drawing.Size(28, 28);
            this.tsTooglePanels.Text = "toolStripButton1";
            this.tsTooglePanels.ToolTipText = "tsToogleToolSet";
            this.tsTooglePanels.Click += new System.EventHandler(this.tsTooglePanels_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbLoadPartFinder
            // 
            this.tsbLoadPartFinder.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbLoadPartFinder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadPartFinder.Image = global::Weaselware.InventoryFerret.Properties.Resources.outline_attach_file_black_24dp;
            this.tsbLoadPartFinder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadPartFinder.Name = "tsbLoadPartFinder";
            this.tsbLoadPartFinder.Size = new System.Drawing.Size(28, 28);
            this.tsbLoadPartFinder.Text = "toolStripButton1";
            this.tsbLoadPartFinder.ToolTipText = "Add Attachments";
            this.tsbLoadPartFinder.Click += new System.EventHandler(this.tsbToggleAttachment_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbToogleOrderFee
            // 
            this.tsbToogleOrderFee.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbToogleOrderFee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbToogleOrderFee.Image = global::Weaselware.InventoryFerret.Properties.Resources.outline_request_quote_black_24dp;
            this.tsbToogleOrderFee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToogleOrderFee.Name = "tsbToogleOrderFee";
            this.tsbToogleOrderFee.Size = new System.Drawing.Size(28, 28);
            this.tsbToogleOrderFee.Text = "toolStripButton1";
            this.tsbToogleOrderFee.ToolTipText = "Add Order Fees";
            this.tsbToogleOrderFee.Click += new System.EventHandler(this.tsbToogleOrderFee_Click);
            // 
            // tsToogleHeader
            // 
            this.tsToogleHeader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsToogleHeader.Image = global::Weaselware.InventoryFerret.Properties.Resources.twotone_view_list_black_24dp;
            this.tsToogleHeader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsToogleHeader.Name = "tsToogleHeader";
            this.tsToogleHeader.Size = new System.Drawing.Size(28, 28);
            this.tsToogleHeader.Text = "toolStripButton1";
            this.tsToogleHeader.ToolTipText = "Toogle Header";
            this.tsToogleHeader.Click += new System.EventHandler(this.tsToogleHeader_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbToggleAttachment
            // 
            this.tsbToggleAttachment.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbToggleAttachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbToggleAttachment.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_post_add_black_24dp;
            this.tsbToggleAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToggleAttachment.Name = "tsbToggleAttachment";
            this.tsbToggleAttachment.Size = new System.Drawing.Size(28, 28);
            this.tsbToggleAttachment.Text = "toolStripButton1";
            this.tsbToggleAttachment.ToolTipText = "find parts";
            this.tsbToggleAttachment.Click += new System.EventHandler(this.tsbLoadPartFinder_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(6, 6);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.orderHeaderVerticalControl1);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.scLineItems);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(4, 4, 12, 4);
            this.splitContainerMain.Size = new System.Drawing.Size(1149, 682);
            this.splitContainerMain.SplitterDistance = 340;
            this.splitContainerMain.TabIndex = 1;
            // 
            // orderHeaderVerticalControl1
            // 
            this.orderHeaderVerticalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderHeaderVerticalControl1.Location = new System.Drawing.Point(4, 4);
            this.orderHeaderVerticalControl1.MinimumSize = new System.Drawing.Size(325, 0);
            this.orderHeaderVerticalControl1.Name = "orderHeaderVerticalControl1";
            this.orderHeaderVerticalControl1.Padding = new System.Windows.Forms.Padding(6);
            this.orderHeaderVerticalControl1.Size = new System.Drawing.Size(332, 674);
            this.orderHeaderVerticalControl1.TabIndex = 0;
            // 
            // scLineItems
            // 
            this.scLineItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLineItems.Location = new System.Drawing.Point(4, 4);
            this.scLineItems.Name = "scLineItems";
            this.scLineItems.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLineItems.Panel1
            // 
            this.scLineItems.Panel1.Controls.Add(this.dgOrderLineItem);
            this.scLineItems.Panel1.Padding = new System.Windows.Forms.Padding(4, 26, 4, 4);
            // 
            // scLineItems.Panel2
            // 
            this.scLineItems.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.scLineItems.Size = new System.Drawing.Size(789, 674);
            this.scLineItems.SplitterDistance = 407;
            this.scLineItems.TabIndex = 0;
            // 
            // dgOrderLineItem
            // 
            this.dgOrderLineItem.AllowUserToAddRows = false;
            this.dgOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderLineItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderLineItem.Location = new System.Drawing.Point(4, 26);
            this.dgOrderLineItem.Name = "dgOrderLineItem";
            this.dgOrderLineItem.Size = new System.Drawing.Size(781, 377);
            this.dgOrderLineItem.TabIndex = 0;
            // 
            // OrderEditSplitPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.tsOrderEditToolBar);
            this.Name = "OrderEditSplitPanelControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1161, 725);
            this.tsOrderEditToolBar.ResumeLayout(false);
            this.tsOrderEditToolBar.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.scLineItems.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scLineItems)).EndInit();
            this.scLineItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsOrderEditToolBar;
        private System.Windows.Forms.ToolStripButton tsTooglePanels;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer scLineItems;
        private System.Windows.Forms.DataGridView dgOrderLineItem;
        private System.Windows.Forms.ToolStripButton tsToogleHeader;
        private OrderHeaderVerticalControl orderHeaderVerticalControl1;
        private System.Windows.Forms.ToolStripButton tsbToggleAttachment;
        private System.Windows.Forms.ToolStripButton tsbLoadPartFinder;
        private System.Windows.Forms.ToolStripButton tsbToogleOrderFee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
