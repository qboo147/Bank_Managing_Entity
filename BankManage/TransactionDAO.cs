using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public class TransactionDAO
    {
        DBConnection DbConnection = new DBConnection();
        public void Create(Tran transaction)
        {
            string sqlStr = string.Format("INSERT INTO Trans(STK, MaGD, LoaiGD, Money, ThoigianGD, ReceivedSTK, Note) VALUES ('{0}', '{1}', '{2}' , '{3}' , '{4}' , '{5}', '{6}')", transaction.STK, transaction.MaGD, transaction.LoaiGD, transaction.Money, transaction.ThoigianGD, transaction.ReceivedSTK, transaction.Note);
            DbConnection.Execute(sqlStr);
        }
    }
}