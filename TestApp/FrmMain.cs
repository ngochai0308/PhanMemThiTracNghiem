using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp;

namespace Ribbon
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void AddNewTab(string strTabName, UserControl ucContent)
        {
            //-----------If exist tabpage then exit---------------
            foreach (TabItem tabPage in tabContent.Tabs)
                if (tabPage.Text == strTabName)
                {
                    tabContent.SelectedTab = tabPage;
                    return;
                }
            TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newTabPage = new TabItem(this.components);
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel" + strTabName;
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1230, 384);
            newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 2;
            newTabPanel.TabItem = newTabPage;
            //-------------New  tab page---------------------
            Random ran = new Random();
            newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22342);
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPanel.Controls.Add(ucContent);
            //------------add Tab page to Tab control-------------
            tabContent.Controls.Add(newTabPanel);
            tabContent.Tabs.Add(newTabPage);
            tabContent.SelectedTab = newTabPage;
        }
        private void tabContent_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            tabContent.Tabs.Remove(tabContent.SelectedTab);
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            UCManageSubject ucManageSubject = new UCManageSubject();
            AddNewTab("Quản lí môn thi", ucManageSubject);
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            UCManageQuestion ucManageQuestion = new UCManageQuestion();
            AddNewTab("Quản lí câu hỏi", ucManageQuestion);
        }


        private void buttonItem14_Click(object sender, EventArgs e)
        {
            UCReportBySubject ucReportBySubject= new UCReportBySubject();
            AddNewTab("Báo cáo bài thi theo môn", ucReportBySubject);
            
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.ShowDialog();
        }


        private void buttonItem21_Click(object sender, EventArgs e)
        {
            UCManageUser ucManageUser = new UCManageUser();
            AddNewTab("Quản lí người dùng", ucManageUser);
        }

        private void buttonItem7_Click_1(object sender, EventArgs e)
        {
            UCReportByTime ucReportByTime = new UCReportByTime();
            AddNewTab("Báo cáo bài thi theo thời gian", ucReportByTime);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
