using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
        private int orderNum;

        public int OrderNum
        {
            get { return orderNum; }
            set { orderNum = value; }
        }

        public PrintOrderForm()
        {
            InitializeComponent();
           
        }

        private void PrintOrderForm_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable df = new DataTable();
            DataSet ds = new DataSet();

            // Create a connection
            using (SqlConnection cnn = new SqlConnection(Weaselware.InventoryFerret.Properties.Settings.Default.BadgerConnectionString))
            {
      
                SqlCommand cmd = new SqlCommand("PrintPO", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ordNum", SqlDbType.Int).Value = orderNum;
                cnn.Open();
                dt.Load(cmd.ExecuteReader());

                SqlCommand cmd2 = new SqlCommand("PrintPOfees", cnn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("ordNum", SqlDbType.Int).Value = orderNum;
                df.Load(cmd2.ExecuteReader());
                ds.Tables.Add(dt);
                ds.Tables.Add(df);

                PurchaseOrderReport1.SetDataSource(ds); 
                
                
            }

            

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
