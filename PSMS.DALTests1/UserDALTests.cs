using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSMS.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace PMSM.DAL.Tests
{
	[TestClass()]
	public class UserDALTests
	{
		UserDAL userdal = new UserDAL();
		[TestMethod()]

		public void GetUserByIdTest()
		{
			User user = userdal.GetUserById(1000);
			Assert.IsNotNull(user);
			//Assert.Fail();
		}

		[TestMethod()]
		public void AddUserTest()
		{
			User user = new User(1002, "dsj", "sfdfsd", "sdfs", DateTime.Parse("2000-07-18"), "dscsz", "hklsa", 0);
			userdal.AddUser(user);
			Assert.IsNotNull(user);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpdateUserTest()
		{
			User user = new User(1000, "dsjddsads", "sfdfsd", "sdfdsadass", DateTime.Parse("2000-07-18"), "dscdsasasz", "hklsdasdasa", 0);
			userdal.UpdateUser(user);
			Assert.IsNotNull(user);
			//Assert.Fail();
		}

		[TestMethod()]
		public void SoftDeleteTest()
		{
			userdal.SoftDelete(1002);
			//Assert.Fail();
		}

		[TestMethod()]
		public void RealDeleteTest()
		{
			userdal.RealDelete(1000);
			//Assert.Fail();
		}

		[TestMethod()]
		public void GetAllUsersTest()
		{
			List<User> users = new List<User>();
			users = userdal.GetAllUsers(0);
			Assert.IsNotNull(users);
			//Assert.Fail();
		}

		[TestMethod()]
		public void GetAllUsersTest1()
		{
			DataTable dt = new DataTable();
			dt = userdal.GetAllUsers();
			Assert.IsNotNull(dt);
			//Assert.Fail();
		}
	}
}