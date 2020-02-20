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
            this.btnFindBySKU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScannerOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAssociateSKU = new System.Windows.Forms.Button();
            this.btnCreateNewPart = new System.Windows.Forms.Button();
            this.btnEditPart = new System.Windows.Forms.Button();
            this.gbSearchOptions = new System.Windows.Forms.GroupBox();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.rbStartsWith = new System.Windows.Forms.RadioButton();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.dgPartsList = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnFindBySKU);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtScannerOutput);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAssociateSKU);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateNewPart);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditPart);
            this.splitContainer1.Panel1.Controls.Add(this.gbSearchOptions);
            this.splitContainer1.Panel1.Controls.Add(this.txtPartSearch);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 240;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1168, 752);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnFindBySKU
            // 
            this.btnFindBySKU.Location = new System.Drawing.Point(16, 208);
            this.btnFindBySKU.Name = "btnFindBySKU";
            this.btnFindBySKU.Size = new System.Drawing.Size(195, 23);
            this.btnFindBySKU.TabIndex = 5;
            this.btnFindBySKU.Text = "Find by SKU";
            this.btnFindBySKU.UseVisualStyleBackColor = true;
            this.btnFindBySKU.Click += new System.EventHandler(this.btnFindBySKU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // txtScannerOutput
            // 
            this.txtScannerOutput.Location = new System.Drawing.Point(16, 302);
            this.txtScannerOutput.Name = "txtScannerOutput";
            this.txtScannerOutput.Size = new System.Drawing.Size(195, 20);
            this.txtScannerOutput.TabIndex = 3;
            this.txtScannerOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAssociateSKU
            // 
            this.btnAssociateSKU.Location = new System.Drawing.Point(16, 237);
            this.btnAssociateSKU.Name = "btnAssociateSKU";
            this.btnAssociateSKU.Size = new System.Drawing.Size(195, 23);
            this.btnAssociateSKU.TabIndex = 2;
            this.btnAssociateSKU.Text = "Associate SKU";
            this.btnAssociateSKU.UseVisualStyleBackColor = true;
            this.btnAssociateSKU.Click += new System.EventHandler(this.btnAssociateSKU_Click);
            // 
            // btnCreateNewPart
            // 
            this.btnCreateNewPart.Location = new System.Drawing.Point(16, 179);
            this.btnCreateNewPart.Name = "btnCreateNewPart";
            this.btnCreateNewPart.Size = new System.Drawing.Size(195, 23);
            this.btnCreateNewPart.TabIndex = 2;
            this.btnCreateNewPart.Text = "Create New Part";
            this.btnCreateNewPart.UseVisualStyleBackColor = true;
            this.btnCreateNewPart.Click += new System.EventHandler(this.btnCreateNewPart_Click);
            // 
            // btnEditPart
            // 
            this.btnEditPart.Location = new System.Drawing.Point(16, 150);
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
            this.gbSearchOptions.Size = new System.Drawing.Size(195, 83);
            this.gbSearchOptions.TabIndex = 1;
            this.gbSearchOptions.TabStop = false;
            this.gbSearchOptions.Text = "Search Options";
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Checked = true;
            this.rbContains.Location = new System.Drawing.Point(19, 52);
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
            this.rbStartsWith.Location = new System.Drawing.Point(19, 29);
            this.rbStartsWith.Name = "rbStartsWith";
            this.rbStartsWith.Size = new System.Drawing.Size(77, 17);
            this.rbStartsWith.TabIndex = 0;
            this.rbStartsWith.Text = "Starts With";
            this.rbStartsWith.UseVisualStyleBackColor = true;
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Location = new System.Drawing.Point(16, 107);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(195, 20);
            this.txtPartSearch.TabIndex = 0;
            this.txtPartSearch.TextChanged += new System.EventHandler(this.txtPartSearch_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.CloseBox);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgPartsList);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(12);
            this.splitContainer2.Size = new System.Drawing.Size(911, 752);
            this.splitContainer2.SplitterDistance = 90;
            this.splitContainer2.TabIndex = 0;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(884, 3);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 12;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // dgPartsList
            // 
            this.dgPartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.Description,
            this.UnitCost});
            this.dgPartsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPartsList.Location = new System.Drawing.Point(12, 12);
            this.dgPartsList.Name = "dgPartsList";
            this.dgPartsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPartsList.Size = new System.Drawing.Size(887, 634);
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
            // PartEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PartEditor";
            this.Size = new System.Drawing.Size(1168, 752);
            this.Load += new System.EventHandler(this.PartEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSearchOptions.ResumeLayout(false);
            this.gbSearchOptions.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgPartsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.Button btnAssociateSKU;
        private System.Windows.Forms.Button btnCreateNewPart;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.TextBox txtScannerOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindBySKU;
        private System.Windows.Forms.Button button1;
    }
}
