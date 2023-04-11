using BusinessLogicLayer;
using Entities;
using PhanMemThiTracNghiem.common;

namespace PhanMemThiTracNghiem
{
	public partial class FrmTest : Form
	{
		private int selectedIndex = 0;
		private int remainTime = 0;
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

		}
		private void loadData()
		{
			try
			{

				lvQuestion.DataSource = BQuestion.GetQuestionForTest(Session.SubjectID, Session.NumberOfQuestion);
				lvQuestion.DisplayMember = "QuestionIndex";
				lvQuestion.ValueMember = "QuestionID";
			}
			catch (Exception ex)
			{

				MessageBox.Show("Lỗi: " + ex, "Thông báo");
			}
		}

		private void lvQuestion_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int.TryParse(lvQuestion.SelectedValue.ToString(), out int questionID);
				if (questionID < 1)
					return;
				selectedIndex = lvQuestion.SelectedIndex;
				//btnPrev.Enabled = (selectedIndex > 0);
				//btnNext.Enabled=(selectedIndex<Session.NumberOfQuestion-1);
				Question selectedQuestion = BQuestion.GetOne(questionID);
				rtxtContent.Text = selectedQuestion.Qcontent;
				rdoA.Text = selectedQuestion.OptionA;
				rdoB.Text = selectedQuestion.OptionB;
				rdoC.Text = selectedQuestion.OptionC;
				rdoD.Text = selectedQuestion.OptionD;
				lbQuestion.Text = lvQuestion.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Loi:" + ex);
			}
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
			string strRemainTime = $"{remainTime / 60}:{remainTime % 60}";
			txtRemainTime.Text = strRemainTime;
		}

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
