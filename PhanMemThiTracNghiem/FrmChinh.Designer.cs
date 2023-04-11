namespace PhanMemThiTracNghiem
{
    partial class FrmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíMônThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíCâuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnMônThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStartExam = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1017, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChangePass,
            this.saoLưuDữLiệuToolStripMenuItem,
            this.phụcHồiDữLiệuToolStripMenuItem,
            this.mnManageUser,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnChangePass
            // 
            this.mnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("mnChangePass.Image")));
            this.mnChangePass.Name = "mnChangePass";
            this.mnChangePass.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnChangePass.Size = new System.Drawing.Size(250, 22);
            this.mnChangePass.Text = "Thay đổi mật khẩu";
            this.mnChangePass.Click += new System.EventHandler(this.mnChangePass_Click);
            // 
            // saoLưuDữLiệuToolStripMenuItem
            // 
            this.saoLưuDữLiệuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saoLưuDữLiệuToolStripMenuItem.Image")));
            this.saoLưuDữLiệuToolStripMenuItem.Name = "saoLưuDữLiệuToolStripMenuItem";
            this.saoLưuDữLiệuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.saoLưuDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.saoLưuDữLiệuToolStripMenuItem.Text = "Sao lưu dữ liệu";
            // 
            // phụcHồiDữLiệuToolStripMenuItem
            // 
            this.phụcHồiDữLiệuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phụcHồiDữLiệuToolStripMenuItem.Image")));
            this.phụcHồiDữLiệuToolStripMenuItem.Name = "phụcHồiDữLiệuToolStripMenuItem";
            this.phụcHồiDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.phụcHồiDữLiệuToolStripMenuItem.Text = "Phục hồi dữ liệu";
            // 
            // mnManageUser
            // 
            this.mnManageUser.Image = ((System.Drawing.Image)(resources.GetObject("mnManageUser.Image")));
            this.mnManageUser.Name = "mnManageUser";
            this.mnManageUser.Size = new System.Drawing.Size(250, 22);
            this.mnManageUser.Text = "Quản lí người dùng";
            this.mnManageUser.Click += new System.EventHandler(this.quảnLíNgườiDùngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíMônThiToolStripMenuItem,
            this.quảnLíCâuHỏiToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // quảnLíMônThiToolStripMenuItem
            // 
            this.quảnLíMônThiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLíMônThiToolStripMenuItem.Image")));
            this.quảnLíMônThiToolStripMenuItem.Name = "quảnLíMônThiToolStripMenuItem";
            this.quảnLíMônThiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quảnLíMônThiToolStripMenuItem.Text = "Quản lí môn thi";
            this.quảnLíMônThiToolStripMenuItem.Click += new System.EventHandler(this.quảnLíMônThiToolStripMenuItem_Click);
            // 
            // quảnLíCâuHỏiToolStripMenuItem
            // 
            this.quảnLíCâuHỏiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLíCâuHỏiToolStripMenuItem.Image")));
            this.quảnLíCâuHỏiToolStripMenuItem.Name = "quảnLíCâuHỏiToolStripMenuItem";
            this.quảnLíCâuHỏiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quảnLíCâuHỏiToolStripMenuItem.Text = "Quản lí câu hỏi";
            this.quảnLíCâuHỏiToolStripMenuItem.Click += new System.EventHandler(this.quảnLíCâuHỏiToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnMônThiToolStripMenuItem,
            this.mnStartExam,
            this.xemDanhSáchToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng ";
            // 
            // chọnMônThiToolStripMenuItem
            // 
            this.chọnMônThiToolStripMenuItem.Name = "chọnMônThiToolStripMenuItem";
            this.chọnMônThiToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.chọnMônThiToolStripMenuItem.Text = "Thi thử";
            this.chọnMônThiToolStripMenuItem.Click += new System.EventHandler(this.chọnMônThiToolStripMenuItem_Click);
            // 
            // mnStartExam
            // 
            this.mnStartExam.Name = "mnStartExam";
            this.mnStartExam.Size = new System.Drawing.Size(268, 22);
            this.mnStartExam.Text = "Làm bài thi";
            this.mnStartExam.Click += new System.EventHandler(this.mnStartExam_Click);
            // 
            // xemDanhSáchToolStripMenuItem
            // 
            this.xemDanhSáchToolStripMenuItem.Name = "xemDanhSáchToolStripMenuItem";
            this.xemDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.xemDanhSáchToolStripMenuItem.Text = "Xem danh sách điểm cao nhất";
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "Thống kê-Báo cáo";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChinh";
            this.Text = "Hệ thống thi trắc nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnChangePass;
        private ToolStripMenuItem saoLưuDữLiệuToolStripMenuItem;
        private ToolStripMenuItem phụcHồiDữLiệuToolStripMenuItem;
        private ToolStripMenuItem mnManageUser;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem quảnLíMônThiToolStripMenuItem;
        private ToolStripMenuItem quảnLíCâuHỏiToolStripMenuItem;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem chọnMônThiToolStripMenuItem;
        private ToolStripMenuItem mnStartExam;
        private ToolStripMenuItem xemDanhSáchToolStripMenuItem;
        private ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}