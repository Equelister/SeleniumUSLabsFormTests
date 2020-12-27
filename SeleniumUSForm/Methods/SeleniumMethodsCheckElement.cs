using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumUSForm.Methods
{
    class SeleniumMethodsCheckElement
    {
        public static bool IsElementPresentXPath(IWebDriver driver, string elementXPath)
        {
            try
            {
                driver.FindElement(By.XPath(elementXPath));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
