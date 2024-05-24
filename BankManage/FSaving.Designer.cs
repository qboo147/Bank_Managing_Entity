namespace BankManage
{
    partial class FSaving
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoneySend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSend = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gvSaving = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSavingNumber = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaving)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(464, 217);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 43);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.Location = new System.Drawing.Point(464, 295);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(96, 43);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Tất toán";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số tiền gửi:";
            // 
            // txtMoneySend
            // 
            this.txtMoneySend.Location = new System.Drawing.Point(177, 162);
            this.txtMoneySend.Name = "txtMoneySend";
            this.txtMoneySend.Size = new System.Drawing.Size(217, 22);
            this.txtMoneySend.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kỳ hạn:";
            // 
            // cbTerm
            // 
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Items.AddRange(new object[] {
            "12 thang voi lai suat 8%/ nam",
            "36 thang voi lai suat 12%/ nam"});
            this.cbTerm.Location = new System.Drawing.Point(177, 212);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(217, 24);
            this.cbTerm.TabIndex = 7;
            this.cbTerm.SelectedIndexChanged += new System.EventHandler(this.cbTerm_SelectedIndexChanged);
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "Nhan ca tien lai va goc( tu dong so) ",
            "Nhan tien lai vao tai khoan, chuyen tien goc sang ky han moi",
            "Toan bo tien goc và tien lai sang ky han moi"});
            this.cbMethod.Location = new System.Drawing.Point(176, 262);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(217, 24);
            this.cbMethod.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phương thức đáo hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày gửi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày đáo hạn:";
            // 
            // dtpSend
            // 
            this.dtpSend.Location = new System.Drawing.Point(176, 312);
            this.dtpSend.Name = "dtpSend";
            this.dtpSend.Size = new System.Drawing.Size(217, 22);
            this.dtpSend.TabIndex = 12;
            this.dtpSend.ValueChanged += new System.EventHandler(this.dtpSend_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Location = new System.Drawing.Point(176, 362);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(217, 22);
            this.dtpEnd.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(651, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 43);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gvSaving
            // 
            this.gvSaving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSaving.Location = new System.Drawing.Point(439, 59);
            this.gvSaving.Name = "gvSaving";
            this.gvSaving.RowHeadersWidth = 51;
            this.gvSaving.RowTemplate.Height = 24;
            this.gvSaving.Size = new System.Drawing.Size(342, 122);
            this.gvSaving.TabIndex = 15;
            this.gvSaving.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSaving_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Khách hàng:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 62);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(217, 22);
            this.txtName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số tiền khả dụng:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(177, 112);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(217, 22);
            this.txtMoney.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sổ tiết kiệm số: ";
            // 
            // txtSavingNumber
            // 
            this.txtSavingNumber.Location = new System.Drawing.Point(177, 12);
            this.txtSavingNumber.Name = "txtSavingNumber";
            this.txtSavingNumber.ReadOnly = true;
            this.txtSavingNumber.Size = new System.Drawing.Size(217, 22);
            this.txtSavingNumber.TabIndex = 21;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(651, 217);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(96, 43);
            this.btnCheck.TabIndex = 22;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(803, 410);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtSavingNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvSaving);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpSend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.cbTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoneySend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnCreate);
            this.Name = "FSaving";
            this.Text = "FSaving";
            this.Load += new System.EventHandler(this.FSaving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSaving)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoneySend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpSend;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView gvSaving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSavingNumber;
        private System.Windows.Forms.Button btnCheck;
    }
}