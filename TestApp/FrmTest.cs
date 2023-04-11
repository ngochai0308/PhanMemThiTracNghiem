using BusinessLogicLayer;
using Entities;
using System;
using System.Data;
using System.Windows.Forms;
using TestApp.common;

namespace TestApp
{
    public partial class FrmTest : Form
    {
        private int selectedIndex = 0;
        private int remainTime = 0;
        private DataTable dtQuestion = null;
        private bool isRaiseSelctedEvent = false;
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            txtFullName.Text = Session.LogonUser.FullName;
            txtBirthday.Text = Session.LogonUser.Birthday.ToString("dd/MM/yyyy");
            txtSubjectName.Text = Session.SubjectName;
            txtNumberofQuestion.Text = Session.NumberOfQuestion.ToString();
            loadData();
            remainTime = Session.TestTime * 60;
            timerTest.Enabled = true;
            isRaiseSelctedEvent = true;
        }
        private void loadData()
        {
            try
            {
                dtQuestion = BQuestion.GetQuestionForTest(Session.SubjectID, Session.NumberOfQuestion);
                //them cột để lưu phương án lựa chọn của người dùng
                dtQuestion.Columns.Add("SelectedOption");

                lvQuestion.DataSource = dtQuestion;
                lvQuestion.DisplayMember = "QuestionIndex";
                lvQuestion.ValueMember = "QuestionID";
                selectedIndex = 0;
                lvQuestion.SelectedIndex = selectedIndex;
                ShowDetailQuestion();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex, "Thông báo");
            }
        }
        private string GetSelectedOption()
        {
            string result = string.Empty;
            if (rdoA.Checked)
                result = rdoA.Text;
            if (rdoB.Checked)
                result = rdoB.Text;
            if (rdoC.Checked)
                result = rdoC.Text;
            if (rdoD.Checked)
                result = rdoD.Text;
            return result;
        }
        private void LoadPrevSelectOpion()
        {
            string prevSelected = dtQuestion.Rows[selectedIndex]["SelectedOption"].ToString();
            if (rdoA.Text.Equals(prevSelected))
                rdoA.Checked = true;
            else if (rdoB.Text.Equals(prevSelected))
                rdoB.Checked = true;
            else if (rdoC.Text.Equals(prevSelected))
                rdoC.Checked = true;
            else if (rdoD.Text.Equals(prevSelected))
                rdoD.Checked = true;
        }
        private void SaveCurrentSelected()
        {
            //Lưu lại phương án đã chọn
            if (selectedIndex >= 0 && selectedIndex < dtQuestion.Rows.Count)
            {
                
                    dtQuestion.Rows[selectedIndex]["SelectedOption"] = GetSelectedOption();
            }
        }
        private void ShowDetailQuestion()
        {
            try
            {
                int.TryParse(lvQuestion.SelectedValue.ToString(), out int questionID);
                if (questionID < 1)
                    return;
                SaveCurrentSelected();
                selectedIndex = lvQuestion.SelectedIndex;
                //btnPrev.Enabled = (selectedIndex > 0);
                //btnNext.Enabled=(selectedIndex<Session.NumberOfQuestion-1);
                Question selectedQuestion = BQuestion.GetOne(questionID);
                rtxtContent.Text = selectedQuestion.Qcontent;
                rdoA.Text ="A. "+selectedQuestion.OptionA;
                rdoB.Text ="B. "+selectedQuestion.OptionB;
                rdoC.Text = "C. "+selectedQuestion.OptionC;
                rdoD.Text = "D. "+selectedQuestion.OptionD;
                rdoA.Checked = rdoB.Checked = rdoC.Checked = rdoD.Checked = false;
                lbQuestion.Text = lvQuestion.Text;
                LoadPrevSelectOpion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi:" + ex);
            }
        }
        private void lvQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isRaiseSelctedEvent)
                ShowDetailQuestion();
        }

        private void btnFistQuestion_Click(object sender, EventArgs e)
        {
            lvQuestion.SelectedIndex = 0;
        }

        private void btnLastQuestion_Click(object sender, EventArgs e)
        {
            lvQuestion.SelectedIndex = Session.NumberOfQuestion - 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (selectedIndex > 0)
                lvQuestion.SelectedIndex = selectedIndex - 1;
            else
                lvQuestion.SelectedIndex = Session.NumberOfQuestion - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selectedIndex < Session.NumberOfQuestion - 1)
                lvQuestion.SelectedIndex = selectedIndex + 1;
            else
                lvQuestion.SelectedIndex = 0;

        }

        private void timeTest_Tick(object sender, EventArgs e)
        {
            remainTime--;
            int remainMinute = remainTime / 60;
            string strRemainTime = (remainMinute < 10 ? "0" : String.Empty) + $"{remainMinute}:{remainTime % 60}";
            txtRemainTime.Text = strRemainTime;
            if (remainTime <= 0)
                FinishTest();

        }
        private void FinishTest()
        {
            isRaiseSelctedEvent = false;
            SaveCurrentSelected();
            int correctAnswer = 0;
            float mark = 0;
            foreach (DataRow row in dtQuestion.Rows)
            {
                string answer = row["Answer"].ToString();
                string selectedOption = row["SelectedOption"].ToString();
                selectedOption = selectedOption.Length > 0 ? selectedOption.Substring(3) : selectedOption;
                if (selectedOption.Equals(answer))
                    correctAnswer++;
            }
            mark = (float)correctAnswer * 10 / Session.NumberOfQuestion;
            //MessageBox.Show("Số điểm:" + mark.ToString("0.00"));
            this.Hide();

            FrmTestResult frmTestResult = new FrmTestResult(correctAnswer, mark);           
            frmTestResult.ShowDialog();
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn nộp bài không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            FinishTest();
        }
    }
}
