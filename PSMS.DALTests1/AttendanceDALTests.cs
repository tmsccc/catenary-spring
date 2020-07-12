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
			Attendance atten = new Attendance(1003, 10, 2, 4, 5, 1, 0);
			attendal.AddAtten(atten);
			//Assert.Fail();
		}

		[TestMethod()]
		public void UpdateAttenTest()
		{
			Attendance atten = new Attendance(1001, 100, 2, 4, 5, 1, 0);
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
			a = attendal.GetAttenById(1003);
			Assert.IsNotNull(a);
		}
	}
}