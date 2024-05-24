using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankManage
{
    public partial class FMain : Form
    {
        DBConnection dBConnection = new DBConnection();
        Customer choosedCustomer = new Customer();
        public FMain()
        {
            InitializeComponent();
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            LoadCustomerData("");
        }

        private void LoadCustomerData(string condition)
        {
            gvSTK.DataSource = dBConnection.Load("Customer", condition);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadCustomerData("");
            bool isShowGvCustomer = false;
            for (int i = 0; i < gvSTK.Rows.Count - 1; i++)
            {
                string CitizenId = gvSTK.Rows[i].Cells["CitizenId"].Value.ToString() ?? "";
                if (txtFilter.Text == CitizenId)
                {
                    LoadCustomerData($" WHERE CitizenId = '{txtFilter.Text}'");
                    isShowGvCustomer = true;
                    break;
                }
            }
            gvSTK.Visible = isShowGvCustomer;
            menuStrip1.Enabled = isShowGvCustomer;
            if (!gvSTK.Visible)
            {
                MessageBox.Show("Chua co tai khoan");
                informationToolStripMenuItem_Click(sender, e);
            }
            else
                pnlOption.Controls.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gvSTK.Visible = false;
            txtFilter.Clear();
        }

        private void TransHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FHistory fHistory = new FHistory(choosedCustomer.STK);
            ShowFormOnPanel(fHistory);
        }
        private void SavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSaving fSaving = new FSaving(choosedCustomer);
            ShowFormOnPanel(fSaving);
        }
        private void BorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FBorrow fBorrow = new FBorrow(choosedCustomer);
            ShowFormOnPanel(fBorrow);
        }
        private void WithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FWithdraw fWithdraw = new FWithdraw(choosedCustomer);
            ShowFormOnPanel(fWithdraw);
        }
        private void SendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSend fsend = new FSend(choosedCustomer);
            ShowFormOnPanel(fsend);
        }
        private void TransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid dataGrid = new DataGrid
            {
                DataSource = dBConnection.Load("Customer")
            };
            DataTable datatable = (DataTable)dataGrid.DataSource;
            pnlOption.Controls.Clear();
            FTrans fTrans = new FTrans(choosedCustomer, datatable);
            ShowFormOnPanel(fTrans);    
        }

        private void CreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FCredit fcredit = new FCredit(choosedCustomer);
            ShowFormOnPanel(fcredit);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            if (choosedCustomer != null)
            {
                FInformation fInformation = new FInformation(choosedCustomer);
                ShowFormOnPanel(fInformation);
            }
        }

        private void gvSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            string stk = gvSTK.Rows[numrow].Cells["STK"].Value.ToString();
            string name = gvSTK.Rows[numrow].Cells["Name"].Value.ToString();
            string address = gvSTK.Rows[numrow].Cells["Address"].Value.ToString();
            DateTime dob = DateTime.Parse(gvSTK.Rows[numrow].Cells["DoB"].Value.ToString());
            string id = gvSTK.Rows[numrow].Cells["CitizenId"].Value.ToString();
            string phoneNumber = gvSTK.Rows[numrow].Cells["PhoneNum"].Value.ToString();
            int money = Convert.ToInt32(gvSTK.Rows[numrow].Cells["Money"].Value.ToString());
            choosedCustomer = new Customer()
            {
                STK = stk,
                Name = name,
                Address = address,
                DoB = dob,
                CitizenID = id,
                PhoneNum = phoneNumber,
                Money = money,
            };
        }

        private void ShowFormOnPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlOption.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}