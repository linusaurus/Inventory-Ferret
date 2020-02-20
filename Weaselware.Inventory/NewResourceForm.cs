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
            this.Text = $"Part : {_part.PartId.ToString()}";
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog.FileName;
                    FileInfo info = new FileInfo(path);

                    SetText(info);
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
    }
}
