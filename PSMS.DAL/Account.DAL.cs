using MySql.Data.MySqlClient;
using PMS15.DAL;
using PSM;
using PSMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.DAL
{
    class AccountDAL
    {
        SqlDbHelper db = new SqlDbHelper();
        UserDAL userdal = new UserDAL();
         //用户注册账号
        public int AddAccount(Account account)
        {
            //sql语句
            String sql = "INSERT INTO t_account(user_id,user_account,user_password) VALUES(@user_id,@user_account,@user_password)";
            //参数列表
            MySqlParameter[] param = {
                                       new MySqlParameter("@user_id",SqlDbType.Int),
                                       new MySqlParameter("@user_account",SqlDbType.Int),
                                       new MySqlParameter("@Price",SqlDbType.VarChar),
                                     
                                   };

            //参数赋值
            param[0].Value = account.id;
            param[1].Value = account.account;
            param[2].Value = account.password;
            return db.ExecuteNonQuery(sql, param);
        }
        public int RealDelete(int id)
        {
            string sql = "DELETE FROM t_account WHERE No =" + id;

            return db.ExecuteNonQuery(sql);
        }
        //显示所有的账号信息
        public List<Account> GetAllAccount()
        {
         
            string sql = "SELECT * FROM t_account" ;
            DataTable dt = db.ExecuteDataTable(sql);
            List<Account> accounts = new List<Account>();

            foreach (DataRow dr in dt.Rows)
            {
                //行转化成对象
                Account account = DataRowToAccount(dr);
                accounts.Add(account);
            }
            return accounts;
        }
        //根据id查找用户信息

        public Account GetAccountById(int id)
        {
            //1 sql语句
            string sql = "SELECT * FROM t_account WHERE user_id=@id";
            MySqlParameter[] param = {
                                        new MySqlParameter("@id",MySqlDbType.Int32)
                                   };
            param[0].Value = id;
            DataTable dt = db.ExecuteDataTable(sql, param);
            //3 关系--》对象     orm --》 ef  nhibernate
            Account account = null;
            if (dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];
                account= DataRowToAccount(dr);
            }
            return account;
        }
        private Account DataRowToAccount(DataRow dr)
        {
            Account account= new Account();
            account.id = Convert.ToInt32(dr["user_id"]);   
            account.account = Convert.ToInt32(dr["user_account"]);
            account.password = Convert.ToString(dr["user_password"]);
            return account;
        }
    }
}
