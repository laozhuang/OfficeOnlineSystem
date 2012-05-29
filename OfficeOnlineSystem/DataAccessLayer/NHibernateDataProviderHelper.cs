using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace DataAccessLayer
{
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
