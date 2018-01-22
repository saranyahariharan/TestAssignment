using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Property.Finder.Test.Framework.Common
{
    /// <summary>
    /// The Class is wrapper for selenium control
    /// </summary>
    public class SeleniumControl
    {
        private By findelement;
        private IWebDriver broswerDriver;

        public SeleniumControl(By byelement, IWebDriver driver)
        {
            this.findelement = byelement;
            this.broswerDriver = driver;
        }
        public void Click()
        {
            broswerDriver.FindElement(findelement).Click();
        }

        public bool ControlVisible()
        {
            if (broswerDriver.FindElements(findelement).Count > 0)
                return true;
            return false;

        }

        public string GetText()
        {
            return broswerDriver.FindElement(findelement).Text;
        }

        public bool WaitForControlVisible(Enumerations.ControlWait controlWait = Enumerations.ControlWait.Average)
        {
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            // Waiting for Timeout defined in the ControlWait property
            while (!ControlVisible() && Timer.ElapsedMilliseconds < (int) controlWait * 1000) 
            {
                
            }
            if (ControlVisible())
            {
                return true;
            }
            else
            {
                throw new Exception("The Control "+ findelement + "is not found for a timeout of Control wait - " + controlWait + " Secs waited - " + (int) controlWait);
            }

        }
    }
}
