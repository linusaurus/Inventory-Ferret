using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DataLayer.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Weaselware.InventoryFerret
{
    public partial class PrintOrderForm : Form
    {
        private POdataset ds;

        public PrintOrderForm(POdataset DS)
        {
            InitializeComponent();
            // Pass in the loaded Dataset --
            ds = DS;
        }

        private void PrintOrderForm_Load(object sender, EventArgs e)
        {
            PO_PrintReport report = new PO_PrintReport();
          
            report.SetDataSource(ds);

            this.crystalReportViewer1.ReportSource = report;
            this.crystalReportViewer1.RefreshReport();
            
        }

      
    }
}
