namespace Weaselware.InventoryFerret.UserControls
{
    partial class AssemblyManagerControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvAssemblies = new System.Windows.Forms.DataGridView();
            this.dgvSubassemblies = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tbcSubAssemblies = new System.Windows.Forms.TabControl();
            this.tbSubAssemblies = new System.Windows.Forms.TabPage();
            this.tbProductDetails = new System.Windows.Forms.TabPage();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssemblyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArchRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMake = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSubID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubAssemblyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMakeFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIsContracted = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.colRiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveResource = new System.Windows.Forms.Button();
            this.txtSqft = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbParts = new System.Windows.Forms.TabPage();
            this.dgvStockBillItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubassemblies)).BeginInit();
            this.tbcSubAssemblies.SuspendLayout();
            this.tbSubAssemblies.SuspendLayout();
            this.tbProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockBillItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(852, 598);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(741, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel Changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvAssemblies
            // 
            this.dgvAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssemblies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAssemblies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAssemblies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAssemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssemblies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colAssemblyName,
            this.colArchRef,
            this.colWidth,
            this.colHeight,
            this.colDepth,
            this.colMake});
            this.dgvAssemblies.Location = new System.Drawing.Point(236, 51);
            this.dgvAssemblies.Name = "dgvAssemblies";
            this.dgvAssemblies.Size = new System.Drawing.Size(691, 147);
            this.dgvAssemblies.TabIndex = 1;
            this.dgvAssemblies.SelectionChanged += new System.EventHandler(this.dgvAssemblies_SelectionChanged);
            // 
            // dgvSubassemblies
            // 
            this.dgvSubassemblies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubassemblies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubID,
            this.colSubAssemblyName,
            this.colSubWidth,
            this.colSubHeight,
            this.colSubDepth,
            this.colMakeFile});
            this.dgvSubassemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubassemblies.Location = new System.Drawing.Point(3, 3);
            this.dgvSubassemblies.Name = "dgvSubassemblies";
            this.dgvSubassemblies.Size = new System.Drawing.Size(677, 356);
            this.dgvSubassemblies.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Edit Assembly";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbcSubAssemblies
            // 
            this.tbcSubAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcSubAssemblies.Controls.Add(this.tbSubAssemblies);
            this.tbcSubAssemblies.Controls.Add(this.tbProductDetails);
            this.tbcSubAssemblies.Controls.Add(this.tbParts);
            this.tbcSubAssemblies.Location = new System.Drawing.Point(236, 204);
            this.tbcSubAssemblies.Name = "tbcSubAssemblies";
            this.tbcSubAssemblies.SelectedIndex = 0;
            this.tbcSubAssemblies.Size = new System.Drawing.Size(691, 388);
            this.tbcSubAssemblies.TabIndex = 5;
            // 
            // tbSubAssemblies
            // 
            this.tbSubAssemblies.BackColor = System.Drawing.Color.Wheat;
            this.tbSubAssemblies.Controls.Add(this.dgvSubassemblies);
            this.tbSubAssemblies.Location = new System.Drawing.Point(4, 22);
            this.tbSubAssemblies.Name = "tbSubAssemblies";
            this.tbSubAssemblies.Padding = new System.Windows.Forms.Padding(3);
            this.tbSubAssemblies.Size = new System.Drawing.Size(683, 362);
            this.tbSubAssemblies.TabIndex = 0;
            this.tbSubAssemblies.Text = "SubAssemblies";
            // 
            // tbProductDetails
            // 
            this.tbProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbProductDetails.Controls.Add(this.label5);
            this.tbProductDetails.Controls.Add(this.label4);
            this.tbProductDetails.Controls.Add(this.label3);
            this.tbProductDetails.Controls.Add(this.label2);
            this.tbProductDetails.Controls.Add(this.label1);
            this.tbProductDetails.Controls.Add(this.textBox6);
            this.tbProductDetails.Controls.Add(this.textBox5);
            this.tbProductDetails.Controls.Add(this.txtWeight);
            this.tbProductDetails.Controls.Add(this.txtPerimeter);
            this.tbProductDetails.Controls.Add(this.txtSqft);
            this.tbProductDetails.Controls.Add(this.btnRemoveResource);
            this.tbProductDetails.Controls.Add(this.btnAddResource);
            this.tbProductDetails.Controls.Add(this.dataGridView1);
            this.tbProductDetails.Controls.Add(this.cbIsContracted);
            this.tbProductDetails.Location = new System.Drawing.Point(4, 22);
            this.tbProductDetails.Name = "tbProductDetails";
            this.tbProductDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbProductDetails.Size = new System.Drawing.Size(683, 362);
            this.tbProductDetails.TabIndex = 1;
            this.tbProductDetails.Text = "Product Details";
            this.tbProductDetails.UseVisualStyleBackColor = true;
            // 
            // colProductID
            // 
            this.colProductID.DataPropertyName = "ProductID";
            this.colProductID.HeaderText = "ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Width = 43;
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAssemblyName.DataPropertyName = "AssemblyName";
            this.colAssemblyName.HeaderText = "Assembly Name";
            this.colAssemblyName.Name = "colAssemblyName";
            this.colAssemblyName.Width = 200;
            // 
            // colArchRef
            // 
            this.colArchRef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArchRef.DataPropertyName = "ArchRef";
            this.colArchRef.HeaderText = "Arch Reference";
            this.colArchRef.Name = "colArchRef";
            // 
            // colWidth
            // 
            this.colWidth.DataPropertyName = "Width";
            this.colWidth.HeaderText = "Width";
            this.colWidth.Name = "colWidth";
            this.colWidth.Width = 60;
            // 
            // colHeight
            // 
            this.colHeight.DataPropertyName = "Height";
            this.colHeight.HeaderText = "Height";
            this.colHeight.Name = "colHeight";
            this.colHeight.Width = 63;
            // 
            // colDepth
            // 
            this.colDepth.DataPropertyName = "Depth";
            this.colDepth.HeaderText = "Depth";
            this.colDepth.Name = "colDepth";
            this.colDepth.Width = 61;
            // 
            // colMake
            // 
            this.colMake.DataPropertyName = "Make";
            this.colMake.HeaderText = "Make";
            this.colMake.Name = "colMake";
            this.colMake.Width = 40;
            // 
            // colSubID
            // 
            this.colSubID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSubID.DataPropertyName = "SubAssemblyID";
            this.colSubID.HeaderText = "SiD";
            this.colSubID.Name = "colSubID";
            this.colSubID.Width = 65;
            // 
            // colSubAssemblyName
            // 
            this.colSubAssemblyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubAssemblyName.DataPropertyName = "SubAssemblyName";
            this.colSubAssemblyName.HeaderText = "SubAssembly Name";
            this.colSubAssemblyName.Name = "colSubAssemblyName";
            // 
            // colSubWidth
            // 
            this.colSubWidth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSubWidth.DataPropertyName = "Width";
            this.colSubWidth.HeaderText = "Width";
            this.colSubWidth.Name = "colSubWidth";
            this.colSubWidth.Width = 70;
            // 
            // colSubHeight
            // 
            this.colSubHeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSubHeight.DataPropertyName = "Height";
            this.colSubHeight.HeaderText = "Height";
            this.colSubHeight.Name = "colSubHeight";
            this.colSubHeight.Width = 70;
            // 
            // colSubDepth
            // 
            this.colSubDepth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSubDepth.DataPropertyName = "Depth";
            this.colSubDepth.HeaderText = "Depth";
            this.colSubDepth.Name = "colSubDepth";
            this.colSubDepth.Width = 70;
            // 
            // colMakeFile
            // 
            this.colMakeFile.DataPropertyName = "MakeFile";
            this.colMakeFile.HeaderText = "MakeFile";
            this.colMakeFile.Name = "colMakeFile";
            this.colMakeFile.Width = 250;
            // 
            // cbIsContracted
            // 
            this.cbIsContracted.AutoSize = true;
            this.cbIsContracted.Location = new System.Drawing.Point(23, 19);
            this.cbIsContracted.Name = "cbIsContracted";
            this.cbIsContracted.Size = new System.Drawing.Size(89, 17);
            this.cbIsContracted.TabIndex = 0;
            this.cbIsContracted.Text = "Is In Contract";
            this.cbIsContracted.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRiD,
            this.colDescription,
            this.colFile});
            this.dataGridView1.Location = new System.Drawing.Point(23, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 237);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(23, 51);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(107, 23);
            this.btnAddResource.TabIndex = 2;
            this.btnAddResource.Text = "Add Resource";
            this.btnAddResource.UseVisualStyleBackColor = true;
            // 
            // colRiD
            // 
            this.colRiD.HeaderText = "RiD";
            this.colRiD.Name = "colRiD";
            this.colRiD.Width = 30;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colFile
            // 
            this.colFile.HeaderText = "File";
            this.colFile.Name = "colFile";
            // 
            // btnRemoveResource
            // 
            this.btnRemoveResource.Location = new System.Drawing.Point(136, 51);
            this.btnRemoveResource.Name = "btnRemoveResource";
            this.btnRemoveResource.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveResource.TabIndex = 2;
            this.btnRemoveResource.Text = "Remove Resource";
            this.btnRemoveResource.UseVisualStyleBackColor = true;
            // 
            // txtSqft
            // 
            this.txtSqft.Location = new System.Drawing.Point(265, 52);
            this.txtSqft.Name = "txtSqft";
            this.txtSqft.Size = new System.Drawing.Size(54, 20);
            this.txtSqft.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(333, 52);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(54, 20);
            this.txtPerimeter.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(401, 52);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(54, 20);
            this.txtWeight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area Sqft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Perimeter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weight";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(506, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 20);
            this.textBox5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Materials Cost";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(586, 52);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 20);
            this.textBox6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Labor Hrs";
            // 
            // tbParts
            // 
            this.tbParts.Controls.Add(this.dgvStockBillItems);
            this.tbParts.Location = new System.Drawing.Point(4, 22);
            this.tbParts.Name = "tbParts";
            this.tbParts.Size = new System.Drawing.Size(683, 362);
            this.tbParts.TabIndex = 2;
            this.tbParts.Text = "Bill of Materials";
            this.tbParts.UseVisualStyleBackColor = true;
            // 
            // dgvStockBillItems
            // 
            this.dgvStockBillItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockBillItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockBillItems.Location = new System.Drawing.Point(0, 0);
            this.dgvStockBillItems.Name = "dgvStockBillItems";
            this.dgvStockBillItems.Size = new System.Drawing.Size(683, 362);
            this.dgvStockBillItems.TabIndex = 0;
            // 
            // AssemblyManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tbcSubAssemblies);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvAssemblies);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MinimumSize = new System.Drawing.Size(940, 635);
            this.Name = "AssemblyManagerControl";
            this.Size = new System.Drawing.Size(940, 635);
            this.Load += new System.EventHandler(this.AssemblyManagerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemblies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubassemblies)).EndInit();
            this.tbcSubAssemblies.ResumeLayout(false);
            this.tbSubAssemblies.ResumeLayout(false);
            this.tbProductDetails.ResumeLayout(false);
            this.tbProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockBillItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvAssemblies;
        private System.Windows.Forms.DataGridView dgvSubassemblies;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tbcSubAssemblies;
        private System.Windows.Forms.TabPage tbSubAssemblies;
        private System.Windows.Forms.TabPage tbProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssemblyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubAssemblyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMakeFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtSqft;
        private System.Windows.Forms.Button btnRemoveResource;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFile;
        private System.Windows.Forms.CheckBox cbIsContracted;
        private System.Windows.Forms.TabPage tbParts;
        private System.Windows.Forms.DataGridView dgvStockBillItems;
    }
}
