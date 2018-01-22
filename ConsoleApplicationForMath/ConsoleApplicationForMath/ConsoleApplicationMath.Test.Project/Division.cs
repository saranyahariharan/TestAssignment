using System;
using System.IO;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplicationMath.Test.Project
{
    [TestClass]
    public class Division
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
        /// This Test validates the Division feature of the Console App Math project
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"TestData\Division.xml", "Test_Division_TC01", DataAccessMethod.Sequential)]
        [Description("This Test validates the Division feature of the Console App Math project")]
        public void Test_Division_TC01()
        {
            int Number1 = Convert.ToInt16(TestContext.DataRow["Number1"]);
            int Number2 = Convert.ToInt16(TestContext.DataRow["Number2"]);
            var ExpectedResult =TestContext.DataRow["Result"].ToString();

            var ActualResult = new ConsoleApplicationForMath.Program().Devision(Number1, Number2);

            //Asserting the Result
            Assert.AreEqual(ExpectedResult, ActualResult, "The addition result is not the expected one");

        }

        /// <summary>
        /// This Test validates the Division feature of the Console App Math project - Division by 0
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"TestData\Division.xml", "Test_Division_TC02", DataAccessMethod.Sequential)]
        [Description("This Test validates the Division feature of the Console App Math project")]
        public void Test_Division_TC02()
        {
            int Number1 = Convert.ToInt16(TestContext.DataRow["Number1"]);
            int Number2 = Convert.ToInt16(TestContext.DataRow["Number2"]);
            var ExpectedResult = "Attempted to divide by zero.";

            var ActualResult = new ConsoleApplicationForMath.Program().Devision(Number1, Number2);

            //Asserting the Result
            Assert.IsTrue(ActualResult.Contains(ExpectedResult));

        }
        #endregion
    }
}
