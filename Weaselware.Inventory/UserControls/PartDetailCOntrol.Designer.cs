namespace Weaselware.InventoryFerret.UserControls
{
    partial class PartDetailCOntrol
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
            System.Windows.Forms.Label itemDescriptionLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label sKULabel;
            System.Windows.Forms.Label partNumLabel;
            System.Windows.Forms.Label partIDLabel;
            this.txtitemDescription = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.ckbCARB = new System.Windows.Forms.CheckBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtPartNum = new System.Windows.Forms.TextBox();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPullStock = new System.Windows.Forms.Button();
            itemDescriptionLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            sKULabel = new System.Windows.Forms.Label();
            partNumLabel = new System.Windows.Forms.Label();
            partIDLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Location = new System.Drawing.Point(37, 64);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new System.Drawing.Size(86, 13);
            itemDescriptionLabel.TabIndex = 1;
            itemDescriptionLabel.Text = "Item Description:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(66, 90);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 3;
            itemNameLabel.Text = "Item Name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(250, 90);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 7;
            locationLabel.Text = "Location:";
            // 
            // sKULabel
            // 
            sKULabel.AutoSize = true;
            sKULabel.Location = new System.Drawing.Point(403, 90);
            sKULabel.Name = "sKULabel";
            sKULabel.Size = new System.Drawing.Size(32, 13);
            sKULabel.TabIndex = 8;
            sKULabel.Text = "SKU:";
            // 
            // partNumLabel
            // 
            partNumLabel.AutoSize = true;
            partNumLabel.Location = new System.Drawing.Point(245, 38);
            partNumLabel.Name = "partNumLabel";
            partNumLabel.Size = new System.Drawing.Size(54, 13);
            partNumLabel.TabIndex = 10;
            partNumLabel.Text = "Part Num:";
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Location = new System.Drawing.Point(84, 38);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new System.Drawing.Size(43, 13);
            partIDLabel.TabIndex = 12;
            partIDLabel.Text = "Part ID:";
            // 
            // txtitemDescription
            // 
            this.txtitemDescription.Location = new System.Drawing.Point(133, 61);
            this.txtitemDescription.Name = "txtitemDescription";
            this.txtitemDescription.Size = new System.Drawing.Size(484, 20);
            this.txtitemDescription.TabIndex = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(133, 87);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 4;
            // 
            // ckbCARB
            // 
            this.ckbCARB.Location = new System.Drawing.Point(513, 35);
            this.ckbCARB.Name = "ckbCARB";
            this.ckbCARB.Size = new System.Drawing.Size(104, 24);
            this.ckbCARB.TabIndex = 6;
            this.ckbCARB.Text = "CARB Track";
            this.ckbCARB.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(307, 87);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(83, 20);
            this.txtLocation.TabIndex = 8;
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(441, 87);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(176, 20);
            this.txtSKU.TabIndex = 9;
            this.txtSKU.TextChanged += new System.EventHandler(this.txtSKU_TextChanged);
            // 
            // txtPartNum
            // 
            this.txtPartNum.Location = new System.Drawing.Point(307, 35);
            this.txtPartNum.Name = "txtPartNum";
            this.txtPartNum.Size = new System.Drawing.Size(151, 20);
            this.txtPartNum.TabIndex = 11;
            // 
            // txtPartID
            // 
            this.txtPartID.AcceptsTab = true;
            this.txtPartID.Enabled = false;
            this.txtPartID.Location = new System.Drawing.Point(133, 35);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(100, 20);
            this.txtPartID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Amount Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Current Stock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPullStock);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtCurrentStock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(133, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 134);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Control";
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.Location = new System.Drawing.Point(19, 61);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.ReadOnly = true;
            this.txtCurrentStock.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentStock.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // btnPullStock
            // 
            this.btnPullStock.Location = new System.Drawing.Point(157, 87);
            this.btnPullStock.Name = "btnPullStock";
            this.btnPullStock.Size = new System.Drawing.Size(100, 31);
            this.btnPullStock.TabIndex = 18;
            this.btnPullStock.Text = "Pull Stock";
            this.btnPullStock.UseVisualStyleBackColor = true;
            this.btnPullStock.Click += new System.EventHandler(this.btnPullStock_Click);
            // 
            // PartDetailCOntrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(partIDLabel);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(partNumLabel);
            this.Controls.Add(this.txtPartNum);
            this.Controls.Add(sKULabel);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.ckbCARB);
            this.Controls.Add(itemNameLabel);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(itemDescriptionLabel);
            this.Controls.Add(this.txtitemDescription);
            this.Name = "PartDetailCOntrol";
            this.Size = new System.Drawing.Size(648, 312);
            this.Load += new System.EventHandler(this.PartDetailCOntrol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtitemDescription;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.CheckBox ckbCARB;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPullStock;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCurrentStock;
    }
}
