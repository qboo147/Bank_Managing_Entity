using System;
using System.CodeDom.Compiler;
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
    public partial class FTrans : Form
    {
        TransactionDAO transactionDAO = new TransactionDAO();
        CustomerDAO customerDAO = new CustomerDAO();
        Customer customerSend, customerReceive;
        CreditDAO creditDAO = new CreditDAO();
        Credit creditSend;
        DataTable datatable;

        public FTrans(Customer choosedCustomer, DataTable table)
        {
            InitializeComponent();
            txtMoneyRemain.Text = choosedCustomer.Money.ToString();
            customerSend = choosedCustomer;
            datatable = table;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSTK.Text != "")
            {
                btnCheck.Enabled = true;
            }

            if (txtMoneySend.Text != "" && txtSTK.Text != "")
            {
                if (cmbMethod.SelectedIndex == 0)
                {
                    int remainMoneyAfterWithDraw = Convert.ToInt32(txtMoneyRemain.Text) - Convert.ToInt32(txtMoneySend.Text);

                    if (remainMoneyAfterWithDraw < 0)
                    {
                        MessageBox.Show("Số dư tài khoản không đủ để chuyển khoản");
                    }
                    else if (remainMoneyAfterWithDraw < 50000)
                    {
                        MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000");
                    }
                    else
                    {
                        txtMoneyRemain.Text = remainMoneyAfterWithDraw.ToString();
                        MessageBox.Show($"Bạn đã chuyển khoản cho tài khoản {txtSTK.Text} thành công. Số dư còn lại của bạn {remainMoneyAfterWithDraw}");

                        customerSend.Money = Convert.ToInt32(txtMoneyRemain.Text);
                        customerDAO.UpdateMoney(customerSend);

                        for (int i = 0; i < datatable.Rows.Count - 1; i++)
                        {
                            string STK = datatable.Rows[i][0].ToString();
                            if (txtSTK.Text == STK)
                            {
                                customerReceive = CreateCustomer(STK, Convert.ToInt32(datatable.Rows[i][6].ToString()));
                            }
                        }
                        customerReceive.Money = Convert.ToInt32(customerReceive.Money + Convert.ToInt32(txtMoneySend.Text));
                        customerDAO.UpdateMoney(customerReceive);

                        Random random = new Random();
                        string TransCode = "CK" + random.NextString(8);
                        
                        Tran transactionSend = CreateTrans(customerSend.STK, TransCode, "Chuyen khoan", Convert.ToInt32(txtMoneySend.Text), customerReceive.STK, txtNote.Text);
                        Tran transactionReceive = CreateTrans(customerReceive.STK, TransCode, "Nhan tien Chuyen khoan", Convert.ToInt32(txtMoneySend.Text), customerSend.STK, txtNote.Text);

                        transactionDAO.Create(transactionSend);
                        transactionDAO.Create(transactionReceive);
                    }
                }
                else
                {
                    int remainMoneyAfterWithDraw = Convert.ToInt32(txtMoneyRemain.Text) + Convert.ToInt32(txtMoneySend.Text);

                    if (remainMoneyAfterWithDraw > creditSend.HanMuc)
                    {
                        MessageBox.Show("Bạn đã xài thẻ tín dụng quá hạn mức");
                    }
                    else
                    {
                        txtMoneyRemain.Text = remainMoneyAfterWithDraw.ToString();
                        MessageBox.Show($"Bạn đã chuyển khoản cho tài khoản {txtSTK.Text} thành công. Số tiền trong thẻ tín dụng đã xài của bạn {remainMoneyAfterWithDraw}");

                        creditSend.UsedMoney = Convert.ToInt32(txtMoneyRemain.Text);
                        creditDAO.Update(creditSend);

                        for (int i = 0; i < datatable.Rows.Count - 1; i++)
                        {
                            string STK = datatable.Rows[i][0].ToString();
                            if (txtSTK.Text == STK)
                            {
                                customerReceive = CreateCustomer(STK, Convert.ToInt32(datatable.Rows[i][6].ToString()));

                            }
                        }
                        customerReceive.Money = Convert.ToInt32(customerReceive.Money + Convert.ToInt32(txtMoneySend.Text));
                        customerDAO.UpdateMoney(customerReceive);

                        Random random = new Random();
                        string TransCode = "TD" + random.NextString(8);

                        Tran transactionSend = CreateTrans(customerSend.STK, TransCode, "Chuyen khoan Tin dung", Convert.ToInt32(txtMoneySend.Text), customerReceive.STK, txtNote.Text);
                        Tran transactionReceive = CreateTrans(customerReceive.STK, TransCode, "Nhan tien Chuyen khoan", Convert.ToInt32(txtMoneySend.Text), customerSend.STK, txtNote.Text);

                        transactionDAO.Create(transactionSend);
                        transactionDAO.Create(transactionReceive);
                    }
                }
                txtMoneySend.Clear();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                btnOK.Enabled = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblNote.Visible = true;
            bool flag = false;

            if (txtSTK.Text == customerSend.STK)
            {
                lblNote.Text = "Người nhận không hợp lệ";
                btnOK.Enabled = false;
            }
            else
            {
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    string STK = datatable.Rows[i][0].ToString();
                    if (txtSTK.Text == STK)
                    {
                        lblNote.Text = datatable.Rows[i][1].ToString();
                        btnOK.Enabled = true;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    lblNote.Text = "Số tài khoản không tồn tại";
                    btnOK.Enabled = false;
                }
            }
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex == 0)
            {
                txtMoneyRemain.Text = customerSend.Money.ToString();
                lblName.Text = "Số dư hiện tại:";
            }
            else if (cmbMethod.SelectedIndex == 1)
            {
                creditSend = new Credit()
                {
                    STK = customerSend.STK,
                };
                creditSend = creditDAO.Get(creditSend);

                if (creditSend.HanMuc == 0)
                {
                    MessageBox.Show("Chua co the tin dung");
                    txtMoneySend.Enabled = false;
                    txtSTK.Enabled = false;
                }
                else
                {
                    txtMoneyRemain.Text = creditSend.UsedMoney.ToString();
                    lblName.Text = "Số tiền đã dùng:";
                }
            }
            txtMoneySend.Enabled = true;
            txtSTK.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
            txtNote.Clear();
            txtSTK.Clear();
            lblNote.Text = "";
        }

        private Customer CreateCustomer(string STK, int Money)
        {
            return new Customer()
            {
                STK = STK,
                CreateAt = DateTime.Now,
                Money = Money
            };
        }

        private Tran CreateTrans(string STK, string MaGD, string LoaiGD, int Money, string ReceivedSTK, string Note)
        {
            return new Tran()
            {
                STK = STK,
                MaGD = MaGD,
                LoaiGD = LoaiGD,
                Money = Money,
                ThoigianGD = DateTime.Now,
                ReceivedSTK = ReceivedSTK,
                Note = Note
            };
        }
    }
}