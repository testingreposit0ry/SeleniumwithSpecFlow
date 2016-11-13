using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumSpecFlow.Pages;

namespace SeleniumSpecFlow.TestHooks
{
    public class Helper
    {
        private BasePage _basePage;

        public BasePage BasePage
        {
            get
            {
                if (_basePage == null) _basePage = new BasePage((IWebDriver)ScenarioContext.Current["driver"]);
                return _basePage;
            }
        }
    }
}
