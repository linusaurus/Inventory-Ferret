namespace Weaselware.InventoryFerret.UserControls
{
    partial class PartResourceEditorControl
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnNewVersion = new System.Windows.Forms.Button();
            this.btnOpenResource = new System.Windows.Forms.Button();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cboUnitOfMeasure = new System.Windows.Forms.ComboBox();
            this.gboxPart = new System.Windows.Forms.GroupBox();
            this.txtWaste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgResources
            // 
            this.dgResources.AllowUserToResizeColumns = false;
            this.dgResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResources.Location = new System.Drawing.Point(66, 525);
            this.dgResources.Name = "dgResources";
            this.dgResources.Size = new System.Drawing.Size(631, 138);
            this.dgResources.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_visibility_black_24dp;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(432, 489);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "Show Versions";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnNewVersion
            // 
            this.btnNewVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewVersion.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewVersion.FlatAppearance.BorderSize = 0;
            this.btnNewVersion.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_get_app_black_24dp;
            this.btnNewVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewVersion.Location = new System.Drawing.Point(310, 489);
            this.btnNewVersion.Name = "btnNewVersion";
            this.btnNewVersion.Size = new System.Drawing.Size(116, 30);
            this.btnNewVersion.TabIndex = 18;
            this.btnNewVersion.Text = "New Version";
            this.btnNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewVersion.UseVisualStyleBackColor = false;
            // 
            // btnOpenResource
            // 
            this.btnOpenResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenResource.FlatAppearance.BorderSize = 0;
            this.btnOpenResource.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_launch_black_24dp;
            this.btnOpenResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenResource.Location = new System.Drawing.Point(188, 489);
            this.btnOpenResource.Name = "btnOpenResource";
            this.btnOpenResource.Size = new System.Drawing.Size(116, 30);
            this.btnOpenResource.TabIndex = 19;
            this.btnOpenResource.Text = "Open Resource";
            this.btnOpenResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenResource.UseVisualStyleBackColor = false;
            // 
            // btnAddResource
            // 
            this.btnAddResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddResource.FlatAppearance.BorderSize = 0;
            this.btnAddResource.Image = global::Weaselware.InventoryFerret.Properties.Resources.round_add_circle_black_24dp1;
            this.btnAddResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddResource.Location = new System.Drawing.Point(66, 489);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(116, 30);
            this.btnAddResource.TabIndex = 20;
            this.btnAddResource.Text = "Add Resource";
            this.btnAddResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddResource.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 669);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 114);
            this.dataGridView1.TabIndex = 21;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(22, 29);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(1);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(389, 20);
            this.txtItemDescription.TabIndex = 22;
            this.txtItemDescription.Text = "Item Description";
            // 
            // txtPartID
            // 
            this.txtPartID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartID.Location = new System.Drawing.Point(413, 29);
            this.txtPartID.Margin = new System.Windows.Forms.Padding(1);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(98, 20);
            this.txtPartID.TabIndex = 22;
            this.txtPartID.Text = "PartID";
            this.txtPartID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(22, 51);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(1);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(317, 20);
            this.txtItemName.TabIndex = 22;
            this.txtItemName.Text = "Item Name";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(413, 51);
            this.txtUnitCost.Margin = new System.Windows.Forms.Padding(1);
            this.txtUnitCost.MinimumSize = new System.Drawing.Size(4, 21);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(98, 21);
            this.txtUnitCost.TabIndex = 22;
            this.txtUnitCost.Text = "Unit Cost";
            this.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(22, 96);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(98, 20);
            this.textBox6.TabIndex = 22;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(22, 74);
            this.txtPartNumber.Margin = new System.Windows.Forms.Padding(1);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(317, 20);
            this.txtPartNumber.TabIndex = 22;
            this.txtPartNumber.Text = "Part Name";
            // 
            // txtMarkup
            // 
            this.txtMarkup.Location = new System.Drawing.Point(117, 177);
            this.txtMarkup.Margin = new System.Windows.Forms.Padding(1);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(98, 20);
            this.txtMarkup.TabIndex = 22;
            this.txtMarkup.Text = "Markup";
            this.txtMarkup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(25, 177);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(1);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(90, 20);
            this.txtWeight.TabIndex = 22;
            this.txtWeight.Text = "Weight";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(413, 73);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(1);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(98, 20);
            this.txtLocation.TabIndex = 22;
            this.txtLocation.Text = "Location";
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboUnitOfMeasure
            // 
            this.cboUnitOfMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitOfMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnitOfMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitOfMeasure.FormattingEnabled = true;
            this.cboUnitOfMeasure.ItemHeight = 13;
            this.cboUnitOfMeasure.Items.AddRange(new object[] {
            "each",
            "gal",
            "lbs",
            "ft"});
            this.cboUnitOfMeasure.Location = new System.Drawing.Point(341, 51);
            this.cboUnitOfMeasure.Margin = new System.Windows.Forms.Padding(1);
            this.cboUnitOfMeasure.Name = "cboUnitOfMeasure";
            this.cboUnitOfMeasure.Size = new System.Drawing.Size(70, 21);
            this.cboUnitOfMeasure.TabIndex = 23;
            // 
            // gboxPart
            // 
            this.gboxPart.Controls.Add(this.label3);
            this.gboxPart.Controls.Add(this.label2);
            this.gboxPart.Controls.Add(this.label1);
            this.gboxPart.Controls.Add(this.txtItemDescription);
            this.gboxPart.Controls.Add(this.cboUnitOfMeasure);
            this.gboxPart.Controls.Add(this.txtItemName);
            this.gboxPart.Controls.Add(this.txtLocation);
            this.gboxPart.Controls.Add(this.txtWaste);
            this.gboxPart.Controls.Add(this.txtMarkup);
            this.gboxPart.Controls.Add(this.txtPartNumber);
            this.gboxPart.Controls.Add(this.textBox6);
            this.gboxPart.Controls.Add(this.txtWeight);
            this.gboxPart.Controls.Add(this.txtUnitCost);
            this.gboxPart.Controls.Add(this.txtPartID);
            this.gboxPart.Location = new System.Drawing.Point(89, 109);
            this.gboxPart.Name = "gboxPart";
            this.gboxPart.Size = new System.Drawing.Size(546, 221);
            this.gboxPart.TabIndex = 24;
            this.gboxPart.TabStop = false;
            this.gboxPart.Text = "Part Details";
            // 
            // txtWaste
            // 
            this.txtWaste.Location = new System.Drawing.Point(217, 177);
            this.txtWaste.Margin = new System.Windows.Forms.Padding(1);
            this.txtWaste.Name = "txtWaste";
            this.txtWaste.Size = new System.Drawing.Size(98, 20);
            this.txtWaste.TabIndex = 22;
            this.txtWaste.Text = "Waste";
            this.txtWaste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(25, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Weight";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(117, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Markup";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(217, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Waste";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PartResourceEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gboxPart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnNewVersion);
            this.Controls.Add(this.btnOpenResource);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.dgResources);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PartResourceEditorControl";
            this.Size = new System.Drawing.Size(777, 822);
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxPart.ResumeLayout(false);
            this.gboxPart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNewVersion;
        private System.Windows.Forms.Button btnOpenResource;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TextBox txtMarkup;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cboUnitOfMeasure;
        private System.Windows.Forms.GroupBox gboxPart;
        private System.Windows.Forms.TextBox txtWaste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
