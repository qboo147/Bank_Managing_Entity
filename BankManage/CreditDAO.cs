using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;

namespace BankManage
{
    internal class CreditDAO
    {
        DBConnection DbConnection = new DBConnection();
        public void Create(Credit credit)
        {
            string sqlStr = string.Format("INSERT INTO Credit(STK, MaThe, HanMuc, UsedMoney, Method, NgayMo, NgayDaoHan) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", credit.STK, credit.MaThe, credit.HanMuc, credit.UsedMoney, credit.Method, credit.NgayMo, credit.NgayDaoHan);
            DbConnection.Execute(sqlStr);
        }
        public void Delete(Credit credit)
        {
            string sqlStr = string.Format("DELETE FROM Credit where MaThe = '{0}'", credit.MaThe);
            DbConnection.Execute(sqlStr, "Xoa the tin dung");
        }
        public void Update(Credit credit)
        {
            string sqlStr = string.Format("UPDATE Credit SET UsedMoney = '{1}' WHERE STK = '{0}'", credit.STK, credit.UsedMoney);
            DbConnection.Execute(sqlStr);
        }

        public Credit Get(Credit credit)
        {
            var data = DbConnection.Load("Credit", $" WHERE STK = '{credit.STK}'");
            if (data.Rows.Count > 0)
            {
                credit.MaThe = data.Rows[0]["MaThe"].ToString();
                credit.HanMuc = Convert.ToInt32(data.Rows[0]["HanMuc"]);
                credit.UsedMoney = Convert.ToInt32(data.Rows[0]["UsedMoney"]);
                credit.Method = data.Rows[0]["Method"].ToString();
                credit.NgayMo = Convert.ToDateTime(data.Rows[0]["NgayMo"]);
                credit.NgayDaoHan = Convert.ToDateTime(data.Rows[0]["NgayDaoHan"]);
            }
            return credit;
        }
    }
}