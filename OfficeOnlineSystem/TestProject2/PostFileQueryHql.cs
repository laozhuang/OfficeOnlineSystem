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
    /// PostFileQueryHql 的摘要说明
    /// </summary>
    [TestClass]
    public class PostFileQueryHql
    {
        
        Post_fileQueryHql postFileQueryHql;


        public PostFileQueryHql()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
            
            postFileQueryHql = new Post_fileQueryHql();

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
        public void GetAllPostFileTest()
        {
            //
            // TODO: 在此处添加测试逻辑
            //
            IList<Post_file> listFile = postFileQueryHql.GetAllPost_file();
            Assert.IsNotNull(listFile);
        }

        [TestMethod]
        public void IsPFileExistTest()
        {
            int fileID = 10;
            bool b = postFileQueryHql.IsPFileExits(fileID);
            Assert.IsTrue(b);
        }

        [TestMethod]
        public void DeletePFileTest()
        {
            var file = postFileQueryHql.GetPost_fileById(10);
            postFileQueryHql.DeletePost_file(file);
            var testFile = postFileQueryHql.GetPost_fileById(10);
            Assert.IsNull(testFile);
        }

        [TestMethod]
        public void UpdatePFileTest()
        {
            var file = postFileQueryHql.GetPost_fileById(11);
            file.title = "你好";
            postFileQueryHql.UpdatePost_file(file);
            var testFile = postFileQueryHql.GetPost_fileById(11);
            Assert.AreEqual("你好", testFile.title);
        }
    }
}
