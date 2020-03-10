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
            this.btnAddSupplierPart = new System.Windows.Forms.Button();
            this.dgSupplierParts = new System.Windows.Forms.DataGridView();
            this.txtSupplierSearch = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbSearchPartName.SuspendLayout();
            this.tbSearchSupplierParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(984, 10);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 8;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tbSearchPartName);
            this.tabControl1.Controls.Add(this.tbSearchPartID);
            this.tabControl1.Controls.Add(this.tbSearchSupplierParts);
            this.tabControl1.Location = new System.Drawing.Point(11, 438);
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
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddSelectedPart_Click);
            // 
            // lbPartsResults
            // 
            this.lbPartsResults.FormattingEnabled = true;
            this.lbPartsResults.Location = new System.Drawing.Point(8, 33);
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
            // btnAddSupplierPart
            // 
            this.btnAddSupplierPart.Location = new System.Drawing.Point(388, 6);
            this.btnAddSupplierPart.Name = "btnAddSupplierPart";
            this.btnAddSupplierPart.Size = new System.Drawing.Size(132, 23);
            this.btnAddSupplierPart.TabIndex = 2;
            this.btnAddSupplierPart.Text = "Add SupplierPart";
            this.btnAddSupplierPart.UseVisualStyleBackColor = true;
            // 
            // dgSupplierParts
            // 
            this.dgSupplierParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplierParts.Location = new System.Drawing.Point(10, 35);
            this.dgSupplierParts.Name = "dgSupplierParts";
            this.dgSupplierParts.Size = new System.Drawing.Size(510, 113);
            this.dgSupplierParts.TabIndex = 1;
            // 
            // txtSupplierSearch
            // 
            this.txtSupplierSearch.Location = new System.Drawing.Point(10, 9);
            this.txtSupplierSearch.Name = "txtSupplierSearch";
            this.txtSupplierSearch.Size = new System.Drawing.Size(192, 20);
            this.txtSupplierSearch.TabIndex = 0;
            this.txtSupplierSearch.TextChanged += new System.EventHandler(this.On_SupplierSearchChanged);
            // 
            // view
            // 
            this.view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Location = new System.Drawing.Point(11, 91);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(997, 341);
            this.view.TabIndex = 11;
            this.view.SelectionChanged += new System.EventHandler(this.view_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(824, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(824, 46);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrderTotal.TabIndex = 13;
            // 
            // PurchaseOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.view);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CloseBox);
            this.Name = "PurchaseOrderControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1020, 626);
            this.Load += new System.EventHandler(this.PurchaseOrderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbSearchPartName.ResumeLayout(false);
            this.tbSearchPartName.PerformLayout();
            this.tbSearchSupplierParts.ResumeLayout(false);
            this.tbSearchSupplierParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplierParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnAddSupplierPart;
        private System.Windows.Forms.DataGridView dgSupplierParts;
        private System.Windows.Forms.TextBox txtSupplierSearch;
        private System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOrderTotal;
    }
}
