using System;
using System.IO;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplicationMath.Test.Project
{
    [TestClass]
    public class Addition
    {
        #region TestContext
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        #endregion

        #region Tests
        /// <summary>
        /// This Test validates the Addition feature of the Console App Math project
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"TestData\Addition.xml", "Test_Addition_TC01", DataAccessMethod.Sequential)]
        [Description("This Test validates the Addition feature of the Console App Math project")]
        public void Test_Addition_TC01()
        {
            int Number1 = Convert.ToInt16(TestContext.DataRow["Number1"]);
            int Number2 = Convert.ToInt16(TestContext.DataRow["Number2"]);
            int ExpectedResult = Convert.ToInt16(TestContext.DataRow["Result"]);

            int ActualResult = new ConsoleApplicationForMath.Program().Addition(Number1, Number2);

            //Asserting the Result
            Assert.AreEqual(ExpectedResult, ActualResult, "The addition result is not the expected one");

        }
        #endregion
    }
}
