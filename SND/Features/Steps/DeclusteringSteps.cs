using FluentAssertions;
using SND.Driver;
using SND.POM;
using System;
using TechTalk.SpecFlow;
using SND.Helpers;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using QAssistant.Extensions;

namespace SND.Features.Steps
{
    [Binding]
    public class DeclusteringSteps : Methods
    {

        ScenarioContext _sc;
        BrowserDriver driver;

        public DeclusteringSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        HomePage homePage = null;

        [Given(@"I click Declustering button")]
        public void GivenIClickDeclusteringButton()
        {
             homePage = new HomePage(driver.Current);
            homePage.Declustering.Click();
        }
        
        [Given(@"I click next button")]
        public void GivenIClickNextButton()
        {
            homePage = new HomePage(driver.Current);
            Sleep();
            homePage.NextBtnDeclustering.Click();
        }
        
        [Given(@"I click plus button (.*) times")]
        public void GivenIClickPlusButtonTimes(int numberOfBoxes)
        {

            for (int i = 0; i < numberOfBoxes; i++)
            {
                Sleep(2500);
                homePage.AddBoxesPlusBtnDeclustering.Click();
            }
            
        }

        [Given(@"I click estimate size button")]
        public void GivenIClickEstimateSizeButton()
        {
            homePage.EstimateSizeBtnDeclustering.Click();

        }

        [Given(@"I verify if recommended plan is displayed")]
        public void GivenIVerifyIfRecommendedPlanIsDisplayed()
        {
            homePage.RecommendedPlanDeclustering.Displayed.Should().BeTrue("This verifies if recommended plan is suggested to user");
        }

        [Given(@"I click find storage button in Declustering")]
        public void GivenIClickFindStorageButtonInDeclustering()
        {
            homePage.FindStorageInDeclustering.Click();
            
        }

        [Then(@"I Validate if storage is displayed")]
        public void ThenIValidateIfStorageIsDisplayed()
        {
            homePage = new HomePage(driver.Current);
            Sleep(15000);
            homePage.ViewAllofFirstStorge.Displayed.Should().BeTrue("This verifies if recommended storage is displayed");
        }

        [Given(@"I select My own box")]
        public void GivenISelectMyOwnBox()
        {
            homePage = new HomePage(driver.Current);
            homePage.SelectInactiveBoxType.Click();
        }

        [Given(@"I input Width Height Depth parameters in my own box")]
        public void GivenIInputWidthHeightDepthParametersInMyOwnBox(Table table)
        {
            // need to create clear and sendkeys method in a same method IMPORTANT NOTE!
            dynamic data = table.CreateDynamicInstance();
            homePage.WidthInBox.Clear(); 
            homePage.WidthInBox.SendKeys(data.Width.ToString());
            homePage.HeightInBox.SendKeys(Keys.Control + "a");
            homePage.HeightInBox.SendKeys(Keys.Backspace);
            homePage.HeightInBox.SendKeys(data.Height.ToString());
            homePage.DepthInBox.Clear();
            homePage.DepthInBox.SendKeys(data.Depth.ToString());
            
        }

        [Then(@"I click find storage button in Declustering")]
        public void ThenIClickFindStorageButtonInDeclustering()
        {
            homePage.FindStorageInDeclustering.Click();
        }


    }
}
