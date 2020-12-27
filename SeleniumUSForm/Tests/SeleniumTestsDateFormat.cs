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
    public class SeleniumTestsDateFormat
    {
        private IWebDriver _driver;

        [SetUp]
        public void BeforeTests()
        {
            _driver = SeleniumMethods.ConfigureDriver(_driver, "chrome", SeleniumParameters.ChromeWebDriverPath);
        }

        [Test]
        public void DateFormatClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15 06 2000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatClassified2()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15.06.2000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15,06,2000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15062000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified2()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "Piętnasty Tego Roku");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified3()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15 V 2000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified4()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2000 r.");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified5()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15 Luty 2000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified6()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "31-12-2000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified7()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-31-2000");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified8()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "2000-12-31");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateFormatNotClassified9()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaDatowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "2000-31-12");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
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
