using System.Windows.Forms;

namespace TestApp
{
    public partial class UCManageQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.grvData = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnFind = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.grpInfor = new System.Windows.Forms.GroupBox();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQcontent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuestionID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.grpInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(405, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(320, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvData.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grvData.Location = new System.Drawing.Point(56, 251);
            this.grvData.Name = "grvData";
            this.grvData.RowHeadersVisible = false;
            this.grvData.RowTemplate.Height = 25;
            this.grvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvData.Size = new System.Drawing.Size(683, 209);
            this.grvData.TabIndex = 16;
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
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "dd/MM/yyyy";
            this.OptionC.DefaultCellStyle = dataGridViewCellStyle5;
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
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFind.Location = new System.Drawing.Point(63, 226);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(165, 20);
            this.txtFind.TabIndex = 14;
            this.txtFind.Text = "Nhập nội dung câu hỏi";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(441, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 28);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(356, 191);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 28);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            // 
            // btnFind
            // 
            this.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Location = new System.Drawing.Point(244, 225);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(64, 20);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Tìm kiếm";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(271, 191);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 28);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
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
            this.grpInfor.Location = new System.Drawing.Point(64, 59);
            this.grpInfor.Name = "grpInfor";
            this.grpInfor.Size = new System.Drawing.Size(651, 127);
            this.grpInfor.TabIndex = 9;
            this.grpInfor.TabStop = false;
            this.grpInfor.Text = "Thông tin câu hỏi";
            // 
            // cbbSubject
            // 
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(88, 61);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(118, 21);
            this.cbbSubject.TabIndex = 9;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(512, 61);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(118, 20);
            this.txtOptionC.TabIndex = 8;
            // 
            // txtOptionD
            // 
            this.txtOptionD.Location = new System.Drawing.Point(512, 94);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(118, 20);
            this.txtOptionD.TabIndex = 8;
            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(304, 94);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(118, 20);
            this.txtOptionB.TabIndex = 7;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(88, 94);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(118, 20);
            this.txtAnswer.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lựa chọn D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lựa chọn B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đáp án đúng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Lựa chọn C";
            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(304, 61);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(118, 20);
            this.txtOptionA.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lựa chọn A";
            // 
            // txtQcontent
            // 
            this.txtQcontent.Location = new System.Drawing.Point(304, 27);
            this.txtQcontent.Name = "txtQcontent";
            this.txtQcontent.Size = new System.Drawing.Size(325, 20);
            this.txtQcontent.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Môn thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nội dung câu hỏi";
            // 
            // txtQuestionID
            // 
            this.txtQuestionID.Location = new System.Drawing.Point(88, 27);
            this.txtQuestionID.Name = "txtQuestionID";
            this.txtQuestionID.Size = new System.Drawing.Size(118, 20);
            this.txtQuestionID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã câu hỏi";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(302, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản lý câu hỏi";
            // 
            // UCQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "UCQuanLyCauHoi";
            this.Size = new System.Drawing.Size(795, 494);
            this.Load += new System.EventHandler(this.UCQuanLyCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.grpInfor.ResumeLayout(false);
            this.grpInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.DataGridViewX grvData;
        private DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.TextBox txtFind;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnFind;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.GroupBox grpInfor;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQcontent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuestionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
