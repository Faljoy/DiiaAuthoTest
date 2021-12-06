using Diya2;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace diiaAuthoTest.Steps
{
    [Binding]
    public class ButtonMoreOnTheHeaderMenuSteps
    {
        private readonly IWebDriver _webDriver;
        private readonly ScenarioContext _scenarioContext;
        private readonly MainPage _mainPage;
        private readonly AnyPage _anyPage;

        public ButtonMoreOnTheHeaderMenuSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("webDriver");
            _mainPage = new MainPage(_webDriver);
            _anyPage = new AnyPage(_webDriver);
        }

        [When(@"i click (.*) on more button")]
        public void WhenIClickOnMoreButton(string namePage)
        {
            _mainPage.ChosePage(namePage);
            _webDriver.SwitchTo().Window(_webDriver.WindowHandles[1]);
        }

        [Then(@"i see title on page (.*)")]
        public void ThenISeeTitleOnPage(string title)
        {
            Thread.Sleep(5000);
            Assert.AreEqual(title, _anyPage.TitleNameOnPageInMoreButton());
        }
    }
}

