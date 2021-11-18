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
    public class QuotationSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;
        
        public QuotationSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }
        Details detailsPage = null;

        [Given(@"I click Get a quote button")]
        public void GivenIClickGetAQuoteButton()
        {
            detailsPage = new Details(driver.Current);
            Sleep(9000);
            ScrollInto(driver.Current, "300");
            detailsPage.GETaQUOTE.Click();
        }
        
        [Given(@"I select ""(.*)"" size estimator")]
        public void GivenISelectSizeEstimator(string estimatorSize)
        {
            if (estimatorSize=="XS")
            {
                Sleep();
                detailsPage.XS_SE.GetParent().Click();
            }
            else if (estimatorSize=="XXS")
            {
                //click radiobutton1
            }
        }
        
        [Given(@"I click What's fit in this size")]
        public void GivenIClickWhatSFitInThisSize()
        {
            Sleep(3333);
            detailsPage.Whatsfitinthissize.Click();
        }
        
        [Given(@"I use sliders on displayed popup")]
        public void GivenIUseSlidersOnDisplayedPopup()
        {
            detailsPage.RightSliderQT.Click();
            Sleep(777);
            detailsPage.LeftSliderQT.Click();
        }
        
        [Given(@"I click select button")]
        public void GivenIClickSelectButton()
        {
            detailsPage.SelectBtnQT.Click();
        }
        
        [Given(@"I click next button in quotation")]
        public void GivenIClickNextButtonInQuotation()
        {
            detailsPage.NextBtnQT.Click();
        }
        
        [Given(@"I use calendar sliders")]
        public void GivenIUseCalendarSliders()
        {
            detailsPage.RightSliderInCalendar.Click();
            Sleep(777);
            detailsPage.LeftSliderInCalendar.Click();
        }
        
        [Given(@"I input Full name")]
        public void GivenIInputFullName()
        {
            detailsPage.FullnameQT.SendKeys("Lukaaa");
        }
        
        [Given(@"I Input Email")]
        public void GivenIInputEmail()
        {
            detailsPage.EmailQT.SendKeys("Luka@spacenextdoor.io");
        }
        
        [Given(@"I Input phone number ""(.*)""")]
        public void GivenIInputPhoneNumber(int phoneNumber)
        {
            detailsPage.NumberQT.SendKeys(phoneNumber.ToString());
        }
        
        [Given(@"I should be redirected to back to home page")]
        public void GivenIShouldBeRedirectedToBackToHomePage()
        {
            Sleep(3500);
            detailsPage.BackToHomePageQT.Displayed.Should().BeTrue("This verifies that we redirected on back to homepage");
        }
        
        [When(@"I click back to homepage button")]
        public void WhenIClickBackToHomepageButton()
        {

            Sleep(3500);
            //driver.Current.ElementExists(By.XPath("(//*[contains(text(), 'Back To Homepage')])[1]"))
            //    .Should().BeTrue("This verifies if button is displayed on back to homepage ");
            detailsPage.BackToHomePageQT.Click();

        }

        [Given(@"I click Get a quote  last button")]
        public void GivenIClickGetAQuoteLastButton()
        {
            Sleep(3555);
            detailsPage.GETaQUOTE.Click();
        }


        [Then(@"I should be redirected to main homepage")]
        public void ThenIShouldBeRedirectedToMainHomepage()
        {
            Sleep(3000);
            driver.Current.Url.Should().Be("https://stag.spacenextdoor.com/");
        }
    }
}
