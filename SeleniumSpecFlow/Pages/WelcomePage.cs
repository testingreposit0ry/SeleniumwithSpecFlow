using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumSpecFlow.Pages
{
    public class WelcomePage : BasePage
    {
        public WelcomePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "search-tabs-to-rent")]
        private IWebElement ToRentTab { get; set; }

        public ToRentPage HomePage()
        {
            ToRentTab.Click();
            return new ToRentPage(Driver);
        }
    }
}
