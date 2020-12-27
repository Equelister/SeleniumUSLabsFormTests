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
    public class SeleniumTestsCheckElements
    {
        private IWebDriver _driver;

        [SetUp]
        public void BeforeTests()
        {
            _driver = SeleniumMethods.ConfigureDriver(_driver, "chrome", SeleniumParameters.ChromeWebDriverPath);
        }

        [Test]
        public void IsFirstNameInputPresent()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            if(SeleniumMethodsCheckElement.IsElementPresentXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath) == false)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void IsLastNameInputPresent()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            if (SeleniumMethodsCheckElement.IsElementPresentXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath) == false)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void IsDateInputPresent()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            if (SeleniumMethodsCheckElement.IsElementPresentXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath) == false)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void IsParentsCheckBoxPresent()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            if (SeleniumMethodsCheckElement.IsElementPresentXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath) == false)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void IsDoctorCheckBoxPresent()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            if (SeleniumMethodsCheckElement.IsElementPresentXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath) == false)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void IsSubmitButtonPresent()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            if (SeleniumMethodsCheckElement.IsElementPresentXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath) == false)
            {
                Assert.Fail();
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
            _driver.Dispose();
        }
    }
}
