namespace PhanMemThiTracNghiem
{
    partial class FrmManageQuestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuestionID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQcontent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.grpInfor = new System.Windows.Forms.GroupBox();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.grvData = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(299, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý câu hỏi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã câu hỏi";
            // 
            // txtQuestionID
            // 
            this.txtQuestionID.Location = new System.Drawing.Point(103, 31);
            this.txtQuestionID.Name = "txtQuestionID";
            this.txtQuestionID.Size = new System.Drawing.Size(137, 23);
            this.txtQuestionID.TabIndex = 0;
            this.txtQuestionID.TextChanged += new System.EventHandler(this.txtQuestionID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Môn thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đáp án đúng";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(103, 109);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(137, 23);
            this.txtAnswer.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nội dung câu hỏi";
            // 
            // txtQcontent
            // 
            this.txtQcontent.Location = new System.Drawing.Point(355, 31);
            this.txtQcontent.Name = "txtQcontent";
            this.txtQcontent.Size = new System.Drawing.Size(379, 23);
            this.txtQcontent.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lựa chọn A";
            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(355, 70);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(137, 23);
            this.txtOptionA.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lựa chọn B";
            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(355, 109);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(137, 23);
            this.txtOptionB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Lựa chọn C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lựa chọn D";
            // 
            // txtOptionD
            // 
            this.txtOptionD.Location = new System.Drawing.Point(597, 109);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(137, 23);
            this.txtOptionD.TabIndex = 8;
            // 
            // grpInfor
            // 
            this.grpInfor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpInfor.Controls.Add(this.cbbSubject);
            this.grpInfor.Controls.Add(this.txtOptionC);
            this.grpInfor.Controls.Add(this.txtOptionD);
            this.grpInfor.Controls.Add(this.txtOptionB);
            this.grpInfor.Controls.Add(this.txtAnswer);
            this.grpInfor.Controls.Add(this.label10);
            this.grpInfor.Controls.Add(this.label7);
            this.grpInfor.Controls.Add(this.label4);
            this.grpInfor.Controls.Add(this.label9);
            this.grpInfor.Controls.Add(this.txtOptionA);
            this.grpInfor.Controls.Add(this.label6);
            this.grpInfor.Controls.Add(this.txtQcontent);
            this.grpInfor.Controls.Add(this.label3);
            this.grpInfor.Controls.Add(this.label5);
            this.grpInfor.Controls.Add(this.txtQuestionID);
            this.grpInfor.Controls.Add(this.label2);
            this.grpInfor.Location = new System.Drawing.Point(21, 47);
            this.grpInfor.Name = "grpInfor";
            this.grpInfor.Size = new System.Drawing.Size(759, 147);
            this.grpInfor.TabIndex = 0;
            this.grpInfor.TabStop = false;
            this.grpInfor.Text = "Thông tin câu hỏi";
            // 
            // cbbSubject
            // 
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(103, 70);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(137, 23);
            this.cbbSubject.TabIndex = 9;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(597, 70);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(137, 23);
            this.txtOptionC.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.Orange;
            this.btnThem.Location = new System.Drawing.Point(263, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.Orange;
            this.btnSua.Location = new System.Drawing.Point(362, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.Orange;
            this.btnXoa.Location = new System.Drawing.Point(461, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(20, 240);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(192, 23);
            this.txtFind.TabIndex = 4;
            this.txtFind.Text = "Nhập nội dung câu hỏi";
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.Enter += new System.EventHandler(this.txtFind_Enter);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            this.txtFind.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtFind_MouseDoubleClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(231, 239);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grvData
            // 
            this.grvData.AllowUserToAddRows = false;
            this.grvData.AllowUserToResizeColumns = false;
            this.grvData.AllowUserToResizeRows = false;
            this.grvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.QuestionID,
            this.SubjectID,
            this.QContent,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.Answer});
            this.grvData.GridColor = System.Drawing.Color.White;
            this.grvData.Location = new System.Drawing.Point(12, 269);
            this.grvData.Name = "grvData";
            this.grvData.RowHeadersVisible = false;
            this.grvData.RowTemplate.Height = 25;
            this.grvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvData.Size = new System.Drawing.Size(797, 241);
            this.grvData.TabIndex = 6;
            this.grvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvData_RowEnter);
            this.grvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grvData_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 35;
            // 
            // QuestionID
            // 
            this.QuestionID.DataPropertyName = "QuestionID";
            this.QuestionID.HeaderText = "Mã câu hỏi";
            this.QuestionID.Name = "QuestionID";
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "Môn thi ";
            this.SubjectID.Name = "SubjectID";
            // 
            // QContent
            // 
            this.QContent.DataPropertyName = "QContent";
            this.QContent.HeaderText = "Nội dung câu hỏi";
            this.QContent.Name = "QContent";
            // 
            // OptionA
            // 
            this.OptionA.DataPropertyName = "OptionA";
            this.OptionA.HeaderText = "Lựa chọn A";
            this.OptionA.Name = "OptionA";
            // 
            // OptionB
            // 
            this.OptionB.DataPropertyName = "OptionB";
            this.OptionB.HeaderText = "Lựa chọn B";
            this.OptionB.Name = "OptionB";
            // 
            // OptionC
            // 
            this.OptionC.DataPropertyName = "OptionC";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "dd/MM/yyyy";
            this.OptionC.DefaultCellStyle = dataGridViewCellStyle2;
            this.OptionC.HeaderText = "Lựa chọn C";
            this.OptionC.Name = "OptionC";
            // 
            // OptionD
            // 
            this.OptionD.DataPropertyName = "OptionD";
            this.OptionD.HeaderText = "Lựa chọn D";
            this.OptionD.Name = "OptionD";
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Đáp án đúng";
            this.Answer.Name = "Answer";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnCancel.Location = new System.Drawing.Point(419, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Location = new System.Drawing.Point(320, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmManageQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 517);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grvData);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpInfor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManageQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí người dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmManageQuestion_Load);
            this.grpInfor.ResumeLayout(false);
            this.grpInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtQuestionID;
        private Label label3;
        private Label label4;
        private TextBox txtAnswer;
        private Label label5;
        private TextBox txtQcontent;
        private Label label6;
        private TextBox txtOptionA;
        private Label label7;
        private TextBox txtOptionB;
        private Label label9;
        private Label label10;
        private TextBox txtOptionD;
        private GroupBox grpInfor;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtFind;
        private Button btnFind;
        private DataGridView grvData;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cbbSubject;
        private TextBox txtOptionC;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn QuestionID;
        private DataGridViewTextBoxColumn SubjectID;
        private DataGridViewTextBoxColumn QContent;
        private DataGridViewTextBoxColumn OptionA;
        private DataGridViewTextBoxColumn OptionB;
        private DataGridViewTextBoxColumn OptionC;
        private DataGridViewTextBoxColumn OptionD;
        private DataGridViewTextBoxColumn Answer;
    }
}