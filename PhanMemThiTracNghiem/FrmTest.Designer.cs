namespace PhanMemThiTracNghiem
{
    partial class FrmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumberofQuestion = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.btnFistQuestion = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLastQuestion = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemainTime = new System.Windows.Forms.TextBox();
            this.lvQuestion = new System.Windows.Forms.ListBox();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtNumberofQuestion);
            this.groupBox1.Controls.Add(this.txtSubjectName);
            this.groupBox1.Controls.Add(this.txtBirthday);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(163, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thí sinh-môn thi";
            // 
            // txtNumberofQuestion
            // 
            this.txtNumberofQuestion.BackColor = System.Drawing.Color.White;
            this.txtNumberofQuestion.Location = new System.Drawing.Point(618, 29);
            this.txtNumberofQuestion.Multiline = true;
            this.txtNumberofQuestion.Name = "txtNumberofQuestion";
            this.txtNumberofQuestion.ReadOnly = true;
            this.txtNumberofQuestion.Size = new System.Drawing.Size(100, 23);
            this.txtNumberofQuestion.TabIndex = 4;
            this.txtNumberofQuestion.TabStop = false;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.White;
            this.txtSubjectName.Location = new System.Drawing.Point(410, 29);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.ReadOnly = true;
            this.txtSubjectName.Size = new System.Drawing.Size(100, 23);
            this.txtSubjectName.TabIndex = 2;
            this.txtSubjectName.TabStop = false;
            // 
            // txtBirthday
            // 
            this.txtBirthday.BackColor = System.Drawing.Color.White;
            this.txtBirthday.Location = new System.Drawing.Point(249, 29);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.ReadOnly = true;
            this.txtBirthday.Size = new System.Drawing.Size(100, 23);
            this.txtBirthday.TabIndex = 1;
            this.txtBirthday.TabStop = false;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(85, 29);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(100, 23);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng câu hỏi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Môn thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbQuestion.Location = new System.Drawing.Point(163, 97);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(93, 21);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Câu hỏi 1:";
            // 
            // rtxtContent
            // 
            this.rtxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtContent.Location = new System.Drawing.Point(163, 124);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.ReadOnly = true;
            this.rtxtContent.Size = new System.Drawing.Size(850, 120);
            this.rtxtContent.TabIndex = 0;
            this.rtxtContent.Text = "Đâu là ngôn ngữ lập trình hướng đối tượng?";
            // 
            // rdoA
            // 
            this.rdoA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoA.AutoSize = true;
            this.rdoA.Location = new System.Drawing.Point(163, 273);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(90, 19);
            this.rdoA.TabIndex = 1;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "Ngôn ngữ C";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoB.AutoSize = true;
            this.rdoB.Location = new System.Drawing.Point(163, 316);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(115, 19);
            this.rdoB.TabIndex = 2;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "Ngôn ngữ Pascal";
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoC
            // 
            this.rdoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoC.AutoSize = true;
            this.rdoC.Location = new System.Drawing.Point(163, 359);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(103, 19);
            this.rdoC.TabIndex = 3;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "Ngôn ngữ java";
            this.rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoD
            // 
            this.rdoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(163, 403);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(106, 19);
            this.rdoD.TabIndex = 4;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "Ngôn ngữ C++";
            this.rdoD.UseVisualStyleBackColor = true;
            // 
            // btnFistQuestion
            // 
            this.btnFistQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFistQuestion.Location = new System.Drawing.Point(299, 436);
            this.btnFistQuestion.Name = "btnFistQuestion";
            this.btnFistQuestion.Size = new System.Drawing.Size(96, 34);
            this.btnFistQuestion.TabIndex = 7;
            this.btnFistQuestion.Text = "<<Câu đầu";
            this.btnFistQuestion.UseVisualStyleBackColor = true;
            this.btnFistQuestion.Click += new System.EventHandler(this.btnFistQuestion_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrev.Location = new System.Drawing.Point(426, 436);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(96, 34);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "<Câu trước";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(550, 436);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 34);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Câu sau>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLastQuestion
            // 
            this.btnLastQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLastQuestion.Location = new System.Drawing.Point(679, 436);
            this.btnLastQuestion.Name = "btnLastQuestion";
            this.btnLastQuestion.Size = new System.Drawing.Size(96, 34);
            this.btnLastQuestion.TabIndex = 10;
            this.btnLastQuestion.Text = "Câu cuối>>";
            this.btnLastQuestion.UseVisualStyleBackColor = true;
            this.btnLastQuestion.Click += new System.EventHandler(this.btnLastQuestion_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinish.Location = new System.Drawing.Point(887, 436);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(96, 34);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "Nộp bài";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(924, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thời gian còn lại";
            // 
            // txtRemainTime
            // 
            this.txtRemainTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRemainTime.BackColor = System.Drawing.Color.White;
            this.txtRemainTime.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemainTime.ForeColor = System.Drawing.Color.Red;
            this.txtRemainTime.Location = new System.Drawing.Point(913, 30);
            this.txtRemainTime.Multiline = true;
            this.txtRemainTime.Name = "txtRemainTime";
            this.txtRemainTime.ReadOnly = true;
            this.txtRemainTime.Size = new System.Drawing.Size(100, 40);
            this.txtRemainTime.TabIndex = 6;
            this.txtRemainTime.Text = "10:00";
            // 
            // lvQuestion
            // 
            this.lvQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvQuestion.FormattingEnabled = true;
            this.lvQuestion.ItemHeight = 15;
            this.lvQuestion.Location = new System.Drawing.Point(12, 24);
            this.lvQuestion.Name = "lvQuestion";
            this.lvQuestion.Size = new System.Drawing.Size(120, 454);
            this.lvQuestion.TabIndex = 10;
            this.lvQuestion.SelectedIndexChanged += new System.EventHandler(this.lvQuestion_SelectedIndexChanged);
            // 
            // timerTest
            // 
            this.timerTest.Enabled = true;
            this.timerTest.Interval = 1000;
            this.timerTest.Tick += new System.EventHandler(this.timeTest_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 492);
            this.Controls.Add(this.lvQuestion);
            this.Controls.Add(this.txtRemainTime);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnLastQuestion);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFistQuestion);
            this.Controls.Add(this.rdoD);
            this.Controls.Add(this.rdoC);
            this.Controls.Add(this.rdoB);
            this.Controls.Add(this.rdoA);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm bài thi trắc nghiệm";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNumberofQuestion;
        private TextBox txtSubjectName;
        private TextBox txtBirthday;
        private TextBox txtFullName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbQuestion;
        private RichTextBox rtxtContent;
        private RadioButton rdoA;
        private RadioButton rdoB;
        private RadioButton rdoC;
        private RadioButton rdoD;
        private Button btnFistQuestion;
        private Button btnPrev;
        private Button btnNext;
        private Button btnLastQuestion;
        private Button btnFinish;
        private Label label6;
        private TextBox txtRemainTime;
        private ListBox lvQuestion;
		private System.Windows.Forms.Timer timerTest;
		private System.Windows.Forms.Timer timer1;
	}
}
