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
    public class SeleniumTestsWrongInputs
    {
        private IWebDriver _driver;

        [SetUp]
        public void BeforeTests()
        {
            _driver = SeleniumMethods.ConfigureDriver(_driver, "chrome", SeleniumParameters.ChromeWebDriverPath);
        }

        [Test]
        public void InputBoxWrongInput0()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput1()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-1410");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput2()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "string not date");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput3()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "1410 > 2077");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput4()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "-1");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput5()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "'okoń'; Select * from password_table;");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput6()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "1410 > 2077");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput7()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "-1");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput8()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "'okoń'; Select * from password_table;");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput9()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "あなたがそれを翻訳してくれてうれしいです");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput10()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "あなたがそれを翻訳してくれてうれしいです");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput11()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "var Nazwisko = Wielbłąd;");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput12()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "''''''''''''''''");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "Artefaktowy");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.ParentsCheckBoxXPath, false);
            SeleniumMethods.SetCheckBoxByXPath(_driver, SeleniumParametersElementsPaths.DoctorCheckBoxXPath, false);

            SeleniumMethods.PickAndClickWebElementByXPath(_driver, SeleniumParametersElementsPaths.SubmitButtonXPath);

            _driver.SwitchTo().Alert().Accept();
            string alertText = _driver.SwitchTo().Alert().Text.ToString();
            Assert.AreEqual(alertText, SeleniumParametersReturnStrings.DefaultErrorString);
            _driver.SwitchTo().Alert().Accept();
        }

        [Test]
        public void InputBoxWrongInput13()
        {
            SeleniumMethods.GoToWebsite(_driver, SeleniumParameters.USFormURL);
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.FirstNameInputBoxXPath, "Michałek");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.LastNameInputBoxXPath, "''''''''''''''''");
            SeleniumMethods.PickAndFillWebElementByXPath(_driver, SeleniumParametersElementsPaths.DateInputBoxXPath, "12-12-2077");

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