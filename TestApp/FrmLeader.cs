using BusinessLogicLayerNew;
using Entities;
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
    public partial class FrmLeader : Form
    {
        public FrmLeader()
        {
            InitializeComponent();
        }

        private void FrmLeader_Load(object sender, EventArgs e)
        {
            try
            {
                TestHistory testHistory = new TestHistory();
                testHistory.SubjectID = Session.SubjectID;
                grvData.AutoGenerateColumns = false;
                grvData.DataSource=BTestHistory.GetLeaderBoard(testHistory);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void grvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grvData["STT", e.RowIndex].Value =(e.RowIndex<9?"0":String.Empty)+ (e.RowIndex + 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
