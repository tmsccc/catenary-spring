using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSMS.DAL;
using PSMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.DAL.Tests
{
	[TestClass()]
	public class UserDALTests
	{
		UserDAL userdal = new UserDAL();
		[TestMethod()]
		public void GetUserByIdTest()
		{
			User user = userdal.GetUserById(1001);
			Assert.IsNotNull(user);
			//Assert.Fail();
		}
	}
}

namespace PSMS.DALTests
{
	class UserDALTests
	{
	}
}
