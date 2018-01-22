using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Property.Finder.Test.Framework.Common
{
    /// <summary>
    /// The Class is wrapper for selenium control and Holds the porperties of TestBox
    /// </summary>
    public class SeleniumTextBox
    {
        private By findelement;
        private IWebDriver broswerDriver;

        public SeleniumTextBox(By byelement, IWebDriver driver)
        {
            this.findelement = byelement;
            this.broswerDriver = driver;
        }

        public void SetText(string text)
        {
            broswerDriver.FindElement(findelement).SendKeys(text);
        }

        public string GetText()
        {
            return broswerDriver.FindElement(findelement).Text;
        }

        public bool IsVisible(Enumerations.ControlWait controlWait = Enumerations.ControlWait.Average)
        {
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            // Waiting for Timeout defined in the ControlWait property
            while (!(broswerDriver.FindElements(findelement).Count > 0) &&
                   Timer.ElapsedMilliseconds < (int) controlWait * 1000)
            {

            }
            if (broswerDriver.FindElements(findelement).Count > 0)
                return true;
            return false;
        }

    }
}
