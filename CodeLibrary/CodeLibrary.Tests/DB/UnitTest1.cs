using System;
using System.Web.WebSockets;
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
            db.Insert("aqa");

        }
    }
}
