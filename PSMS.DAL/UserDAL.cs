using PSMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using PSM;

namespace PMSM.DAL
{
	public class UserDAL
	{
		SqlDbHelper db = new SqlDbHelper();
		//添加员工信息，这里传入的user.id要和账号信息里的user_id对应，不然就不能根据账号信息查找到对应用户信息
		public int AddUser(User user)
		{
			//sql语句
			String sql = "INSERT INTO t_user(emp_id,emp_name,emp_sex,emp_job,emp_entrytime,emp_emailbox,emp_department,Is_del) VALUES(@emp_id,@emp_name,@emp_sex,@emp_job,@emp_entrytime,@emp_emailbox,@emp_department,@Is_del)";
			//参数列表
			MySqlParameter[] param = {
				 new MySqlParameter("@emp_id",MySqlDbType.Int32),
				 new MySqlParameter("@emp_name",MySqlDbType.VarChar),
				 new MySqlParameter("@emp_sex",MySqlDbType.VarChar),
				 new MySqlParameter("@emp_job",MySqlDbType.VarChar),
				 new MySqlParameter("@emp_entrytime",MySqlDbType.DateTime),
				 new MySqlParameter("@emp_emailbox",MySqlDbType.VarChar),
				 new MySqlParameter("@emp_department",MySqlDbType.VarChar),
				 new MySqlParameter("@Is_del",MySqlDbType.Int16),

			};
			param[0].Value = user.id;
			param[1].Value = user.name;
			param[2].Value = user.sex;
			param[3].Value = user.job;
			param[4].Value = user.entrytime;
			param[5].Value = user.email;
			param[6].Value = user.department;
			param[7].Value = user.is_del;

			return db.ExecuteNonQuery(sql, param);

		}
		//更新用户信息
		public int UpdateUser(User user)
		{
			String sql = "UPDATE t_user SET emp_name=@emp_name,emp_sex=@emp_sex,emp_job=@emp_job,emp_entrytime=@emp_entrytime,emp_emailbox=@emp_emailbox,emp_department=@emp_department,Is_del=@is_del WHERE emp_id=@emp_id";
			//参数列表
			MySqlParameter[] param ={
			  	 new MySqlParameter("@emp_id",MySqlDbType.Int32),
				 new MySqlParameter("@emp_name",MySqlDbType.VarChar),
				 new MySqlParameter("@emp_sex",MySqlDbType.VarChar),
				 new MySqlParameter("@emp_job",MySqlDbType.VarChar),
				 new MySqlParameter("@emp_entrytime",MySqlDbType.DateTime),
				 new MySqlParameter("@emp_emailbox",MySqlDbType.VarChar),
				 new MySqlParameter("@emp_department",MySqlDbType.VarChar),
				 new MySqlParameter("@Is_del",MySqlDbType.Int16),

			};
			//参数赋值
			param[0].Value = user.id;
			param[1].Value = user.name;
			param[2].Value = user.sex;
			param[3].Value = user.job;
			param[4].Value = user.entrytime;
			param[5].Value = user.email;
			param[6].Value = user.department;
			param[7].Value = user.is_del;
			return db.ExecuteNonQuery(sql, param);
		}
		//软删除，改变Is_del字段的值实现删除，Is_del字段如果为——1，则用户不存在
		public int SoftDelete(int id)
		{
			String sql = "UPDATE t_user SET Is_del=1 WHERE emp_id=" + id;
			return db.ExecuteNonQuery(sql);
		}
		//硬删除，直接用删除语句进行删除
		public int RealDelete(int id)
		{
			String sql = "DELETE FROM t_user WHERE emp_id=" + id;
			return db.ExecuteNonQuery(sql);
		}
		//查询所有的员工，以链表的形式返回所有数据
		public List<User> GetAllUsers(int is_Del) //is_Del字段是显示员工是否被删除，is_Del=1可以查询所有在职员工，is_Del=1则查询删除的员工
		{
			String sql = "SELECT *FROM t_user WHERE Is_del=" + is_Del;
			DataTable dt = db.ExecuteDataTable(sql);
			List<User> users = new List<User>();
			foreach (DataRow dr in dt.Rows)
			{ 
				User user = DataRowToUser(dr);
				users.Add(user);
			}
			return users;

		}
		//以DataTable的形式返回数据，查找所有的用户信息
		public DataTable GetAllUsers()
		{
			int is_Del = 0;
			String sql = "SELECT * FROM t_user WHERE Is_del=" + is_Del;
			DataTable dt = db.ExecuteDataTable(sql);
			return dt;
		}
		//通过id寻找用户信息,返回的是对象
		public User GetUserById(int id)
		{
			String sql = "SELECT * FROM t_user WHERE emp_id=@id";
			MySqlParameter[] param = {
										new MySqlParameter("@id",MySqlDbType.Int32)
								   };
			param[0].Value = id;
			DataTable dt = db.ExecuteDataTable(sql, param);
			User user = null;
			if (dt.Rows.Count > 0)
			{

				DataRow dr = dt.Rows[0];
				user = DataRowToUser(dr);
			}
			return user;
		}

		//从datable中获取数据，将DataTable中每一行的数据转保存到User的对象中

		public User DataRowToUser(DataRow dr)  //private
		{
			User user = new User();

			//user.Id = Convert.ToInt32(dr[0]);
			user.id = Convert.ToInt32(dr["emp_id"]);
			if (dr["emp_entrytime"] != DBNull.Value)//判断日期非空
			{
				user.entrytime = Convert.ToDateTime(dr["emp_entrytime"]);
			}
			user.name = Convert.ToString(dr["emp_name"]);
			user.sex = Convert.ToString(dr["emp_sex"]);
			user.job = Convert.ToString(dr["emp_job"]);
			user.email = Convert.ToString(dr["emp_emailbox"]);
			user.is_del = Convert.ToInt32(dr["Is_del"]);
			user.department = Convert.ToString(dr["emp_department"]);
			return user;
		}


	}
}
