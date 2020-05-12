using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Services;
using DataLayer.Models;
using DataLayer.Interfaces;
using DataLayer.Entities;
using Weaselware.InventoryFerret;

namespace Weaselware.UserControls
{
    public partial class MyOrdersControl : UserControl
    {
        private readonly IOrdersService _ordersService;
        private readonly IJobsService _jobsService;
        private readonly BadgerDataModel ctx;
        private int _employeeID;
        private int _selectedOrderId;

        public MyOrdersControl(BadgerDataModel context, int employeeID)
        {
            InitializeComponent();
            ctx = context;
            _employeeID = employeeID;
            _ordersService = new OrdersService(ctx);
            _jobsService = new JobsService(ctx);

      
            

            dgMyOrdersGrid.AutoGenerateColumns = false;
    
            dgMyOrdersGrid.CellFormatting += DgMyOrdersGrid_CellFormatting;
        }

        private void DgMyOrdersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Compare the column to the column you want to format
            if (this.dgMyOrdersGrid.Columns[e.ColumnIndex].Name == "colRecieved")
            {
                //get the IChessitem you are currently binding, using the index of the current row to access the datasource
                OrderListDto item = (OrderListDto)dgMyOrdersGrid.Rows[e.RowIndex].DataBoundItem;
                //check the condition
                if (item.Recieved == true)
                {
                    dgMyOrdersGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cornsilk;
                }
            }
        }

        private void MyOrdersControl_Load(object sender, EventArgs e)
        {
           
            var list = _jobsService.All();

            cbJobName.DataSource = _jobsService.All();
            cbJobName.DisplayMember = "JobName";
            cbJobName.ValueMember = "JobID";
            this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, false);
        }

        private void dgMyOrdersGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView) sender;
            if (dg.DataSource != null)
            {
                if (dg.Rows.Count > 0)
                {
                    _selectedOrderId = ((OrderListDto)dg.CurrentRow.DataBoundItem).OrderNum;
                }
            }
        }

        private void dgMyOrdersGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_selectedOrderId != default)
            {
                Main main = (Main)Application.OpenForms["Main"];
                main.OpenAnOrder(_selectedOrderId);
            }
        }

        private void ckbShowRecieved_CheckedChanged(object sender, EventArgs e)
        {
           CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            { this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, true); }

            else
            { this.dgMyOrdersGrid.DataSource = _ordersService.GetMyOrders(_employeeID, false); }
               

        }

       
    }
}
