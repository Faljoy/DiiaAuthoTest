using OpenQA.Selenium;
using Diya2;
using TechTalk.SpecFlow;
using NUnit.Framework;

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
        }

        [Then(@"i see title on page (.*)")]
        public void ThenISeeTitleOnPage(string title)
        {
            Assert.AreEqual(_anyPage.TitleNameOnPageInMoreButton(), title);
        }

    }
}
