using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.BLL
{
    class ManagerBLL
    {
        string id = "2018112558";
        string pwd = "2018112558";
        public bool ManagerLogin(string id, string pwd )
        {

            if (this.pwd == pwd&&this.id ==id)
            { return true; }

            return false ;

        }

    }
}
