using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Services;

namespace Weaselware.InventoryFerret
{
    public partial class LoginForm : Form
    {
        BadgerDataModel _context;
        bool isValidated = false;
        int _employeeID;
        IEmployeeService _employeeService;

        
        public LoginForm()
        {
            InitializeComponent();

        }

        public int EmployeeID
        {
            get { return _employeeID; }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            using(_context = new BadgerDataModel() )
            {
                _employeeService = new EmployeeService(_context);

                var user = _context.Employee.Where(c => c.Login == username).FirstOrDefault();
                if (user != null)
                {
                    
                
                if (password == user.Password)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    isValidated = true;
                    this._employeeID = user.EmployeeId;
                    Globals.CurrentLoggedUserID = user.EmployeeId;
                    Globals.CurrentUserName = _employeeService.FullName(user.EmployeeId);
                }
                else
                {
                    isValidated = false;
                    txtPassWord.Clear();
                    
                    
                }
                }
                else
                {
                    txtUserName.Clear();
                    txtPassWord.Clear();
                    txtUserName.Focus();
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isValidated)
            {
                e.Cancel = true;
                txtUserName.Focus();
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
