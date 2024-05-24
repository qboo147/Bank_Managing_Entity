using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankManage
{
    public partial class FCredit : Form
    {
        Customer customer;
        DBConnection DbConnection = new DBConnection();
        CreditDAO creditDAO = new CreditDAO();
        Credit credit;
        
        public FCredit(Customer choosedCustomer)
        {
            InitializeComponent();
            customer = choosedCustomer;
        }

        private void FCredit_Load(object sender, EventArgs e)
        {
            credit = new Credit()
            {
                STK = customer.STK,
            };
            credit = creditDAO.Get(credit);

            txtSothe.Text = credit.MaThe;
            txtHanmuc.Text = credit.HanMuc.ToString();
            txtMoneyUsed.Text = credit.UsedMoney.ToString();

            if (DateTime.Now >= credit.NgayDaoHan)
            {
                CustomerDAO customerDAO = new CustomerDAO();
                customer.Money = customer.Money - credit.UsedMoney;

                if (customer.Money < 50000 )
                {
                    MessageBox.Show("Số tiền trong tài khoản gốc không đủ để trả thế chấp. Bạn sẽ bị khóa thẻ");
                    btnDelete.Enabled = false;
                    btnSubmit.Enabled = false;
                }
                else
                {
                    customerDAO.UpdateMoney(customer);
                }
            }

            if (credit.UsedMoney > credit.HanMuc)
            {
                MessageBox.Show("Bạn đã xài quá hạn mức. Vui lòng gửi tiền vào thẻ để tiếp tục sử dụng");
            }
            else
            {
                if (txtSothe.Text == "")
                {
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnSubmit.Enabled = false;
                }
            }            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string MaThe = random.NextString(10);

            if (txtHanmuc.Text == "")
            {
                MessageBox.Show("Vui long nhap han muc the");
            }
            else
            {
                Credit credit = new Credit()
                {
                    STK = customer.STK,
                    MaThe = MaThe,
                    HanMuc = Convert.ToInt32(txtHanmuc.Text),
                    UsedMoney = 0,
                    Method = cmbMethod.Text,
                    NgayMo = DateTime.Now,
                    NgayDaoHan = DateTime.Now.AddMonths(1)
                };
                creditDAO.Create(credit);

                MessageBox.Show("Chúc mừng bạn đã mở thẻ tín dụng thành công:\nSố thẻ: " + MaThe + "\nHạn mức cho phép:" + txtHanmuc.Text + "\nVui lòng thanh toán dư nợ vào ngày " + DateTime.Now.Day + " của tháng tiếp theo, nếu phát sinh giao dịch");
            }
            FCredit_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit()
            {
                STK = customer.STK,
                MaThe = txtSothe.Text
            };
            creditDAO.Delete(credit);
            FCredit_Load(sender, e);
            btnDelete.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInformation();
            btnDelete.Enabled = false;
        }
        private void ClearInformation()
        {
            txtHanmuc.Clear();
            txtMoneyUsed.Clear();
            txtSothe.Clear();
            cmbMethod.Text = "";
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMethod.Text != "")
            {
                btnSubmit.Enabled = true;
            }
        }
    }
}