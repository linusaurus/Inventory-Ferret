using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Services;
using DataLayer.Interfaces;
using System.Diagnostics;
using System.IO;

namespace Weaselware.InventoryFerret
{
    public partial class ClaimControl : UserControl
    {
        Claim _claim;
        BadgerDataModel _ctx;
        IClaimService _claimService;
        IEmployeeService _employeeService;
        BindingSource bsClaimBindingSource = new BindingSource();
        BindingSource bsClaimItemBindingSource = new BindingSource();

        //cTor
        public ClaimControl(int claimID, BadgerDataModel context)
        {
            InitializeComponent();
            _ctx = context;
            _claimService = new ClaimService(_ctx);
            _employeeService = new EmployeeService(_ctx);
            _claim = _claimService.Find(claimID);
            bsClaimBindingSource.DataSource = _claim;
            ///TODO need claim child navigation added to claim class
           // bsClaimItemBindingSource.DataSource = _claim.ClaimItems;

        }

        private void ClaimControl_Load(object sender, EventArgs e)
        {
            dgClaimItems.AutoGenerateColumns = false;
            btnShowDocuments.Enabled = false;

            if (_claim != null)
            {
              databind(_claim);
              dgClaimItems.DataSource = bsClaimItemBindingSource;
            }
            
           
        }

        private void databind(Claim _claim)
        {

            this.tbClaimDate.Text = _claim.ClaimDate.Value.ToShortDateString();
            //--
            this.tbPurchaseOrder.Text = _claim.OrderNum.ToString();
            //--
            this.tbSupplierName.Text = _claim.Supplier.SupplierName.ToString();
            //--
            this.tbClaimDate.Text = _claim.ClaimDate.Value.ToShortDateString();
            //--
            this.txtClaimID.Text = _claim.ClaimId.ToString();

            //this.tbSupplierOrder.Text = _claim.SupplierOrder.ToString();
            this.tbSupplierOrder.DataBindings.Add("Text", _claim, "SupplierOrder");


        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            TabControl tabControl = (TabControl)tabpage.Parent;
            tabControl.TabPages.Remove(tabpage);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgClaimItems_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView) sender;
            ClaimItem item = (ClaimItem)dg.CurrentRow.DataBoundItem;
            txtDefectDescription.DataBindings.Clear();
            txtDefectDescription.DataBindings.Add("Text", item, "DefectDescription");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //_ctx.SaveChanges();
        }

        private void btnCloseClaim_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintClaim(_claim);
        }

        private void PrintClaim(Claim claim)
        {
            // Look up the Odd related items
            //
            string purchaserName = _employeeService.FullName(claim.EmployeeId.Value);
            StringBuilder sb = new StringBuilder();


            sb.Clear();

            // Header for Report
            sb.AppendLine("---------------------------------------------------------------------------------------------");
            sb.AppendLine(String.Format("   DEFECT CLAIM : #{0:40 } | {1:40}  |  SO# {2:-24}  | CLAIM-DATE: {3:-20}",claim.ClaimId.ToString(), claim.Supplier.SupplierName.ToString(), claim.SupplierOrder ,claim.ClaimDate.Value.ToShortDateString() ));
            sb.AppendLine("---------------------------------------------------------------------------------------------");
            sb.AppendLine(String.Format("   CUSTOMER     :  {0:40 } ", "DESIGN SYNTHESIS, INC * 9855 BLACK MOUNTAIN RD. * SAN DIEGO * CA-92126"));
            sb.AppendLine(String.Format("   CUSTOMER PO  : # {0:40 } -- Purchaser : {1:40} ", claim.OrderNum.ToString(),purchaserName));
            sb.AppendLine("---------------------------------------------------------------------------------------------");
            sb.AppendLine("");
            sb.AppendLine("");
        
            
            sb.AppendLine(String.Format("|{0:-8}|{1:-10}|{2:-20}|{3:-24}", "LineID".PadRight(8), "ClaimItem".PadRight(10), "Bcode".PadRight(20),"PartID"));
            foreach (ClaimItem x in claim.ClaimItems)
            {
                sb.AppendLine("---------------------------------------------------------------------------------------------");
                sb.AppendLine(String.Format("{0:-8}|{1:-10}|{2:-20}|{3:-12}",x.LineId.ToString().PadRight(9),x.ClaimItemId.ToString().PadRight(10),x.Bcode.PadRight(20),x.PartId.ToString().PadRight(12)));
                sb.AppendLine("---------------------------------------------------------------------------------------------");
                sb.AppendLine("");
                sb.AppendLine(String.Format("ITEM -- {0:-80}",x.Description.ToString()));
                
                sb.AppendLine(String.Format("DEFECT: {0:-80}", x.DefectDescription.ToString()));
                sb.AppendLine("");

            }


          


                string reportLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                reportLocation += @"\Claim.txt";

                File.WriteAllText(reportLocation, sb.ToString());
                Process.Start(reportLocation);



            
        }
    }
}
