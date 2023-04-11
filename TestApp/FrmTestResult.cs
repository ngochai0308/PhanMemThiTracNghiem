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
    public partial class FrmTestResult : Form
    {
        public FrmTestResult(int correctAnswer, float mark)
        {
            InitializeComponent();
            txtFullName.Text = Session.LogonUser.FullName;
            txtBirthday.Text = Session.LogonUser.Birthday.ToString("dd/MM/yyyy");
            txtSubject.Text = Session.SubjectName;
            txtNumberOfQuestion.Text = Session.NumberOfQuestion.ToString();
            txtCorrecAnswer.Text = correctAnswer.ToString();
            txtMark.Text = mark.ToString("0.00");
            if (mark >= 9)
                txtRate.Text = "Bạn đã vượt qua kỳ thi xuất sắc!";
            else if (mark >= 7)
                txtRate.Text = "Chúc mừng bạn thi điểm số khá tốt khá tốt!";
            else if (mark >= 5)
                txtRate.Text = "Chúc mừng bạn đã thi đỗ!";
            else
                txtRate.Text = "Bạn đã thi rớt!!!!!";

            //Save mark to database
            TestHistory testHistory = new TestHistory()
            {
                UserID = Session.LogonUser.UserID,
                SubjectID = Session.SubjectID,
                TestDate = DateTime.Now,
                CorrectAnswer = correctAnswer,
                Mark = (int)mark,
                TotalQuestion = Session.NumberOfQuestion,
                CreatedBy = Session.LogonUser.UserName
            };
            try
            {
                BTestHistory.SaveResult(testHistory);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex);
            }

            this.components = components;
        }

        private void FrmTestResult_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTestResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbtnLeaderBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLeader frmLeader= new FrmLeader();
            frmLeader.ShowDialog();
        }
    }
}
