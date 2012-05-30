using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate;
using DataTransfer;

namespace DataAccessLayer
{
    public class NHibernateDataProvider
    {

        public Customer GetCustomerById(int customerId)
        {
            ISessionFactory sessionFactory = (new Configuration()).Configure().BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            return session.Get<Customer>(customerId);
        }

    }
}
