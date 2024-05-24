namespace BankManage
{
    partial class FTrans
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
            this.dtpSend = new System.Windows.Forms.DateTimePicker();
            this.txtMoneySend = new System.Windows.Forms.TextBox();
            this.txtMoneyRemain = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpSend
            // 
            this.dtpSend.Enabled = false;
            this.dtpSend.Location = new System.Drawing.Point(133, 216);
            this.dtpSend.Name = "dtpSend";
            this.dtpSend.Size = new System.Drawing.Size(200, 22);
            this.dtpSend.TabIndex = 29;
            // 
            // txtMoneySend
            // 
            this.txtMoneySend.Enabled = false;
            this.txtMoneySend.Location = new System.Drawing.Point(133, 116);
            this.txtMoneySend.Name = "txtMoneySend";
            this.txtMoneySend.Size = new System.Drawing.Size(200, 22);
            this.txtMoneySend.TabIndex = 28;
            // 
            // txtMoneyRemain
            // 
            this.txtMoneyRemain.Location = new System.Drawing.Point(133, 66);
            this.txtMoneyRemain.Name = "txtMoneyRemain";
            this.txtMoneyRemain.ReadOnly = true;
            this.txtMoneyRemain.Size = new System.Drawing.Size(200, 22);
            this.txtMoneyRemain.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 38);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(133, 386);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 38);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày gửi tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số tiền muốn gửi:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 17);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Số dư hiện tại:";
            // 
            // txtSTK
            // 
            this.txtSTK.Enabled = false;
            this.txtSTK.Location = new System.Drawing.Point(133, 166);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(200, 22);
            this.txtSTK.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "STK người nhận:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(133, 266);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(200, 96);
            this.txtNote.TabIndex = 34;
            this.txtNote.Text = "";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(342, 166);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(76, 22);
            this.btnCheck.TabIndex = 35;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(134, 233);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 16);
            this.lblNote.TabIndex = 36;
            this.lblNote.Visible = false;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "Phương thức thanh toán:";
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Tài khoản chính",
            "Thẻ tín dụng"});
            this.cmbMethod.Location = new System.Drawing.Point(133, 16);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(200, 24);
            this.cmbMethod.TabIndex = 38;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // FTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(428, 430);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpSend);
            this.Controls.Add(this.txtMoneySend);
            this.Controls.Add(this.txtMoneyRemain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Name = "FTrans";
            this.Text = "FTrans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSend;
        private System.Windows.Forms.TextBox txtMoneySend;
        private System.Windows.Forms.TextBox txtMoneyRemain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMethod;
    }
}