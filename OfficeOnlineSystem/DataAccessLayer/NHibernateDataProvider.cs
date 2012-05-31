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



    }
}
