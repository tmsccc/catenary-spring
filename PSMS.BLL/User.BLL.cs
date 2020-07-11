
using PSMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSMS.DAL;
using PMSM.DAL;

namespace PSMS.BLL
{
   

    public class UserBLL
   {
        private UserDAL userDal = new UserDAL();

        public bool Login(string name, string pwd, out User user)//out
        {
            user = userDal.GetUserByID(id);
            if (user.password == pwd)
            { 
                return false; 
            }

            return user != null;
        }



        //        public bool UpdateUser(User user)
        //        {
        //            return userDal.UpdateUser(user) > 0;
        //        }
        //        /// <summary>
        //        /// 
        //        /// </summary>
        //        /// <param name="person"></param>
        //        /// <returns></returns>
        //        public bool AddUser(User user)
        //        {
        //            return userDal.AddUser(user) > 0;
        //        }

        //        /// <summary>
        //        /// 删除
        //        /// </summary>
        //        /// <param name="pid">id</param>
        //        /// <param name="flag">1 真删除  0 软删除</param>
        //        /// <returns></returns>
        //        public bool Delete(String eno, int flag)
        //        {
        //            bool result = false;
        //            if (flag == 1)
        //            {
        //                result = userDal.RealDelete(eno) > 0;
        //            }
        //            else if (flag == 0)
        //            {
        //                result = userDal.SoftDelete(eno) > 0;
        //            }
        //            return result;
        //        }

        //        /// <summary>
        //        /// 查询所有用户
        //        /// </summary>
        //        /// <param name="isDel">0 未删除的用户  1 删除的用户</param>
        //        /// <returns></returns>
        //        public List<User> GetAllUsers(int isDel)
        //        {
        //            return userDal.GetAllUsers(isDel);
        //        }

        //        /// <summary>
        //        /// 修改密码
        //        /// </summary>
        //        /// <param name="eName">登录名</param>
        //        /// <param name="oldPwd"></param>
        //        /// <param name="newPwd"></param>
        //        /// <param name="msg"></param>
        //        /// <returns></returns>
        //        public bool UpdatePwd(string eName, string oldPwd, string newPwd, out string msg)
        //        {
        //            bool result = false;
        //            User user = userDal.GetUserByLoginName(eName, 1);// 有问题
        //            if (user != null)
        //            {
        //                if (user.Password == oldPwd)
        //                {
        //                    //更新密码
        //                    result = userDal.UpdatePwd(user, newPwd) > 0;
        //                    if (result)
        //                    {
        //                        msg = "更新成功";
        //                    }
        //                    else
        //                    {
        //                        msg = "更新失败";
        //                    }
        //                }
        //                else
        //                {
        //                    msg = "旧密码错误";
        //                }
        //            }
        //            else
        //            {
        //                msg = "账号不存在";
        //            }
        //            return result;
        //        }


        //        /// <summary>
        //        /// 登录
        //        /// </summary>
        //        /// <param name="name"></param>
        //        /// <param name="pwd"></param>
        //        /// <param name="type"></param>
        //        /// <returns></returns>

    }
    }
}
