namespace Weaselware.InventoryFerret
{
    partial class PartView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierDesc = new System.Windows.Forms.TextBox();
            this.cboSuppliers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbUseSupplierDesc = new System.Windows.Forms.CheckBox();
            this.cboUnits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboManus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.gbCostFactors = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtWaste = new System.Windows.Forms.TextBox();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DocIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.txtBoilingPoint = new System.Windows.Forms.TextBox();
            this.txtVOCcontent = new System.Windows.Forms.TextBox();
            this.txtMixRatio = new System.Windows.Forms.TextBox();
            this.txtVOCLimit = new System.Windows.Forms.TextBox();
            this.ckbCarbTrack = new System.Windows.Forms.CheckBox();
            this.labelBoilingPoint = new System.Windows.Forms.Label();
            this.lblVOCcontent = new System.Windows.Forms.Label();
            this.lblMixRatio = new System.Windows.Forms.Label();
            this.lblVOCLimits = new System.Windows.Forms.Label();
            this.btnScanSKU = new System.Windows.Forms.Button();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PartsDetailTabControl = new System.Windows.Forms.TabControl();
            this.tbResources = new System.Windows.Forms.TabPage();
            this.tbTransactions = new System.Windows.Forms.TabPage();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.btnSetLevel = new System.Windows.Forms.Button();
            this.btnPullStock = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTransCalc = new System.Windows.Forms.TextBox();
            this.txtStockOnHand = new System.Windows.Forms.TextBox();
            this.rbRecieved = new System.Windows.Forms.RadioButton();
            this.rbUsed = new System.Windows.Forms.RadioButton();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.colStockID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DateRevd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAdvanced = new System.Windows.Forms.TabPage();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errDescription)).BeginInit();
            this.gbCostFactors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PartsDetailTabControl.SuspendLayout();
            this.tbResources.SuspendLayout();
            this.tbTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.tbAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(860, 563);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 24);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(758, 563);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 24);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(88, 13);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(536, 20);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier";
            // 
            // txtSupplierDesc
            // 
            this.txtSupplierDesc.Enabled = false;
            this.txtSupplierDesc.Location = new System.Drawing.Point(324, 39);
            this.txtSupplierDesc.Name = "txtSupplierDesc";
            this.txtSupplierDesc.Size = new System.Drawing.Size(300, 20);
            this.txtSupplierDesc.TabIndex = 2;
            // 
            // cboSuppliers
            // 
            this.cboSuppliers.Enabled = false;
            this.cboSuppliers.FormattingEnabled = true;
            this.cboSuppliers.Location = new System.Drawing.Point(88, 39);
            this.cboSuppliers.Name = "cboSuppliers";
            this.cboSuppliers.Size = new System.Drawing.Size(151, 21);
            this.cboSuppliers.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier Desc";
            // 
            // ckbUseSupplierDesc
            // 
            this.ckbUseSupplierDesc.AutoSize = true;
            this.ckbUseSupplierDesc.Enabled = false;
            this.ckbUseSupplierDesc.Location = new System.Drawing.Point(510, 68);
            this.ckbUseSupplierDesc.Name = "ckbUseSupplierDesc";
            this.ckbUseSupplierDesc.Size = new System.Drawing.Size(114, 17);
            this.ckbUseSupplierDesc.TabIndex = 5;
            this.ckbUseSupplierDesc.Text = "Use Supplier Desc";
            this.ckbUseSupplierDesc.UseVisualStyleBackColor = true;
            // 
            // cboUnits
            // 
            this.cboUnits.FormattingEnabled = true;
            this.cboUnits.Location = new System.Drawing.Point(56, 34);
            this.cboUnits.Name = "cboUnits";
            this.cboUnits.Size = new System.Drawing.Size(59, 21);
            this.cboUnits.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Units";
            // 
            // cboManus
            // 
            this.cboManus.FormattingEnabled = true;
            this.cboManus.Location = new System.Drawing.Point(88, 66);
            this.cboManus.Name = "cboManus";
            this.cboManus.Size = new System.Drawing.Size(151, 21);
            this.cboManus.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Manufactor";
            // 
            // errDescription
            // 
            this.errDescription.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Unit Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(124, 35);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(52, 20);
            this.txtUnitPrice.TabIndex = 1;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // gbCostFactors
            // 
            this.gbCostFactors.Controls.Add(this.txtLocation);
            this.gbCostFactors.Controls.Add(this.txtWaste);
            this.gbCostFactors.Controls.Add(this.txtMarkup);
            this.gbCostFactors.Controls.Add(this.txtWeight);
            this.gbCostFactors.Controls.Add(this.label11);
            this.gbCostFactors.Controls.Add(this.cboUnits);
            this.gbCostFactors.Controls.Add(this.txtUnitPrice);
            this.gbCostFactors.Controls.Add(this.label9);
            this.gbCostFactors.Controls.Add(this.label4);
            this.gbCostFactors.Controls.Add(this.label8);
            this.gbCostFactors.Controls.Add(this.label6);
            this.gbCostFactors.Controls.Add(this.label7);
            this.gbCostFactors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbCostFactors.Location = new System.Drawing.Point(27, 101);
            this.gbCostFactors.Name = "gbCostFactors";
            this.gbCostFactors.Size = new System.Drawing.Size(597, 67);
            this.gbCostFactors.TabIndex = 9;
            this.gbCostFactors.TabStop = false;
            this.gbCostFactors.Text = "Cost Factors";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(506, 35);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(70, 20);
            this.txtLocation.TabIndex = 5;
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLocation.Validating += new System.ComponentModel.CancelEventHandler(this.txtLocation_Validating);
            // 
            // txtWaste
            // 
            this.txtWaste.Location = new System.Drawing.Point(401, 35);
            this.txtWaste.Name = "txtWaste";
            this.txtWaste.Size = new System.Drawing.Size(52, 20);
            this.txtWaste.TabIndex = 4;
            this.txtWaste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarkup
            // 
            this.txtMarkup.Location = new System.Drawing.Point(345, 35);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(52, 20);
            this.txtMarkup.TabIndex = 3;
            this.txtMarkup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(288, 35);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(52, 20);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(517, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Waste ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Markup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Weight";
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(477, 179);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(147, 20);
            this.txtSKU.TabIndex = 11;
            this.txtSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocIDColumn,
            this.DesriptionColumn,
            this.DocPathColumn,
            this.DocView});
            this.dataGridView1.Location = new System.Drawing.Point(9, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 282);
            this.dataGridView1.TabIndex = 13;
            // 
            // DocIDColumn
            // 
            this.DocIDColumn.DataPropertyName = "DocID";
            this.DocIDColumn.HeaderText = "DocID";
            this.DocIDColumn.Name = "DocIDColumn";
            this.DocIDColumn.Width = 60;
            // 
            // DesriptionColumn
            // 
            this.DesriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DesriptionColumn.DataPropertyName = "Description";
            this.DesriptionColumn.HeaderText = "Description";
            this.DesriptionColumn.Name = "DesriptionColumn";
            // 
            // DocPathColumn
            // 
            this.DocPathColumn.DataPropertyName = "DocumentPath";
            this.DocPathColumn.HeaderText = "Path";
            this.DocPathColumn.Name = "DocPathColumn";
            this.DocPathColumn.Width = 60;
            // 
            // DocView
            // 
            this.DocView.DataPropertyName = "View";
            this.DocView.HeaderText = "DocumentView";
            this.DocView.Name = "DocView";
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(10, 19);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(89, 23);
            this.btnAddResource.TabIndex = 14;
            this.btnAddResource.Text = "New Resource";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // txtBoilingPoint
            // 
            this.txtBoilingPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoilingPoint.Location = new System.Drawing.Point(156, 259);
            this.txtBoilingPoint.Name = "txtBoilingPoint";
            this.txtBoilingPoint.Size = new System.Drawing.Size(80, 20);
            this.txtBoilingPoint.TabIndex = 4;
            this.txtBoilingPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVOCcontent
            // 
            this.txtVOCcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVOCcontent.Location = new System.Drawing.Point(242, 259);
            this.txtVOCcontent.Name = "txtVOCcontent";
            this.txtVOCcontent.Size = new System.Drawing.Size(71, 20);
            this.txtVOCcontent.TabIndex = 5;
            this.txtVOCcontent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMixRatio
            // 
            this.txtMixRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMixRatio.Location = new System.Drawing.Point(319, 259);
            this.txtMixRatio.Name = "txtMixRatio";
            this.txtMixRatio.Size = new System.Drawing.Size(79, 20);
            this.txtMixRatio.TabIndex = 6;
            this.txtMixRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVOCLimit
            // 
            this.txtVOCLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtVOCLimit.Location = new System.Drawing.Point(404, 259);
            this.txtVOCLimit.Name = "txtVOCLimit";
            this.txtVOCLimit.Size = new System.Drawing.Size(75, 20);
            this.txtVOCLimit.TabIndex = 7;
            this.txtVOCLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbCarbTrack
            // 
            this.ckbCarbTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbCarbTrack.AutoSize = true;
            this.ckbCarbTrack.Location = new System.Drawing.Point(62, 261);
            this.ckbCarbTrack.Name = "ckbCarbTrack";
            this.ckbCarbTrack.Size = new System.Drawing.Size(86, 17);
            this.ckbCarbTrack.TabIndex = 3;
            this.ckbCarbTrack.Text = "CARB Track";
            this.ckbCarbTrack.UseVisualStyleBackColor = true;
            this.ckbCarbTrack.CheckedChanged += new System.EventHandler(this.ckbCarbTrack_CheckedChanged);
            // 
            // labelBoilingPoint
            // 
            this.labelBoilingPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBoilingPoint.AutoSize = true;
            this.labelBoilingPoint.Location = new System.Drawing.Point(167, 243);
            this.labelBoilingPoint.Name = "labelBoilingPoint";
            this.labelBoilingPoint.Size = new System.Drawing.Size(65, 13);
            this.labelBoilingPoint.TabIndex = 17;
            this.labelBoilingPoint.Text = "Boiling Point";
            // 
            // lblVOCcontent
            // 
            this.lblVOCcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVOCcontent.AutoSize = true;
            this.lblVOCcontent.Location = new System.Drawing.Point(242, 243);
            this.lblVOCcontent.Name = "lblVOCcontent";
            this.lblVOCcontent.Size = new System.Drawing.Size(69, 13);
            this.lblVOCcontent.TabIndex = 17;
            this.lblVOCcontent.Text = "VOC Content";
            // 
            // lblMixRatio
            // 
            this.lblMixRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMixRatio.AutoSize = true;
            this.lblMixRatio.Location = new System.Drawing.Point(332, 243);
            this.lblMixRatio.Name = "lblMixRatio";
            this.lblMixRatio.Size = new System.Drawing.Size(51, 13);
            this.lblMixRatio.TabIndex = 17;
            this.lblMixRatio.Text = "Mix Ratio";
            // 
            // lblVOCLimits
            // 
            this.lblVOCLimits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVOCLimits.AutoSize = true;
            this.lblVOCLimits.Location = new System.Drawing.Point(414, 243);
            this.lblVOCLimits.Name = "lblVOCLimits";
            this.lblVOCLimits.Size = new System.Drawing.Size(53, 13);
            this.lblVOCLimits.TabIndex = 17;
            this.lblVOCLimits.Text = "VOC Limit";
            // 
            // btnScanSKU
            // 
            this.btnScanSKU.Location = new System.Drawing.Point(339, 178);
            this.btnScanSKU.Name = "btnScanSKU";
            this.btnScanSKU.Size = new System.Drawing.Size(132, 23);
            this.btnScanSKU.TabIndex = 18;
            this.btnScanSKU.Text = "Scan/Associate UPC";
            this.btnScanSKU.UseVisualStyleBackColor = true;
            this.btnScanSKU.Click += new System.EventHandler(this.btnScanSKU_Click);
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(324, 66);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(180, 20);
            this.txtPartName.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Part Num";
            // 
            // PartsDetailTabControl
            // 
            this.PartsDetailTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PartsDetailTabControl.Controls.Add(this.tbResources);
            this.PartsDetailTabControl.Controls.Add(this.tbTransactions);
            this.PartsDetailTabControl.Controls.Add(this.tbAdvanced);
            this.PartsDetailTabControl.Location = new System.Drawing.Point(17, 208);
            this.PartsDetailTabControl.Name = "PartsDetailTabControl";
            this.PartsDetailTabControl.SelectedIndex = 0;
            this.PartsDetailTabControl.Size = new System.Drawing.Size(677, 379);
            this.PartsDetailTabControl.TabIndex = 20;
            // 
            // tbResources
            // 
            this.tbResources.Controls.Add(this.dataGridView1);
            this.tbResources.Controls.Add(this.btnAddResource);
            this.tbResources.Location = new System.Drawing.Point(4, 22);
            this.tbResources.Name = "tbResources";
            this.tbResources.Padding = new System.Windows.Forms.Padding(3);
            this.tbResources.Size = new System.Drawing.Size(669, 353);
            this.tbResources.TabIndex = 0;
            this.tbResources.Text = "Resources";
            this.tbResources.UseVisualStyleBackColor = true;
            // 
            // tbTransactions
            // 
            this.tbTransactions.Controls.Add(this.rbAll);
            this.tbTransactions.Controls.Add(this.btnSetLevel);
            this.tbTransactions.Controls.Add(this.btnPullStock);
            this.tbTransactions.Controls.Add(this.label12);
            this.tbTransactions.Controls.Add(this.txtTransCalc);
            this.tbTransactions.Controls.Add(this.txtStockOnHand);
            this.tbTransactions.Controls.Add(this.rbRecieved);
            this.tbTransactions.Controls.Add(this.rbUsed);
            this.tbTransactions.Controls.Add(this.dgvTransactions);
            this.tbTransactions.Location = new System.Drawing.Point(4, 22);
            this.tbTransactions.Name = "tbTransactions";
            this.tbTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransactions.Size = new System.Drawing.Size(606, 323);
            this.tbTransactions.TabIndex = 1;
            this.tbTransactions.Text = "Transactions";
            this.tbTransactions.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(174, 6);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 6;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // btnSetLevel
            // 
            this.btnSetLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetLevel.Location = new System.Drawing.Point(115, 292);
            this.btnSetLevel.Name = "btnSetLevel";
            this.btnSetLevel.Size = new System.Drawing.Size(98, 28);
            this.btnSetLevel.TabIndex = 5;
            this.btnSetLevel.Text = "Set Level";
            this.btnSetLevel.UseVisualStyleBackColor = true;
            this.btnSetLevel.Click += new System.EventHandler(this.btnSetLevel_Click);
            // 
            // btnPullStock
            // 
            this.btnPullStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPullStock.Location = new System.Drawing.Point(5, 292);
            this.btnPullStock.Name = "btnPullStock";
            this.btnPullStock.Size = new System.Drawing.Size(98, 28);
            this.btnPullStock.TabIndex = 5;
            this.btnPullStock.Text = "Pull Stock";
            this.btnPullStock.UseVisualStyleBackColor = true;
            this.btnPullStock.Click += new System.EventHandler(this.btnPullStock_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Stock On Hand";
            // 
            // txtTransCalc
            // 
            this.txtTransCalc.Location = new System.Drawing.Point(223, 5);
            this.txtTransCalc.Name = "txtTransCalc";
            this.txtTransCalc.Size = new System.Drawing.Size(72, 20);
            this.txtTransCalc.TabIndex = 3;
            // 
            // txtStockOnHand
            // 
            this.txtStockOnHand.Location = new System.Drawing.Point(495, 6);
            this.txtStockOnHand.Name = "txtStockOnHand";
            this.txtStockOnHand.Size = new System.Drawing.Size(100, 20);
            this.txtStockOnHand.TabIndex = 2;
            this.txtStockOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockOnHand.TextChanged += new System.EventHandler(this.txtStockOnHand_TextChanged);
            // 
            // rbRecieved
            // 
            this.rbRecieved.AutoSize = true;
            this.rbRecieved.Location = new System.Drawing.Point(10, 6);
            this.rbRecieved.Name = "rbRecieved";
            this.rbRecieved.Size = new System.Drawing.Size(71, 17);
            this.rbRecieved.TabIndex = 1;
            this.rbRecieved.TabStop = true;
            this.rbRecieved.Text = "Received";
            this.rbRecieved.UseVisualStyleBackColor = true;
            this.rbRecieved.CheckedChanged += new System.EventHandler(this.rbRecieved_CheckedChanged);
            // 
            // rbUsed
            // 
            this.rbUsed.AutoSize = true;
            this.rbUsed.Location = new System.Drawing.Point(87, 6);
            this.rbUsed.Name = "rbUsed";
            this.rbUsed.Size = new System.Drawing.Size(75, 17);
            this.rbUsed.TabIndex = 1;
            this.rbUsed.TabStop = true;
            this.rbUsed.Text = "Consumed";
            this.rbUsed.UseVisualStyleBackColor = true;
            this.rbUsed.CheckedChanged += new System.EventHandler(this.rbUsed_CheckedChanged);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockID,
            this.DateRevd,
            this.colLineID,
            this.colQnty,
            this.colJobName});
            this.dgvTransactions.Location = new System.Drawing.Point(3, 30);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(12);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(593, 259);
            this.dgvTransactions.TabIndex = 0;
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            // 
            // colStockID
            // 
            this.colStockID.DataPropertyName = "OrderReceiptId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStockID.DefaultCellStyle = dataGridViewCellStyle1;
            this.colStockID.HeaderText = "ReceiptID";
            this.colStockID.Name = "colStockID";
            this.colStockID.ReadOnly = true;
            this.colStockID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStockID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStockID.Width = 60;
            // 
            // DateRevd
            // 
            this.DateRevd.DataPropertyName = "TransDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DateRevd.DefaultCellStyle = dataGridViewCellStyle2;
            this.DateRevd.HeaderText = "Date";
            this.DateRevd.Name = "DateRevd";
            this.DateRevd.ReadOnly = true;
            this.DateRevd.Width = 70;
            // 
            // colLineID
            // 
            this.colLineID.DataPropertyName = "LineID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLineID.DefaultCellStyle = dataGridViewCellStyle3;
            this.colLineID.HeaderText = "LineID";
            this.colLineID.Name = "colLineID";
            this.colLineID.ReadOnly = true;
            this.colLineID.Width = 60;
            // 
            // colQnty
            // 
            this.colQnty.DataPropertyName = "QntyRev";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colQnty.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQnty.HeaderText = "Qnty";
            this.colQnty.Name = "colQnty";
            this.colQnty.ReadOnly = true;
            this.colQnty.Width = 58;
            // 
            // colJobName
            // 
            this.colJobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJobName.DataPropertyName = "JobName";
            this.colJobName.HeaderText = "Job";
            this.colJobName.Name = "colJobName";
            this.colJobName.ReadOnly = true;
            // 
            // tbAdvanced
            // 
            this.tbAdvanced.Controls.Add(this.txtBoilingPoint);
            this.tbAdvanced.Controls.Add(this.txtVOCcontent);
            this.tbAdvanced.Controls.Add(this.txtMixRatio);
            this.tbAdvanced.Controls.Add(this.lblVOCLimits);
            this.tbAdvanced.Controls.Add(this.txtVOCLimit);
            this.tbAdvanced.Controls.Add(this.lblMixRatio);
            this.tbAdvanced.Controls.Add(this.ckbCarbTrack);
            this.tbAdvanced.Controls.Add(this.lblVOCcontent);
            this.tbAdvanced.Controls.Add(this.labelBoilingPoint);
            this.tbAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tbAdvanced.Name = "tbAdvanced";
            this.tbAdvanced.Size = new System.Drawing.Size(606, 323);
            this.tbAdvanced.TabIndex = 2;
            this.tbAdvanced.Text = "Advanced";
            this.tbAdvanced.UseVisualStyleBackColor = true;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.Image = global::Weaselware.InventoryFerret.Properties.Resources.close_window;
            this.CloseBox.Location = new System.Drawing.Point(947, 13);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseBox.TabIndex = 21;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // PartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.PartsDetailTabControl);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.btnScanSKU);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.gbCostFactors);
            this.Controls.Add(this.cboManus);
            this.Controls.Add(this.ckbUseSupplierDesc);
            this.Controls.Add(this.cboSuppliers);
            this.Controls.Add(this.txtSupplierDesc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(644, 460);
            this.Name = "PartView";
            this.Size = new System.Drawing.Size(987, 601);
            this.Load += new System.EventHandler(this.PartView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errDescription)).EndInit();
            this.gbCostFactors.ResumeLayout(false);
            this.gbCostFactors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PartsDetailTabControl.ResumeLayout(false);
            this.tbResources.ResumeLayout(false);
            this.tbTransactions.ResumeLayout(false);
            this.tbTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.tbAdvanced.ResumeLayout(false);
            this.tbAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierDesc;
        private System.Windows.Forms.ComboBox cboSuppliers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbUseSupplierDesc;
        private System.Windows.Forms.ComboBox cboUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboManus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.GroupBox gbCostFactors;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocPathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocView;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.CheckBox ckbCarbTrack;
        private System.Windows.Forms.TextBox txtVOCLimit;
        private System.Windows.Forms.TextBox txtMixRatio;
        private System.Windows.Forms.TextBox txtVOCcontent;
        private System.Windows.Forms.TextBox txtBoilingPoint;
        private System.Windows.Forms.Label lblVOCLimits;
        private System.Windows.Forms.Label lblMixRatio;
        private System.Windows.Forms.Label lblVOCcontent;
        private System.Windows.Forms.Label labelBoilingPoint;
        private System.Windows.Forms.Button btnScanSKU;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtWaste;
        private System.Windows.Forms.TextBox txtMarkup;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl PartsDetailTabControl;
        private System.Windows.Forms.TabPage tbResources;
        private System.Windows.Forms.TabPage tbTransactions;
        private System.Windows.Forms.TabPage tbAdvanced;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.RadioButton rbRecieved;
        private System.Windows.Forms.RadioButton rbUsed;
        private System.Windows.Forms.TextBox txtStockOnHand;
        private System.Windows.Forms.TextBox txtTransCalc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSetLevel;
        private System.Windows.Forms.Button btnPullStock;
        private System.Windows.Forms.DataGridViewLinkColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRevd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobName;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.PictureBox CloseBox;
    }
}
