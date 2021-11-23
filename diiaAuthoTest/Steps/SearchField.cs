using Diya2;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace diiaAuthoTest.Steps
{
    [Binding]
    public class PopularServiceSteps
    {
        private readonly IWebDriver _webDriver;
        private readonly ScenarioContext _scenarioContext;
        private readonly MainPage _mainPage;
        private readonly AnyPage _anyPage;

        public PopularServiceSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("webDriver");
            _mainPage = new MainPage(_webDriver);
            _anyPage = new AnyPage(_webDriver);
        }

        [When(@"i input '(.*)' in search field")]
        public void WhenIInputInSearchField(string inputTextInField)
        {
            _mainPage.SearchInputField(inputTextInField);
        }

        [When(@"i click on seach button")]
        public void WhenIClickOnSeachButton()
        {
            _mainPage.ButtonSearch();
        }

        [Then(@"i see a validSearchResult page with text '(.*)'")]
        public void ThenISeeAValidSearchResultPageWithText(string textResult)
        {
            Thread.Sleep(1000);
            string receivedЕext = _anyPage.RequestValidText();
            bool checkResultat = receivedЕext.Contains(textResult);
            Assert.AreEqual(true, checkResultat);
        }

        [Then(@"i see a invalidSearchResult page with text '(.*)'")]
        public void ThenISeeAInvalidSearchResultPageWithText(string textResult)
        {
            Thread.Sleep(1000);
            string receivedЕext = _anyPage.RequestInvalidText();
            Assert.AreEqual(receivedЕext, textResult);
        }
    }
}
