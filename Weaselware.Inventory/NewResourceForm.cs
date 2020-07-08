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
using DataLayer.Services;

namespace Weaselware.InventoryFerret
{
    public partial class NewResourceForm : Form
    {
        
        private OpenFileDialog openFileDialog;
        private FileInfo resourcePath;

        public NewResourceForm(int partID)
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }

        private void NewResourceForm_Load(object sender, EventArgs e)
        { }

        private void SetText(FileInfo info)
        {
           this.txtFilePath.Text = info.Name.ToString();          
        }
        private string resourceDescription;

        public string ResourceDescription
        {  get { return resourceDescription; }  }  
                  
        public FileInfo ResourcePath
        {get { return resourcePath; }}
            
 
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog.FileName;
                    FileInfo info = new FileInfo(path);

                    SetText(info);
                    resourcePath = info;
                }
                catch (SecurityException ex)
                {                  
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

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
            ValidateDescription();
            
            //string errorMsg = "Resource must have a decent description";
            //if (tb.Text.Length < 12)
            //{
            //    // Cancel the event and select the text to be corrected by the user.
            //    e.Cancel = true;
            //    tb.Select(0, txtResourceDescription.Text.Length);

            //    // Set the ErrorProvider error with the text to display. 
            //    this.errorProvider1.SetError(tb, errorMsg);
                
            //}
            //resourceDescription = tb.Text;
            

        }

        private void textBox1_Validated(object sender, System.EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(tb, "");
         
        }

        private bool ValidateDescription()
        {
            bool bStatus = true;
            if (txtResourceDescription.Text == "" | txtResourceDescription.Text.Length < 10)
            {
                errorProvider1.SetError(txtResourceDescription, "Please provide some description");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtResourceDescription, "");
            return bStatus;
        }

        private void txtResourceDescription_TextChanged(object sender, EventArgs e)
        {
            ValidateDescription();
        }
    }
}
