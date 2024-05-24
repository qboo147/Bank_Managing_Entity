using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        public bool IsLoggedIn { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin_name.Text == "user" && txtPass.Text == "user")
            {
                Close();
                IsLoggedIn = true;
            }
            else
                MessageBox.Show("Tài khoản không hợp lệ");
        }
    }
}
