using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSpecFlow.AppSettings.BrowserSetup
{
    public class Browser
    {
        private IWebDriver _driver;

        public IWebDriver LunchBrowser()
        {
            var browser = Zoopla.Default.Browser;
            if (browser.Contains("chrome")) _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(Zoopla.Default.BaseUrl);
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            return _driver;
        }

        public void CloseBrowser()
        {
            if (_driver != null) _driver.Quit();
        }
    }
}
