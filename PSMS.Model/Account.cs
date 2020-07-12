using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Model
{
	public class Account //用户账号信息类
	{
		public int ac_number { set; get; }//用户账号
		public String password { set; get; }//用户密码
		public int id { set; get; }//用户编号
		public int is_del{set;get;} //账号信息是否存在
		//无参构造函数
		public Account() { }
		//带参构造函数
		public Account(int id, int account, String password,int is_del)
		{
			this.id = id;
			ac_number = account;
			this.password = password;
			this.is_del = is_del;
		}
	}
}
