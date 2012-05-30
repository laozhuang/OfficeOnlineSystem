using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using MbUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataTransfer;
using DataAccessLayer;
//using NUnit.Framework;


namespace OfficeOnlineSystemTest
{
    [TestClass]
    public class NHibernateDataProviderTest
    {
        private NHibernateDataProvider provider;
        private NHibernateDataProviderHelper helper;
        public NHibernateDataProviderTest()
        {
            helper = new NHibernateDataProviderHelper();
            provider = new NHibernateDataProvider(helper.GetSession());

        }



        [TestMethod]
        public void CreateUserTest()
        {
            var tempUser = new User { username = "aoao", password = "123", email = "123@abc.com", office_id = 3 };
            provider.CreateUser(tempUser);

        }

        [TestMethod]
        public void CreatePostFile()
        {
            var postfile = new Post_file { title = "1", content = "2", status = 0, username = "hs撒地方dc" };
            provider.CreateFile(postfile);
        }

        [TestMethod]
        public void CreateTreatFile()
        {
            var treatfile = new Treat_file { title = "1", content = "2", status = 1, username = "aoao" };
            provider.CreateTreatFile(treatfile);
        }
        [TestMethod]
        public void GetUserByName()
        {
            User u = provider.GetUserByName("hsdc");
            int o = u.office_id;
            Assert.AreEqual(3, o);
 
        }
    }
}
