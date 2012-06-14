using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using DataTransfer;

namespace BLL
{
    public class UserBL
    {
        private UserQueryHql helperU = new UserQueryHql();

        /// <summary>
        /// 根据username取得user
        /// </summary>
        /// <param name="name"></param>
        public User GetUserByName(string name)
        {
            return helperU.GetUserByUserName(name);
        }
    }
}
