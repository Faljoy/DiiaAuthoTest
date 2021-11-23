using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diya2
{
    public class AnyPage
    {
        private readonly IWebDriver _webDriver;
        private readonly By _searchValidRequestText = By.CssSelector("[class='search_request-text']");
        private readonly By _searchInvalidRequestText = By.CssSelector("[class='search_empty-msg']");
        private readonly By _registrationPageText = By.CssSelector("[id='id-app-login-mainTitle']");
        private readonly By _FAQTextPage = By.CssSelector("[class='page_title-text']");
        private readonly By _healsPageEat = By.CssSelector("[class='article-level-1']");
        private readonly By _diiaOpenDataButtonaboutHeals = By.CssSelector("[href='/life-situations/zdorovij-sposib-zhittya']");
        private readonly By _searchValidRequestTextOnDataPage = By.CssSelector("[class='results-message']");
        private readonly By _searchInValidRequestTextOnDataPage = By.CssSelector("[class='search-not-found-container']");
        private readonly By _apiButtonOnDataAnalyticsPage = By.XPath("//*[@id='content']//li[3]/a");
        private readonly By _apiTextOnDataAnalyticsPage = By.CssSelector("[class='analytics-title']");
        private readonly By _FAQTextOnDataAnalyticsPage = By.CssSelector("[class='toolbar-title simplified']");
        private readonly By _allSetsTextOnDataAnalyticsPage = By.CssSelector("div[class='datasets-container'] h2");
        private readonly By _titleAboutPageOnButtonMore = By.TagName("title");

        public AnyPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AnyPage DataOpenButtonHealsEat()
        {
            _webDriver.FindElement(_diiaOpenDataButtonaboutHeals).Click();
            return this;
        }

        public string DataTextAllSet() => _webDriver.FindElement(_allSetsTextOnDataAnalyticsPage).Text;

        public AnyPage ButtonApiAnalytics()
        {
            _webDriver.FindElement(_apiButtonOnDataAnalyticsPage).Click();
            return this;
        }

        public string RequestValidText() => _webDriver.FindElement(_searchValidRequestText).Text;

        public string RequestInvalidText() => _webDriver.FindElement(_searchInvalidRequestText).Text;

        public string RegistrationPageText() => _webDriver.FindElement(_registrationPageText).Text;

        public string FAQPageText() => _webDriver.FindElement(_FAQTextPage).Text;

        public string HealsPageText() => _webDriver.FindElement(_healsPageEat).Text;

        public string ApiAnalyticsPageText() => _webDriver.FindElement(_apiTextOnDataAnalyticsPage).Text;

        public string FAQDataText() => _webDriver.FindElement(_FAQTextOnDataAnalyticsPage).Text;

        public string RequestValidTextOnDataPage() => _webDriver.FindElement(_searchValidRequestTextOnDataPage).Text;

        public string RequestInValidTextOnDataPage() => _webDriver.FindElement(_searchInValidRequestTextOnDataPage).Text;

        public string TitleNameOnPageInMoreButton() => _webDriver.FindElement(_titleAboutPageOnButtonMore).Text;
    }
}
