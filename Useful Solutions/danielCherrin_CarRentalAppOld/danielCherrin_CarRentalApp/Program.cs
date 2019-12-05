using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danielCherrin_CarRentalApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_LoginCustomer());
            Application.Run(new frm_RegisterCustomer());
            Application.Run(new frm_CustomerOptions());
            Application.Run(new frm_AlterCustomer());
            Application.Run(new frm_VehiclesCreateContract());
            Application.Run(new frm_DisplayContracts());
        }
    }
}
