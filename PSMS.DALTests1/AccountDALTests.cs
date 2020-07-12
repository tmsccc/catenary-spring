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
	public class AccountDALTests
	{
		AccountDAL account = new AccountDAL();
		[TestMethod()]
		public void AddAccountTest()
		{
			String sql = "'fasf1fsf2'";
			int t = 18;
			account.AddAccount(t, sql);
			//Assert.Fail();
		}

		[TestMethod()]
		public void SoftDeleteTest()
		{
			Account acco = new Account();
			acco = account.GetAccountById(3);
			Assert.IsNotNull(acco);
			//Assert.Fail();
		}

		[TestMethod()]
		public void GetUserByLoginNameAndPasswordTest()
		{
			Account a = new Account();
			a = account.GetUserByLoginNameAndPassword(1003, "dha2");
			Assert.IsNotNull(a);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpdatePwdTest()
		{
			Account a = new Account(2, 1003, "sada", 0);
			account.UpdatePwd(a, "dha2");

		}

		[TestMethod()]
		public void SoftDeleteTest1()
		{
			account.SoftDelete(1);
			//Assert.Fail();
		}

		[TestMethod()]
		public void RealDeleteTest()
		{
			account.RealDelete(1);
			//Assert.Fail();
		}

		[TestMethod()]
		public void GetAccountByIdTest()
		{
			Account a = new Account();
			a = account.GetAccountById(2);
			Assert.IsNotNull(a);
		}

		[TestMethod()]
		public void GetAllAccountTest()
		{
			List<Account> a = new List<Account>();
			a = account.GetAllAccount();
			Assert.IsNotNull(a);
		}

		[TestMethod()]
		public void UpDateAccountTest()
		{
			account.UpDateAccount(3, 1004);
			//Assert.Fail();
		}
	}
}