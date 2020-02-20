using System.ComponentModel;
using DataLayer.Entities;
using DataLayer.Services;


namespace Weaselware.InventoryFerret
{


    public class InventoryLookupItem {

        BadgerDataModel _context;

        JobsService jobService;
        OrdersService orderService;
        OrderRecieptService recieptService;
        EmployeeService employeeService;
     
        PurchaseOrder po;
        Job job;
        OrderReciept receipt;
        Employee emp;
 
        private string orderNum;
        public string orderDate;
        public string jobName;
        public string quantity;
        public string unitCost;
        public string itemDescription;
        public string supplierName;
        public string receivedDate;
        public string receivedBy;
        public string orderedBy;

        [DisplayName("Order Number")]
        public string OrderNum
        {get { return orderNum;}set{orderNum = value; } } 
 
        [DisplayName("Job Name")]
        public string JobName
        {get { return jobName; }set{ jobName = value; } }
            
        [DisplayName("Quantity")]
        public string Quantity
        {get { return quantity; } set{ quantity = value; }}
            
        [DisplayName("Unit Cost")]
        public string UnitCost
        { get { return unitCost; }set { unitCost = value; } }

        [DisplayName("Item Description")]
        public string ItemDescription
        {get { return itemDescription; }set { itemDescription = value; }}

        [DisplayName("Supplier Name")]
        public string SupplierName
        { get { return supplierName; } set { supplierName = value; } }

        [DisplayName("Received Date")]
        public string ReceivedDate
        { get { return receivedDate; } set { receivedDate = value; } }

        [DisplayName("Received By")]
        public string ReceivedBy
        { get { return receivedBy; } set { receivedBy = value; } }

        [DisplayName("Order By")]
        public string OrderedBy
        { get { return orderedBy; } set { orderedBy = value; } }


        public InventoryLookupItem(Inventory inventory, BadgerDataModel ctx) {


            if (inventory == null)
            {
                return;
            }
            _context = ctx;
            jobService = new JobsService(_context);
            orderService = new OrdersService(_context);
            recieptService = new OrderRecieptService(_context);
            employeeService = new EmployeeService(_context);

            po = orderService.GetOrderByID(recieptService.GetOrderReciept
                                                (inventory.OrderReceiptId.Value).OrderNum.Value);
            job = jobService.Find(inventory.JobId.Value);

            receipt = recieptService.GetOrderReciept(inventory.OrderReceiptId.Value);
            emp = employeeService.Find(receipt.EmployeeId.Value);

            orderNum = po.OrderNum.ToString();
            orderDate = po.OrderDate.Value.ToShortDateString();
            jobName = job.Jobname.ToString();
            quantity = inventory.Qnty.ToString();
            unitCost = "0.0";
            itemDescription = inventory.Description;            
            supplierName = po.Supplier.SupplierName.ToString();
            receivedDate = receipt.ReceiptDate.Value.ToShortDateString();
            receivedBy = emp.Firstname + " " + emp.Lastname;
            orderedBy = po.Employee.Firstname.ToString() + " "  + po.Employee.Lastname.ToString();
            

    }



    }
}
