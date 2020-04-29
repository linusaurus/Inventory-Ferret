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
        private Part _part;
        private OpenFileDialog openFileDialog;
        

        public NewResourceForm(Part part)
        {
            InitializeComponent();
            _part = part;
            this.Text =String.Format("Part : {0} --{1}", _part.PartID.ToString(),_part.ItemDescription.ToString().Substring(0,40));
            openFileDialog = new OpenFileDialog();
        }

        private void NewResourceForm_Load(object sender, EventArgs e)
        {

        }

        private void SetText(FileInfo info)
        {
           this.txtFilePath.Text = info.Name.ToString();          
           this.txtFileExtension.Text = info.Extension.ToString();

        }

        private FileInfo resourcePath;

        public FileInfo ResourcePath
        {
            get { return resourcePath; }
            set { resourcePath = value; }
        }


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

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            
            string errorMsg = "Resource must have a decent description";
            if (tb.Text.Length > 20)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tb.Select(0, textBox1.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(tb, errorMsg);
            }

        }

        private void textBox1_Validated(object sender, System.EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(tb, "");
        }
    }
}
