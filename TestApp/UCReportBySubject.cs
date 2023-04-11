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

namespace TestApp
{
    public partial class UCReportBySubject : UserControl
    {
        public UCReportBySubject()
        {
            InitializeComponent();
        }

        private void FrmReportBySubject_Load(object sender, EventArgs e)
        {
             LoadData();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string subjectID = cbbSubject.SelectedValue.ToString();
                DataTable dtData =BTestHistory.GetReportBySubject(subjectID);
                CrystalReportBySubjectt crystalReportBySubjectt = new CrystalReportBySubjectt();
                crystalReportBySubjectt.SetDataSource(dtData);
                crystalReportViewer1.ReportSource = crystalReportBySubjectt;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi:" + ex);
            }
             
        }

        private void LoadData()
        {
            try
            {
                cbbSubject.DataSource = BSubject.GetAll();
                cbbSubject.DisplayMember = "SubjectName";
                cbbSubject.ValueMember = "SubjectID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Thong Bao Loi!");
            }
        }
    }
}
