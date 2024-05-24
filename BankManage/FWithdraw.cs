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
using System.Xml.Linq;

namespace BankManage
{
    public partial class FWithdraw : Form
    {
        CustomerDAO customerDAO = new CustomerDAO();
        TransactionDAO transactionDAO = new TransactionDAO();
        Customer customer;
        public FWithdraw(Customer choosedCustomer)
        {
            InitializeComponent();
            txtMoneyRemain.Text = choosedCustomer.Money.ToString();
            customer = choosedCustomer;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int remainMoneyAfterWithDraw = Convert.ToInt32(txtMoneyRemain.Text) - Convert.ToInt32(txtMoneySend.Text);

            if (remainMoneyAfterWithDraw < 0)
            {
                MessageBox.Show("Số dư tài khoản không đủ để rút tiền");
            }
            else if (remainMoneyAfterWithDraw < 50000)
            {
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000");
            }
            else
            {
                txtMoneyRemain.Text = remainMoneyAfterWithDraw.ToString();
                MessageBox.Show($"Bạn đã rút tiền thành công. Số dư còn lại của bạn {remainMoneyAfterWithDraw}");
                customer.Money = remainMoneyAfterWithDraw;

                Random random = new Random();
                string TransCode = "RT" + random.NextString(8);

                customerDAO.UpdateMoney(customer);
                Tran transaction = new Tran()
                {
                    STK = customer.STK,
                    MaGD = TransCode,
                    LoaiGD = "Rut tien",
                    Money = Convert.ToInt32(txtMoneySend.Text),
                    ThoigianGD = DateTime.Now,
                    ReceivedSTK = customer.STK,
                };
                transactionDAO.Create(transaction);
                txtMoneySend.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
        }
    }
}
