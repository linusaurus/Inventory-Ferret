namespace Weaselware.InventoryFerret
{
    partial class PartEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOpenPart = new System.Windows.Forms.Button();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.btnFindBySKU = new System.Windows.Forms.Button();
            this.txtScannerOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAssociateSKU = new System.Windows.Forms.Button();
            this.btnCreateNewPart = new System.Windows.Forms.Button();
            this.btnEditPart = new System.Windows.Forms.Button();
            this.gbSearchOptions = new System.Windows.Forms.GroupBox();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.rbStartsWith = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNewVersion = new System.Windows.Forms.Button();
            this.btnOpenResource = new System.Windows.Forms.Button();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.dgResources = new System.Windows.Forms.DataGridView();
            this.colDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.dgPartsList = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleName = "NavigationPanel";
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenPart);
            this.splitContainer1.Panel1.Controls.Add(this.txtPartNumber);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindBySKU);
            this.splitContainer1.Panel1.Controls.Add(this.txtScannerOutput);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAssociateSKU);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateNewPart);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditPart);
            this.splitContainer1.Panel1.Controls.Add(this.gbSearchOptions);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.btnNewVersion);
            this.splitContainer1.Panel2.Controls.Add(this.btnOpenResource);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddResource);
            this.splitContainer1.Panel2.Controls.Add(this.dgResources);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.CloseBox);
            this.splitContainer1.Panel2.Controls.Add(this.dgPartsList);
            this.splitContainer1.Panel2.Controls.Add(this.txtPartSearch);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 659);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnOpenPart
            // 
            this.btnOpenPart.Location = new System.Drawing.Point(35, 234);
            this.btnOpenPart.Name = "btnOpenPart";
            this.btnOpenPart.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPart.TabIndex = 7;
            this.btnOpenPart.Text = "Find Part";
            this.btnOpenPart.UseVisualStyleBackColor = true;
            this.btnOpenPart.Click += new System.EventHandler(this.btnOpenPart_Click);
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(116, 236);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(66, 20);
            this.txtPartNumber.TabIndex = 6;
            this.txtPartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFindBySKU
            // 
            this.btnFindBySKU.Location = new System.Drawing.Point(15, 153);
            this.btnFindBySKU.Name = "btnFindBySKU";
            this.btnFindBySKU.Size = new System.Drawing.Size(195, 23);
            this.btnFindBySKU.TabIndex = 5;
            this.btnFindBySKU.Text = "Find by SKU";
            this.btnFindBySKU.UseVisualStyleBackColor = true;
            this.btnFindBySKU.Click += new System.EventHandler(this.btnFindBySKU_Click);
            // 
            // txtScannerOutput
            // 
            this.txtScannerOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtScannerOutput.Location = new System.Drawing.Point(11, 591);
            this.txtScannerOutput.Name = "txtScannerOutput";
            this.txtScannerOutput.Size = new System.Drawing.Size(195, 20);
            this.txtScannerOutput.TabIndex = 3;
            this.txtScannerOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print Part Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAssociateSKU
            // 
            this.btnAssociateSKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAssociateSKU.Location = new System.Drawing.Point(12, 621);
            this.btnAssociateSKU.Name = "btnAssociateSKU";
            this.btnAssociateSKU.Size = new System.Drawing.Size(195, 23);
            this.btnAssociateSKU.TabIndex = 2;
            this.btnAssociateSKU.Text = "Associate SKU";
            this.btnAssociateSKU.UseVisualStyleBackColor = true;
            this.btnAssociateSKU.Click += new System.EventHandler(this.btnAssociateSKU_Click);
            // 
            // btnCreateNewPart
            // 
            this.btnCreateNewPart.Location = new System.Drawing.Point(16, 124);
            this.btnCreateNewPart.Name = "btnCreateNewPart";
            this.btnCreateNewPart.Size = new System.Drawing.Size(195, 23);
            this.btnCreateNewPart.TabIndex = 2;
            this.btnCreateNewPart.Text = "Create New Part";
            this.btnCreateNewPart.UseVisualStyleBackColor = true;
            this.btnCreateNewPart.Click += new System.EventHandler(this.btnCreateNewPart_Click);
            // 
            // btnEditPart
            // 
            this.btnEditPart.Location = new System.Drawing.Point(16, 95);
            this.btnEditPart.Name = "btnEditPart";
            this.btnEditPart.Size = new System.Drawing.Size(195, 23);
            this.btnEditPart.TabIndex = 2;
            this.btnEditPart.Text = "Edit Part";
            this.btnEditPart.UseVisualStyleBackColor = true;
            this.btnEditPart.Click += new System.EventHandler(this.btnEditPart_Click);
            // 
            // gbSearchOptions
            // 
            this.gbSearchOptions.Controls.Add(this.rbContains);
            this.gbSearchOptions.Controls.Add(this.rbStartsWith);
            this.gbSearchOptions.Location = new System.Drawing.Point(16, 18);
            this.gbSearchOptions.Name = "gbSearchOptions";
            this.gbSearchOptions.Size = new System.Drawing.Size(195, 71);
            this.gbSearchOptions.TabIndex = 1;
            this.gbSearchOptions.TabStop = false;
            this.gbSearchOptions.Text = "Search Options";
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Checked = true;
            this.rbContains.Location = new System.Drawing.Point(19, 45);
            this.rbContains.Name = "rbContains";
            this.rbContains.Size = new System.Drawing.Size(66, 17);
            this.rbContains.TabIndex = 1;
            this.rbContains.TabStop = true;
            this.rbContains.Text = "Contains";
            this.rbContains.UseVisualStyleBackColor = true;
            this.rbContains.CheckedChanged += new System.EventHandler(this.rbContains_CheckedChanged);
            // 
            // rbStartsWith
            // 
            this.rbStartsWith.AutoSize = true;
            this.rbStartsWith.Location = new System.Drawing.Point(19, 22);
            this.rbStartsWith.Name = "rbStartsWith";
            this.rbStartsWith.Size = new System.Drawing.Size(77, 17);
            this.rbStartsWith.TabIndex = 0;
            this.rbStartsWith.Text = "Starts With";
            this.rbStartsWith.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_visibility_black_24dp;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(16, 607);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Show Versions";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // btnNewVersion
            // 
            this.btnNewVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewVersion.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewVersion.FlatAppearance.BorderSize = 0;
            this.btnNewVersion.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_get_app_black_24dp;
            this.btnNewVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewVersion.Location = new System.Drawing.Point(16, 571);
            this.btnNewVersion.Name = "btnNewVersion";
            this.btnNewVersion.Size = new System.Drawing.Size(116, 30);
            this.btnNewVersion.TabIndex = 15;
            this.btnNewVersion.Text = "New Version";
            this.btnNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewVersion.UseVisualStyleBackColor = false;
            this.btnNewVersion.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // btnOpenResource
            // 
            this.btnOpenResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenResource.FlatAppearance.BorderSize = 0;
            this.btnOpenResource.Image = global::Weaselware.InventoryFerret.Properties.Resources.baseline_launch_black_24dp;
            this.btnOpenResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenResource.Location = new System.Drawing.Point(16, 535);
            this.btnOpenResource.Name = "btnOpenResource";
            this.btnOpenResource.Size = new System.Drawing.Size(116, 30);
            this.btnOpenResource.TabIndex = 15;
            this.btnOpenResource.Text = "Open Resource";
            this.btnOpenResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenResource.UseVisualStyleBackColor = false;
            this.btnOpenResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // btnAddResource
            // 
            this.btnAddResource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddResource.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddResource.FlatAppearance.BorderSize = 0;
            this.btnAddResource.Image = global::Weaselware.InventoryFerret.Properties.Resources.round_add_circle_black_24dp1;
            this.btnAddResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddResource.Location = new System.Drawing.Point(16, 499);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(116, 30);
            this.btnAddResource.TabIndex = 15;
            this.btnAddResource.Text = "Add Resource";
            this.btnAddResource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddResource.UseVisualStyleBackColor = false;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // dgResources
            // 
            this.dgResources.AllowUserToResizeColumns = false;
            this.dgResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocID,
            this.colDescription,
            this.colCreator,
            this.colModDate});
            this.dgResources.Location = new System.Drawing.Point(147, 499);
            this.dgResources.Name = "dgResources";
            this.dgResources.Size = new System.Drawing.Size(685, 144);
            this.dgResources.TabIndex = 14;
            // 
            // colDocID
            // 
            this.colDocID.DataPropertyName = "DocID";
            this.colDocID.HeaderText = "DocID";
            this.colDocID.Name = "colDocID";
            this.colDocID.Width = 70;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colCreator
            // 
            this.colCreator.DataPropertyName = "Creator";
            this.colCreator.HeaderText = "Creator";
            this.colCreator.Name = "colCreator";
            this.colCreator.Width = 80;
            // 
            // colModDate
            // 
            this.colModDate.DataPropertyName = "ModDate";
            this.colModDate.HeaderText = "Mod Date";
            this.colModDate.Name = "colModDate";
            this.colModDate.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search";
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(808, 14);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 12;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // dgPartsList
            // 
            this.dgPartsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.Description,
            this.UnitCost});
            this.dgPartsList.Location = new System.Drawing.Point(16, 47);
            this.dgPartsList.Name = "dgPartsList";
            this.dgPartsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPartsList.Size = new System.Drawing.Size(816, 436);
            this.dgPartsList.TabIndex = 0;
            this.dgPartsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPartsList_CellDoubleClick);
            this.dgPartsList.SelectionChanged += new System.EventHandler(this.dgPartsList_SelectionChanged);
            // 
            // PartID
            // 
            this.PartID.DataPropertyName = "PartID";
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            this.PartID.Width = 70;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "ItemDescription";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // UnitCost
            // 
            this.UnitCost.DataPropertyName = "Cost";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.UnitCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.UnitCost.HeaderText = "UnitCost";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.Width = 70;
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Location = new System.Drawing.Point(66, 17);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(253, 20);
            this.txtPartSearch.TabIndex = 0;
            this.txtPartSearch.TextChanged += new System.EventHandler(this.txtPartSearch_TextChanged);
            // 
            // PartEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PartEditor";
            this.Size = new System.Drawing.Size(1090, 659);
            this.Load += new System.EventHandler(this.PartEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSearchOptions.ResumeLayout(false);
            this.gbSearchOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbSearchOptions;
        private System.Windows.Forms.RadioButton rbContains;
        private System.Windows.Forms.RadioButton rbStartsWith;
        private System.Windows.Forms.TextBox txtPartSearch;
        private System.Windows.Forms.DataGridView dgPartsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.Button btnAssociateSKU;
        private System.Windows.Forms.Button btnCreateNewPart;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.TextBox txtScannerOutput;
        private System.Windows.Forms.Button btnFindBySKU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgResources;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.Button btnOpenPart;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNewVersion;
        private System.Windows.Forms.Button btnOpenResource;
    }
}
