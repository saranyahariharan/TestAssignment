using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Property.Finder.Test.Framework
{
    /// <summary>
    /// Test base for all Test Classes
    /// </summary>
    public class Testbase : FactoryDriver
    {
        #region Initialize

        /// <summary>
        /// Driver instance
        /// </summary>
        public string Driver { get; set ; }

        public IWebDriver Browser;

        /// <summary>
        /// returns the enum type of available drivers under this test framework 
        /// </summary>
        /// <param name="_driver"></param>
        /// <returns></returns>
        public Enumerations.Driver getDriverType(string _driver)
        {
            switch (_driver)
            {
                case "Chrome":
                    return Enumerations.Driver.Chrome;
                case "chrome":
                    return Enumerations.Driver.Chrome;
                case "IE":
                    return Enumerations.Driver.InternetExplorer;
                case "InternetExplorer":
                    return Enumerations.Driver.InternetExplorer;
                case "FF":
                    return Enumerations.Driver.FireFox;
                case "FireFox":
                    return Enumerations.Driver.FireFox;
                case "firefox":
                    return Enumerations.Driver.FireFox;
                case "Safari":
                    return Enumerations.Driver.Safari;
                case "safari":
                    return Enumerations.Driver.Safari;
                default:
                    return Enumerations.Driver.Chrome;
            }
        }
        #endregion
    }
}
