using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public class SavingDAO
    {
        DBConnection DbConnection = new DBConnection();
        public void Create(Saving saving)
        {
            string sqlStr = string.Format("INSERT INTO Saving(STK, MaSo, Money, KyHan, PhuongThucDaoHan, NgayGui, NgayDaoHan) VALUES ('{0}', '{1}', '{2}' , '{3}' , '{4}' , '{5}', '{6}')", saving.STK, saving.MaSo, saving.Money, saving.KyHan, saving.PhuongThucDaoHan, saving.NgayGui, saving.NgayDaoHan);
            DbConnection.Execute(sqlStr);
        }
        public void Delete(Saving saving)
        {
            string sqlStr = string.Format("DELETE FROM Saving where Maso = '{0}'", saving.MaSo);
            DbConnection.Execute(sqlStr);
        }
    }
}
