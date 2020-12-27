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
    public class SeleniumTestsBoundaryMethod
    {
        private IWebDriver _driver;

        [SetUp]
        public void BeforeTests()
        {
            _driver = SeleniumMethods.ConfigureDriver(_driver, "chrome", SeleniumParameters.ChromeWebDriverPath);
        }

        [Test]
        public void DateBoundaryMethodNotClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "01-01-2019");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodNotClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "31-12-2019");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodMlodzik0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "31-12-2010");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsMlodzikString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodMlodzik1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "01-01-2010");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsMlodzikString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodJunior0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "01-01-2006");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsJuniorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodJunior1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "31-12-2006");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsJuniorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodDorosly0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "31-12-2002");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodDorosly1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "01-01-2002");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodSenior0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "01-01-1955");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsSeniorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateBoundaryMethodSenior1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaGranicznie");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "31-12-1955");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsSeniorString);
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
