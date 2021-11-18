using FluentAssertions;
using OpenQA.Selenium;
using QAssistant.Extensions;
using SND.Driver;
using SND.Helpers;
using SND.POM;
using System;
using TechTalk.SpecFlow;

namespace SND.Features.Steps
{
    [Binding]
    public class EstimatorResultsSteps : Methods
    {

        ScenarioContext _sc;
        BrowserDriver driver;

        public EstimatorResultsSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        HomePage homePage = null;

        [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string URL)
        {
            homePage = new HomePage(driver.Current);
            GoToUrl(driver.Current, URL);
        }
        
        [When(@"I click clear all filters button")]
        public void WhenIClickClearAllFiltersButton()
        {
            homePage.ClearAllFilter.Click();
        }
        
        [Then(@"I check if any ""(.*)"" site appeared on search page")]
        public void ThenICheckIfAnySiteAppearedOnSearchPage(string environment)
        {
   
            for (int i = 0; i < 3; i++)
            {
                ScrollInto(driver.Current, "15000");
                Sleep();               
            }

           driver.Current.
                ElementExists(By.XPath($"//*[text()='{environment}']"))
                .Should()
                .BeFalse("This means no other market sites are appeared in search results");
        }
    }
}
