using SND.Driver;
using SND.POM;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using QAssistant.Extensions;
using QAssistant.Helpers;
namespace SND.Features.Steps
{
    [Binding]
    public class BusinessInventorySteps
    {

        ScenarioContext _sc;
        BrowserDriver driver;

        public BusinessInventorySteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        HomePage homePage = null;


        [Given(@"I click Business Inventory button")]
        public void GivenIClickBusinessInventoryButton()
        {
            homePage = new HomePage(driver.Current);
            homePage.BussinesInventory.Click();
        }


        [Given(@"I click find storage button in Business Inventory")]
        public void GivenIClickFindStorageButtonInBusinessInventory()
        {
            homePage.FindStorageInBusinessInventory.Click();
        }

        [Given(@"I click go back button")]
        public void GivenIClickGoBackButton()
        {
            homePage = new HomePage(driver.Current);
            homePage.GoBackBtn.Click();
        }

        [Given(@"I verify if quantity of boxes is saved")]
        public void GivenIVerifyIfQuantityOfBoxesIsSaved()
        {
            //same xpath for quantity of boxes
            homePage.WidthInBox.ReadFromFieldValue().Should().Be("3", "I selected 2 additional boxes. and they should remain same even if i am using back button");
            //test need
        }

        [Then(@"I verify if i am on What kind of box do you need\? step")]
        public void ThenIVerifyIfIAmOnWhatKindOfBoxDoYouNeedStep()
        {
            homePage.SelectInactiveBoxType.Displayed.Should().BeTrue("This verifies if i am on first step after clicking back buttons");
        }

    }
}
