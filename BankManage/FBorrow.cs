using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class FBorrow : Form
    {
        BorrowDAO borrowDAO = new BorrowDAO();
        DBConnection dBConnection = new DBConnection();
        Customer currentCustomer;
        public FBorrow(Customer choosedCustomer)
        {
            InitializeComponent();
            this.currentCustomer = choosedCustomer;
            txtMoneyRemain.Text = currentCustomer.Money.ToString(); ;
            txtID.Text = currentCustomer.CitizenID.ToString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bool isMonthBorrow = cbTerm.Text.Contains("12");
            if (isMonthBorrow)
                dtpBack.Value = dtpAllow.Value.AddYears(1);
            else
                dtpBack.Value = dtpAllow.Value.AddMonths(8);
        }

        private void cbKyhan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbTerm.SelectedItem.ToString() == "12 thang, lai suat 10%/nam")
                dtpBack.Value = dtpAllow.Value.AddYears(1);
            else
                dtpBack.Value = dtpAllow.Value.AddMonths(8);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            Borrow newBorrow = new Borrow ()
            {
                //Money, CitizenID, Salary, Moneyborrow, Kieutindung, TaiSanTheChap, Kyhan, Ngaychovay, Ngayhoantien
                Money = Convert.ToInt32(txtMoneyRemain.Text),
                CitizenID = currentCustomer.CitizenID,
                Salary = Convert.ToInt32(txtEarnings.Text),
                MoneyBorrow = Convert.ToInt32(txtMoneyBorrow.Text),
                KieuTinDung = cbTypeOfCredit.Text,
                TaiSanTheChap = cbCollateral.Text,
                KyHan = cbTerm.Text,
                NgayChoVay = dtpAllow.Value.Date,
                NgayHoanTien = dtpBack.Value.Date,
            };
            if (Convert.ToInt32(txtMoneyBorrow.Text) > (15 * Convert.ToInt32(txtEarnings.Text)) + Convert.ToInt32(txtMoneyRemain.Text))
            {
                MessageBox.Show("Bạn không được phép vay, bởi vì quá mức giới hạn chi trả của bạn");
            }
            else
            {

                borrowDAO.Create(newBorrow);
                MessageBox.Show("Chúc mừng bạn đã vay thành công với số tiền: " + txtMoneyBorrow.Text + "\nKỳ hạn: " + cbTerm.Text + "\nVui lòng thanh toán trước " + dtpBack.Value.Date);
            }
        }

        private void cbTypeOfCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCollateral.Enabled = cbTypeOfCredit.SelectedItem.ToString() == "Vay the chap";
        } 
        private void FBorrow_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData($" WHERE CitizenID = '{currentCustomer.CitizenID}'");
                if (DateTime.Compare(DateTime.Now, dtpBack.Value.Date) < 0)
                {
                    MessageBox.Show("Hiện tại bạn đang có nợ xấu, vui lòng thanh toán.");
                    btnSubmit.Enabled = false;
                    btnCancel.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hiện tại bạn không có khoản nợ xấu nào.");
                    btnSubmit.Enabled = true;
                }
            } catch { }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEarnings.Clear();
            txtMoneyBorrow.Clear();           
        }

        private void LoadData(string condition)
        {
            try
            {
                var data = dBConnection.Load("Borrow", condition);
                if (data.Rows.Count > 0)
                {
                    txtEarnings.Text = data.Rows[0]["Salary"].ToString();
                    txtMoneyBorrow.Text = data.Rows[0]["MoneyBorrow"].ToString();
                    cbTypeOfCredit.Text = data.Rows[0]["KieuTinDung"].ToString();
                    cbCollateral.Text = data.Rows[0]["TaiSanTheChap"].ToString();
                    cbTerm.Text = data.Rows[0]["KyHan"].ToString();
                    dtpAllow.Text = data.Rows[0]["NgayChoVay"].ToString();
                    dtpBack.Text = data.Rows[0]["NgayHoanTien"].ToString();
                }
            } catch { }
        }
    }
}

