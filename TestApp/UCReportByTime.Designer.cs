namespace TestApp
{
    partial class UCReportByTime
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
            this.rptViewByTime = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowReport = new DevComponents.DotNetBar.ButtonX();
            this.dpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dpkEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rptViewByTime
            // 
            this.rptViewByTime.ActiveViewIndex = -1;
            this.rptViewByTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptViewByTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewByTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewByTime.Location = new System.Drawing.Point(0, 39);
            this.rptViewByTime.Name = "rptViewByTime";
            this.rptViewByTime.Size = new System.Drawing.Size(800, 411);
            this.rptViewByTime.TabIndex = 0;
            this.rptViewByTime.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Từ ngày";
            // 
            // btnShowReport
            // 
            this.btnShowReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowReport.Location = new System.Drawing.Point(560, 10);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(96, 23);
            this.btnShowReport.TabIndex = 12;
            this.btnShowReport.Text = "Xem báo cáo";
            this.btnShowReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // dpkStartDate
            // 
            this.dpkStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpkStartDate.CustomFormat = "dd/MM/yyyy";
            this.dpkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkStartDate.Location = new System.Drawing.Point(196, 10);
            this.dpkStartDate.Name = "dpkStartDate";
            this.dpkStartDate.Size = new System.Drawing.Size(108, 20);
            this.dpkStartDate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đến ngày";
            // 
            // dpkEndDate
            // 
            this.dpkEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpkEndDate.CustomFormat = "dd/MM/yyyy";
            this.dpkEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkEndDate.Location = new System.Drawing.Point(407, 10);
            this.dpkEndDate.Name = "dpkEndDate";
            this.dpkEndDate.Size = new System.Drawing.Size(108, 20);
            this.dpkEndDate.TabIndex = 13;
            // 
            // FrmReportByTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dpkEndDate);
            this.Controls.Add(this.dpkStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rptViewByTime);
            this.Name = "FrmReportByTime";
            this.Text = "Báo cáo điểm thi theo thời gian";
            this.Load += new System.EventHandler(this.FrmReportBySubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewByTime;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btnShowReport;
        private System.Windows.Forms.DateTimePicker dpkStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpkEndDate;
    }
}