using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumSpecFlow.Pages
{
    public class BasePage
    {
        public IWebDriver Driver;
		private HomePage _homePage;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

		public HomePage HomePage
        {
            get
            {
				if (_homePage == null) _homePage = new HomePage(Driver);
				return _homePage;
            }
        }
        
       
    }
}
