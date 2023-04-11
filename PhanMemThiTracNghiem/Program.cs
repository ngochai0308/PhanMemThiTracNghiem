namespace PhanMemThiTracNghiem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FrmDangNhap frmDangNhap = new FrmDangNhap();

            Application.Run(frmDangNhap);
            if(frmDangNhap.isLoginSucces)
            {
                Application.Run(new FrmChinh());
            }    
        }
    }
}