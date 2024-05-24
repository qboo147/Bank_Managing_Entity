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
    public partial class FSend : Form
    {
        CustomerDAO customerDAO = new CustomerDAO();
        TransactionDAO transactionDAO = new TransactionDAO();
        Customer customer;
        public FSend(Customer choosedCustomer)
        {
            InitializeComponent();
            txtMoneyRemain.Text = choosedCustomer.Money.ToString();
            customer = choosedCustomer;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int moneyAfterSend = Convert.ToInt32(txtMoneySend.Text) + Convert.ToInt32(txtMoneyRemain.Text);
            txtMoneyRemain.Text = moneyAfterSend.ToString();
            MessageBox.Show($"Bạn đã gửi tiền thành công. Số dư còn lại của bạn {moneyAfterSend}");
            customer.Money = moneyAfterSend;

            Random random = new Random();
            string TransCode = "GT" + random.NextString(8);

            customerDAO.UpdateMoney(customer);
            Tran transaction = new Tran()
            {
                STK = customer.STK,
                MaGD = TransCode,
                LoaiGD = "Gui tien",
                Money = Convert.ToInt32(txtMoneySend.Text),
                ThoigianGD = DateTime.Now,
                ReceivedSTK = customer.STK,
            };
            transactionDAO.Create(transaction);
            txtMoneySend.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
        }
    }
}