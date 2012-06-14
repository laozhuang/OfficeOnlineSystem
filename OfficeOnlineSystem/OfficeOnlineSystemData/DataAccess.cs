using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using OfficeOnlineSystem;

namespace OfficeOnlineSystemData
{
    public class DataAccess
    {
        public File GetFileById(int id)
        {
            ISessionFactory sessionFactory = (new Configuration()).Configure().BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            return session.Get<File>(id);
        }
    }
}
