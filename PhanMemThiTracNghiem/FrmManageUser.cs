using Entities;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PhanMemThiTracNghiem.common;

namespace PhanMemThiTracNghiem
{
    public partial class FrmManageUser : Form
    {
       
        public FrmManageUser()
        {
            InitializeComponent();
        }
        private bool isAddNew=false;
        private int rowIndex = 0;
        string strMessageInputSearch = "Nhập tên/Tài khoản...";
        private void FrmManageUser_Load(object sender, EventArgs e)
        {
            ShowHideButton(false);
            int defaultAge = 18;
            dpkBirthday.Value = DateTime.Now.AddYears(-defaultAge);
            loadData();
            SetEnableControl(false);
            
            DataTable dtData= BUserRole.GetAll();
            cbbRole.DataSource = dtData;
            cbbRole.DisplayMember = "RoleName";
            cbbRole.ValueMember = "RoleID";

            DataRow row = dtData.NewRow();
            row["RoleName"] = "Tất cả";
            row["RoleID"] = "all";
            dtData.Rows.InsertAt(row, 0);

            cbbRoleFilter.DataSource = dtData;
            cbbRoleFilter.DisplayMember = "RoleName";
            cbbRoleFilter.ValueMember = "RoleID";
        }
        private UserAccout GetUserInfor()
        {
            UserAccout userAccout = new UserAccout();
            userAccout.Address = txtAddress.Text.Trim();
            userAccout.PassWord = txtPassword.Text.Trim();
            userAccout.RoleID = cbbRole.SelectedValue.ToString();
            userAccout.PhoneNumber = txtPhoneNb.Text.Trim();
            userAccout.UserName = txtUsername.Text.Trim();
            userAccout.FullName = txtFullName.Text.Trim();
            userAccout.Email = txtEmail.Text.Trim();
            userAccout.CreatedBy = Session.LogonUser.UserName;
            userAccout.CreatedAt=DateTime.Now;
            userAccout.ModifiedBy = Session.LogonUser.UserName;
            userAccout.ModifiedAt=DateTime.Now;
            userAccout.Birthday = dpkBirthday.Value;
            int.TryParse(txtUserID.Text, out int UserID);
            userAccout.UserID = UserID;
            return userAccout;
        }
        private bool IsValidUser(UserAccout user)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(user.FullName))
            {
                strMessage = "Họ tên không được để trống\n";
            }
            if (string.IsNullOrEmpty(user.Email))
            {
                strMessage += "Email không được để trống\n";
            }
            if (string.IsNullOrEmpty(user.Email))
            {
                strMessage += "Email không được để trống\n";
            }
            if (string.IsNullOrEmpty(user.UserName))
            {
                strMessage += "Tài khoản không được để trống\n";
            }
            if(DateTime.Now.Year-user.Birthday.Year<10)
            {
                strMessage += "Bạn chưa đủ tuổi!";
            }    
            if (string.IsNullOrEmpty(user.PassWord))
            {
                strMessage += "Mật khẩu không được để trống\n";
            }
            if (string.IsNullOrEmpty(user.PhoneNumber))
            {
                strMessage += "Điện thoại không được để trống\n";
            }
            if(!string.IsNullOrEmpty(strMessage))
            {
                MessageBox.Show(strMessage, "Lỗi nhập");
                return false;
            }
            return true;

        }
        private void addNewUser()
        {
            var newUser = GetUserInfor();
            if (!IsValidUser(newUser))
                return;
            try
            {
                BUserAccout.AddNewUser(newUser);
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
            txtUserID.Text = "0";
            txtUserID.ReadOnly = true;
        }
        private void UpdateUser()
        {
            var editUser = GetUserInfor();
            if (!IsValidUser(editUser))
                return;
            try
            {
                BUserAccout.UpdateUser(editUser);
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
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtUsername.Text = row.Cells["UserName"].Value.ToString();
                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                dpkBirthday.Text = row.Cells["Birthday"].FormattedValue.ToString();
                txtPhoneNb.Text = row.Cells["PhoneNumber"].Value.ToString();
                cbbRole.SelectedValue = row.Cells["RoleID"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
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
            int.TryParse(txtUserID.Text,out int userID);
            if (userID==0)
            {
                MessageBox.Show("Vui long chon nguoi muon xoa");
                return;
            }
            try
            {
                string fullName = txtFullName.Text.Trim();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa người dùng \"{fullName} \"?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    BUserAccout.DeleteUser(userID);
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
            grvData.AutoGenerateColumns = false;
            try
            {
                grvData.DataSource = BUserAccout.GetAll();
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
                string roleFilter = cbbRoleFilter.SelectedValue.ToString();
                grvData.DataSource = BUserAccout.Search(keyword,roleFilter);
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
                UpdateUser();
            else
                addNewUser();
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
