using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Entities;
using System.Windows.Forms;


namespace Weaselware.InventoryFerret
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhadledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         

            // Standard App Startup
            //---------------------------------------------------------------------------------
            Main mainForm = new Main();  
            //TestHarnessForm mainForm = new TestHarnessForm();
           
            mainForm.LoggedOnUserID = 8;
            Globals.CurrentLoggedUserID = 8;
            Globals.CurrentUserName = "Richard";
            //Application.Run(new DataForm());

            Application.Run(mainForm);

            //Application.Run(mainForm);
            //--------------------------------------------------------------------------------

            //LoginForm loginForm = new LoginForm();
            //if (loginForm.ShowDialog() == DialogResult.OK)
            //{
            //    Main mainForm = new Main();
            //    mainForm.LoggedOnUserID = loginForm.EmployeeID;
            //    Globals.CurrentLoggedUserID = loginForm.EmployeeID;
            //    Application.Run(mainForm);
            //}


        }

        private static void CurrentDomainOnUnhadledException(object sender, UnhandledExceptionEventArgs e) {
            var message = String.Format("Sorry, something went wrong.\r\n" +
               "{0}\r\n" +
               "Please contact support at ext 106",
               ((Exception)e.ExceptionObject).Message);

            Console.WriteLine("ERROR {0}: {1}",
                DateTimeOffset.Now, e.ExceptionObject);

            MessageBox.Show(message, "Unexpected Error");
        }

        private static void ApplicationOnThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            var message = String.Format("Sorry, something went wrong.\r\n" +
                                        "{0}\r\n" +
                                        "Please contact support at ext 106",
                                        e.Exception.Message);

                                    Console.WriteLine("ERROR {0}: {1}",
                                        DateTimeOffset.Now, e.Exception);

            MessageBox.Show(message, "Unexpected Error");
        }
    }
}
