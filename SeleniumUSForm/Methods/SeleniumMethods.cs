using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumUSForm.Methods
{
    public static class SeleniumMethods
    {
        private static IWebElement element;
        public static IWebDriver ConfigureDriver(IWebDriver driver, string driverType, string driverPath)
        {
            switch(driverType)
            {
                case "chrome":
                    {
                        driver = new ChromeDriver(driverPath);
                        //driver.Manage().Window.Maximize();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5);
                        return driver;
                    }
                case "firefox":
                    {
                        driver = new FirefoxDriver(driverPath);
                        //driver.Manage().Window.Maximize();
                        return driver;
                    }
            }
            return driver;
        }

        public static IWebDriver GoToWebsite(IWebDriver driver, string websiteURL)
        {
            driver.Navigate().GoToUrl(websiteURL);
            return driver;
        }

        public static void PickAndFillWebElementByXPath(IWebDriver driver, string elementXPath, string text)
        {
            element = driver.FindElement(By.XPath(elementXPath));
            element.Clear();
            element.SendKeys(text);
        }

        public static void PickAndClickWebElementByXPath(IWebDriver driver, string elementXPath)
        {
            element = driver.FindElement(By.XPath(elementXPath));
            element.Click();
        }

        public static void SetCheckBoxByXPath(IWebDriver driver, string elementXPath, bool newStatus)
        {
            element = driver.FindElement(By.XPath(elementXPath));
            if(newStatus)
            {
                if (element.Selected == false)
                {
                    element.Click();
                }
            }else
            {
                if (element.Selected == true)
                {
                    element.Click();
                }
            }
        }


    }
}
