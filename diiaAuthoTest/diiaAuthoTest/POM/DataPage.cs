using OpenQA.Selenium;
using System.Threading;

namespace Diya2
{
    public class DataPage
    {
        private readonly IWebDriver _webDriver;
        private readonly By _textOnDataPage = By.CssSelector("[class='ng-star-inserted']>app-menu-item>a");
        private readonly By _searchButtonOnDataPage = By.CssSelector("[placeholder='Пошук набору даних']");
        private readonly By _searchButton = By.CssSelector("[class='hero-search-wrapper__btn']");
        private readonly By _analytichButton = By.CssSelector("[class='header-menu-list'] a[href='/stats2/common']");
        private readonly By _FAQButtonOnDatePage = By.CssSelector("[class='header-menu-list'] a[href='/faq']");
        private readonly By _allSetsButtonOnDatePage = By.CssSelector("[href='/dataset?sort=views_total+desc']");

        public DataPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public DataPage OpenDataPage()
        {
            _webDriver.Navigate().GoToUrl("https://data.gov.ua/");
            Thread.Sleep(1000);
            return this;
        }

        public string TextOnDataPageAboutOpenData() => _webDriver.FindElements(_textOnDataPage)[6].Text;

        public DataPage SearchInputFieldOnDataPage(string inputText)
        {
            _webDriver.FindElement(_searchButtonOnDataPage).SendKeys(inputText);
            return this;
        }

        public DataPage SearchButtonOnDataPage()
        {
            _webDriver.FindElement(_searchButton).Click();
            return this;
        }

        public DataPage AllSetsButtonOnDataPage()
        {
            _webDriver.FindElement(_allSetsButtonOnDatePage).Click();
            return this;
        }

        public DataPage AnalyticsButtonOnDataPage()
        {
            _webDriver.FindElement(_analytichButton).Click();
            return this;
        }

        public DataPage FAQButtonOnDataPage()
        {
            _webDriver.FindElement(_FAQButtonOnDatePage).Click();
            return this;
        }
    }
}