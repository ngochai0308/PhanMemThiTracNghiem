using BusinessLogicLayer;
using BusinessLogicLayerNew;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.common;

namespace TestApp
{
    public partial class UCReportByTime : UserControl
    {
        public UCReportByTime()
        {
            InitializeComponent();
        }

        private void FrmReportBySubject_Load(object sender, EventArgs e)
        {
            dpkStartDate.Value = DateTime.Now.AddDays(-30);
            dpkEndDate.Value = DateTime.Now;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                DateTime startDate=dpkStartDate.Value;
                DateTime endDate=dpkEndDate.Value;
                 
                DataTable dtData =BTestHistory.GetReportByTime(startDate,endDate);
                CrystalReportByTime crystalReportByTime = new CrystalReportByTime();
                crystalReportByTime.SetDataSource(dtData);
                string reportTime = string.Format("Từ ngày {0} đến ngày {1}", startDate.ToString("dd/MM/yyyy"), endDate.ToString("dd/MM/yyyy"));
                crystalReportByTime.SetParameterValue("@ReportTime",reportTime);
                crystalReportByTime.SetParameterValue("@CreateBy", Session.LogonUser.UserName);
                rptViewByTime.ReportSource = crystalReportByTime;
                rptViewByTime.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi:" + ex);
            }
             
        }

        
    }
}
