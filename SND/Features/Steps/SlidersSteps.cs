using SND.Driver;
using SND.POM;
using System;
using TechTalk.SpecFlow;
using QAssistant.Extensions;
using QAssistant.Helpers;
using QAssistant.WaitHelpers;
using SND.Helpers;
using FluentAssertions;

namespace SND.Features.Steps
{
    [Binding]
    public class SlidersSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;


        public SlidersSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }
        HomePage homePage = null;
        Details detailsPage = null;

        [Given(@"I scroll down to features listings")]
        public void GivenIScrollDownToFeaturesListings()
        {
            homePage = new HomePage(driver.Current);
            Sleep(3500);
            driver.Current.ScrollIntoView(homePage.FeaturedListingInSingapore);
        }

        [When(@"I Click all right sliders  ""(.*)"" times")]
        public void WhenIClickAllRightSlidersTimes(int slidingTimes)
        {
            for (int i = 0; i < slidingTimes; i++)
            {
                Sleep(3500);
                homePage.RightSlider1.Click();
                Sleep(760);
                homePage.RightSlider2.Click();
                Sleep(760);
                homePage.RightSlider3.Click();
                Sleep(760);
                homePage.RightSlider4.Click();
                
            }
        }

        [Then(@"I click all left sliders ""(.*)"" times")]
        public void ThenIClickAllLeftSlidersTimes(int slidingTimes)
        {
            for (int i = 0; i < slidingTimes; i++)
            {
                Sleep();
                homePage.LeftSlider1.Click();
                Sleep(760);
                homePage.LeftSlider2.Click();
                Sleep(760);
                homePage.LeftSlider3.Click();
                Sleep(760);
                homePage.LeftSlider4.Click();
                
            }
        }

        //
        [Given(@"I Click ""(.*)"" photo")]
        public void GivenIClickPhoto(string photoOpion)
        {
            detailsPage = new Details(driver.Current);
            if (photoOpion == "storage cover")
            {
                detailsPage.StorageCoverPhoto.Click();
            }
            else if (photoOpion == "storage seconday cover")
            {
                detailsPage.SecondaryStorageCoverPhoto.Click();
            }
            else if (photoOpion == "storage small cover")
            {
                detailsPage.SmallCoverPhoto.GetParent().Click();
            }
        }

        [Given(@"I Click ""(.*)"" thumbnail to slide")]
        public void GivenIClickThumbnailToSlide(string thumbnailOption)
        {
            if (thumbnailOption == "last")
            {
                detailsPage.LastThumbnail.Click();
            }
            else if (thumbnailOption == "first")
            {
                detailsPage.FirstThumbnail.Click();
            }
            else if (thumbnailOption == "5th")
            {
                detailsPage.FifthThumbnail.Click();
            }
        }

        [Given(@"I disable cs support chat widget")]
        public void GivenIDisableCsSupportChatWidget()
        {
            // Sleep(3333);
            SwitchiFrame(driver.Current, detailsPage.HelcrunchIframe);
            DisplayTypeElement(driver.Current,detailsPage.DisableChatPopup);
            detailsPage.DisableChatPopup.Click();
            driver.Current.SwitchTo().DefaultContent();
        }



        [Given(@"I Slide right ""(.*)"" times")]
        public void GivenISlideRightTimes(int slidingCount)
        {
            for (int i = 0; i < slidingCount; i++)
            {
                detailsPage.RightSlide.Click();
                Sleep(400);
            }
              
        }

        [Given(@"I Slide left ""(.*)"" times")]
        public void GivenISlideLeftTimes(int slidingCount)
        {
            for (int i = 0; i < slidingCount; i++)
            {
                detailsPage.LeftSlide.Click();
                Sleep(400);
            }
        }

        [Given(@"I Close sliding view popup")]
        public void GivenICloseSlidingViewPopup()
        {
            
            detailsPage.CloseXSlideView.GetParent().Click(); //xpath is unstable
        }

        [Then(@"I Validate if ""(.*)"" is unchangable after these actions")]
        public void ThenIValidateIfIsUnchangableAfterTheseActions(string URL)
        {
            driver.Current.Url.Should().Be(URL, "We made few clicks but URL should be unchangable");
        }


    }
}
