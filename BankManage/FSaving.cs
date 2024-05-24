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
    public partial class FSaving : Form
    {
        SavingDAO savingDAO = new SavingDAO();
        CustomerDAO customerDAO = new CustomerDAO();
        DBConnection dBConnection = new DBConnection();
        Customer currentCustomer;
        int loans;
        int laisuat;
        

        public FSaving(Customer choosedCustomer)
        {
            InitializeComponent();
            this.currentCustomer = choosedCustomer;
            txtName.Text = currentCustomer.Name;
            txtMoney.Text = currentCustomer.Money.ToString();
        }

        private void FSaving_Load(object sender, EventArgs e)
        {
            LoadCustomerData($" WHERE STK = '{currentCustomer.STK}'");
        }
        private void LoadCustomerData(string condition)
        {
            gvSaving.DataSource = dBConnection.Load("Saving", condition);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string randomMaSo = RandomMaSo();
            Saving newSaving = new Saving()
            {
                //STK, MaSo, Money, KyHan, PhuongThucDaoHan, NgayGui, NgayDaoHan
                STK = currentCustomer.STK,
                MaSo = randomMaSo,
                Money = Convert.ToInt32(txtMoneySend.Text),
                KyHan = cbTerm.Text,
                PhuongThucDaoHan = cbMethod.Text,
                NgayGui = dtpSend.Value.Date,
                NgayDaoHan = dtpEnd.Value.Date,
                
            };
            int remainMoneyAfterSaving = Convert.ToInt32(currentCustomer.Money) - Convert.ToInt32(txtMoneySend.Text);
            if (remainMoneyAfterSaving < 0)
            {
                MessageBox.Show("Số dư tài khoản không đủ để tạo sổ tiết kiệm, vui lòng nạp thêm tiền.");
            }
            else if (remainMoneyAfterSaving < 50000)
            {
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000, vui lòng nạp thêm tiền.");
            }
            else
            {
                currentCustomer.Money = remainMoneyAfterSaving;
                txtMoneySend.Clear();
                customerDAO.UpdateMoney(currentCustomer);
                savingDAO.Create(newSaving);
                MessageBox.Show($"Bạn đã tạo thành công sổ tiết kiệm số: " + txtSavingNumber.Text + "\nKỳ hạn: " + cbTerm.Text + "\nNgày đáo hạn: " + dtpEnd.Value.Date + " (" + cbMethod.Text +")");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Saving withdrawSaving = new Saving()
            {
                MaSo = txtSavingNumber.Text,

            };
            savingDAO.Delete(withdrawSaving);
            LoadCustomerData($" WHERE MaSo = '{txtSavingNumber.Text}'");
            MessageBox.Show("Lưu ý: Rút tiền sẽ bị mất phí 5%");
            currentCustomer.Money = currentCustomer.Money + (Convert.ToInt32(txtMoneySend.Text) * 95 / 100);
            ClearInfomation();
            customerDAO.UpdateMoney(currentCustomer);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInfomation();
        }

        private void gvSaving_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;
            txtSavingNumber.Text = gvSaving.Rows[numRow].Cells["MaSo"].Value.ToString();
            txtName.Text = currentCustomer.Name;
            txtMoney.Text = currentCustomer.Money.ToString();
            txtMoneySend.Text = gvSaving.Rows[numRow].Cells["Money"].Value.ToString();
            cbTerm.Text = gvSaving.Rows[numRow].Cells["KyHan"].Value.ToString();
            cbMethod.Text = gvSaving.Rows[numRow].Cells["PhuongThucDaoHan"].Value.ToString();
            dtpSend.Text = gvSaving.Rows[numRow].Cells["NgayGui"].Value.ToString();
            dtpEnd.Text = gvSaving.Rows[numRow].Cells["NgayDaoHan"].Value.ToString();
            btnWithdraw.Enabled = true;
            btnCheck.Enabled = true;
            if (cbMethod.Text.Contains("Nhan ca tien lai va goc( tu dong so) ")) {
                if (dtpEnd.Value.Date == DateTime.Now.Date)
                {
                    currentCustomer.Money = currentCustomer.Money + Convert.ToInt32(txtMoneySend.Text) + loans;
                    customerDAO.UpdateMoney(currentCustomer);
                    Saving withdrawSaving = new Saving()
                    {
                        MaSo = txtSavingNumber.Text,

                    };
                    savingDAO.Delete(withdrawSaving);
                    LoadCustomerData($" WHERE MaSo = '{txtSavingNumber.Text}'");
                    MessageBox.Show("DA XOA SO THANH CONG, TIEN LAI VA GOC DA DUOC NHAN TRONG TAI KHOAN");
                }
            }
        }
        
        private void cbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbTerm.SelectedItem.ToString() == "12 thang voi lai suat 8%/ nam")
                dtpEnd.Value = dtpSend.Value.AddYears(1);
            else
                dtpEnd.Value = dtpSend.Value.AddYears(3);
        }

        private void dtpSend_ValueChanged(object sender, EventArgs e)
        {
            bool isMonthBorrow = cbTerm.Text.Contains("12");
            if (isMonthBorrow)
                dtpEnd.Value = dtpSend.Value.AddYears(1);
            else
                dtpEnd.Value = dtpSend.Value.AddYears(3);
        }

        private void ClearInfomation()
        {
            txtSavingNumber.Clear();
            txtMoneySend.Clear();
        }
        private string RandomMaSo()
        {
            Random random = new Random();
            return random.NextString(10);
        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            TimeSpan Time = DateTime.Now - dtpSend.Value.Date;           
            int TongSoNgay = Time.Days;
            if (cbTerm.Text.Contains("8"))
                laisuat = 8;
            else
                laisuat = 12;
            loans = (Convert.ToInt32(txtMoneySend.Text) * laisuat / 100) * TongSoNgay / 365;
            if (dtpEnd.Value.Date == DateTime.Now.Date)
            {
                if (cbMethod.Text.Contains( "Nhan tien lai vao tai khoan, chuyen tien goc sang ky han moi"))
                {
                    currentCustomer.Money = currentCustomer.Money + loans;
                    customerDAO.UpdateMoney(currentCustomer);
                    string randomMaSo = RandomMaSo();
                    Saving newSaving = new Saving()
                    {
                        
                        STK = currentCustomer.STK,
                        MaSo = randomMaSo,
                        Money = Convert.ToInt32(txtMoneySend.Text),
                        KyHan = cbTerm.Text,
                        PhuongThucDaoHan = cbMethod.Text,
                        NgayGui = dtpSend.Value.Date,
                        NgayDaoHan = dtpEnd.Value.Date,

                    };
                    savingDAO.Create(newSaving);
                    Saving withdrawSaving = new Saving()
                    {
                        MaSo = txtSavingNumber.Text,

                    };
                    savingDAO.Delete(withdrawSaving);
                    MessageBox.Show("Da tra lai vao tai khoan");
                }
                if (cbMethod.Text.Contains("Toan bo tien goc và tien lai sang ky han moi"))
                {
                    string randomMaSo = RandomMaSo();
                    int txtMoneysend_update = Convert.ToInt32(txtMoneySend.Text) + loans;
                    Saving newSaving = new Saving()
                    {

                        STK = currentCustomer.STK,
                        MaSo = randomMaSo,
                        Money = Convert.ToInt32(txtMoneySend.Text),
                        KyHan = cbTerm.Text,
                        PhuongThucDaoHan = cbMethod.Text,
                        NgayGui = dtpSend.Value.Date,
                        NgayDaoHan = dtpEnd.Value.Date,

                    };
                    savingDAO.Create(newSaving);
                    Saving withdrawSaving = new Saving()
                    {
                        MaSo = txtSavingNumber.Text,

                    };
                    savingDAO.Delete(withdrawSaving);
                    MessageBox.Show("Da chuyen goc va lai sang ky han moi");
                }
            }
        }
    }
}
