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
using System.IO;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage;
using System.Security;
using System.Windows.Controls;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class PartResourceEditorControl : UserControl
    {       
        BadgerDataModel ctx;
        private PartsService partService;
        private Part _part;
        private PartDetailDTO _partDTO = new PartDetailDTO();
        private BindingSource bsPart = new BindingSource();
        private BindingSource bsResources = new BindingSource();
        private List<UnitOfMeasure> units = new List<UnitOfMeasure>();
        private bool isDirty = false;
        PartDetailsMappers _partMapper = new PartDetailsMappers();
        private ResourceDto _selectedResourceDto;

        public PartResourceEditorControl()
        {
            InitializeComponent();          
            BuildGrid();
            BuildVersionsGrid();
        }

        public PartResourceEditorControl(BadgerDataModel context,int partID)
        {
            InitializeComponent();
        }

        public void SetDataSource(BadgerDataModel context, int partID)
        {
            ctx = context;
            partService = new PartsService(ctx);
            units = partService.Units();
            // Load the Unit Combo ----
            cboUnitOfMeasure.DisplayMember = "Uom";
            cboUnitOfMeasure.ValueMember = "UID";
            cboUnitOfMeasure.DataSource = units;

            loadData(7991);
                       
            bsPart.ListChanged += BsPart_ListChanged; 
            bsResources.ListChanged += BsResources_ListChanged;
 
            BindPart();              
        }

        private void BsResources_ListChanged(object sender, ListChangedEventArgs e)
        {
            CheckForDirtyState(e);
        }

        private void loadData(int partid)
        {
           // Pull the part from database
            _part = partService.Find(partid);
           // Hydrate the DTO
            _partMapper.Map(_part, _partDTO);
            bsPart.DataSource = _partDTO;
            bsResources.DataSource = _partDTO.Resources;
            dgResources.DataSource = bsResources;
            txtPartCategory.Text = partService.PartTypeName(_partDTO.PartTypeID);
        }

        private void BsPart_ListChanged(object sender, ListChangedEventArgs e)
        {
            CheckForDirtyState(e);
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

            // Created By  -----------------------------------------------------------------
            DataGridViewTextBoxColumn colCreatedBy = new DataGridViewTextBoxColumn();
            colCreatedBy.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCreatedBy.Width = 90;
            colCreatedBy.HeaderText = "Created By";
            colCreatedBy.DataPropertyName = "Createdby";

            // Version Date ----------
            DataGridViewTextBoxColumn colVersionDate = new DataGridViewTextBoxColumn();
            colVersionDate.Width = 100;
            colVersionDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colVersionDate.HeaderText = "Version Date";
            colVersionDate.DataPropertyName = "CreatedDate";

            // CurrentVersion ----------
            DataGridViewTextBoxColumn colCurrentVersion = new DataGridViewTextBoxColumn();
            colCurrentVersion.Width = 65;
            colCurrentVersion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCurrentVersion.HeaderText = "Vers.";
            colCurrentVersion.DataPropertyName = "CurrentVersion";

            // FileSize ----------
            DataGridViewTextBoxColumn colFileSize= new DataGridViewTextBoxColumn();
            colFileSize.Width = 65;
            colFileSize.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colFileSize.HeaderText = "Size";
            colFileSize.DataPropertyName = "FileSize";



            //colUnit.DataSource = _partService.Units();
            dgResources.Columns.AddRange(colID, colDescription, colCreatedBy, colCurrentVersion, colVersionDate,colFileSize );

            foreach (DataGridViewColumn col in dgResources.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.HeaderCell.Style.BackColor = Color.Cornsilk;
            }

        }

        private void BuildVersionsGrid()
        {
            dgVersions.AutoGenerateColumns = false;
            dgVersions.AutoGenerateColumns = false;
            dgVersions.AutoGenerateColumns = false;
            dgVersions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
            DataGridViewTextBoxColumn colResourceVersionID = new DataGridViewTextBoxColumn();
            colResourceVersionID.HeaderText = "RiD";
            colResourceVersionID.DataPropertyName = "ResourceVersionID";
            colResourceVersionID.Width = 55;

            // VersionComment Column ---------------------------------------------------------------
            DataGridViewTextBoxColumn colVersionComment = new DataGridViewTextBoxColumn();
            colVersionComment.HeaderText = "Version Comment";
            colVersionComment.DataPropertyName = "VersionComment";
            colVersionComment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVersionComment.Width = 200;

            // VersionComment Column ---------------------------------------------------------------
            DataGridViewTextBoxColumn colRVersion = new DataGridViewTextBoxColumn();
            colRVersion.HeaderText = "Ver#";
            colRVersion.DataPropertyName = "RVersion";
            colRVersion.Width = 50;

            // VersionDate Column ---------------------------------------------------------------
            DataGridViewTextBoxColumn colModDate = new DataGridViewTextBoxColumn();
            colModDate.HeaderText = "Date";
            colModDate.DataPropertyName = "ModDate";
            colModDate.Width = 70;

            // Modified By Column ---------------------------------------------------------------
            DataGridViewTextBoxColumn colModifiedBy = new DataGridViewTextBoxColumn();
            colModifiedBy.HeaderText = "Modified By";
            colModifiedBy.DataPropertyName = "ModifiedBy";
            colModifiedBy.Width = 100;

            dgVersions.Columns.AddRange(colResourceVersionID, colVersionComment, colRVersion, colModDate, colModifiedBy);
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
            //Units of Measure Combo  --------------------------------------------------------------------------------------------------
            this.cboUnitOfMeasure.DataBindings.Clear();
            this.cboUnitOfMeasure.DataBindings.Add("SelectedValue", bsPart, "UID", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void btnTypePicker_Click(object sender, EventArgs e)
        {
            PartTypePickerDialog dialog = new PartTypePickerDialog();
            dialog.PickerControl.SetContext(ctx);
           
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _partDTO.PartTypeID = dialog.PickerControl.SelectedPartType;
                txtPartCategory.Text = partService.PartTypeName(_partDTO.PartTypeID);
            }                        
        }

        private void PickerControl_OnCategorySelected(object sender, PartTypePicker.CategorySelectedEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            partService.InsertOrUpdate(_partDTO, "Richard Young");
            loadData(_partDTO.PartID);
            isDirty = false;
            ToogleButtonStyle(isDirty);
        }

        private void CheckForDirtyState(ListChangedEventArgs e)
        {
            if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged)
            {
                btnSave.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                btnSave.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                btnSave.Enabled = true;
                isDirty = true;
                ToogleButtonStyle(isDirty);
            }
        }

        private void ToogleButtonStyle(bool dirtyState)
        {
            if (dirtyState == true)
            {
                btnSave.BackColor = System.Drawing.Color.Cornsilk;
                btnSave.FlatStyle = FlatStyle.Flat;
                btnSave.FlatAppearance.BorderColor = Color.Red;
                btnSave.FlatAppearance.BorderSize = 3;
            }
            else if (dirtyState == false)
            {
                btnSave.BackColor = Color.Gainsboro;
                btnSave.FlatAppearance.BorderColor = Color.Cornsilk;
            }
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {                                          
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog.FileName;
                    FileInfo info = new FileInfo(path);
                    NewResourceForm resourceForm = new NewResourceForm(info,_partDTO.PartID);
                    resourceForm.ResourcePath = info;
                    if (resourceForm.ShowDialog() == DialogResult.OK)
                    {
                        ResourceDto newResource = resourceForm.ResourceDTO;
                        newResource.Data = File.ReadAllBytes(resourceForm.ResourcePath.FullName);
                        
                        bsResources.Add(newResource);
                    }


                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

            //NewResourceForm frm = new NewResourceForm(_partDTO.PartID);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    _info = new FileInfo(frm.ResourcePath.FullName);
               

            //    resourceDto.FileSize = FileHelpers.GetSizeInMemory(_info.Length);
            //    //Read the bytes of the file into a byte array
            //    resourceDto.Data = File.ReadAllBytes(_info.FullName);
            //    bsResources.Add(resourceDto);
            //}

        }

        private void btnOpenResource_Click(object sender, EventArgs e)
        {
            string localPath = String.Format("{0}\\WeaselScat\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            if (!File.Exists(localPath))
            {
                System.IO.Directory.CreateDirectory(localPath);
            }

            if (_selectedResourceDto != null)
            {
                localPath += _selectedResourceDto.Src;
                try
                {
                    System.IO.File.WriteAllBytes(localPath, _selectedResourceDto.Data);
                    Process.Start(localPath);
                }
                catch (Exception)
                {MessageBox.Show("Error opening file");}   
            }
        }

        private void dgResources_SelectionChanged(object sender, EventArgs e)
        {
            if (dgResources.DataSource != null)
            {
                if (dgResources.Rows.Count > 0)
                {
                    _selectedResourceDto = (ResourceDto)dgResources.CurrentRow.DataBoundItem;
                    var versions = ctx.ResourceVersion.OrderByDescending(p => p.ResourceVersionID).Where(r => r.ResourceID == _selectedResourceDto.ResourceID).ToList();
                    dgVersions.DataSource = versions;
                }
            }
        }
        /// <summary>
        /// Push a New Version onto the Stack, with renumbering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewVersion_Click(object sender, EventArgs e)
        {

        }
    }
    
}
