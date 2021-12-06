using OpenQA.Selenium;

namespace diiaAuthoTest
{
    public class MainPage
    {
        private readonly IWebDriver _webDriver;
        private readonly By _searchInputField = By.CssSelector("[class ='input form-search_input']");
        private readonly By _searchButton = By.CssSelector("input[class='btn btn_search-main']");
        private readonly By _moreButtonInHeader = By.CssSelector("[data-menu-target='menu-sub-5']");
        private readonly By _diiaOpenDataButtonInHeader = By.CssSelector("a[href='https://diia.data.gov.ua/']");
        private readonly By _diiaOpenBusinessButtonInHeader = By.CssSelector("a[href='https://business.diia.gov.ua']");
        private readonly By _diiaOpenVzaemoDiiaButtonInHeader = By.CssSelector("a[href='https://vzaemo.diia.gov.ua/']");
        private readonly By _diiaOpenOsvitaButtonInHeader = By.CssSelector("a[href='https://osvita.diia.gov.ua']");
        private readonly By _diiaOpenPapperlessButtonInHeader = By.CssSelector("a[href='https://paperless.diia.gov.ua/']");
        private readonly By _diiaOpenPortalDataButtonInHeader = By.CssSelector("a[href='https://data.gov.ua/']");
        private readonly By _diiaOpenDataButtonRegistration = By.CssSelector("header>div>div>div>div>[class='btn btn_register']");
        private readonly By _diiaOpenDataButtonKnowMore = By.XPath("//*[@id='gromadyanam']/div[2]/div/div[1]/div[2]/div/a");
        private readonly By _diiaOpenDataButtonPlaningChild = By.CssSelector("[href='/life-situations/ya-planuyu-ditinu']");

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPage OpenMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        public MainPage SearchInputField(string inputText)
        {
            _webDriver.FindElement(_searchInputField).SendKeys(inputText);
            return this;
        }

        public void ButtonSearch() => _webDriver.FindElement(_searchButton).Click();

        public void ButtonKnowMore() => _webDriver.FindElement(_diiaOpenDataButtonKnowMore).Click();

        public MainPage MoreButtonOnHeader()
        {
            _webDriver.FindElement(_moreButtonInHeader).Click();
            return this;
        }

        public MainPage DataOpenButtonOnHeader()
        {
            _webDriver.FindElement(_diiaOpenDataButtonInHeader).Click();
            return this;
        }

        public MainPage BusinessOpenButtonOnHeader()
        {
            _webDriver.FindElement(_diiaOpenBusinessButtonInHeader).Click();
            return this;
        }

        public MainPage VzaemoDiiaOpenButtonOnHeader()
        {
            _webDriver.FindElement(_diiaOpenVzaemoDiiaButtonInHeader).Click();
            return this;
        }

        public MainPage PaperlessOpenButtonOnHeader()
        {
            _webDriver.FindElement(_diiaOpenPapperlessButtonInHeader).Click();
            return this;
        }

        public MainPage PortalDataOpenButtonOnHeader()
        {
            _webDriver.FindElement(_diiaOpenPortalDataButtonInHeader).Click();
            return this;
        }

        public MainPage OsvitaOpenButtonOnHeader()
        {
            _webDriver.FindElement(_diiaOpenOsvitaButtonInHeader).Click();
            return this;
        }
        public MainPage DataOpenButtonPlanningChild()
        {
            _webDriver.FindElement(_diiaOpenDataButtonPlaningChild).Click();
            return this;
        }

        public MainPage RegistrationButtonOnHeader()
        {
            _webDriver.FindElement(_diiaOpenDataButtonRegistration).Click();
            return this;
        }

        public MainPage ButtonOnButtonMore(string cssPath)
        {
            _webDriver.FindElement(By.CssSelector(cssPath)).Click();
            return this;
        }

        public string TextOnPageOnButtonMore()
        {
            return _webDriver.FindElement(By.TagName("title")).Text;
        }

        public MainPage ChosePage(string nameOfPage)
        {
            switch (nameOfPage)
            {
                case "Open Data":
                    return DataOpenButtonOnHeader();
                case "Bussiness":
                    return BusinessOpenButtonOnHeader();
                case "VzaemoDiia":
                    return VzaemoDiiaOpenButtonOnHeader();
                case "Digital education":
                    return OsvitaOpenButtonOnHeader();
                case "Paperless":
                    return PaperlessOpenButtonOnHeader();
                case "Data Gov":
                    return PortalDataOpenButtonOnHeader();
                default:
                    return this;
            }
        }
    }
}