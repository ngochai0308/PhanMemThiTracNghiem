
namespace Ribbon
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.btnManageQuestion = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.btnReportByTime = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar9 = new DevComponents.DotNetBar.RibbonBar();
            this.btnReportBySubject = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar11 = new DevComponents.DotNetBar.RibbonBar();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar10 = new DevComponents.DotNetBar.RibbonBar();
            this.btnManageUser = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnChangePassword = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.btnManageSubject = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem4 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem5 = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.tabContent = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabItem = new DevComponents.DotNetBar.TabItem(this.components);
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabContent)).BeginInit();
            this.tabContent.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel5);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.btnManageSubject,
            this.ribbonTabItem4,
            this.ribbonTabItem5});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(800, 98);
            // 
            // 
            // 
            this.ribbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel5.TabIndex = 5;
            this.ribbonPanel5.Visible = false;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar4);
            this.ribbonPanel2.Controls.Add(this.ribbonBar5);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(800, 98);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.DragDropSupport = true;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnManageQuestion});
            this.ribbonBar4.Location = new System.Drawing.Point(103, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 2;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnManageQuestion
            // 
            this.btnManageQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnManageQuestion.Image")));
            this.btnManageQuestion.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.btnManageQuestion.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnManageQuestion.Name = "btnManageQuestion";
            this.btnManageQuestion.SubItemsExpandWidth = 14;
            this.btnManageQuestion.Text = "Quản lí câu hỏi";
            this.btnManageQuestion.Click += new System.EventHandler(this.buttonItem6_Click);
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.DragDropSupport = true;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem5});
            this.ribbonBar5.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem5
            // 
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 14;
            this.buttonItem5.Text = "Quản lí môn thi";
            this.buttonItem5.Click += new System.EventHandler(this.buttonItem5_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.ribbonBar6);
            this.ribbonPanel4.Controls.Add(this.ribbonBar9);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(800, 98);
            // 
            // 
            // 
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar6.ContainerControlProcessDialogKey = true;
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.DragDropSupport = true;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReportByTime});
            this.ribbonBar6.Location = new System.Drawing.Point(103, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar6.TabIndex = 5;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnReportByTime
            // 
            this.btnReportByTime.Image = ((System.Drawing.Image)(resources.GetObject("btnReportByTime.Image")));
            this.btnReportByTime.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.btnReportByTime.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReportByTime.Name = "btnReportByTime";
            this.btnReportByTime.SubItemsExpandWidth = 14;
            this.btnReportByTime.Text = "Báo cáo\r\ntheo thời gian";
            this.btnReportByTime.Click += new System.EventHandler(this.buttonItem7_Click_1);
            // 
            // ribbonBar9
            // 
            this.ribbonBar9.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar9.ContainerControlProcessDialogKey = true;
            this.ribbonBar9.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar9.DragDropSupport = true;
            this.ribbonBar9.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReportBySubject});
            this.ribbonBar9.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar9.Name = "ribbonBar9";
            this.ribbonBar9.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar9.TabIndex = 4;
            // 
            // 
            // 
            this.ribbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnReportBySubject
            // 
            this.btnReportBySubject.Image = ((System.Drawing.Image)(resources.GetObject("btnReportBySubject.Image")));
            this.btnReportBySubject.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.btnReportBySubject.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReportBySubject.Name = "btnReportBySubject";
            this.btnReportBySubject.SubItemsExpandWidth = 14;
            this.btnReportBySubject.Text = "Báo cáo điểm\r\n thi theo môn";
            this.btnReportBySubject.Click += new System.EventHandler(this.buttonItem14_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar11);
            this.ribbonPanel1.Controls.Add(this.ribbonBar10);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(800, 98);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar11
            // 
            this.ribbonBar11.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar11.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar11.ContainerControlProcessDialogKey = true;
            this.ribbonBar11.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar11.DragDropSupport = true;
            this.ribbonBar11.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExit});
            this.ribbonBar11.Location = new System.Drawing.Point(403, 0);
            this.ribbonBar11.Name = "ribbonBar11";
            this.ribbonBar11.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar11.TabIndex = 4;
            this.ribbonBar11.Text = "..";
            // 
            // 
            // 
            this.ribbonBar11.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar11.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.btnExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExit.Name = "btnExit";
            this.btnExit.SubItemsExpandWidth = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ribbonBar10
            // 
            this.ribbonBar10.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar10.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar10.ContainerControlProcessDialogKey = true;
            this.ribbonBar10.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar10.DragDropSupport = true;
            this.ribbonBar10.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnManageUser});
            this.ribbonBar10.Location = new System.Drawing.Point(303, 0);
            this.ribbonBar10.Name = "ribbonBar10";
            this.ribbonBar10.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar10.TabIndex = 3;
            this.ribbonBar10.Text = "..";
            // 
            // 
            // 
            this.ribbonBar10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar10.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnManageUser
            // 
            this.btnManageUser.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUser.Image")));
            this.btnManageUser.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.btnManageUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.SubItemsExpandWidth = 14;
            this.btnManageUser.Text = "Quản lý \r\nngười dùng";
            this.btnManageUser.Click += new System.EventHandler(this.buttonItem21_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem4});
            this.ribbonBar3.Location = new System.Drawing.Point(203, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 2;
            this.ribbonBar3.Text = "..";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem4
            // 
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 14;
            this.buttonItem4.Text = "Phục hồi dữ liệu";
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem3});
            this.ribbonBar2.Location = new System.Drawing.Point(103, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "..";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem3
            // 
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 14;
            this.buttonItem3.Text = "Sao lưu dữ liệu";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnChangePassword});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "..";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.btnChangePassword.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.SubItemsExpandWidth = 14;
            this.btnChangePassword.Text = "Thay đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Hệ Thống";
            // 
            // btnManageSubject
            // 
            this.btnManageSubject.Name = "btnManageSubject";
            this.btnManageSubject.Panel = this.ribbonPanel2;
            this.btnManageSubject.Text = "Danh Mục";
            // 
            // ribbonTabItem4
            // 
            this.ribbonTabItem4.Name = "ribbonTabItem4";
            this.ribbonTabItem4.Panel = this.ribbonPanel4;
            this.ribbonTabItem4.Text = "Báo Cáo-Thống Kê";
            // 
            // ribbonTabItem5
            // 
            this.ribbonTabItem5.Name = "ribbonTabItem5";
            this.ribbonTabItem5.Panel = this.ribbonPanel5;
            this.ribbonTabItem5.Text = "Trợ Giúp";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // tabContent
            // 
            this.tabContent.CanReorderTabs = true;
            this.tabContent.CloseButtonOnTabsAlwaysDisplayed = false;
            this.tabContent.CloseButtonOnTabsVisible = true;
            this.tabContent.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabContent.Controls.Add(this.tabControlPanel1);
            this.tabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContent.Location = new System.Drawing.Point(0, 154);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabContent.SelectedTabIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(800, 296);
            this.tabContent.TabIndex = 1;
            this.tabContent.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabContent.Tabs.Add(this.tabItem);
            this.tabContent.Text = "tabControl1";
            this.tabContent.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabContent_TabItemClose);
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.pictureBox1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(800, 270);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabItem
            // 
            this.tabItem.AttachedControl = this.tabControlPanel1;
            this.tabItem.Name = "tabItem";
            this.tabItem.Text = "Giới thiệu";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem10.Image")));
            this.buttonItem10.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.SubItemsExpandWidth = 14;
            this.buttonItem10.Text = "Ngày tiếp theo";
            // 
            // buttonItem11
            // 
            this.buttonItem11.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem11.Image")));
            this.buttonItem11.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.SubItemsExpandWidth = 14;
            this.buttonItem11.Text = "Ngày tiếp theo";
            // 
            // buttonItem12
            // 
            this.buttonItem12.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem12.Image")));
            this.buttonItem12.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.SubItemsExpandWidth = 14;
            this.buttonItem12.Text = "Ngày tiếp theo";
            // 
            // buttonItem13
            // 
            this.buttonItem13.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem13.Image")));
            this.buttonItem13.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem13.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.SubItemsExpandWidth = 14;
            this.buttonItem13.Text = "Ngày tiếp theo";
            // 
            // buttonItem15
            // 
            this.buttonItem15.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem15.Image")));
            this.buttonItem15.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem15.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.SubItemsExpandWidth = 14;
            this.buttonItem15.Text = "Thay đổi mật khẩu";
            // 
            // buttonItem16
            // 
            this.buttonItem16.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem16.Image")));
            this.buttonItem16.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem16.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.SubItemsExpandWidth = 14;
            this.buttonItem16.Text = "Sao lưu dữ liệu";
            // 
            // buttonItem17
            // 
            this.buttonItem17.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem17.Image")));
            this.buttonItem17.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem17.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem17.Name = "buttonItem17";
            this.buttonItem17.SubItemsExpandWidth = 14;
            this.buttonItem17.Text = "Thay đổi mật khẩu";
            // 
            // buttonItem18
            // 
            this.buttonItem18.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem18.Image")));
            this.buttonItem18.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem18.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem18.Name = "buttonItem18";
            this.buttonItem18.SubItemsExpandWidth = 14;
            this.buttonItem18.Text = "Sao lưu dữ liệu";
            // 
            // buttonItem19
            // 
            this.buttonItem19.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem19.Image")));
            this.buttonItem19.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem19.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem19.Name = "buttonItem19";
            this.buttonItem19.SubItemsExpandWidth = 14;
            this.buttonItem19.Text = "Thay đổi mật khẩu";
            // 
            // buttonItem20
            // 
            this.buttonItem20.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem20.Image")));
            this.buttonItem20.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem20.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem20.Name = "buttonItem20";
            this.buttonItem20.SubItemsExpandWidth = 14;
            this.buttonItem20.Text = "Sao lưu dữ liệu";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabContent);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Phần mềm thi trắc nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabContent)).EndInit();
            this.tabContent.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem btnManageSubject;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem btnChangePassword;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem4;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnManageQuestion;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.TabControl tabContent;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar9;
        private DevComponents.DotNetBar.ButtonItem btnReportBySubject;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private DevComponents.DotNetBar.ButtonItem buttonItem11;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private DevComponents.DotNetBar.ButtonItem buttonItem13;
        private DevComponents.DotNetBar.RibbonBar ribbonBar11;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.RibbonBar ribbonBar10;
        private DevComponents.DotNetBar.ButtonItem btnManageUser;
        private DevComponents.DotNetBar.ButtonItem buttonItem15;
        private DevComponents.DotNetBar.ButtonItem buttonItem16;
        private DevComponents.DotNetBar.ButtonItem buttonItem17;
        private DevComponents.DotNetBar.ButtonItem buttonItem18;
        private DevComponents.DotNetBar.ButtonItem buttonItem19;
        private DevComponents.DotNetBar.ButtonItem buttonItem20;
        private DevComponents.DotNetBar.RibbonBar ribbonBar6;
        private DevComponents.DotNetBar.ButtonItem btnReportByTime;
    }
}