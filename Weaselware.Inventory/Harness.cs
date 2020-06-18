using DataLayer.Entities;
using System;
using System.Windows.Forms;
using DataLayer.Services;
using DataLayer.Models;


namespace Weaselware.InventoryFerret
{
    public partial class Harness : Form
    {

        private BadgerDataModel ctx;
        BindingSource BSorder = new BindingSource();
        PurchaseOrder _purchaseOrder;
        OrderDetailDto orderDTO = new OrderDetailDto();
        OrdersService _orderService;

        public Harness()
        {
            InitializeComponent();
            ctx = new BadgerDataModel();
            
            this.orderEditSplitPanelControl1.SetDataSource(ctx, 5000);
         

        }

        
    }
}
