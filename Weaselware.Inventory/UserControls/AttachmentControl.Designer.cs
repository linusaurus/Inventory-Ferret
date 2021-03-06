﻿namespace Weaselware.InventoryFerret.UserControls
{
    partial class AttachmentControl
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
            this.dgResources = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenResource = new System.Windows.Forms.Button();
            this.btnAddResource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResources
            // 
            this.dgResources.AllowUserToResizeColumns = false;
            this.dgResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResources.Location = new System.Drawing.Point(7, 43);
            this.dgResources.Name = "dgResources";
            this.dgResources.Size = new System.Drawing.Size(769, 192);
            this.dgResources.TabIndex = 16;
            this.dgResources.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResources_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::Weaselware.InventoryFerret.Properties.Resources.outline_delete_black_24dp2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(281, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Delete";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnOpenResource
            // 
            this.btnOpenResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenResource.FlatAppearance.BorderSize = 0;
            this.btnOpenResource.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_launch_black_24dp;
            this.btnOpenResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenResource.Location = new System.Drawing.Point(145, 7);
            this.btnOpenResource.Name = "btnOpenResource";
            this.btnOpenResource.Size = new System.Drawing.Size(118, 30);
            this.btnOpenResource.TabIndex = 19;
            this.btnOpenResource.Text = "Open Attachment";
            this.btnOpenResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenResource.UseVisualStyleBackColor = false;
            this.btnOpenResource.Click += new System.EventHandler(this.btnOpenResource_Click);
            // 
            // btnAddResource
            // 
            this.btnAddResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddResource.FlatAppearance.BorderSize = 0;
            this.btnAddResource.Image = global::Weaselware.InventoryFerret.Properties.Resources.round_add_circle_black_24dp1;
            this.btnAddResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddResource.Location = new System.Drawing.Point(9, 7);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(118, 30);
            this.btnAddResource.TabIndex = 20;
            this.btnAddResource.Text = "Add Attachment";
            this.btnAddResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddResource.UseVisualStyleBackColor = false;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // AttachmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenResource);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.dgResources);
            this.Name = "AttachmentControl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(783, 242);
            this.Load += new System.EventHandler(this.AttachmentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenResource;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.Button button1;
    }
}
