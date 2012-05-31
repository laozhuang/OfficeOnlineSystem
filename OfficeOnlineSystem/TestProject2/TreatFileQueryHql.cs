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
    /// TreatFileQueryHql 的摘要说明
    /// </summary>
    [TestClass]
    public class TreatFileQueryHql
    {
        
        Treat_fileQueryHql treatFileQueryHql;
        public TreatFileQueryHql()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
            
            treatFileQueryHql = new Treat_fileQueryHql();
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
        public void GetAllTreatFileTest()
        {
            //
            // TODO: 在此处添加测试逻辑
            //
            IList<Treat_file> listFile = treatFileQueryHql.GetAllPost_file();
            Assert.IsNotNull(listFile);
        }

        [TestMethod]
        public void IsTreatFileExistText()
        {
            int id = 100;
            bool b = treatFileQueryHql.IsTFileExist(id);
            Assert.IsFalse(b);
        }

        [TestMethod]
        public void DeleteTFileTest()
        {
            var file = treatFileQueryHql.GetTreat_fileByID(10);
            treatFileQueryHql.DeleteTreat_file(file);
            var testFile = treatFileQueryHql.GetTreat_fileByID(10);
            Assert.IsNull(testFile);
        }

        [TestMethod]
        public void UpdateTreat_fileTest()
        {
            var file = treatFileQueryHql.GetTreat_fileByID(11);
            file.title = "你好";
            treatFileQueryHql.UpdateTreat_file(file);
            var testFile = treatFileQueryHql.GetTreat_fileByID(11);
            Assert.AreEqual("你好",testFile.title);
        }
    }
}
