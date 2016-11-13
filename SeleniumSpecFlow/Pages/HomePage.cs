using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SeleniumSpecFlow.Pages
{
    public class HomePage : BasePage
    {
		public HomePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Name,Using = "q")]
        private IWebElement SearchFiled { get; set; }


		public HomePage SearchSomething(string query)
        {


            return this;
        }
			
    }

}
