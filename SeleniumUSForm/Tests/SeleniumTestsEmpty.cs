using OpenQA.Selenium;
using SeleniumUSForm.Methods;
using SeleniumUSForm.Parameters;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumUSForm.Tests
{
    public class SeleniumTestsEmpty
    {
        private IWebDriver _driver;

        [SetUp]
        public void BeforeTests()
        {
            _driver = SeleniumMethods.ConfigureDriver(_driver, "chrome", SeleniumParameters.ChromeWebDriverPath);
        }

        [Test]
        public void FirstNameEmptyAlert0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.FirstNameEmptyErrorString);
            _driver.SwitchTo().Alert().Accept();
        }
        [Test]
        public void FirstNameEmptyAlert1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Atok am ala");
            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.FirstNameEmptyErrorString);
            _driver.SwitchTo().Alert().Accept();
        }
        [Test]
        public void FirstNameEmptyAlert2()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Atok am ala");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "01-01-2000");
           SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.FirstNameEmptyErrorString);
            _driver.SwitchTo().Alert().Accept();
        }
        [Test]
        public void FirstNameEmptyAlert3()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "01-01-2000");
            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.FirstNameEmptyErrorString);
            _driver.SwitchTo().Alert().Accept();
        }


        [Test]
        public void LastNameEmptyAlert0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Ala ma kota");
            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.LastNameEmptyErrorString);
            _driver.SwitchTo().Alert().Accept();
        }
        [Test]
        public void LastNameEmptyAlert1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Ala ma kota");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "01-01-2000");
            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.LastNameEmptyErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEmptyAlert()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Ala ma kota");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Atok am ala");
            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DateEmptyErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
            _driver.Dispose();
        }
    }
}
