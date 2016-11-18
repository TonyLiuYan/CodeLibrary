using System;
using System.Web.WebSockets;
using CodeLibraryDB.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeLibrary.Tests.DB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CodeLibraryDB.DB db = new CodeLibraryDB.DB();
            Content content = db.SelectById(19);

            Assert.AreEqual(content.Id,19);

        }
    }
}
