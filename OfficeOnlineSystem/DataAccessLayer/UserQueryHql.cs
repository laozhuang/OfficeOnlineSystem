using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using DataTransfer;

namespace DataAccessLayer
{
    public class UserQueryHql : NHibernateDataProviderHelper
    {
        protected ISession _session { get; set; }

        public UserQueryHql()
        {
            _session = this.GetSession();
        }


        public void CreateUser(User tempUser)
        {
            _session.Save(tempUser);
            _session.Flush();
        }


        public IList<User> GetAllUser()
        {
            //返回所有User类的实例
            return _session.CreateQuery("from User").List<User>();
        }



        /***
         * 获取所有用户的username
         */
        public IList<string> GetAllUserName()
        {
            return _session.CreateQuery("select u.username from User u").List<string>();
        }

        public User GetUserByUserName(string uname)
        {
            
            IList<User> list =  _session.CreateQuery("from User u where u.username=:un").SetString("un",uname).List<User>();
            if (list.Count != 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }



        public bool IsUserExist(string uname)
        {
            IList<User> list = _session.CreateQuery("from User u where u.username=:un").SetString("un", uname).List<User>();
            if (list.Count != 0)
                return true;
            else

                return false;
        }


        public void DeleteUser(User user)
        {
            _session.Delete(user);
            _session.Flush();
        }


        public void UpdateUser(User user)
        {
            _session.Update(user);
            _session.Flush();
        }
    }
}
