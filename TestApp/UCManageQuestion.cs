using BusinessLogicLayer;
using Entities;
using System;
using System.Windows.Forms;
using TestApp.common;

namespace TestApp
{
    public partial class UCManageQuestion : UserControl
    {
        public UCManageQuestion()
        {
            InitializeComponent();
        }
        private bool isAddNew = false;
        private int rowIndex = 0;
        private void UCQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            ShowHideButton(false);
            loadData();
            SetEnableControl(false);
            cbbSubject.DataSource = BSubject.GetAll();
            cbbSubject.DisplayMember = "SubjectName";
            cbbSubject.ValueMember = "SubjectID";
        }
        private Question GetUserInfor()
        {
            Question question = new Question();
            int.TryParse(txtQuestionID.Text, out int questionID);
            question.QuestionID = questionID;
            question.SubjectID = cbbSubject.SelectedValue.ToString();
            question.Qcontent = txtQcontent.Text.Trim();
            question.Answer = txtAnswer.Text.Trim();
            question.OptionA = txtOptionA.Text.Trim();
            question.OptionB = txtOptionB.Text.Trim();
            question.OptionC = txtOptionC.Text.Trim();
            question.OptionD = txtOptionD.Text.Trim();
            question.CreatedBy = Session.LogonUser.UserName;
            question.ModifiedBy = Session.LogonUser.UserName;
            return question;


        }
        private bool IsValidQuestion(Question question)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(question.Qcontent))
            {
                strMessage = "Nội dung không được để trống\n";
            }
            if (string.IsNullOrEmpty(question.OptionA))
            {
                strMessage += "Nội dung A không được để trống\n";
            }
            if (string.IsNullOrEmpty(question.OptionB))
            {
                strMessage += "Nội dung B không được để trống\n";
            }
            if (string.IsNullOrEmpty(question.OptionC))
            {
                strMessage += "Nội dung C không được để trống\n";
            }
            if (string.IsNullOrEmpty(question.OptionD))
            {
                strMessage += "Nội dung D không được để trống\n";
            }
            if (!string.IsNullOrEmpty(strMessage))
            {
                MessageBox.Show(strMessage, "Lỗi Nhập Liệu\n");
                return false;
            }
            return true;

        }
        private void addNewQuestion()
        {
            var newQuestion = GetUserInfor();
            if (!IsValidQuestion(newQuestion))
                return;
            try
            {
                BQuestion.AddNewQuestion(newQuestion);
                MessageBox.Show("Them thanh cong", "Thong Bao");
                loadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi:" + ex);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpInfor.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Clear();
                }
            }
            isAddNew = false;
            ShowHideButton(true);
            SetEnableControl(true);
        }
        private void UpdateUser()
        {
            var editQuestion = GetUserInfor();
            if (!IsValidQuestion(editQuestion))
                return;
            try
            {
                BQuestion.UpdateQuestion(editQuestion);
                MessageBox.Show("Sua thanh cong", "Thong bao");
                loadData();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi:" + ex);
            }
        }

        private void grvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grvData["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : string.Empty) + (e.RowIndex + 1);
        }
        private void ShowDetailData(int rowIndex)
        {

            DataGridViewRow row = grvData.Rows[rowIndex];
            try
            {
                txtQcontent.Text = row.Cells["Qcontent"].Value.ToString();
                txtAnswer.Text = row.Cells["Answer"].Value.ToString();
                txtQuestionID.Text = row.Cells["QuestionID"].Value.ToString();
                txtOptionB.Text = row.Cells["OptionB"].Value.ToString();
                txtOptionD.Text = row.Cells["OptionD"].Value.ToString();
                cbbSubject.SelectedValue = row.Cells["SubjectID"].Value.ToString();
                txtOptionA.Text = row.Cells["OptionA"].Value.ToString();
                txtOptionC.Text = row.Cells["OptionC"].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi: " + ex);
            }
        }
        private void SetEnableControl(bool isEnable = true)
        {
            foreach (Control ctr in grpInfor.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txtInpuy = (TextBox)ctr;
                    ctr.Enabled = isEnable;
                }
                else if (ctr is ComboBox)
                {
                    ComboBox cbbID = ctr as ComboBox;
                    cbbID.Enabled = isEnable;
                }
            }
        }
        private void grvData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            ShowDetailData(rowIndex);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAddNew = true;
            ShowHideButton(true);
            SetEnableControl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int.TryParse(txtQuestionID.Text, out int QuestionID);
            if (QuestionID == 0)
            {
                MessageBox.Show("Vui long chon cau hoi muon xoa");
                return;
            }
            try
            {
                string fullName = txtQcontent.Text.Trim();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa câu hỏi \"{fullName} \"?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BQuestion.DeleteQuestion(QuestionID);
                    MessageBox.Show("Xoa thanh cong!", "Thong Bao");
                    loadData();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi: " + ex);
            }
        }
        private void loadData()
        {
            try
            {
                grvData.AutoGenerateColumns = false;
                grvData.DataSource = BQuestion.GetAll();

                cbbSubject.DataSource = BQuestion.GetAll();
                cbbSubject.DisplayMember = "SubjectName";
                cbbSubject.ValueMember = "SubjectID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Thong Bao Loi!");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtFind.Text.Trim();
                grvData.DataSource = BQuestion.Search(keyword);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Thong Bao Loi!");
            }
        }

        private void txtFind_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtFind.Clear();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
            {
                txtFind.Text = "Nhập nội dung câu hỏi";
            }
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            txtFind.Clear();
        }
        private void ShowHideButton(bool isSaveCancel = false)
        {
            btnSave.Visible = isSaveCancel;
            btnCancel.Visible = isSaveCancel;
            btnThem.Visible = btnSua.Visible = btnXoa.Visible = !isSaveCancel;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddNew)
                UpdateUser();
            else
                addNewQuestion();
            ShowHideButton(false);
            SetEnableControl(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowHideButton(false);
            ShowDetailData(rowIndex);
            SetEnableControl(false);
        }
    }
}
