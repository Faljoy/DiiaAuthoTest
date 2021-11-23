using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace diiaAuthoTest
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario()]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            var driver = new ChromeDriver(options);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);

            _scenarioContext.Add("webDriver", driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            IWebDriver driver = _scenarioContext.Get<IWebDriver>("webDriver");
            driver.Dispose();
        }
    }
}
