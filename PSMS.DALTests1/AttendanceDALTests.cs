using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSMS.DAL;
using PSMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.DAL.Tests
{
	[TestClass()]
	public class AttendanceDALTests
	{
		AttendanceDAL attendal = new AttendanceDAL();
		[TestMethod()]
		public void AddAttenTest()
		{
			Attendance atten = new Attendance(1008, 10, 2, 4, 5, 100, 10, 1, 0);
			attendal.AddAtten(atten);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpdateAttenTest()
		{
			Attendance atten = new Attendance(1006, 101, 34, 4, 5, 10, 10, 1, 0);
			attendal.UpdateAtten(atten);
			//Assert.Fail();
		}

		[TestMethod()]
		public void SoftDeleteTest()
		{
			attendal.SoftDelete(1001);
			//Assert.Fail();
		}

		[TestMethod()]
		public void RealDeleteTest()
		{
			attendal.RealDelete(1001);
			//Assert.Fail();
		}

		[TestMethod()]
		public void GetAllattenTest()
		{
			List<Attendance> attens = new List<Attendance>();
			attens = attendal.GetAllAttens(0);
			Assert.IsNotNull(attens);
			//Assert.Fail();
		}

		[TestMethod()]
		public void GetAllAttensTest()
		{
			DataTable dt;
			dt = attendal.GetAllAttens();
			Assert.IsNotNull(dt);
			//Assert.Fail();
		}

		[TestMethod()]
		public void GetUserByIdTest()
		{
			Attendance a = new Attendance();
			a = attendal.GetAttenById(1006);
			Assert.IsNotNull(a);
		}
		[TestMethod()]
		public void UpDateClockinTest()
		{
			attendal.UpDateClockin(1003, 1);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpDateLateTest()
		{
			attendal.UpDateLate(1003, 2);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpDatecLeaveTest()
		{
			attendal.UpDatecLeave(1003, 3);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpDateAbsenTest()
		{
			attendal.UpDateAbsen(1003, 4);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpDateIsSgnTest()
		{
			attendal.UpDateIsSgn(1003, 5);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpDateRewordTest()
		{
			attendal.UpDateReword(1003, 6);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpDatePunishTest()
		{
			attendal.UpDatePunish(1003, 7);
			//Assert.Fail();
		}
	}
}