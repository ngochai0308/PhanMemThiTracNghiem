using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem
{
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void mnChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePassWord frmChangePassWord = new FrmChangePassWord();
            frmChangePassWord.Show();
        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageUser frmManageUser = new FrmManageUser();
            frmManageUser.ShowDialog();
        }

        private void quảnLíMônThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageSubject frmManageSubject = new FrmManageSubject();
            frmManageSubject.ShowDialog();
        }

        private void quảnLíCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageQuestion frmManageQuestion = new FrmManageQuestion();
            frmManageQuestion.ShowDialog();
        }

        private void mnStartExam_Click(object sender, EventArgs e)
        {
            FrmOption frmOption = new FrmOption();
            frmOption.ShowDialog();
        }

        private void chọnMônThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTest frmTest = new FrmTest();
            frmTest.ShowDialog();
        }
    }
}
