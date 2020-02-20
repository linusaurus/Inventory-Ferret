namespace Weaselware.InventoryFerret
{
    partial class NewOrderForm
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbSupplierFinder = new System.Windows.Forms.TabPage();
            this.tbSuppliersSearch = new System.Windows.Forms.TextBox();
            this.lbSuppliersList = new System.Windows.Forms.ListBox();
            this.tbJobFinder = new System.Windows.Forms.TabPage();
            this.lbJobSearchList = new System.Windows.Forms.ListBox();
            this.tbJobSearch = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnAbortOrder = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tbSupplierFinder.SuspendLayout();
            this.tbJobFinder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbSupplierFinder);
            this.tabControl2.Controls.Add(this.tbJobFinder);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(315, 156);
            this.tabControl2.TabIndex = 15;
            // 
            // tbSupplierFinder
            // 
            this.tbSupplierFinder.Controls.Add(this.tbSuppliersSearch);
            this.tbSupplierFinder.Controls.Add(this.lbSuppliersList);
            this.tbSupplierFinder.Location = new System.Drawing.Point(4, 22);
            this.tbSupplierFinder.Name = "tbSupplierFinder";
            this.tbSupplierFinder.Padding = new System.Windows.Forms.Padding(3);
            this.tbSupplierFinder.Size = new System.Drawing.Size(307, 130);
            this.tbSupplierFinder.TabIndex = 0;
            this.tbSupplierFinder.Text = "Supplier";
            this.tbSupplierFinder.UseVisualStyleBackColor = true;
            // 
            // tbSuppliersSearch
            // 
            this.tbSuppliersSearch.Location = new System.Drawing.Point(6, 7);
            this.tbSuppliersSearch.Name = "tbSuppliersSearch";
            this.tbSuppliersSearch.Size = new System.Drawing.Size(207, 20);
            this.tbSuppliersSearch.TabIndex = 11;
            this.tbSuppliersSearch.TextChanged += new System.EventHandler(this.tbSuppliersSearch_TextChanged);
            // 
            // lbSuppliersList
            // 
            this.lbSuppliersList.FormattingEnabled = true;
            this.lbSuppliersList.Location = new System.Drawing.Point(6, 33);
            this.lbSuppliersList.Name = "lbSuppliersList";
            this.lbSuppliersList.Size = new System.Drawing.Size(207, 82);
            this.lbSuppliersList.TabIndex = 12;
            this.lbSuppliersList.SelectedIndexChanged += new System.EventHandler(this.lbSuppliersList_SelectedIndexChanged);
            // 
            // tbJobFinder
            // 
            this.tbJobFinder.Controls.Add(this.lbJobSearchList);
            this.tbJobFinder.Controls.Add(this.tbJobSearch);
            this.tbJobFinder.Location = new System.Drawing.Point(4, 22);
            this.tbJobFinder.Name = "tbJobFinder";
            this.tbJobFinder.Padding = new System.Windows.Forms.Padding(3);
            this.tbJobFinder.Size = new System.Drawing.Size(307, 130);
            this.tbJobFinder.TabIndex = 1;
            this.tbJobFinder.Text = "Job";
            this.tbJobFinder.UseVisualStyleBackColor = true;
            // 
            // lbJobSearchList
            // 
            this.lbJobSearchList.FormattingEnabled = true;
            this.lbJobSearchList.Location = new System.Drawing.Point(6, 29);
            this.lbJobSearchList.Name = "lbJobSearchList";
            this.lbJobSearchList.Size = new System.Drawing.Size(198, 95);
            this.lbJobSearchList.TabIndex = 1;
            this.lbJobSearchList.SelectedIndexChanged += new System.EventHandler(this.lbJobSearchList_SelectedIndexChanged);
            // 
            // tbJobSearch
            // 
            this.tbJobSearch.Location = new System.Drawing.Point(6, 6);
            this.tbJobSearch.Name = "tbJobSearch";
            this.tbJobSearch.Size = new System.Drawing.Size(198, 20);
            this.tbJobSearch.TabIndex = 0;
            this.tbJobSearch.TextChanged += new System.EventHandler(this.tbJobSearch_TextChanged);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNewOrder.Location = new System.Drawing.Point(343, 34);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(105, 23);
            this.btnNewOrder.TabIndex = 16;
            this.btnNewOrder.Text = "Create Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // btnAbortOrder
            // 
            this.btnAbortOrder.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbortOrder.Location = new System.Drawing.Point(343, 63);
            this.btnAbortOrder.Name = "btnAbortOrder";
            this.btnAbortOrder.Size = new System.Drawing.Size(105, 23);
            this.btnAbortOrder.TabIndex = 16;
            this.btnAbortOrder.Text = "Abort Order";
            this.btnAbortOrder.UseVisualStyleBackColor = true;
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 181);
            this.ControlBox = false;
            this.Controls.Add(this.btnAbortOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Purchase Order";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tbSupplierFinder.ResumeLayout(false);
            this.tbSupplierFinder.PerformLayout();
            this.tbJobFinder.ResumeLayout(false);
            this.tbJobFinder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbSupplierFinder;
        private System.Windows.Forms.TextBox tbSuppliersSearch;
        private System.Windows.Forms.ListBox lbSuppliersList;
        private System.Windows.Forms.TabPage tbJobFinder;
        private System.Windows.Forms.ListBox lbJobSearchList;
        private System.Windows.Forms.TextBox tbJobSearch;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnAbortOrder;
    }
}