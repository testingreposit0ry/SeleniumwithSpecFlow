using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using ZooplaOnline.Pages;
using ZooplaOnline.TestHooks;

namespace SeleniumSpecFlow.Steps
{
    [Binding]
	public sealed class GoogleSearchSteps
    {
        private Helper _helper;
        private HomePage _homePage;
		// For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
		public GoogleSearchSteps(Helper helper)
        {
            _helper = helper;
        }

		[When(@"When I Search For Something")]
		public void WhenISearchForSomething()
        {
			_homePage = _helper.BasePage.HomePage.SearchSomething();
        }

     


    }
}
