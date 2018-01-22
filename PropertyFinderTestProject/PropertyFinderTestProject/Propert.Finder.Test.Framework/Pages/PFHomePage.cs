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
    /// POM implementation - Property Finder Home Page
    /// </summary>
    public class PFHomePage
    {
        #region Initialize
       
        public SeleniumControl FindTypeDropDownButton { get; private set; }
        public SeleniumControl FindTypeRent { get; private set; }
        public SeleniumControl PropertyTypeDropDownButton { get; private set; }
        public SeleniumControl PropertyTypeApartment { get; private set; }
        public SeleniumTextBox SearchCity { get; private set;}
        public SeleniumButton FindButton { get; private set; }

        #endregion

        #region Constructor

        public PFHomePage(IWebDriver driver)
        {
            this.FindTypeDropDownButton = new SeleniumControl(By.XPath("//form[@id=\"search-form-property\"]/div[3]/div[2]/div/button[@class=\'ms-choice\']"),driver);
            this.FindTypeRent = new SeleniumControl(By.XPath("//*[@id=\"search-form-property\"]/div[3]/div[2]/div/div/ul/li[.=\"Rent\"]"),driver);
            this.PropertyTypeDropDownButton = new SeleniumControl(By.XPath("//*[@id=\"search-form-property\"]/div[4]/div/div[1]/div/button/Span[.='Property type']"), driver);
            this.PropertyTypeApartment = new SeleniumControl(By.XPath("//*[@id=\"search-form-property\"]/div[4]/div/div[1]/div/div/ul/li[.='Apartment']"), driver);
            this.SearchCity = new SeleniumTextBox(By.XPath("//input[@name='q' and @type='search']"), driver);
            this.FindButton = new SeleniumButton(By.XPath("//button[@type='submit']/div[.='Find']"), driver);
            
        }
        #endregion

        #region Helpers

        public void FetchThePreviousContentCreated(string postTitle,IWebDriver browser)
        {
            //ContentFirstListControl = new SeleniumButton(By.XPath("//section[contains(@class,\'content-list-content\')]//li[contains(@class,\"ember-view\")]//h3[contains(text(),\'"+postTitle+"\')]"), browser);
        }

        #endregion
    }
}
