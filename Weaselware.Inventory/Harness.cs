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
            _orderService = new OrdersService(ctx);
            // Init the mapper
            Mappers.PurchaseOrderMapper mapper = new Mappers.PurchaseOrderMapper();
            // Retrieve to PurchaseOrder Entity
            _purchaseOrder = _orderService.GetOrderByID(5000);
           

            int zip;           
            if (int.TryParse(_purchaseOrder.Supplier.Zip.ToString(),out zip ))
            {
                 _purchaseOrder.TaxRate = _orderService.GetSupplierTaxRate(zip);
            }

            if (_purchaseOrder != null)
            {
                // Map to the DTO detached data transfer object
                mapper.Map(_purchaseOrder, orderDTO);
                
                BSorder.DataSource = orderDTO;
                this.orderEditSplitPanelControl1.SetDataSource(ctx, BSorder);
            }
            

        }

        private void Harness_Load(object sender, EventArgs e)
        {

        }
    }
}
