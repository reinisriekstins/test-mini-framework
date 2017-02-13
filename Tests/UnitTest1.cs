using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
