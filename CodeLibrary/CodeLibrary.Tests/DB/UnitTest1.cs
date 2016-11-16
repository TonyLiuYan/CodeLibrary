using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeLibrary.Tests.DB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CodeLibraryDB.DB DB=new CodeLibraryDB.DB();
            DB.Open();
        }
    }
}
