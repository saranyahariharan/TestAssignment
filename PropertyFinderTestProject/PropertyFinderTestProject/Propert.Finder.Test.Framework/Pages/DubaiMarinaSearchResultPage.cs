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
    public class DubaiMarinaSearchResultPage
    {
        #region Initialize
       
        public SeleniumControl ResultTitle { get; private set; }
        public SeleniumControl FirstResultItem { get; private set; }

        #endregion

        #region Constructor

        public DubaiMarinaSearchResultPage(IWebDriver driver)
        {
            this.ResultTitle = new SeleniumControl(By.XPath("//*[@id=\"serp-nav\"]/div[@class='title-sort-area']"),driver);
            this.FirstResultItem = new SeleniumControl(By.XPath("//*[@class='info-container']/h2/a[1]"),driver);
            
        }
        #endregion

    }
}
