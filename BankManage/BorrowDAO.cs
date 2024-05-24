using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public class BorrowDAO
    {
        DBConnection DbConnection = new DBConnection();
        public void Create(Borrow borrow)
        {
            string sqlStr = string.Format("INSERT INTO Borrow(Money, CitizenID, Salary, Moneyborrow, Kieutindung, TaiSanTheChap, Kyhan, Ngaychovay, Ngayhoantien) VALUES ('{0}', '{1}', '{2}' , '{3}' , '{4}' , '{5}', '{6}', '{7}','{8}')", borrow.Money, borrow.CitizenID , borrow.Salary, borrow.Money, borrow.KieuTinDung, borrow.TaiSanTheChap,borrow.KyHan, borrow.NgayChoVay, borrow.NgayHoanTien);
            DbConnection.Execute(sqlStr);
        }
     
    }
}
