namespace Weaselware.InventoryFerret
{
    partial class NewResourceForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewResourceForm));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtResourceDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(10, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(107, 11);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(349, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // txtResourceDescription
            // 
            this.txtResourceDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResourceDescription.Location = new System.Drawing.Point(107, 35);
            this.txtResourceDescription.Name = "txtResourceDescription";
            this.txtResourceDescription.Size = new System.Drawing.Size(349, 20);
            this.txtResourceDescription.TabIndex = 3;
            this.txtResourceDescription.TextChanged += new System.EventHandler(this.txtResourceDescription_TextChanged);
            this.txtResourceDescription.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(32, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Enabled = false;
            this.errorProvider1.SetIconPadding(this.btnSubmit, 2);
            this.btnSubmit.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_done_black_24dp;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Location = new System.Drawing.Point(342, 61);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_highlight_off_black_24dp;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(231, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewResourceForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 101);
            this.ControlBox = false;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtResourceDescription);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewResourceForm";
            this.Text = "Add Resource";
            this.Load += new System.EventHandler(this.NewResourceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtResourceDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}