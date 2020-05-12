namespace Weaselware.UserControls
{
    partial class MyOrdersControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMyOrdersGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbShowRecieved = new System.Windows.Forms.CheckBox();
            this.cbJobName = new System.Windows.Forms.ComboBox();
            this.colOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecieved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyOrdersGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMyOrdersGrid
            // 
            this.dgMyOrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMyOrdersGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgMyOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNum,
            this.colOrderDate,
            this.colSupplier,
            this.colJobName,
            this.colOrderTotal,
            this.colRecieved});
            this.dgMyOrdersGrid.Location = new System.Drawing.Point(10, 79);
            this.dgMyOrdersGrid.Name = "dgMyOrdersGrid";
            this.dgMyOrdersGrid.Size = new System.Drawing.Size(1080, 679);
            this.dgMyOrdersGrid.TabIndex = 0;
            this.dgMyOrdersGrid.SelectionChanged += new System.EventHandler(this.dgMyOrdersGrid_SelectionChanged);
            this.dgMyOrdersGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgMyOrdersGrid_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbJobName);
            this.panel1.Controls.Add(this.ckbShowRecieved);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 63);
            this.panel1.TabIndex = 1;
            // 
            // ckbShowRecieved
            // 
            this.ckbShowRecieved.AutoSize = true;
            this.ckbShowRecieved.Location = new System.Drawing.Point(20, 25);
            this.ckbShowRecieved.Name = "ckbShowRecieved";
            this.ckbShowRecieved.Size = new System.Drawing.Size(136, 17);
            this.ckbShowRecieved.TabIndex = 1;
            this.ckbShowRecieved.Text = "Show Recieved Orders";
            this.ckbShowRecieved.UseVisualStyleBackColor = true;
            this.ckbShowRecieved.CheckedChanged += new System.EventHandler(this.ckbShowRecieved_CheckedChanged);
            // 
            // cbJobName
            // 
            this.cbJobName.FormattingEnabled = true;
            this.cbJobName.Location = new System.Drawing.Point(444, 21);
            this.cbJobName.Name = "cbJobName";
            this.cbJobName.Size = new System.Drawing.Size(339, 21);
            this.cbJobName.TabIndex = 2;
            // 
            // colOrderNum
            // 
            this.colOrderNum.DataPropertyName = "OrderNum";
            this.colOrderNum.HeaderText = "Order#";
            this.colOrderNum.Name = "colOrderNum";
            // 
            // colOrderDate
            // 
            this.colOrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.colOrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colOrderDate.HeaderText = "Order Date";
            this.colOrderDate.Name = "colOrderDate";
            // 
            // colSupplier
            // 
            this.colSupplier.DataPropertyName = "Supplier";
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Width = 200;
            // 
            // colJobName
            // 
            this.colJobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJobName.DataPropertyName = "JobName";
            this.colJobName.HeaderText = "Jobname";
            this.colJobName.Name = "colJobName";
            // 
            // colOrderTotal
            // 
            this.colOrderTotal.DataPropertyName = "OrderTotal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colOrderTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOrderTotal.HeaderText = "Total";
            this.colOrderTotal.Name = "colOrderTotal";
            // 
            // colRecieved
            // 
            this.colRecieved.DataPropertyName = "Recieved";
            this.colRecieved.HeaderText = "Received";
            this.colRecieved.Name = "colRecieved";
            this.colRecieved.ReadOnly = true;
            this.colRecieved.Width = 75;
            // 
            // MyOrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgMyOrdersGrid);
            this.Name = "MyOrdersControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1099, 768);
            this.Load += new System.EventHandler(this.MyOrdersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyOrdersGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMyOrdersGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbShowRecieved;
        private System.Windows.Forms.ComboBox cbJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRecieved;
    }
}
