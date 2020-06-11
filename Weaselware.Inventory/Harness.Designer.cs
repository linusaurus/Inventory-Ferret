using DataLayer.Entities;

namespace Weaselware.InventoryFerret
{
    partial class Harness
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
            this.orderEditSplitPanelControl1 = new Weaselware.InventoryFerret.UserControls.OrderEditSplitPanelControl();
            this.SuspendLayout();
            // 
            // orderEditSplitPanelControl1
            // 
            this.orderEditSplitPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderEditSplitPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.orderEditSplitPanelControl1.Name = "orderEditSplitPanelControl1";
            this.orderEditSplitPanelControl1.Padding = new System.Windows.Forms.Padding(6);
            this.orderEditSplitPanelControl1.Size = new System.Drawing.Size(1106, 797);
            this.orderEditSplitPanelControl1.TabIndex = 0;
            // 
            // Harness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 797);
            this.Controls.Add(this.orderEditSplitPanelControl1);
            this.Name = "Harness";
            this.Text = "Harness";
            this.Load += new System.EventHandler(this.Harness_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.OrderEditSplitPanelControl orderEditSplitPanelControl1;
    }
}