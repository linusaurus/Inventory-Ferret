﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Models;
using System.IO;

namespace Weaselware.InventoryFerret.UserControls
{
    public partial class AttachmentControl : UserControl
    {

        private OrderDetailDto orderDTO;
        private BindingSource bsAttachements = new BindingSource();
        public AttachmentControl()
        {
            InitializeComponent();
            this.dgResources.AutoGenerateColumns = false;
            InitializeGrid();
        }


        public void SetDatasource(OrderDetailDto OrderDTO,BindingSource Source)
        {           
           
            bsAttachements = Source;
            orderDTO = OrderDTO;
            this.dgResources.DataSource = bsAttachements;
        }

        private void AttachmentControl_Load(object sender, EventArgs e)
        {

        }


        private void InitializeGrid()
        {

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


            // AttachmentID Column --
            DataGridViewTextBoxColumn colAttachmentID = new DataGridViewTextBoxColumn();
            colAttachmentID.HeaderText = "ID";
            colAttachmentID.DataPropertyName = "AttachmentID";
            colAttachmentID.Width = 55;

            // AttachmentID Column --
            DataGridViewTextBoxColumn colCreator = new DataGridViewTextBoxColumn();
            colCreator.HeaderText = "Creator";
            colCreator.DataPropertyName = "Creator";
            colCreator.Width = 75;

            // Date Column --
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Date";
            colDate.DataPropertyName = "CreatedDate";
            colDate.Width = 75;

            // Description Column --
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();
            colDescription.HeaderText = "Description";
            colDescription.DataPropertyName = "AttachmentDescription";
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescription.DefaultCellStyle = dstyleWrapText;
            //colDescription.Width = 75;

            // Source File Column --
            DataGridViewTextBoxColumn colSourceFile = new DataGridViewTextBoxColumn();
            colSourceFile.HeaderText = "Source File";
            colSourceFile.DataPropertyName = "Src";
            colSourceFile.Width = 115;

            // Filesize Column --
            DataGridViewTextBoxColumn colFileSize = new DataGridViewTextBoxColumn();
            colFileSize.HeaderText = "File Size (KB)";
            colFileSize.DataPropertyName = "FileSize";
            colFileSize.Width = 95;

            dgResources.Columns.AddRange(colAttachmentID, colCreator, colDate, colDescription, colSourceFile, colFileSize);


        }

        private void dgResources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            AttachmentDto newAttachment = new AttachmentDto
            {
                OrderNum = orderDTO.PurchaseOrderID,
                AttachmentDescription = string.Empty,
                Src = string.Empty,
                //FileSource = new byte[],
                Ext = ".pdf",


            };

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    FileInfo fileInfo = new FileInfo(filePath);
                    newAttachment.Ext = fileInfo.Extension;
                    newAttachment.Src = fileInfo.Name.ToString();
                    newAttachment.FileSize = FileHelpers.GetSizeInMemory(fileInfo.Length);
                    newAttachment.creator = orderDTO.Purchaser;
                    newAttachment.CreatedDate = DateTime.Today;
                    //Read the bytes of the file into a byte array
                    newAttachment.FileSource = File.ReadAllBytes(filePath);
                }
            }

             bsAttachements.Add(newAttachment);
        }

        private void btnOpenResource_Click(object sender, EventArgs e)
        {

        }
    }
}
