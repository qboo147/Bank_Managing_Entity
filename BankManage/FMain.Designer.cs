namespace BankManage
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gvSTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFind
            // 
            this.pnlFind.AutoSize = true;
            this.pnlFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFind.Location = new System.Drawing.Point(286, 12);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(0, 0);
            this.pnlFind.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(268, 86);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 43);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gvSTK
            // 
            this.gvSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSTK.Location = new System.Drawing.Point(461, 14);
            this.gvSTK.Name = "gvSTK";
            this.gvSTK.RowHeadersWidth = 51;
            this.gvSTK.RowTemplate.Height = 24;
            this.gvSTK.Size = new System.Drawing.Size(435, 115);
            this.gvSTK.TabIndex = 2;
            this.gvSTK.Visible = false;
            this.gvSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSTK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập CMND/CCCD:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(90, 86);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(93, 43);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(16, 41);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilter.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(425, 22);
            this.txtFilter.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Location = new System.Drawing.Point(238, 265);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 7;
            // 
            // pnlOption
            // 
            this.pnlOption.Location = new System.Drawing.Point(16, 13);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(880, 434);
            this.pnlOption.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gvSTK);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Location = new System.Drawing.Point(11, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 142);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlOption);
            this.panel2.Location = new System.Drawing.Point(238, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 458);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.ContractToolStripMenuItem,
            this.BorrowToolStripMenuItem,
            this.CreditToolStripMenuItem,
            this.SavingToolStripMenuItem,
            this.TransHistoryToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 37);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(233, 233);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.informationToolStripMenuItem.Text = "Thông tin khách hàng";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WithdrawToolStripMenuItem,
            this.SendToolStripMenuItem,
            this.TransToolStripMenuItem});
            this.ContractToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.ContractToolStripMenuItem.Text = "Giao dịch";
            // 
            // WithdrawToolStripMenuItem
            // 
            this.WithdrawToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WithdrawToolStripMenuItem.Name = "WithdrawToolStripMenuItem";
            this.WithdrawToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.WithdrawToolStripMenuItem.Text = "Rút tiền";
            this.WithdrawToolStripMenuItem.Click += new System.EventHandler(this.WithdrawToolStripMenuItem_Click);
            // 
            // SendToolStripMenuItem
            // 
            this.SendToolStripMenuItem.Name = "SendToolStripMenuItem";
            this.SendToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.SendToolStripMenuItem.Text = "Gửi tiền";
            this.SendToolStripMenuItem.Click += new System.EventHandler(this.SendToolStripMenuItem_Click);
            // 
            // TransToolStripMenuItem
            // 
            this.TransToolStripMenuItem.Name = "TransToolStripMenuItem";
            this.TransToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.TransToolStripMenuItem.Text = "Chuyển khoản";
            this.TransToolStripMenuItem.Click += new System.EventHandler(this.TransToolStripMenuItem_Click);
            // 
            // BorrowToolStripMenuItem
            // 
            this.BorrowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem";
            this.BorrowToolStripMenuItem.Size = new System.Drawing.Size(57, 32);
            this.BorrowToolStripMenuItem.Text = "Vay";
            this.BorrowToolStripMenuItem.Click += new System.EventHandler(this.BorrowToolStripMenuItem_Click);
            // 
            // CreditToolStripMenuItem
            // 
            this.CreditToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CreditToolStripMenuItem.Name = "CreditToolStripMenuItem";
            this.CreditToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.CreditToolStripMenuItem.Text = "Tín dụng ";
            this.CreditToolStripMenuItem.Click += new System.EventHandler(this.CreditToolStripMenuItem_Click);
            // 
            // SavingToolStripMenuItem
            // 
            this.SavingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SavingToolStripMenuItem.Name = "SavingToolStripMenuItem";
            this.SavingToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.SavingToolStripMenuItem.Text = "Tài khoản tiết kiệm";
            this.SavingToolStripMenuItem.Click += new System.EventHandler(this.SavingToolStripMenuItem_Click);
            // 
            // TransHistoryToolStripMenuItem
            // 
            this.TransHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TransHistoryToolStripMenuItem.Name = "TransHistoryToolStripMenuItem";
            this.TransHistoryToolStripMenuItem.Size = new System.Drawing.Size(211, 32);
            this.TransHistoryToolStripMenuItem.Text = "Xem lịch sử giao dịch";
            this.TransHistoryToolStripMenuItem.Click += new System.EventHandler(this.TransHistoryToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(-12, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 636);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(236, -11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(939, 165);
            this.panel5.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1162, 626);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView gvSTK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WithdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransHistoryToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}