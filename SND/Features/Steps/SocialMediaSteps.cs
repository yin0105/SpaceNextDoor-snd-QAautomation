using SND.Driver;
using SND.POM;
using System;
using TechTalk.SpecFlow;
using QAssistant.Extensions;
using FluentAssertions;
using SND.Helpers;

namespace SND.Features.Steps
{
    [Binding]
    public class SocialMediaSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;
        public SocialMediaSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }
        HomePage homePage = null;

        [Given(@"I scroll down to social media buttons")]
        public void GivenIScrollDownToSocialMediaButtons()
        {
            
            homePage = new HomePage(driver.Current);
            driver.Current.ScrollIntoView(homePage.FacebookLogo);
            Sleep();
        }
        
        [When(@"I click instagram button")]
        public void WhenIClickInstagramButton()
        {
            homePage.InstagramLogo.Click();
            Sleep(500);
        }
        
        [Then(@"I check the redirection link ""(.*)""")]
        public void ThenICheckTheRedirectionLink(string URL)
        {
            if(URL== "https://www.instagram.com/spacenextdoor/")
            {
                SwitchToTab(driver.Current);
                driver.Current.Url.Should().Contain(URL,"This verifies if Instagram URL is correct");
                CloseTab(driver.Current);
            }
            else if (URL == "https://www.facebook.com/spacenextdoor")
            {
                SwitchToTab(driver.Current);
                driver.Current.Url.Should().Contain(URL, "This verifies if Facebook URL is correct");
                CloseTab(driver.Current);

            }
        }
        
        [Then(@"I click facebook button")]
        public void ThenIClickFacebookButton()
        {
            
            homePage.FacebookLogo.Click();
            Sleep(500);
        } //test need
    }
}
