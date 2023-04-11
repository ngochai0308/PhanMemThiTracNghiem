using Entities;
using System.Data.SqlClient;
using BusinessLogicLayer;
using System.Windows.Forms;
using System;

namespace TestApp
{
    
    public partial class FrmChangePassword : Form
    {
        public bool isLoginSucces = false;


        public FrmChangePassword()
        {
            InitializeComponent();
        }
         
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private bool IsValidUserInfor(UserAccout user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                MessageBox.Show("vui lòng nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(user.PassWord))
            {
                MessageBox.Show("vui lòng nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(user.NewPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(user.ConfirmPass))
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Kiem tra tai khoan mat khau 
            if(!BUserAccout.IsExistsAccout(user))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, Vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Kiem tra mat khau moi va xac nhan mat khau phai giong nhau
            if(!user.NewPass.Equals(user.ConfirmPass))
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không giống nhau, Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserAccout eUser = new UserAccout()
            {
                UserName = txtUser.Text.Trim(),
                PassWord = txtPassWord.Text.Trim(),
                NewPass=txtNewPass.Text.Trim(),
                ConfirmPass=txtConfirmPass.Text.Trim()
            };
          //Kiem tra thong tin hop le chua
            if(!IsValidUserInfor(eUser))
            {
                return;
            }
            //Cap nhat thong tin moi cho nguoi dung
            try
            {
                BUserAccout.UpdatePassword(eUser);
                MessageBox.Show("Thay doi mat khau thanh cong.");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}