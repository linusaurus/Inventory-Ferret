using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;
using DataLayer.Entities;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class PartResourceEditorControl : UserControl
    {
        private ResourceDto resourceDTO;
        BadgerDataModel ctx;

        public PartResourceEditorControl()
        {
            InitializeComponent();
            BuildGrid();
        }

        public PartResourceEditorControl(BadgerDataModel context,int partID)
        {
            InitializeComponent();
        }

        public void SetDataSource(BadgerDataModel context, int partID)
        {
            ctx = context;

        }


        private void BuildGrid()
        {
            dgResources.AutoGenerateColumns = false;
            dgResources.AutoGenerateColumns = false;
            dgResources.AutoGenerateColumns = false;
            dgResources.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Currency Decimal Style
            DataGridViewCellStyle dstyleCurrency = new DataGridViewCellStyle();
            dstyleCurrency.Format = "C";
            dstyleCurrency.NullValue = "";
            dstyleCurrency.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Currency Decimal Style
            DataGridViewCellStyle dstyleDecimal = new DataGridViewCellStyle();
            dstyleDecimal.Format = "N2";
            dstyleDecimal.NullValue = "0.00";
            dstyleDecimal.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Wrapping Text Style
            DataGridViewCellStyle dstyleWrapText = new DataGridViewCellStyle();
            dstyleWrapText.NullValue = "";
            dstyleWrapText.Alignment = DataGridViewContentAlignment.TopLeft;
            dstyleWrapText.WrapMode = DataGridViewTriState.True;

            // ID Column ---------------------------------------------------------------
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "RID";
            colID.DataPropertyName = "ResourceID";
            colID.Width = 55;
            
            // Description Column ------------------------------------------------------
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();
            colDescription.DefaultCellStyle = dstyleWrapText;
            colDescription.HeaderText = "Description";
            colDescription.DataPropertyName = "ResourceDescription";

            colDescription.Width = 450;
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // UnitCost -----------------------------------------------------------------
            DataGridViewTextBoxColumn colCreatedBy = new DataGridViewTextBoxColumn();
            colCreatedBy.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCreatedBy.Width = 90;
            colCreatedBy.HeaderText = "Created By";
            colCreatedBy.DataPropertyName = "Createdby";
            
            // CurrentVersion ----------
            DataGridViewTextBoxColumn colCurrentVersion = new DataGridViewTextBoxColumn();
            colCurrentVersion.Width = 100;
            colCurrentVersion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCurrentVersion.HeaderText = "R-Version";
            colCurrentVersion.DataPropertyName = "CurrentVersion";

         

            //colUnit.DataSource = _partService.Units();
            dgResources.Columns.AddRange(colID, colDescription, colCreatedBy, colCurrentVersion);

        }

        
    }
}
