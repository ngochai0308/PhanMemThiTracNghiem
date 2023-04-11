using Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.common;

namespace TestApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Nap gia tri tu file app.config
            TestCore.ConnectionString.loadConfig();
            FrmDangNhap frmDangNhap = new FrmDangNhap();

            Application.Run(frmDangNhap);
            if (frmDangNhap.isLoginSucces)
            {
                if (Session.LogonUser.RoleID=="User")
                    Application.Run(new FrmOption());
                else
                Application.Run(new FrmMain());
            }
        }
    }
}
