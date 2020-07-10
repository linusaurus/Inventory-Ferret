using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Models;
using DataLayer.Services;

namespace Weaselware.InventoryFerret
{
    public partial class NewResourceForm : Form
    {
        
        
        private FileInfo resourcePath;
        private ResourceDto _resourceDTO;
        private BindingSource bsResource = new BindingSource();

        public NewResourceForm(FileInfo fileInfo,int partID)
        {
            InitializeComponent();
            resourcePath = fileInfo;
            _resourceDTO = new ResourceDto();        
            _resourceDTO.PartID = partID;
            _resourceDTO.Createdby = Globals.CurrentUserName;
            _resourceDTO.CreatedDate = DateTime.Today;
            _resourceDTO.FileSize = FileHelpers.GetSizeInMemory(fileInfo.Length);
            _resourceDTO.Extension = fileInfo.Extension;

            this.Text = $"Add Resource for Part: [{_resourceDTO.PartID}]";
            _resourceDTO.Src = resourcePath.Name;
            bsResource.DataSource = _resourceDTO;

            BindResource();
        }

       
        public ResourceDto ResourceDTO
        {
            get { return _resourceDTO; }
        }
      
        public FileInfo ResourcePath
        {
            get { return resourcePath; }
            set { resourcePath = value; }
        }

        private void BindResource()
        {
            // Description ----
            txtResourceDescription.DataBindings.Clear();
            txtResourceDescription.DataBindings.Add("Text", bsResource, "ResourceDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            // Scr ----
            txtSrc.DataBindings.Clear();
            txtSrc.DataBindings.Add("Text", bsResource, "Src", true, DataSourceUpdateMode.OnPropertyChanged);
            // Created By ----
            txtCreatedBy.DataBindings.Clear();
            txtCreatedBy.DataBindings.Add("Text", bsResource, "Createdby", true, DataSourceUpdateMode.OnPropertyChanged);
            // IsValid ----
            btnSubmit.DataBindings.Clear();
            btnSubmit.DataBindings.Add("Enabled", bsResource, "IsValid", false, DataSourceUpdateMode.OnPropertyChanged);
            // Date Added ----
            txtDateAdded.DataBindings.Clear();
            txtDateAdded.DataBindings.Add("Text", bsResource, "CreatedDate", false, DataSourceUpdateMode.OnPropertyChanged);
            // FileSize ----
            txtFileSize.DataBindings.Clear();
            txtFileSize.DataBindings.Add("Text", bsResource, "FileSize", false, DataSourceUpdateMode.OnPropertyChanged);
            // Extension ----
            txtExtension.DataBindings.Clear();
            txtExtension.DataBindings.Add("Text", bsResource, "Extension", false, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void ToogleButtonStyle(Button btn,bool dirtyState)
        {
            if (dirtyState == true)
            {
                btn.BackColor = System.Drawing.Color.Cornsilk;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Red;
                btn.FlatAppearance.BorderSize = 3;
            }
            else if (dirtyState == false)
            {
                btn.BackColor = Color.Gainsboro;
                btn.FlatAppearance.BorderColor = Color.Cornsilk;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (txtResourceDescription.Text.Length < 10)
            {
                errorProvider1.SetError(txtResourceDescription, "Please provide a description");
                e.Cancel = true;
                btnSubmit.Enabled = false;
                ToogleButtonStyle(btnSubmit, false);
            }
            else
            {
                errorProvider1.SetError(txtResourceDescription, "");
                e.Cancel = true;
                btnSubmit.Enabled = true;
                ToogleButtonStyle(btnSubmit, true);     
            }
        }


        private void NewResourceForm_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = txtResourceDescription;
        }

        private void NewResourceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
