using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Model
{
	public class User //员工基本信息类
	{
		//无参构造函数
		public User() { }
		//带参构造函数
		public User(int id, String name, String sex, String job,int wages,DateTime entrytime, String email, String department, int is_del)
		{
			this.id = id;
			this.name = name;
			this.sex = sex;
			this.job = job;
			this.entrytime = entrytime;
			this.email = email;
			this.department = department;
			this.is_del = is_del;
			this.wages = wages;
		}
		public int id { set; get; }//员工编号
		public String name { set; get; }//员工姓名
		public String sex { set; get; }//性别
		public String job { set; get; }//工作岗位
		public DateTime entrytime { set; get; }//入职时间
		public String email { set; get; }//员工邮箱地址
		public String department { set; get; }//员工所属部门
		public int is_del { set; get; }//用户是否删除
		public int wages { set; get; } //员工基本工资

	}
}
