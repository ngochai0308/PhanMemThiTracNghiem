using Entities;
using System.Data.SqlClient;
using BusinessLogicLayer;
using PhanMemThiTracNghiem.common;

namespace PhanMemThiTracNghiem
{
    
    public partial class FrmDangNhap : Form
    {
        public bool isLoginSucces = false;


        public FrmDangNhap()
        {
            InitializeComponent();
        }
         
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
        private bool isValidUser(UserAccout user)
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
            return true;
        }
        private void btnMatKhau_Click(object sender, EventArgs e)
        {
            UserAccout eUser = new UserAccout()
            {
                UserName = txtTaiKhoan.Text.Trim(),
                PassWord = txtMatKhau.Text.Trim()
            };
          //Kiem tra thong tin hop le chua
            if(!isValidUser(eUser))
            {
                return;
            }
            //Kiem tra tai khoan dang nhap
            if (BUserAccout.IsExistsAccout(eUser))
            {
               // MessageBox.Show("Dang nhap thanh cong");

                isLoginSucces = true;
                Session.LogonUser = BUserAccout.GetUserInfor(eUser.UserName);
                this.Close();
            }
            else
            {

                MessageBox.Show("tai khoan/mat khau khong dung\n Vui long nhap lai","Thông Báo");
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}