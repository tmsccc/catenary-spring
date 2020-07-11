using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Model
{
	public class Attendance //考勤信息类
	{
		int id { set; get; }//员工编号
		int late_day { set; get; }//迟到次数
		int leave_day { set; get; }//请假次数
		int absent_day { set; get; }//旷工次数
		int is_sign { set; get; }//签到状况，0—未签到；1—按时签到，2—过时签到
		int clockin_day { set; get; }//迟到次数
		int Is_del { set; get; }  //考勤信息是否删除							 
		//无参构造函数
		public Attendance() { }
		//带参构造函数
		public Attendance(int id, int clockin_day, int late_day, int leave_day, int absent_day, int is_sign,int is_del)
		{
			this.id = id;
			this.is_sign = is_sign;
			this.late_day = late_day;
			this.absent_day = absent_day;
			this.leave_day = leave_day;
			this.clockin_day = clockin_day;
			this.Is_del = is_del;
		}
	}
}
