using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using DataTransfer;
using System.Collections;
namespace OfficeOnlineSystemTest
{
    /// <summary>
    /// FileBLL 的摘要说明
    /// </summary>
    [TestClass]
    public class FileBLL
    {
       private  FileBL fileBL;
        public FileBLL()
        {

            //
            //TODO: 在此处添加构造函数逻辑
            //
             fileBL = new FileBL();

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
        public void GetAllTFileUTest()
        {

            //
            // TODO: 在此处添加测试逻辑
            //
            IList<Treat_file> list = fileBL.GetAllTFileU();
            Assert.IsNotNull(list);
            
        }

        [TestMethod]
        public void GetAllTFileATest()
        {
            IList<Treat_file> list = fileBL.GetAllTFileA();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetAllPFileTest()
        {
            IList<Post_file> list = fileBL.GetAllPFile();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetAllSemiFileTest()
        {
            IList<Post_file> list = fileBL.GetAllSemiFile();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetTFileByIdTest()
        {
            Treat_file tFile = fileBL.GetTFileById(18);
            Assert.AreEqual(tFile.id, 18);
        }

        [TestMethod]
        public void GetPFileByIdTest()
        {
            Post_file pFile = fileBL.GetPFileById(14);
            Assert.AreEqual(pFile.id, 14);
        }

        [TestMethod]
        public void GetPFileByNameTest()
        {
            string name = "hs撒地方dc";
            IList<Post_file> list = fileBL.GetPFileByName(name);
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetTFileByNameTest()
        {
            string name = "hs撒地方dc";
            IList<Treat_file> list = fileBL.GetTFileByName(name);
            Assert.IsNotNull(list);
 
        }

        [TestMethod]
        public void GetSemiFileByNameTest()
        {
            string name = "hs撒地方dc";
            IList<Post_file> list = fileBL.GetSemiFileByName(name);
            Assert.IsNotNull(list);
 
        }


    }
}
