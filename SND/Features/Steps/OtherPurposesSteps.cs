using SND.Driver;
using SND.Helpers;
using SND.POM;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using QAssistant.Extensions;
using OpenQA.Selenium;

namespace SND.Features.Steps
{
    [Binding]
    public class OtherPurposesSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;
        public OtherPurposesSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        HomePage homePage = null;

        [Given(@"I click Other Purposes button")]
        public void GivenIClickOtherPurposesButton()
        {
            homePage = new HomePage(driver.Current);
            homePage.OtherPurposes.Click();
        }



        [Then(@"I check if all items are clickable")]
        public void ThenICheckIfAllItemsAreClickable()
        {
            Sleep(6600);
            homePage.LivingRoomItem.Click();
            Sleep(500);
            homePage.KitchenItem.Click();
            Sleep(500);
            homePage.AppliancesItem.Click();
            Sleep(500);
            homePage.OutdoorItem.Click();
            Sleep(500);
            homePage.SportsItem.Click();
            Sleep(500);
            homePage.MiscellaneousItem.Click();
            Sleep(500);
            homePage.OfficeItem.Click();
            Sleep(500);
            homePage.BedroomItem.Click();
        }



        [Given(@"I verify if est\.space ""(.*)"" displayed correctly")]
        public void GivenIVerifyIfEst_SpaceDisplayedCorrectly(string estSpaceSqft)
        {
            if (estSpaceSqft == "183.3 sqft")
            {
                homePage.Est_SpaceNeeded_Verify.Text.Should().Be(estSpaceSqft, "This verifies if space calculated correctly");
            }
            else if (estSpaceSqft == "183.3 sqft")
            {
                homePage.Est_SpaceNeeded_Verify.Text.Should().Be(estSpaceSqft, "This verifies if space calculated correctly");
            }
        }

        [Given(@"I Clear ""(.*)"" item from top of the list")]
        public void GivenIClearItemFromTopOfTheList(int closeItemsCount)
        {
            for (int i = 0; i < closeItemsCount; i++)
            {
                homePage.ClearOneItem.Click();
                Sleep(877);
            }
        }

        [When(@"I click clear all in list of items popup")]
        public void WhenIClickClearAllInListOfItemsPopup()
        {
            homePage.ClearAllListOfItems.Click();
        }

        [Then(@"I verify that a popup is disabled")]
        public void ThenIVerifyThatAPopupIsDisabled()
        {

             bool checker = driver.Current.ElementExists(By.XPath("//p[contains(text(),'Est. Space needed')]"));
             checker.Should().BeFalse("This verifies if popup is disabled");

        }
    }
    }

