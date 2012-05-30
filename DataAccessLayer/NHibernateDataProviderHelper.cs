using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace DataAccessLayer
{
    //辅助类NHibernateHelper 用于创建ISessionFactory并配置ISessionFactory和打开一个新的Session单线程的方法，
    //之后在每个数据操作类可以使用这个辅助类创建ISession 。
    public class NHibernateDataProviderHelper
    {
        private ISessionFactory _sessionFactory;
        public NHibernateDataProviderHelper()
        {
            _sessionFactory = GetSessionFactory();
        }

        private ISessionFactory GetSessionFactory()
        {
            return (new Configuration()).Configure().BuildSessionFactory();
        }

        public ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
