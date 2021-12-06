using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Diya2.Steps
{
    [Binding]
    public class DataPageSteps
    {
        private readonly IWebDriver _webDriver;
        private readonly ScenarioContext _scenarioContext;
        private readonly DataPage _dataPage;
        private readonly AnyPage _anyPage;

        public DataPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("webDriver");
            _dataPage = new DataPage(_webDriver);
            _anyPage = new AnyPage(_webDriver);
        }

        [Given(@"data page is open")]
        public void GivenDataPageIsOpen()
        {
            _dataPage.OpenDataPage();
        }

        [When(@"i input '(.*)' in daat search field")]
        public void WhenIInputInDaatSearchField(string textInput)
        {
            _dataPage.SearchInputFieldOnDataPage(textInput);
        }

        [When(@"i click on seach button on data page")]
        public void WhenIClickOnSeachButtonOnDataPage()
        {
            _dataPage.SearchButtonOnDataPage();
        }

        [Then(@"i see a validSearchResult data page with text '(.*)'")]
        public void ThenISeeAValidSearchResultDataPageWithText(string textResultat)
        {
            bool checkResultat = _anyPage.RequestValidTextOnDataPage().Contains(textResultat);
            System.Console.WriteLine(_anyPage.RequestValidTextOnDataPage());
            Assert.AreEqual(actual: checkResultat, expected: true);
        }

        [Then(@"i see a invalidSearchResult data page with text '(.*)'")]
        public void ThenISeeAInvalidSearchResultDataPageWithText(string textResultat)
        {
            bool checkResultat = _anyPage.RequestInValidTextOnDataPage().Contains(textResultat);
            Assert.AreEqual(actual: checkResultat, expected: true);
        }

        [When(@"i click on analytic button")]
        public void WhenIClickOnAnalyticButton()
        {
            _dataPage.AnalyticsButtonOnDataPage();
        }

        [When(@"i click on api on analitycs page")]
        public void WhenIClickOnApiOnAnalitycsPage()
        {
            _anyPage.ButtonApiAnalytics();
        }

        [Then(@"i see a  page with text '(.*)'")]
        public void ThenISeeAPageWithText(string textResultat)
        {
            Assert.AreEqual(actual: _anyPage.ApiAnalyticsPageText(), expected: textResultat);
        }

        [When(@"i click on FAQ button")]
        public void WhenIClickOnFAQButton()
        {
            _dataPage.FAQButtonOnDataPage();
        }

        [Then(@"i see a data page with text '(.*)'")]
        public void ThenISeeADataPageWithText(string textResultat)
        {
            Assert.AreEqual(actual: _anyPage.FAQDataText(), expected: textResultat);
        }

        [When(@"i click on All sets button")]
        public void WhenIClickOnAllSetsButton()
        {
            _dataPage.AllSetsButtonOnDataPage();
        }

        [Then(@"i see a all set page with text '(.*)'")]
        public void ThenISeeAAllSetPageWithText(string textResultat)
        {
            bool checkResultat = _anyPage.DataTextAllSet().Contains(textResultat);
            Assert.AreEqual(actual: checkResultat, expected: true);
        }
    }
}
