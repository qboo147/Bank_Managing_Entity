using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class FInformation : Form
    {
        DBConnection dBConnection = new DBConnection();
        CustomerDAO customerDAO = new CustomerDAO();
        Customer customer;

        public FInformation(Customer choosedCustomer)
        {
            InitializeComponent();
            customer = choosedCustomer;
        }

        private void FInformation_Load(object sender, EventArgs e)
        {
            if (customer != null)
                LoadInformation();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string randomStk = RandomSTK();
            DataTable Customers = GetAllCustomer();
            for (int i = 0; i < Customers.Rows.Count - 1; i++)
                while (randomStk == Customers.Rows[i]["STK"].ToString())
                    randomStk = RandomSTK();
            Customer newCustomer = new Customer()
            {
                STK = randomStk,
                Name = txtName.Text,
                Address = txtAddr.Text,
                DoB = dtpDoB.Value,
                CitizenID = txtID.Text,
                PhoneNum = txtPNum.Text,
                Money = 0,
                CreateAt = DateTime.Now
            };
            if (customerDAO.ValidateFormCreate(newCustomer))
                MessageBox.Show("Khong duoc de trong");
            customerDAO.Create(newCustomer);
            ClearInfomation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer updatedCustomer = new Customer()
            {
                STK = txtSTK.Text,
                Name = txtName.Text,
                Address = txtAddr.Text,
                DoB = dtpDoB.Value,
                CitizenID = txtID.Text,
                PhoneNum = txtPNum.Text,
                Money = Convert.ToInt32(txtMoney.Text),
                UpdateAt = DateTime.Now
        };
            if (customerDAO.ValidateFormCreate(updatedCustomer))
                MessageBox.Show("Khong duoc de trong");
            else
            {
                customerDAO.Update(updatedCustomer);
                ClearInfomation();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer deletetedCustomer = new Customer()
            {
                STK = txtSTK.Text
            };
            customerDAO.Delete(deletetedCustomer);
            ClearInfomation();
        }

        private void ClearInfomation()
        {
            txtSTK.Clear();
            txtName.Clear();
            txtAddr.Clear();
            txtID.Clear();
            txtPNum.Clear();
            txtMoney.Clear();
        }

        private string RandomSTK()
        {
            Random random = new Random();
            return random.NextString(10);
        }

        private void LoadInformation()
        {
            txtSTK.Text = customer.STK;
            txtName.Text = customer.Name;
            txtAddr.Text = customer.Address;
            txtID.Text = customer.CitizenID;
            txtPNum.Text = customer.PhoneNum;
            txtMoney.Text = customer.Money.ToString();
        }

        private DataTable GetAllCustomer()
        {

            DataGrid dataGrid = new DataGrid
            {
                DataSource = dBConnection.Load("Customer")
            };
            DataTable datatable = (DataTable)dataGrid.DataSource;
            return datatable;
        }
    }
}
