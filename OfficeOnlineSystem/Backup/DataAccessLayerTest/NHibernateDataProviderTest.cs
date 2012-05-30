using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;

namespace DataAccessLayerTest
{
    [TestFixture]
    public class NHibernateDataProviderTest
    {
        [Test]
        public void CanGetCustomerById()
        {
            DataAccessLayer.NHibernateDataProvider provider = new DataAccessLayer.NHibernateDataProvider();

            Assert.AreEqual(1, provider.GetCustomerById(1).CustomerId);
        }
    }
}
