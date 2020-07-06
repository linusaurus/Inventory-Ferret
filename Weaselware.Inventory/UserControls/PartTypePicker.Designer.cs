namespace Weaselware.InventoryFerret.UserControls
{
    partial class PartTypePicker
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
            this.tvPartTypes = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvPartTypes
            // 
            this.tvPartTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvPartTypes.Location = new System.Drawing.Point(2, 2);
            this.tvPartTypes.Name = "tvPartTypes";
            this.tvPartTypes.Size = new System.Drawing.Size(272, 469);
            this.tvPartTypes.TabIndex = 0;
            // 
            // PartTypePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvPartTypes);
            this.Name = "PartTypePicker";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(276, 476);
            this.Load += new System.EventHandler(this.PartTypePicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvPartTypes;
    }
}
