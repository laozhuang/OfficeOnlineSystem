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
        protected ISession _session { get; set; }

        public NHibernateDataProvider(ISession session)
        {
            _session = session;
        }

        public Customer GetCustomerById(int customerId)
        {

            ISessionFactory _sessionFactory = (new Configuration()).Configure().BuildSessionFactory();

            _session = _sessionFactory.OpenSession();
            //session.Close();
            return _session.Get<Customer>(customerId);
            
        }


        public void CreateCustomer(Customer tempCutomer)
        {
            _session.Save(tempCutomer);
            _session.Flush();
        }


        public void CreateUser(User tempUser)
        {
            _session.Save(tempUser);
            _session.Flush();
        }

        public void CreateFile(Post_file postfile)
        {
            _session.Save(postfile);
            _session.Flush();
        }
        public void CreateTreatFile(Treat_file treatfile)
        {
            _session.Save(treatfile);
            _session.Flush();
        }
    }
}
