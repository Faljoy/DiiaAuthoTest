using Diya2;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace diiaAuthoTest.Steps
{
    [Binding]
    public class MainPageSteps
    {
        private readonly IWebDriver _webDriver;
        private readonly ScenarioContext _scenarioContext;
        private readonly MainPage _mainPage;
        private readonly DataPage _dataPage;
        private readonly AnyPage _anyPage;

        public MainPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("webDriver");
            _mainPage = new MainPage(_webDriver);
            _anyPage = new AnyPage(_webDriver);
        }

        [Given(@"main page is open")]
        public void GivenMainPageIsOpen()
        {
            _mainPage.OpenMainPage();
        }

        [When(@"i click on more button")]
        public void WhenIClickOnMoreButton()
        {
            _mainPage.MoreButtonOnHeader();
        }

        [When(@"i click on diia open data")]
        public void WhenIClickOnDiiaOpenData()
        {
            _mainPage.DataOpenButtonOnHeader();
            Thread.Sleep(1000);
            _webDriver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "\t");
        }

        [Then(@"i see on a opened data page text '(.*)'")]
        public void ThenISeeOnAOpenedDataPageText(string textAboutDataPage)
        {
            Thread.Sleep(10000);
            string actualResultat = _dataPage.TextOnDataPageAboutOpenData();
            bool checkText = textAboutDataPage.Contains(actualResultat);
            Assert.AreEqual(actual: checkText, expected: true);
        }

        [When(@"i click on registration buttom")]
        public void WhenIClickOnRegistrationButtom()
        {
            _mainPage.RegistrationButtonOnHeader();
        }

        [Then(@"i see on a opened registration page text '(.*)'")]
        public void ThenISeeOnAOpenedRegistrationPageText(string textResultat)
        {
            Assert.AreEqual(actual: _anyPage.RegistrationPageText(), expected: textResultat);
        }

        [When(@"i click on know more buttom")]
        public void WhenIClickOnKnowMoreButtom()
        {
            _mainPage.ButtonKnowMore();
        }

        [Then(@"i see on a opened faq page text '(.*)'")]
        public void ThenISeeOnAOpenedFaqPageText(string textResultat)
        {
            Assert.AreEqual(actual: _anyPage.FAQPageText(), expected: textResultat);
        }

        [When(@"i click on i planing child buttom")]
        public void WhenIClickOnIPlaningChildButtom()
        {
            _mainPage.DataOpenButtonPlanningChild();
        }

        [When(@"i click on i healthy food buttom")]
        public void WhenIClickOnIHealthyFoodButtom()
        {
            _anyPage.DataOpenButtonHealsEat();
        }

        [Then(@"i see on a opened food text '(.*)'")]
        public void ThenISeeOnAOpenedFoodText(string textResultat)
        {
            Assert.AreEqual(actual: _anyPage.HealsPageText(), expected: textResultat);
        }
    }
}
