using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;

namespace Property.Finder.Test.Framework.Common
{
    /// <summary>
    /// Wrapper for Selenium Button Controllers
    /// </summary>
    public class SeleniumButton
    {
        private By findelement;
        private IWebDriver broswerDriver;

        public SeleniumButton(By byelement, IWebDriver driver)
        {
            this.findelement = byelement;
            this.broswerDriver = driver;
        }

        public void Click()
        {
            broswerDriver.FindElement(findelement).Click();
        }

        public void DoubleClick()
        {
            try
            {
                IWebElement webElement = broswerDriver.FindElement(findelement);
                Actions action = new Actions(broswerDriver).DoubleClick(webElement);
                action.Build().Perform();
            }
            catch (StaleElementReferenceException e)
            {
                throw new Exception("Element is not attached to the page document "
                                   + e.ToString());
            }
            catch (NoSuchElementException e)
            {
                throw new Exception("Element was not found in DOM "
                                   + e.ToString());
            }
            catch (Exception e)
            {
               throw new Exception("Element was not clickable "
                                   + e.ToString());
            }
        }

        public string GetButtonName()
        {
            return broswerDriver.FindElement(findelement).Text;
        }

        public bool IsVisible(Enumerations.ControlWait controlWait = Enumerations.ControlWait.Average)
        {
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            // Waiting for Timeout defined in the ControlWait property
            while (!(broswerDriver.FindElements(findelement).Count > 0) &&
                   Timer.ElapsedMilliseconds < (int)controlWait * 1000)
            {

            }
            if (broswerDriver.FindElements(findelement).Count > 0)
                return true;
            return false;
        }
    }
}
