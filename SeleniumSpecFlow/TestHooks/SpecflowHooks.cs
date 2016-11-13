using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumSpecFlow.AppSettings.BrowserSetup;

namespace SeleniumSpecFlow.TestHooks
{
    [Binding]
    public sealed class SpecflowHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly Browser _browser;

        public SpecflowHooks(Browser browser)
        {
            _browser = browser;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ScenarioContext.Current["driver"]=_browser.LunchBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _browser.CloseBrowser();
        }
    }
}
