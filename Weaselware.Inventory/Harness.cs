using DataLayer.Entities;
using System;
using System.Windows.Forms;
using DataLayer.Services;
using DataLayer.Models;
using Weaselware.UserControls;
using Weaselware.InventoryFerret.UserControls;

namespace Weaselware.InventoryFerret
{
    public partial class Harness : Form
    {

        private BadgerDataModel ctx;
        //BindingSource BSorder = new BindingSource();
        
        //OrderDetailDto orderDTO = new OrderDetailDto();
        //OrdersService _orderService;

        public Harness()
        {
            InitializeComponent();
            ctx = new BadgerDataModel();

            PartResourceEditorControl ctr = new PartResourceEditorControl();
            this.Controls.Add(ctr);
            ctr.SetDataSource(ctx,7991);
         

        }

        
    }
}
