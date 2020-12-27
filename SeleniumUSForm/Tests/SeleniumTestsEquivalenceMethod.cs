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
    public class SeleniumTestsEquivalenceMethod
    {
        private IWebDriver _driver;

        [SetUp]
        public void BeforeTests()
        {
            _driver = SeleniumMethods.ConfigureDriver(_driver, "chrome", SeleniumParameters.ChromeWebDriverPath);
        }

        /// <summary>
        /// Tests for being too young to classify
        /// </summary>

        [Test]
        public void DateEquivalenceMethodNotClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2015");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodNotClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2015");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodNotClassified2()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2015");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodNotClassified3()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2015");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Tests for having documents by Person [Mlodzik]
        /// </summary>

        [Test]
        public void DateEquivalenceMethodMlodzikClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2008");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsMlodzikString);
            _driver.SwitchTo().Alert().Accept();
        }
        
        [Test]
        public void DateEquivalenceMethodMlodzikNotClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2008");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodMlodzikNotClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2008");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodMlodzikNotClassified2()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2008");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Tests for having documents by Person [Junior]
        /// </summary>

        [Test]
        public void DateEquivalenceMethodJuniorClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2004");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsJuniorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodJuniorNotClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2004");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodJuniorNotClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2004");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodJuniorNotClassified2()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-2004");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Tests for having documents by Person [Dorosly]
        /// </summary>

        [Test]
        public void DateEquivalenceMethodDoroslyClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-1980");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodDoroslyClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-1980");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodDoroslyClassified2()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-1980");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodDoroslyClassified3()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-1980");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsDoroslyString);
            _driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Tests for having documents by Person [Senior]
        /// </summary>

        [Test]
        public void DateEquivalenceMethodSeniorClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-1950");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsSeniorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodSeniorClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-1950");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, true);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.ClassifiedAsSeniorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodSeniorNotClassified0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-1950");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, true);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void DateEquivalenceMethodSeniorNotClassified1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "PozdrawiaRównoważnościowo");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "15-06-1950");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.NotClassifiedString);
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
