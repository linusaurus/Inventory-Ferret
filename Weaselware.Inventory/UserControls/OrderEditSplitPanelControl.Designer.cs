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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsTooglePanels = new System.Windows.Forms.ToolStripButton();
            this.tsToogleHeader = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.orderHeaderVerticalControl1 = new Weaselware.InventoryFerret.UserControls.OrderHeaderVerticalControl();
            this.scLineItems = new System.Windows.Forms.SplitContainer();
            this.dgOrderLineItem = new System.Windows.Forms.DataGridView();
            this.partFinderControl1 = new Weaselware.InventoryFerret.PartFinderControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLineItems)).BeginInit();
            this.scLineItems.Panel1.SuspendLayout();
            this.scLineItems.Panel2.SuspendLayout();
            this.scLineItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItem)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTooglePanels,
            this.tsToogleHeader});
            this.toolStrip1.Location = new System.Drawing.Point(6, 733);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1149, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Toogle Part Tools";
            // 
            // tsTooglePanels
            // 
            this.tsTooglePanels.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTooglePanels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTooglePanels.Image = global::Weaselware.InventoryFerret.Properties.Resources.outline_message_black_24dp2;
            this.tsTooglePanels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTooglePanels.Name = "tsTooglePanels";
            this.tsTooglePanels.Size = new System.Drawing.Size(28, 28);
            this.tsTooglePanels.Text = "toolStripButton1";
            this.tsTooglePanels.ToolTipText = "tsToogleToolSet";
            this.tsTooglePanels.Click += new System.EventHandler(this.tsTooglePanels_Click);
            // 
            // tsToogleHeader
            // 
            this.tsToogleHeader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsToogleHeader.Image = global::Weaselware.InventoryFerret.Properties.Resources.twotone_view_list_black_24dp;
            this.tsToogleHeader.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsToogleHeader.Name = "tsToogleHeader";
            this.tsToogleHeader.Size = new System.Drawing.Size(28, 28);
            this.tsToogleHeader.Text = "toolStripButton1";
            this.tsToogleHeader.Click += new System.EventHandler(this.tsToogleHeader_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainerMain.Size = new System.Drawing.Size(1149, 727);
            this.splitContainerMain.SplitterDistance = 350;
            this.splitContainerMain.TabIndex = 1;
            // 
            // orderHeaderVerticalControl1
            // 
            this.orderHeaderVerticalControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderHeaderVerticalControl1.Location = new System.Drawing.Point(4, 4);
            this.orderHeaderVerticalControl1.MinimumSize = new System.Drawing.Size(325, 0);
            this.orderHeaderVerticalControl1.Name = "orderHeaderVerticalControl1";
            this.orderHeaderVerticalControl1.Padding = new System.Windows.Forms.Padding(6);
            this.orderHeaderVerticalControl1.Size = new System.Drawing.Size(342, 719);
            this.orderHeaderVerticalControl1.TabIndex = 0;
            // 
            // scLineItems
            // 
            this.scLineItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLineItems.Location = new System.Drawing.Point(0, 0);
            this.scLineItems.Name = "scLineItems";
            this.scLineItems.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLineItems.Panel1
            // 
            this.scLineItems.Panel1.Controls.Add(this.dgOrderLineItem);
            this.scLineItems.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // scLineItems.Panel2
            // 
            this.scLineItems.Panel2.Controls.Add(this.partFinderControl1);
            this.scLineItems.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.scLineItems.Size = new System.Drawing.Size(795, 727);
            this.scLineItems.SplitterDistance = 440;
            this.scLineItems.TabIndex = 0;
            // 
            // dgOrderLineItem
            // 
            this.dgOrderLineItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderLineItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrderLineItem.Location = new System.Drawing.Point(4, 4);
            this.dgOrderLineItem.Name = "dgOrderLineItem";
            this.dgOrderLineItem.Size = new System.Drawing.Size(787, 432);
            this.dgOrderLineItem.TabIndex = 0;
            // 
            // partFinderControl1
            // 
            this.partFinderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partFinderControl1.Location = new System.Drawing.Point(4, 4);
            this.partFinderControl1.Name = "partFinderControl1";
            this.partFinderControl1.SelectedPart = null;
            this.partFinderControl1.Size = new System.Drawing.Size(787, 275);
            this.partFinderControl1.TabIndex = 0;
            this.partFinderControl1.Load += new System.EventHandler(this.partFinderControl1_Load);
            // 
            // OrderEditSplitPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OrderEditSplitPanelControl";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(1161, 770);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.scLineItems.Panel1.ResumeLayout(false);
            this.scLineItems.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scLineItems)).EndInit();
            this.scLineItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderLineItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsTooglePanels;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer scLineItems;
        private System.Windows.Forms.DataGridView dgOrderLineItem;
        private System.Windows.Forms.ToolStripButton tsToogleHeader;
        private OrderHeaderVerticalControl orderHeaderVerticalControl1;
        private PartFinderControl partFinderControl1;
    }
}