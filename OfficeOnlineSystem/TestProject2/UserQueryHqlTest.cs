using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using DataTransfer;

namespace OfficeOnlineSystemTest
{
    /// <summary>
    /// UnitTest2 的摘要说明
    /// </summary>
    [TestClass]
    public class UnitTest2
    {

        UserQueryHql userQueryHql;
        public UnitTest2()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //

            userQueryHql = new UserQueryHql();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetAllUserTest()
        {
            //
            // TODO: 在此处添加测试逻辑
            //
            IList<User> list = userQueryHql.GetAllUser();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetAllUserNameTest()
        {
            IList<string> listUName = userQueryHql.GetAllUserName();
            Assert.IsNotNull(listUName);
        }

        [TestMethod]
        public void GetUserByUsernameTest()
        {
            string uname = "abcd";
            var u = userQueryHql.GetUserByUserName(uname);
            Assert.IsNull(u);
        }




        [TestMethod]
        public void IsUserExistTest()
        {
            string uname = "abcd";
            bool b = userQueryHql.IsUserExist(uname);
            Assert.IsFalse(b);
        }

        [TestMethod]
        public void DeleteUserTest()
        {
            var user = userQueryHql.GetUserByUserName("abc");
            userQueryHql.DeleteUser(user);
            var testUser = userQueryHql.GetUserByUserName("abc");
            Assert.IsNull(testUser);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            var user = userQueryHql.GetUserByUserName("adc");
            user.email = "adc@123.com";
            userQueryHql.UpdateUser(user);
            var testUser = userQueryHql.GetUserByUserName("adc");
            Assert.AreEqual("adc@123.com", testUser.email);
        }

    }
}
