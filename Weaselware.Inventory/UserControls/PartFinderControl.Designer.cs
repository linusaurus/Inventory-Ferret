namespace Weaselware.InventoryFerret
{
    partial class PartFinderControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbStartsWith = new System.Windows.Forms.RadioButton();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.dgvPartsSearchResults = new System.Windows.Forms.DataGridView();
            this.PartID_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearchParts = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnNewPart = new System.Windows.Forms.Button();
            this.btnAddJobPart = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 206);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbStartsWith);
            this.tabPage1.Controls.Add(this.rbContains);
            this.tabPage1.Controls.Add(this.dgvPartsSearchResults);
            this.tabPage1.Controls.Add(this.tbSearchParts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parts Finder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbStartsWith
            // 
            this.rbStartsWith.AutoSize = true;
            this.rbStartsWith.Location = new System.Drawing.Point(485, 9);
            this.rbStartsWith.Name = "rbStartsWith";
            this.rbStartsWith.Size = new System.Drawing.Size(77, 17);
            this.rbStartsWith.TabIndex = 3;
            this.rbStartsWith.Text = "Starts With";
            this.rbStartsWith.UseVisualStyleBackColor = true;
            this.rbStartsWith.CheckedChanged += new System.EventHandler(this.rbStartsWith_CheckedChanged);
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Checked = true;
            this.rbContains.Location = new System.Drawing.Point(356, 9);
            this.rbContains.Name = "rbContains";
            this.rbContains.Size = new System.Drawing.Size(66, 17);
            this.rbContains.TabIndex = 2;
            this.rbContains.TabStop = true;
            this.rbContains.Text = "Contains";
            this.rbContains.UseVisualStyleBackColor = true;
            this.rbContains.CheckedChanged += new System.EventHandler(this.rbContains_CheckedChanged);
            // 
            // dgvPartsSearchResults
            // 
            this.dgvPartsSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartsSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID_Col,
            this.Description_Col,
            this.PartNumber_col});
            this.dgvPartsSearchResults.Location = new System.Drawing.Point(6, 32);
            this.dgvPartsSearchResults.Name = "dgvPartsSearchResults";
            this.dgvPartsSearchResults.Size = new System.Drawing.Size(657, 141);
            this.dgvPartsSearchResults.TabIndex = 1;
            this.dgvPartsSearchResults.SelectionChanged += new System.EventHandler(this.dgvPartsSearchResults_SelectionChanged);
            // 
            // PartID_Col
            // 
            this.PartID_Col.DataPropertyName = "PartID";
            this.PartID_Col.HeaderText = "PartID";
            this.PartID_Col.Name = "PartID_Col";
            this.PartID_Col.Width = 70;
            // 
            // Description_Col
            // 
            this.Description_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description_Col.DataPropertyName = "ItemDescription";
            this.Description_Col.HeaderText = "Description";
            this.Description_Col.Name = "Description_Col";
            // 
            // PartNumber_col
            // 
            this.PartNumber_col.DataPropertyName = "PartNumber";
            this.PartNumber_col.HeaderText = "Part Number";
            this.PartNumber_col.Name = "PartNumber_col";
            // 
            // tbSearchParts
            // 
            this.tbSearchParts.Location = new System.Drawing.Point(6, 6);
            this.tbSearchParts.Name = "tbSearchParts";
            this.tbSearchParts.Size = new System.Drawing.Size(224, 20);
            this.tbSearchParts.TabIndex = 0;
            this.tbSearchParts.Text = "Search...";
            this.tbSearchParts.TextChanged += new System.EventHandler(this.tbSearchParts_TextChanged);
            this.tbSearchParts.Enter += new System.EventHandler(this.tbSearchParts_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplier Part";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToOrder.Location = new System.Drawing.Point(294, 6);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(123, 27);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnNewPart
            // 
            this.btnNewPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPart.Location = new System.Drawing.Point(423, 6);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(123, 27);
            this.btnNewPart.TabIndex = 4;
            this.btnNewPart.Text = "New Part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            this.btnNewPart.Click += new System.EventHandler(this.btnNewPart_Click);
            // 
            // btnAddJobPart
            // 
            this.btnAddJobPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddJobPart.Location = new System.Drawing.Point(552, 6);
            this.btnAddJobPart.Name = "btnAddJobPart";
            this.btnAddJobPart.Size = new System.Drawing.Size(123, 27);
            this.btnAddJobPart.TabIndex = 4;
            this.btnAddJobPart.Text = "Add Job Part";
            this.btnAddJobPart.UseVisualStyleBackColor = true;
            this.btnAddJobPart.Click += new System.EventHandler(this.btnAddJobPart_Click);
            // 
            // PartFinderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddJobPart);
            this.Controls.Add(this.btnNewPart);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.tabControl1);
            this.Name = "PartFinderControl";
            this.Size = new System.Drawing.Size(685, 231);
            this.Load += new System.EventHandler(this.PartFinderControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsSearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbStartsWith;
        private System.Windows.Forms.RadioButton rbContains;
        private System.Windows.Forms.DataGridView dgvPartsSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber_col;
        private System.Windows.Forms.TextBox tbSearchParts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.Button btnAddJobPart;
    }
}
