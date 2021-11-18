using SND.Driver;
using SND.Helpers;
using SND.POM;
using System;
using TechTalk.SpecFlow;
using QAssistant.Extensions;
using QAssistant.Helpers;
using QAssistant.WaitHelpers;
using OpenQA.Selenium;
using FluentAssertions;

namespace SND.Features.Steps
{
    [Binding]
    public class UserSelectOptionsSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;
        public UserSelectOptionsSteps(BrowserDriver driver,ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        HomePage homePage = null;

        [Given(@"I navigate on ""(.*)""")]
        public void GivenINavigateOn(string URL)
        {
           homePage = new HomePage(driver.Current);
           GoToUrl(driver.Current, URL);
        }
        
        [Given(@"I select all sizes one by one")]
        public void GivenISelectAllSizesOneByOne()
        {
            for (int i = 1; i < 8; i++)
            {
                Sleep(2500);
                driver.Current.Click(By.XPath($"//*[@id='size{i}']"));
                Sleep(700);
            }
            
        }
        
        [Then(@"I mark all features & amanities")]
        public void ThenIMarkAllFeaturesAmanities()
        {
            ((IJavaScriptExecutor)driver.Current).ExecuteScript(("window.scrollTo(0,1300);"));
            Sleep(1500);
            for (int i = 1; i < 22; i++)
            {
                Sleep(2500);
                driver.Current.Click(By.XPath($"//*[@id='featureAmenity{i}']"));
                Sleep(2500);

            }

        }

        [Given(@"I select ""(.*)"" date on search page")]
        public void GivenISelectDateOnSearchPage(string moveType)
        {
            Bookings bookingsPage = new Bookings(driver.Current);
            if (moveType=="Move_In")
            {
                Sleep();
                bookingsPage.MoveInSearchPage.Click();
                Sleep();
                bookingsPage.ConfirmCalenar.Click();
            }
            else if (moveType=="Move_Out")
            {
                Sleep();
                bookingsPage.MoveOutSearchPage.Click();
                Sleep();
                bookingsPage.ConfirmCalenar.Click();
            }
        }

        [Then(@"I verify if URL changed accordingly")]
        public void ThenIVerifyIfURLChangedAccordingly()
        {
            Sleep(2500);
            driver.Current.Url.Should().Contain("move_in=","This Veifies if URL changed accordingly");
            driver.Current.Url.Should().Contain("move_out=", "This Veifies if URL changed accordingly");
        }


    }
}
