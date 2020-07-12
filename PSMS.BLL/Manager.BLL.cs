using PMSM.DAL;
using PSMS.DAL;
using PSMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.BLL
{
    public class ManagerBLL
    {   UserDAL ud = new UserDAL();
        AccountDAL ad = new AccountDAL();

        string id = "2018112558";
        string pwd = "2018112558";
        public bool ManagerLogin(string id, string pwd)
        {
            if (this.pwd == pwd && this.id == id)
            { return true; }
            return false;
        }
        public DataTable GetAllUserIfo()
        {            
            DataTable dt = ud.GetAllUsers();
            return dt;
        }
        public User SearchUserIfoById(int id)
        {         
            User user = ud.GetUserById(id);
            return user;
        }
        public int SoftDeleteUser(int id)
        {
            return ud.SoftDelete(id);
        }

        public int RealDeleteUser(int id)
        {
            return ud.RealDelete(id);
        }
        public int AddUser(User user)
        {
            return ud.AddUser(user); 
        }
        public int UpdateUser(User user)
        {
            return ud.UpdateUser(user);
        }
        public int AddAccount(int number, String password)
        {
            return ad.AddAccount(number, password);    
        }















    }
}
