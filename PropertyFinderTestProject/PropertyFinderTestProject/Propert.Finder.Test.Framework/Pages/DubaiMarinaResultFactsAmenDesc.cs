using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property.Finder.Test.Framework.Common;
using OpenQA.Selenium;

namespace Property.Finder.Test.Framework.Pages
{
    /// <summary>
    /// POM implementation - Dubai Marina Search Result Page
    /// </summary>
    public class DubaiMarinaResultFactsAmenDesc
    {
        #region Initialize
       
        public SeleniumControl PropertyIntro { get; private set; }
        public SeleniumControl PropertyFacts { get; private set; }
        public SeleniumControl PropertyFactsTable { get; private set; }
        public SeleniumControl Amenities { get; private set; }
        public SeleniumControl AmenitiesDetails { get; private set; }
        public SeleniumControl Description { get; private set; }
        public SeleniumControl GetPrice { get; private set; }
        public SeleniumControl ChangePrice { get; private set; }
        public SeleniumControl CurrencyTypeEUR { get; private set; }
        public SeleniumControl CurrencyTypeINR { get; private set; }
        public SeleniumControl CurrencyTypeUSD { get; private set; }
        public SeleniumButton EmailButton { get; private set; }
        public SeleniumControl EmailPopup { get; private set; }
        public SeleniumTextBox EmailTextBox { get; private set; }
        public SeleniumTextBox EmailmailidBox { get; private set; }
        public SeleniumTextBox EmailPhoneBox { get; private set; }
        public SeleniumButton EmailSendButton { get; private set; }
        public SeleniumControl EmailSentMessage { get; private set; }
        #endregion

        #region Constructor

        public DubaiMarinaResultFactsAmenDesc(IWebDriver driver)
        {
            this.PropertyIntro = new SeleniumControl(By.XPath("//*[@id='property-intro']"), driver);
            this.PropertyFacts = new SeleniumControl(By.XPath("//*[@id='property-facts']"),driver);
            this.PropertyFactsTable = new SeleniumControl(By.XPath("//*[@id='property-facts']/table[@class='fixed-table']/tbody"),driver);
            this.Amenities = new SeleniumControl(By.XPath("//*[@id='property-amenities']"),driver); 
            this.AmenitiesDetails = new SeleniumControl(By.XPath("//*[@id='property-amenities']/ul[@class='amenities-list']"),driver);
            this.Description = new SeleniumControl(By.XPath("//*[@id='page-content']"), driver);
            this.GetPrice = new SeleniumControl(By.XPath("//*[@id=\"property-facts\"]/table/tbody/tr[1]/td"), driver);
            this.ChangePrice = new SeleniumControl(By.XPath("//*[@id=\"contact-info-container\"]/div[2]/div/div[2]/div[1]/button[@class='ms-choice']"), driver);
            this.CurrencyTypeEUR = new SeleniumControl(By.XPath("//*[@id=\"contact-info-container\"]/div[2]/div/div[2]/div[1]/div/ul/li[@data-value='EUR']"), driver);
            this.CurrencyTypeINR = new SeleniumControl(By.XPath("//*[@id=\"contact-info-container\"]/div[2]/div/div[2]/div[1]/div/ul/li[@data-value='INR']"), driver);
            this.CurrencyTypeUSD = new SeleniumControl(By.XPath("//*[@id=\"contact-info-container\"]/div[2]/div/div[2]/div[1]/div/ul/li[@data-value='USD']"), driver);
            this.EmailButton = new SeleniumButton(By.XPath("//*[@id=\"contact-info-container\"]/div[2]/ul/li[@class='hide-on-print']"), driver);
            this.EmailPopup = new SeleniumControl(By.XPath("//*[@id=\"contact-form-popup\"]"), driver);
            this.EmailTextBox = new SeleniumTextBox(By.XPath("//*[@id=\"popup-content\"]/form/div[2]/input[@name='name']"), driver);
            this.EmailmailidBox = new SeleniumTextBox(By.XPath("//*[@id=\"popup-content\"]/form/div[@class='email']"), driver);
            this.EmailPhoneBox = new SeleniumTextBox(By.XPath("//*[@id=\"popup-content\"]/form/div[@class='phone']/div/input"), driver);
            this.EmailSendButton = new SeleniumButton(By.XPath("//*[@id=\"popup-content\"]/form/input[@type='submit']"), driver);
            this.EmailSentMessage = new SeleniumControl(By.XPath("//*[@id=\"message-popup\"]/div/div[.='Thank you']"), driver);

        }
        #endregion

    }
}
