
namespace BankManage
{
    partial class FCredit
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
            this.dtpOpen = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSothe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHanmuc = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMoneyUsed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpOpen
            // 
            this.dtpOpen.Enabled = false;
            this.dtpOpen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOpen.Location = new System.Drawing.Point(148, 166);
            this.dtpOpen.Name = "dtpOpen";
            this.dtpOpen.Size = new System.Drawing.Size(200, 22);
            this.dtpOpen.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ngày mở thẻ: ";
            // 
            // txtSothe
            // 
            this.txtSothe.Location = new System.Drawing.Point(148, 16);
            this.txtSothe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSothe.Name = "txtSothe";
            this.txtSothe.ReadOnly = true;
            this.txtSothe.Size = new System.Drawing.Size(200, 22);
            this.txtSothe.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Số thẻ: ";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 39);
            this.label7.TabIndex = 64;
            this.label7.Text = "Hồ sơ chứng minh năng lực tài chính: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Hạn mức thẻ:";
            // 
            // txtHanmuc
            // 
            this.txtHanmuc.Location = new System.Drawing.Point(148, 116);
            this.txtHanmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHanmuc.Name = "txtHanmuc";
            this.txtHanmuc.Size = new System.Drawing.Size(200, 22);
            this.txtHanmuc.TabIndex = 67;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(12, 269);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 38);
            this.btnSubmit.TabIndex = 68;
            this.btnSubmit.Text = "Mở thẻ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(272, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 38);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMoneyUsed
            // 
            this.txtMoneyUsed.Location = new System.Drawing.Point(148, 66);
            this.txtMoneyUsed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoneyUsed.Name = "txtMoneyUsed";
            this.txtMoneyUsed.ReadOnly = true;
            this.txtMoneyUsed.Size = new System.Drawing.Size(200, 22);
            this.txtMoneyUsed.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Số tiền đã dùng:";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(148, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 38);
            this.btnDelete.TabIndex = 72;
            this.btnDelete.Text = "Xóa thẻ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Sao kê bảng lương",
            "Hợp đồng lao động",
            "Hợp đồng thuê tài sản"});
            this.cmbMethod.Location = new System.Drawing.Point(148, 216);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(199, 24);
            this.cmbMethod.TabIndex = 75;
            this.cmbMethod.SelectedIndexChanged += new System.EventHandler(this.cmbMethod_SelectedIndexChanged);
            // 
            // FCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(360, 338);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMoneyUsed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHanmuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSothe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpOpen);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FCredit";
            this.Text = "FCredit";
            this.Load += new System.EventHandler(this.FCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSothe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHanmuc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMoneyUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbMethod;
    }
}