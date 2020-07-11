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
			String sql = "fasf1fsf2";
			account.AddAccount(18, sql);
			//Assert.Fail();
		}

		[TestMethod()]
		public void SoftDeleteTest()
		{
			Account acco= new Account();
				acco=account.GetAccountById(1);
			Assert.IsNotNull(acco);
			//Assert.Fail();
		}
	}
}