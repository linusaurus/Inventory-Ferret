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
using DataLayer.Services;
using Weaselware.InventoryFerret.Mappers;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class PartResourceEditorControl : UserControl
    {
        private ResourceDto resourceDTO;
        BadgerDataModel ctx;
        private PartsService partService;
        private Part _part;
        private PartDetailDTO _partDTO = new PartDetailDTO();
        private BindingSource bsPart = new BindingSource();
        private List<UnitOfMeasure> units = new List<UnitOfMeasure>();

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
            partService = new PartsService(ctx);
            _part = partService.Find(7991);
            units = partService.Units();
            PartDetailsMappers _partMapper = new PartDetailsMappers();
            _partMapper.Map(_part, _partDTO);
            bsPart.DataSource = _partDTO;
          
            BindPart();
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

        private void BindPart()
        {
            // PartID-------------------------------------------------------------------------------------------------------
            this.txtPartID.DataBindings.Clear();
            this.txtPartID.DataBindings.Add("Text", bsPart, "PartID", true,DataSourceUpdateMode.OnPropertyChanged);
            // Item Description --------------------------------------------------------------------------------------------
            this.txtItemDescription.DataBindings.Clear();
            this.txtItemDescription.DataBindings.Add("Text", bsPart, "ItemDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            // Item Name --------------------------------------------------------------------------------------------
            this.txtItemName.DataBindings.Clear();
            this.txtItemName.DataBindings.Add("Text", bsPart, "ItemName", true, DataSourceUpdateMode.OnPropertyChanged);
            // Part Number --------------------------------------------------------------------------------------------
            this.txtPartNumber.DataBindings.Clear();
            this.txtPartNumber.DataBindings.Add("Text", bsPart, "PartNum", true, DataSourceUpdateMode.OnPropertyChanged);
            // Unit Cost  --------------------------------------------------------------------------------------------------
            this.txtUnitCost.DataBindings.Clear();
            this.txtUnitCost.DataBindings.Add("Text", bsPart, "UnitCost", true, DataSourceUpdateMode.OnPropertyChanged);
            // UnitofMeasure  --------------------------------------------------------------------------------------------------
            this.txtLocation.DataBindings.Clear();
            this.txtLocation.DataBindings.Add("Text", bsPart, "Location", true, DataSourceUpdateMode.OnPropertyChanged);
            // Weight  --------------------------------------------------------------------------------------------------
            this.txtWeight.DataBindings.Clear();
            this.txtWeight.DataBindings.Add("Text", bsPart, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
            // Waste  --------------------------------------------------------------------------------------------------
            this.txtWaste.DataBindings.Clear();
            this.txtWaste.DataBindings.Add("Text", bsPart, "Waste", true, DataSourceUpdateMode.OnPropertyChanged);
            // Markup  --------------------------------------------------------------------------------------------------
            this.txtMarkup.DataBindings.Clear();
            this.txtMarkup.DataBindings.Add("Text", bsPart, "MarkUp", true, DataSourceUpdateMode.OnPropertyChanged);
            //Added By  --------------------------------------------------------------------------------------------------
            this.txtAddedBy.DataBindings.Clear();
            this.txtAddedBy.DataBindings.Add("Text", bsPart, "AddedBy", true, DataSourceUpdateMode.OnPropertyChanged);
            //Added Date  --------------------------------------------------------------------------------------------------
            this.txtAddedDate.DataBindings.Clear();
            this.txtAddedDate.DataBindings.Add("Text", bsPart, "DateAdded", true, DataSourceUpdateMode.OnPropertyChanged);
            //Mod By  --------------------------------------------------------------------------------------------------
            this.txtModifiedBy.DataBindings.Clear();
            this.txtModifiedBy.DataBindings.Add("Text", bsPart, "ModifiedBy", true, DataSourceUpdateMode.OnPropertyChanged);
            //Mod Date  --------------------------------------------------------------------------------------------------
            this.txtModDate.DataBindings.Clear();
            this.txtModDate.DataBindings.Add("Text", bsPart, "ModifiedDate", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void btnTypePicker_Click(object sender, EventArgs e)
        {
            PartTypePickerDialog dialog = new PartTypePickerDialog();
            dialog.PickerControl.SetContext(ctx);
           
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _part.PartTypeId = dialog.PickerControl.SelectedPartType;
            }
        }

        private void PickerControl_OnCategorySelected(object sender, PartTypePicker.CategorySelectedEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            partService.InsertOrUpdate(_partDTO, "Richard Young");
        }
    }
}
