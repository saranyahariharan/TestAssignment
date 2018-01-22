using System;
using Property.Finder.Test.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Threading;
using System.Windows.Forms;
using Property.Finder.Test.Framework.Common;
using Property.Finder.Test.Framework.Pages;

namespace CrossOverSampleTestProject
{
    [TestClass]
    public class SearchForRentAppartmentsInDubaiMarina : Testbase
    {
        #region TestContext
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        #endregion

        #region Test Method - To Search a rented Appartment and write down the Details - Facts | Amenities | Description
        [TestMethod]
        // To get the Test Data and use it in the Test Method without hard coding the values.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"TestData\TestdataInput.xml", "SearchForRentAppartmentsInDubaiMarinaTC01", DataAccessMethod.Sequential)]
        [Description("This Test Search an Apartment for Rent in ProperyFinder.ae and write the details in a flat file")]
        // Add attributes to get info on the test script
        public void TestId100SearchAndWriteTheInfoOnFlatFile_TC01()
        {
            #region Declaration and Definition
            Driver = TestContext.DataRow["Browser"].ToString();
            Browser = InitializeDriver(getDriverType(Driver));
            TestConfig testConfig = new TestConfig();
            PFHomePage pfHomepage = new PFHomePage(Browser);
            DubaiMarinaSearchResultPage DMResultPage = new DubaiMarinaSearchResultPage(Browser);
            DubaiMarinaResultFactsAmenDesc DMFactAmenDesc = new DubaiMarinaResultFactsAmenDesc(Browser);
            #endregion

            #region Functionality
            // Navigate to Property Finder site
            // Step1: Select the Type of Requirement : 'Rent'.
            // Step2: Select the Property Type : 'Apartment'
            // Step3: Enter the Location : 'Dubai Marina(Dubai)'
            // Step4: Click on 'Find'
            // Verify whether the Next Page is loaded with the Apartment results : Apartments for rent in Dubai Marina
            // Step5: Click on the first result Found
            NavigateToDubaiMarinaResultPage(Browser);

            // Step6: Get All Facts and store in a variable
            Assert.IsTrue(DMFactAmenDesc.PropertyFacts.ControlVisible());
            string data = "Property Title \r\n";
            data += DMFactAmenDesc.PropertyIntro.GetText();
            data += "\r\n Facts \r\n";
            data += DMFactAmenDesc.PropertyFactsTable.GetText();
            data += "\r\n Amenities \r\n";
            data += DMFactAmenDesc.AmenitiesDetails.GetText();
            data += "\r\n Property Description \r\n";
            data += DMFactAmenDesc.Description.GetText();
            if (Directory.Exists("C:\\Test"))
            Directory.CreateDirectory("C:\\Test");
            File.WriteAllLines("C:\\Test\\TestId100SearchAndWriteTheInfoOnFlatFile_TC01.txt", data.Split(new String[] { "\r\n" }, StringSplitOptions.None));
            #endregion
        }

        #endregion

        #region Test Method - To Search a rented Appartment and Change the Currency type and check the updated price
        [TestMethod]
        // To get the Test Data and use it in the Test Method without hard coding the values.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"TestData\TestdataInput.xml", "SearchForRentAppartmentsInDubaiMarinaTC01", DataAccessMethod.Sequential)]
        [Description("This Test Search an Apartment for Rent in ProperyFinder.ae , Change the Currency type and check the updated price")]
        // Add attributes to get info on the test script
        public void TestId101ChangeTheCurrencyAndCheckWhetherUpdatedPriceIsDisplayed_TC02()
        {
            #region Declaration and Definition
            Driver = TestContext.DataRow["Browser"].ToString();
            Browser = InitializeDriver(getDriverType(Driver));
            TestConfig testConfig = new TestConfig();
            PFHomePage pfHomepage = new PFHomePage(Browser);
            DubaiMarinaSearchResultPage DMResultPage = new DubaiMarinaSearchResultPage(Browser);
            DubaiMarinaResultFactsAmenDesc DMFactAmenDesc = new DubaiMarinaResultFactsAmenDesc(Browser);
            #endregion

            #region Functionality
            // Navigate to Property Finder site
            // Step1: Select the Type of Requirement : 'Rent'.
            // Step2: Select the Property Type : 'Apartment'
            // Step3: Enter the Location : 'Dubai Marina(Dubai)'
            // Step4: Click on 'Find'
            // Verify whether the Next Page is loaded with the Apartment results : Apartments for rent in Dubai Marina
            // Step5: Click on the first result Found
            NavigateToDubaiMarinaResultPage(Browser);

            // Step6: Change the Currency Type and check the updated Price
            Assert.IsTrue(DMFactAmenDesc.PropertyFacts.ControlVisible());
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
            js.ExecuteScript("scroll(0,700);");

            Assert.IsTrue(DMFactAmenDesc.GetPrice.GetText().Contains("AED"));
            //Click on EUR
            DMFactAmenDesc.ChangePrice.Click();
            DMFactAmenDesc.CurrencyTypeEUR.Click();
            Assert.IsTrue(DMFactAmenDesc.GetPrice.GetText().Contains("EUR"));

            //Click on INR
            DMFactAmenDesc.ChangePrice.Click();
            DMFactAmenDesc.CurrencyTypeINR.Click();
            Assert.IsTrue(DMFactAmenDesc.GetPrice.GetText().Contains("INR"));

            //Click on USD
            DMFactAmenDesc.ChangePrice.Click();
            DMFactAmenDesc.CurrencyTypeUSD.Click();
            Assert.IsTrue(DMFactAmenDesc.GetPrice.GetText().Contains("USD"));

            
            #endregion
        }

        #endregion

        #region Test Method - To Search a rented Appartment and Send an Email to the Agent
        [TestMethod]
        // To get the Test Data and use it in the Test Method without hard coding the values.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"TestData\TestdataInput.xml", "SearchForRentAppartmentsInDubaiMarinaTC01", DataAccessMethod.Sequential)]
        [Description("This Test Search an Apartment for Rent in ProperyFinder.ae , Change the Currency type and check the updated price")]
        // Add attributes to get info on the test script
        public void TestId102SearchForARentApartmentAndSendAnEmailToAgent_TC03()
        {
            #region Declaration and Definition
            Driver = TestContext.DataRow["Browser"].ToString();
            Browser = InitializeDriver(getDriverType(Driver));
            TestConfig testConfig = new TestConfig();
            PFHomePage pfHomepage = new PFHomePage(Browser);
            DubaiMarinaSearchResultPage DMResultPage = new DubaiMarinaSearchResultPage(Browser);
            DubaiMarinaResultFactsAmenDesc DMFactAmenDesc = new DubaiMarinaResultFactsAmenDesc(Browser);
            #endregion

            #region Functionality
            // Navigate to Property Finder site
            // Step1: Select the Type of Requirement : 'Rent'.
            // Step2: Select the Property Type : 'Apartment'
            // Step3: Enter the Location : 'Dubai Marina(Dubai)'
            // Step4: Click on 'Find'
            // Verify whether the Next Page is loaded with the Apartment results : Apartments for rent in Dubai Marina
            // Step5: Click on the first result Found
            NavigateToDubaiMarinaResultPage(Browser);

            // Step6: Change the Currency Type and check the updated Price
            Assert.IsTrue(DMFactAmenDesc.PropertyFacts.ControlVisible());
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
            js.ExecuteScript("scroll(0,700);");

            // Step7: Click on Email Button
            Assert.IsTrue(DMFactAmenDesc.EmailButton.IsVisible());
            DMFactAmenDesc.EmailButton.Click();

            // Step8: Wait for the Pop up message
            Assert.IsTrue(DMFactAmenDesc.EmailPopup.ControlVisible());
            //Enter the Name, email and mobile number and click on send
            DMFactAmenDesc.EmailTextBox.SetText("Test");
            DMFactAmenDesc.EmailmailidBox.SetText("Test@test.in");
            DMFactAmenDesc.EmailPhoneBox.SetText("12312312321");
            DMFactAmenDesc.EmailSendButton.Click();

            Thread.Sleep(3000);
            Assert.IsTrue(DMFactAmenDesc.EmailSentMessage.ControlVisible());




            #endregion
        }

        #endregion

        #region Test Cleanup to close the deafult Browser
        [TestCleanup]
        public void CloseDriver()
        {
            if (Browser != null)
            {
                Browser.Close();
            }
        }
        #endregion

        #region Test Method Helpers

        private void NavigateToDubaiMarinaResultPage(IWebDriver Browser)
        {

            TestConfig testConfig = new TestConfig();
            PFHomePage pfHomepage = new PFHomePage(Browser);
            DubaiMarinaSearchResultPage DMResultPage = new DubaiMarinaSearchResultPage(Browser);
            DubaiMarinaResultFactsAmenDesc DMFactAmenDesc = new DubaiMarinaResultFactsAmenDesc(Browser);
            Browser.Url = testConfig.HomeUrl;

            // Step1: Select the Type of Requirement : 'Rent'.
            pfHomepage.FindTypeDropDownButton.Click();
            pfHomepage.FindTypeRent.Click();

            // Step2: Select the Property Type : 'Apartment'
            pfHomepage.PropertyTypeDropDownButton.Click();
            pfHomepage.PropertyTypeApartment.Click();

            // Step3: Enter the Location : 'Dubai Marina(Dubai)'
            pfHomepage.SearchCity.SetText("Dubai Marina (Dubai)");

            // Step4: Click on 'Find'
            pfHomepage.FindButton.Click();

            // Verify whether the Next Page is loaded with the Apartment results : Apartments for rent in Dubai Marina
            Assert.IsTrue(DMResultPage.ResultTitle.ControlVisible());
            Assert.IsTrue(DMResultPage.ResultTitle.GetText().Contains("Apartments for rent in Dubai Marina"));

            // Step5: Click on the first result Found
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
            js.ExecuteScript("scroll(0,250);");
            DMResultPage.FirstResultItem.Click();
        }
    #endregion
    }
}
