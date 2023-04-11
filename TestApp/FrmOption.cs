using BusinessLogicLayer;
using TestApp.common;
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
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Selectd infor
                Session.SubjectName = cbbSubject.Text;
                Session.SubjectID = cbbSubject.SelectedValue.ToString();
                int.TryParse(cbbNumberOfQuestion.Text,out int numberOfQuestion);
                Session.NumberOfQuestion = numberOfQuestion;
                int.TryParse(txtTime.Text, out int time);
                Session.TestTime =time;
                FrmTest frmTest = new FrmTest();
                this.Hide();
                frmTest.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
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

        private void cbbNumberOfQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTime.Text=cbbNumberOfQuestion.Text;
        }
    }
}
