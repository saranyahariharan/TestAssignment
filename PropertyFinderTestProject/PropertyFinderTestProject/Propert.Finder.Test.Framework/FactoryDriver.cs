using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace Property.Finder.Test.Framework
{
    /// <summary>
    /// Factory Design Pattern Implementation to return the run time driver instance based on the Test Settings.
    /// </summary>
    public class FactoryDriver 
    {
        public IWebDriver InitializeDriver(Enumerations.Driver driverType)
        {
            IWebDriver _driver = null;
            switch (driverType)
            {
                case Enumerations.Driver.Chrome:
                    _driver = new ChromeDriver(@"External");
                    break;
                case Enumerations.Driver.InternetExplorer:
                    _driver = new InternetExplorerDriver(@"External");
                    break;
                case Enumerations.Driver.Safari:
                    _driver = new SafariDriver(@"External");
                    break;
                case Enumerations.Driver.FireFox:
                    _driver = new FirefoxDriver();
                    break;
            }
            return _driver;
        }
        
    }
}
