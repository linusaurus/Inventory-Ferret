namespace Weaselware.InventoryFerret
{
    partial class PurchaseOrderControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgLineItems = new System.Windows.Forms.DataGridView();
            this.LineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qauntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extended_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbSearchPartName = new System.Windows.Forms.TabPage();
            this.btnJobPart = new System.Windows.Forms.Button();
            this.btnNewPart = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lbPartsResults = new System.Windows.Forms.ListBox();
            this.tbPartsSearch = new System.Windows.Forms.TextBox();
            this.tbSearchPartID = new System.Windows.Forms.TabPage();
            this.tbSearchSupplierParts = new System.Windows.Forms.TabPage();
            this.txtSupplierSearch = new System.Windows.Forms.TextBox();
            this.dgSupplierParts = new System.Windows.Forms.DataGridView();
            this.btnAddSupplierPart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbSearchPartName.SuspendLayout();
            this.tbSearchSupplierParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLineItems
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgLineItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLineItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineID,
            this.PartID,
            this.Qauntity,
            this.colUnitCost,
            this.Description,
            this.Extended_col});
            this.dgLineItems.Location = new System.Drawing.Point(11, 213);
            this.dgLineItems.Name = "dgLineItems";
            this.dgLineItems.Size = new System.Drawing.Size(1016, 360);
            this.dgLineItems.TabIndex = 5;
            // 
            // LineID
            // 
            this.LineID.DataPropertyName = "LineID";
            this.LineID.HeaderText = "LineID";
            this.LineID.Name = "LineID";
            this.LineID.Width = 60;
            // 
            // PartID
            // 
            this.PartID.DataPropertyName = "PartID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PartID.DefaultCellStyle = dataGridViewCellStyle9;
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            // 
            // Qauntity
            // 
            this.Qauntity.DataPropertyName = "Qnty";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0.00";
            this.Qauntity.DefaultCellStyle = dataGridViewCellStyle10;
            this.Qauntity.HeaderText = "Qnty";
            this.Qauntity.Name = "Qauntity";
            this.Qauntity.Width = 60;
            // 
            // colUnitCost
            // 
            this.colUnitCost.DataPropertyName = "UnitCost";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = "0.00";
            this.colUnitCost.DefaultCellStyle = dataGridViewCellStyle11;
            this.colUnitCost.HeaderText = "Unit Cost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Width = 80;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Extended_col
            // 
            this.Extended_col.DataPropertyName = "Extended";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = "0.00";
            this.Extended_col.DefaultCellStyle = dataGridViewCellStyle12;
            this.Extended_col.HeaderText = "Extended";
            this.Extended_col.Name = "Extended_col";
            this.Extended_col.Width = 80;
            // 
            // CloseBox
            // 
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(1003, 18);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 8;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbSearchPartName);
            this.tabControl1.Controls.Add(this.tbSearchPartID);
            this.tabControl1.Controls.Add(this.tbSearchSupplierParts);
            this.tabControl1.Location = new System.Drawing.Point(11, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 177);
            this.tabControl1.TabIndex = 10;
            // 
            // tbSearchPartName
            // 
            this.tbSearchPartName.Controls.Add(this.btnJobPart);
            this.tbSearchPartName.Controls.Add(this.btnNewPart);
            this.tbSearchPartName.Controls.Add(this.btnAddToOrder);
            this.tbSearchPartName.Controls.Add(this.lbPartsResults);
            this.tbSearchPartName.Controls.Add(this.tbPartsSearch);
            this.tbSearchPartName.Location = new System.Drawing.Point(4, 22);
            this.tbSearchPartName.Name = "tbSearchPartName";
            this.tbSearchPartName.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearchPartName.Size = new System.Drawing.Size(534, 151);
            this.tbSearchPartName.TabIndex = 0;
            this.tbSearchPartName.Text = "Search PartName";
            this.tbSearchPartName.UseVisualStyleBackColor = true;
            // 
            // btnJobPart
            // 
            this.btnJobPart.Location = new System.Drawing.Point(438, 4);
            this.btnJobPart.Name = "btnJobPart";
            this.btnJobPart.Size = new System.Drawing.Size(87, 23);
            this.btnJobPart.TabIndex = 4;
            this.btnJobPart.Text = "Job Part";
            this.btnJobPart.UseVisualStyleBackColor = true;
            this.btnJobPart.Click += new System.EventHandler(this.On_JobPartClicked);
            // 
            // btnNewPart
            // 
            this.btnNewPart.Location = new System.Drawing.Point(336, 4);
            this.btnNewPart.Name = "btnNewPart";
            this.btnNewPart.Size = new System.Drawing.Size(94, 23);
            this.btnNewPart.TabIndex = 3;
            this.btnNewPart.Text = "New Part";
            this.btnNewPart.UseVisualStyleBackColor = true;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(234, 4);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(96, 23);
            this.btnAddToOrder.TabIndex = 2;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lbPartsResults
            // 
            this.lbPartsResults.FormattingEnabled = true;
            this.lbPartsResults.Location = new System.Drawing.Point(6, 29);
            this.lbPartsResults.Name = "lbPartsResults";
            this.lbPartsResults.Size = new System.Drawing.Size(520, 95);
            this.lbPartsResults.TabIndex = 1;
            this.lbPartsResults.SelectedIndexChanged += new System.EventHandler(this.lbPartsResults_SelectedIndexChanged);
            // 
            // tbPartsSearch
            // 
            this.tbPartsSearch.Location = new System.Drawing.Point(6, 6);
            this.tbPartsSearch.Name = "tbPartsSearch";
            this.tbPartsSearch.Size = new System.Drawing.Size(222, 20);
            this.tbPartsSearch.TabIndex = 0;
            this.tbPartsSearch.TextChanged += new System.EventHandler(this.tbPartsSearch_TextChanged);
            // 
            // tbSearchPartID
            // 
            this.tbSearchPartID.Location = new System.Drawing.Point(4, 22);
            this.tbSearchPartID.Name = "tbSearchPartID";
            this.tbSearchPartID.Size = new System.Drawing.Size(534, 151);
            this.tbSearchPartID.TabIndex = 1;
            this.tbSearchPartID.Text = "Search PartID";
            this.tbSearchPartID.UseVisualStyleBackColor = true;
            // 
            // tbSearchSupplierParts
            // 
            this.tbSearchSupplierParts.Controls.Add(this.btnAddSupplierPart);
            this.tbSearchSupplierParts.Controls.Add(this.dgSupplierParts);
            this.tbSearchSupplierParts.Controls.Add(this.txtSupplierSearch);
            this.tbSearchSupplierParts.Location = new System.Drawing.Point(4, 22);
            this.tbSearchSupplierParts.Name = "tbSearchSupplierParts";
            this.tbSearchSupplierParts.Size = new System.Drawing.Size(534, 151);
            this.tbSearchSupplierParts.TabIndex = 2;
            this.tbSearchSupplierParts.Text = "Search Supplier Parts";
            this.tbSearchSupplierParts.UseVisualStyleBackColor = true;
            // 
            // txtSupplierSearch
            // 
            this.txtSupplierSearch.Location = new System.Drawing.Point(10, 9);
            this.txtSupplierSearch.Name = "txtSupplierSearch";
            this.txtSupplierSearch.Size = new System.Drawing.Size(192, 20);
            this.txtSupplierSearch.TabIndex = 0;
            this.txtSupplierSearch.TextChanged += new System.EventHandler(this.On_SupplierSearchChanged);
            // 
            // dgSupplierParts
            // 
            this.dgSupplierParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplierParts.Location = new System.Drawing.Point(10, 35);
            this.dgSupplierParts.Name = "dgSupplierParts";
            this.dgSupplierParts.Size = new System.Drawing.Size(510, 113);
            this.dgSupplierParts.TabIndex = 1;
            // 
            // btnAddSupplierPart
            // 
            this.btnAddSupplierPart.Location = new System.Drawing.Point(388, 6);
            this.btnAddSupplierPart.Name = "btnAddSupplierPart";
            this.btnAddSupplierPart.Size = new System.Drawing.Size(132, 23);
            this.btnAddSupplierPart.TabIndex = 2;
            this.btnAddSupplierPart.Text = "Add SupplierPart";
            this.btnAddSupplierPart.UseVisualStyleBackColor = true;
            // 
            // PurchaseOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.dgLineItems);
            this.Name = "PurchaseOrderControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1038, 661);
            this.Load += new System.EventHandler(this.PurchaseOrderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbSearchPartName.ResumeLayout(false);
            this.tbSearchPartName.PerformLayout();
            this.tbSearchSupplierParts.ResumeLayout(false);
            this.tbSearchSupplierParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgLineItems;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbSearchPartName;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.ListBox lbPartsResults;
        private System.Windows.Forms.TextBox tbPartsSearch;
        private System.Windows.Forms.Button btnNewPart;
        private System.Windows.Forms.TabPage tbSearchPartID;
        private System.Windows.Forms.TabPage tbSearchSupplierParts;
        private System.Windows.Forms.Button btnJobPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qauntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extended_col;
        private System.Windows.Forms.Button btnAddSupplierPart;
        private System.Windows.Forms.DataGridView dgSupplierParts;
        private System.Windows.Forms.TextBox txtSupplierSearch;
    }
}
