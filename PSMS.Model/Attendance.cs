using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Model
{
	public class Attendance //考勤信息类
	{
		public Attendance() { }
		//带参构造函数
		public Attendance(int id, int clockin_day, int late_day, int leave_day, int absent_day, int reward, int punish, int is_sign, int is_del)
		{
			this.id = id;
			this.is_sign = is_sign;
			this.late_day = late_day;
			this.absent_day = absent_day;
			this.leave_day = leave_day;
			this.clockin_day = clockin_day;
			this.punish = punish;
			this.reward = reward;
			this.is_del = is_del;
		}
		public int id { set; get; }//员工编号
		public int clockin_day { set; get; }//打卡天数
		public int late_day { set; get; }//迟到次数
		public int leave_day { set; get; }//请假次数
		public int absent_day { set; get; }//旷工次数
		public int reward { set; get; }//奖励金额
		public int punish { set; get; }//惩罚金额
		public int is_sign { set; get; }//签到状况，0—未签到；1—按时签到，2—过时签到
		public int is_del { set; get; } //考勤信息是否删除
								 //无参构造函数


	}
}
