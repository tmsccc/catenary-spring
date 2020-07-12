using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PSM;
using PSMS.Model;
using MySql.Data.MySqlClient;

namespace PSMS.DAL
{
    public class AttendanceDAL
    {
        SqlDbHelper db = new SqlDbHelper();
		Attendance attenc= new Attendance();
		
        //添加考勤信息,需要传入Attence类的对象，Attendance对象的id要与账号信息里的user_id一一对应。
        public int AddAtten(Attendance atten)
        {
            String sql = "INSERT INTO t_checkwork(check_number,clockin_day,late_day,leave_day,absenteeism_day,reward,punish,is_sign,Is_del)VALUES(@check_number, @clockin_day, @late_day, @leave_day, @absenteeism_day, @reward,@punish,@is_sign,@Is_del)";
			MySqlParameter[] param = {
				 new MySqlParameter("@check_number",MySqlDbType.Int32),
				 new MySqlParameter("@clockin_day",MySqlDbType.Int32),
				 new MySqlParameter("@late_day",MySqlDbType.Int32),
				 new MySqlParameter("@leave_day",MySqlDbType.Int32),
				 new MySqlParameter("@absenteeism_day",MySqlDbType.Int32),
				 new MySqlParameter("@reward",MySqlDbType.Int32),
				 new MySqlParameter("@punish",MySqlDbType.Int32),
				 new MySqlParameter("@is_sign",MySqlDbType.Int32),
				 new MySqlParameter("@Is_del",MySqlDbType.Int32),

			};
			param[0].Value =atten.id;
			param[1].Value = atten.clockin_day;
			param[2].Value = atten.late_day;
			param[3].Value = atten.leave_day;
			param[4].Value = atten.absent_day;
			param[5].Value = atten.reward;
			param[6].Value = atten.punish;
			param[7].Value = atten.is_sign;
			param[8].Value = atten.is_del;
		
			return db.ExecuteNonQuery(sql, param);
		}
		//更新考勤信息，需要传入Attendance类的对象
		public int UpdateAtten(Attendance atten)
		{
			String sql = "UPDATE t_checkwork SET clockin_day=@clockin_day,late_day=@late_day,leave_day=@leave_day,absenteeism_day=@absenteeism_day,reward=@reward,punish=@punish,is_sign=@is_sign,Is_del=@is_del WHERE check_number=@check_number";
			//参数列表
			MySqlParameter[] param = {
				 new MySqlParameter("@clockin_day",MySqlDbType.Int32),
				 new MySqlParameter("@late_day",MySqlDbType.Int32),
				 new MySqlParameter("@leave_day",MySqlDbType.Int32),
				 new MySqlParameter("@absenteeism_day",MySqlDbType.Int32),
				 new MySqlParameter("@reward",MySqlDbType.Int32),
				 new MySqlParameter("@punish",MySqlDbType.Int32),
				 new MySqlParameter("@is_sign",MySqlDbType.Int32),
				 new MySqlParameter("@Is_del",MySqlDbType.Int32),
				 new MySqlParameter("@check_number",MySqlDbType.Int32),


			};
			param[0].Value = atten.clockin_day;
			param[1].Value = atten.late_day;
			param[2].Value = atten.leave_day;
			param[3].Value = atten.absent_day;
			param[4].Value = atten.reward;
			param[5].Value = atten.punish;
			param[6].Value = atten.is_sign;
			param[7].Value = atten.is_del;
			param[8].Value = atten.id;
			return db.ExecuteNonQuery(sql, param);
		}
		//软删除通过设置Is_del字段实现
		public int SoftDelete(int id)
		{
			String sql = "UPDATE t_checkwork SET Is_del=1 WHERE check_number=" + id;
			return db.ExecuteNonQuery(sql);
		}
		//硬删除，直接用删除语句进行删除
		public int RealDelete(int id)
		{
			String sql = "DELETE FROM t_checkwork WHERE check_number=" + id;
			return db.ExecuteNonQuery(sql);
		}
		public List<Attendance> GetAllAttens(int is_Del) //is_del=0,查询在职员工，以list的形式返回数据
		{
			String sql = "SELECT *FROM t_checkwork WHERE Is_del=" + is_Del;
			DataTable dt = db.ExecuteDataTable(sql);
			List<Attendance> attens = new List<Attendance>();
			foreach (DataRow dr in dt.Rows)
			{
				//行转化成对象
				Attendance atten = DataRowToAtten(dr);
				attens.Add(atten);
			}
			return attens;

		}
		//以DataTable的形式返回数据，查找所有的考勤信息
		public DataTable GetAllAttens()
		{
			int is_Del = 0;
			String sql = "SELECT * FROM t_checkwork WHERE Is_del=" + is_Del;
			DataTable dt = db.ExecuteDataTable(sql);
			return dt;
		}
		//通过id寻找考勤信息,这里的id和用户信息id以及账号信息的id是相等的，返回的是Attendence对象
		public Attendance GetAttenById(int id)
		{
			String sql = "SELECT * FROM t_checkwork WHERE check_number=@id";
			MySqlParameter[] param = {
										new MySqlParameter("@id",MySqlDbType.Int32)
								   };
			param[0].Value = id;
			DataTable dt = db.ExecuteDataTable(sql, param);
			Attendance atten = null;
			if (dt.Rows.Count > 0)
			{

				DataRow dr = dt.Rows[0];
				atten = DataRowToAtten(dr);
			}
			return atten;
		}

		//从datable中获取数据，将DataTable中每一行的数据转保存到User的对象中
		private Attendance DataRowToAtten(DataRow dr)
		{
			Attendance atten= new Attendance();
			atten.id= Convert.ToInt32(dr["check_number"]);
			atten.clockin_day= Convert.ToInt32(dr["clockin_day"]);
			atten.late_day= Convert.ToInt32(dr["late_day"]);
			atten.leave_day= Convert.ToInt32(dr["leave_day"]);
			atten.absent_day= Convert.ToInt32(dr["absenteeism_day"]);
			atten.absent_day= Convert.ToInt32(dr["reward"]);
			atten.absent_day= Convert.ToInt32(dr["punish"]);
			atten.is_sign= Convert.ToInt32(dr["is_sign"]);
			atten.is_del= Convert.ToInt32(dr["Is_del"]);
			return atten;
		}

		//以下是修改各字段的方法，Is_del字段修改就是前面的软删除函数
		public int UpDateClockin(int id,int c_day)   //修改员工打卡的天数
		{
			String sql = "UPDATE t_checkwork SET clockin_day=@clockin_day WHERE check_number="+id;
			MySqlParameter[] param ={
							   new MySqlParameter("@clockin_day",MySqlDbType.Int32),
			};
			param[0].Value = c_day;
			return db.ExecuteNonQuery(sql, param);
		}		
		public int UpDateLate(int id,int l_day) //修改员工迟到的天数
		{
			String sql = "UPDATE t_checkwork SET late_day=@late_day WHERE check_number="+id;
			MySqlParameter[] param ={
							   new MySqlParameter("@late_day",MySqlDbType.Int32),
			};
			param[0].Value = l_day;
			return db.ExecuteNonQuery(sql, param);
		}		
		public int UpDatecLeave(int id,int le_day) //修改员工请假的天数
		{
			String sql = "UPDATE t_checkwork SET leave_day=@leave_day WHERE check_number="+id;
			MySqlParameter[] param ={
							   new MySqlParameter("@leave_day",MySqlDbType.Int32),
			};
			param[0].Value = le_day;
			return db.ExecuteNonQuery(sql, param);
		}		
		public int UpDateAbsen(int id,int ab_day) //修改员工旷工的天数
		{
			String sql = "UPDATE t_checkwork SET absenteeism_day=@absenteeism_day WHERE check_number="+id;
			MySqlParameter[] param ={
							   new MySqlParameter("@absenteeism_day",MySqlDbType.Int32),
			};
			param[0].Value = ab_day;
			return db.ExecuteNonQuery(sql, param);
		}
		public int UpDateIsSgn(int id,int sign) //修改员工打卡状态，，sign: 0—未签到；1—按时签到，2—过时签到
		{
			String sql = "UPDATE t_checkwork SET is_sign=@sign WHERE check_number="+id;
			MySqlParameter[] param ={
							   new MySqlParameter("@sign",MySqlDbType.Int32),
			};
			param[0].Value = sign;
			return db.ExecuteNonQuery(sql, param);
		}		
		public int UpDateReword(int id,int reward) //修改员工奖励金额
		{
			String sql = "UPDATE t_checkwork SET reward=@reward WHERE check_number="+id;
			MySqlParameter[] param ={
							   new MySqlParameter("@reward",MySqlDbType.Int32),
			};
			param[0].Value = reward;
			return db.ExecuteNonQuery(sql, param);
		}		
		public int UpDatePunish(int id,int punish) //修改员工处罚金额
		{
			String sql = "UPDATE t_checkwork SET punish=@punish WHERE check_number="+id;
			MySqlParameter[] param ={
							   new MySqlParameter("@punish",MySqlDbType.Int32),
			};
			param[0].Value = punish;
			return db.ExecuteNonQuery(sql, param);
		}
	}
}
