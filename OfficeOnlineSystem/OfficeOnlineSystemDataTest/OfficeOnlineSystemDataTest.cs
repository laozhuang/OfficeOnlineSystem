using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;
using OfficeOnlineSystemData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OfficeOnlineSystemDataTest
{
    []
      public class Tests
      {
        [Test]
        public void GetFileByIdTest()
        {
            OfficeOnlineSystemData.DataAccess provider = new OfficeOnlineSystemData.DataAccess();

            Assert.AreEqual(1, provider.GetFileById(1).id);
        }
      }
}
