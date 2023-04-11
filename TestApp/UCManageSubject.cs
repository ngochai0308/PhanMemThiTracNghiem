using BusinessLogicLayer;
using Entities;
using BusinessLogicLayer;
using TestApp.common;
using System.Windows.Forms;
using System;

namespace TestApp
{
    public partial class UCManageSubject : UserControl
    {
       
        public UCManageSubject()
        {
            InitializeComponent();
        }
        private bool isAddNew=false;
        private int rowIndex = 0;
        string strMessageInputSearch = "Nhập tên môn thi..";
        private void FrmManageSubject_Load(object sender, EventArgs e)
        {
            ShowHideButton(false);
            int defaultAge = 18;
            
            loadData();
            SetEnableControl(false);
        }
        private Subject GetSubjectInfor()
        {
            Subject subject = new Subject();
            subject.SubjectID = txtSubjectID.Text.Trim();
            subject.SubjectName = txtSubjectName.Text.Trim();
            subject.Description = txtDescription.Text.ToString();

            subject.CreatedBy = Session.LogonUser.UserName;
            subject.ModifiedBy = Session.LogonUser.UserName;


            return subject;
        }
        private bool IsValidInfor(Subject subject)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(subject.SubjectName))
            {
                strMessage = "Tên môn thi không được để trống\n";
            }
            if (string.IsNullOrEmpty(subject.SubjectID))
            {
                strMessage += "Mã môn không được để trống\n";
            }
            if(!string.IsNullOrEmpty(strMessage))
            {
                MessageBox.Show(strMessage, "Lỗi nhập");
                return false;
            }
            return true;

        }
        private void addNewSubject()
        {
            var newSubject = GetSubjectInfor();
            if (!IsValidInfor(newSubject))
                return;
            try
            {
                BSubject.AddNewSubject(newSubject);
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
            isAddNew = false;
            ShowHideButton(true);
            SetEnableControl(true);
            txtSubjectID.Clear();
            txtSubjectName.Clear();
            txtDescription.Clear();
            
        }
        private void UpdateSubject()
        {
            var editUser = GetSubjectInfor();
            if (!IsValidInfor(editUser))
                return;
            try
            {
                BSubject.UpdateSubject(editUser);
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
                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                txtSubjectID.Text = row.Cells["SubjectID"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi: " + ex);
            }
        }
        private void SetEnableControl(bool isEnable=true)
        {
            foreach (Control ctr in grpInfor.Controls)
            {
                if(ctr is TextBox)
                {
                    TextBox txtInpuy = (TextBox)ctr;
                    ctr.Enabled = isEnable;
                }
                else if(ctr is DateTimePicker)
                {
                    DateTimePicker dpkInput = ctr as DateTimePicker;
                    dpkInput.Enabled = isEnable;
                }
                else if(ctr is ComboBox)
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
           string SubjectID= txtSubjectID.Text.Trim();
            if (SubjectID=="")
            {
                MessageBox.Show("Vui long chon mon hoc muon xoa");
                return;
            }
            try
            {
                string subjectName = txtSubjectName.Text.Trim();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa môn \"{subjectName} \"?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    BSubject.DeleteSubject(SubjectID);
                    MessageBox.Show("Xoa thanh cong!", "Thong Bao");
                    loadData();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi: " +ex);
            }
        }
        private void loadData()
        {
            try
            {
                grvData.DataSource = BSubject.GetAll();
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
                string keyword=txtFind.Text.Trim();
                if (keyword.Equals(strMessageInputSearch))
                    keyword = string.Empty;
                grvData.DataSource = BSubject.Search(keyword);
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

        private void txtFind_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFind.Text))
            {
                txtFind.Text = strMessageInputSearch;
            }    
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            txtFind.Clear();
        }
        private void ShowHideButton(bool isSaveCancel=false)
        {
            btnSave.Visible = isSaveCancel;
            btnCancel.Visible = isSaveCancel;
            btnThem.Visible=btnSua.Visible=btnXoa.Visible= !isSaveCancel;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddNew)
                UpdateSubject();
            else
                addNewSubject();
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
