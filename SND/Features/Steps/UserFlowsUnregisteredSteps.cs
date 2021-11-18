using SND.Driver;
using System;
using TechTalk.SpecFlow;
using SND.Helpers;
using SND.POM;
using TechTalk.SpecFlow.Assist;
using QAssistant.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using FluentAssertions;
using QAssistant.Extensions;
using QAssistant.Helpers;
using QAssistant.WaitHelpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SND.Features.Steps
{
    [Binding]
    public class UserFlowsUnregisteredSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;
        public UserFlowsUnregisteredSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }
        HomePage homePage = null;

        ReadOnlyCollection<IWebElement> ListiFrame = null; 

        [Given(@"I navigate on ""(.*)"" main page")]
        public void GivenINavigateOnMainPage(string option)
        {


             homePage = new HomePage(driver.Current);
            // GoToUrl(driver.Current, option);
            driver.Current.Url.Should().Be("https://stag.spacenextdoor.com/", "Url is passed form outside and im just verifying");


        }
        
        [Given(@"I search ""(.*)"" and select it in main search field")]
        public void GivenISearchAndSelectItInMainSearchField(string option)
        {
            homePage = new HomePage(driver.Current);
            homePage.SearchField.SendKeys(option);
            Sleep(2200);
            homePage.FirstResultOfSearchField.Click();
        }
        
        [Given(@"I Choose ""(.*)"" size estimator")]
        public void GivenIChooseSizeEstimator(string option)
        {
            if (option == "XS")
            {
                Sleep(3000);
                homePage.XS_Estimator.Click();
            }
            else if (option == "XXS")
            {
                //here will be inputed all sizes of the estimators
            }
            else if (option == "S")
            {
                Sleep(2500);
                homePage.S_Estimator.Click();
            }
                
        }
        
        [Given(@"I click ""(.*)"" View All button")]
        public void GivenIClickViewAllButton(string option)
        {
            if (option == "First")
            {
                Sleep(18000);
                    homePage.ViewAllofFirstStorge.Click();
            }
            else if(option == "Second")
            {
                Sleep(18000);
                homePage.ViewAllofSecondtStorge.Click();

            }
            SwitchToTab(driver.Current, 1);
        }
        
        [Given(@"I click ""(.*)"" storage unit")]
        public void GivenIClickStorageUnit(string option)
        {
            homePage = new HomePage(driver.Current);
            if (option == "First")
            {
                Sleep(9000);
                homePage.FirstStorageUnit.Click();
            }
            else if (option == "Second")
            {
                Sleep(9000);
                homePage.SecondStorageUnit.Click();
            }
        }
        
        [Given(@"I click book now button")]
        public void GivenIClickBookNowButton()
        {
            Sleep(3000);
            homePage.BookNowBtn.Click();
        }
        
        [Given(@"I input following parameters into your details")]
        public void GivenIInputFollowingParametersIntoYourDetails(Table table)
        {
             dynamic data = table.CreateDynamicInstance();
            //var ConvertedData = table.CreateInstance<(string Fullname, string Email, string Phonenumber)>();
            homePage.FullnameYourDetail.SendKeys(data.Fullname.ToString());
            homePage.EmailYourDetail.SendKeys(data.Email.ToString());
            homePage.PhoneNumberYourDetail.SendKeys(data.Phonenumber.ToString());
        }
        
        [Given(@"I click reserve unit button")]
        public void GivenIClickReserveUnitButton()
        {
            Sleep();
            homePage.ReserveThisUnitBtn.Click();
        }
        
        [Given(@"I click continue button")]
        public void GivenIClickContinueButton()
        {
            Sleep();
            homePage.ContinueBtn.Click();
        }
        
        [Given(@"I select ""(.*)"" insurance plan")]
        public void GivenISelectInsurancePlan(string option)
        {
            if (option == "First")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn1.Click();
            } 
            else if(option=="Second")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn2.Click();
            }
            else if(option=="Third")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn3.Click();
            }
            else if(option=="Fourth")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn4.Click();
            }
            else if (option == "Fifth")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn5.Click();
            }

        }
       

        [Given(@"I input card number parameters into payment method")]
        public void GivenIInputCardNumberParametersIntoPaymentMethod(Table table)
        {
            
            dynamic data = table.CreateDynamicInstance();
            ListiFrame = getAlliFrames(driver.Current);
            //SwitchiFrame(driver.Current, homePage.iFramePayment);
            SwitchiFrame(driver.Current, ListiFrame[0]);           
            homePage.CardNumberInPaymentMethod.SendKeys(data.CardNumber);
            homePage.MMYYInPaymentMethod.SendKeys(data.MMYY.ToString());
            homePage.CVCInPaymentMethod.SendKeys(data.CVV.ToString());

        }
        
        [When(@"I click pay button")]
        public void WhenIClickPayButton()
        {
            driver.Current.SwitchTo().DefaultContent();
            homePage.PayBtn.Click();
        }
        
        [Then(@"The booking confirmation page should be displayed")]
        public void ThenTheBookingConfirmationPageShouldBeDisplayed()
        {
            homePage.IsBookingConfirmed.Text.Should().Be("Your booking is confirmed!", "This verifies if booking succesfully done");
        }

        [Given(@"I click Home Renovations button")]
        public void GivenIClickHomeRenovationsButton()
        {
            homePage = new HomePage(driver.Current);
            homePage.HomeRenevationBtn.Click();
        }


        [Given(@"I select some options about storage")]
        public void GivenISelectSomeOptionsAboutStorage()
        {
            homePage = new HomePage(driver.Current);
            Sleep(3500);
            homePage.BedFrameQueen.SendKeys("2");
            Sleep(760);
            homePage.BedFrameSingle.SendKeys("1");
            Sleep(760);
            homePage.BedFrameKing.SendKeys("3");
        }


        [Given(@"I click find storage button")]
        public void GivenIClickFindStorageButton()
        {
            homePage.FindStorageBtn.Click();           
        }

        [Given(@"I should see the hyperlink Self storage license agreement \.")]
        public void GivenIShouldSeeTheHyperlinkSelfStorageLicenseAgreement_()
        {
            homePage.HyperlinkSelfstorage.Displayed.Should().BeTrue("Hyperlink should be displayed"); //gasatestia
        }

        [Given(@"I click  Self storage license agreement  hyperlink")]
        public void GivenIClickSelfStorageLicenseAgreementHyperlink()
        {
            homePage.HyperlinkSelfstorage.Click();
        }

        [When(@"the popup should be displayed")]
        public void WhenThePopupShouldBeDisplayed()
        {
            
             homePage.ClosePopUp.Displayed.Should().BeTrue("Popup should be appeared");
            
        }

        [Then(@"I click X button to disable")]
        public void ThenIClickXButtonToDisable()
        {
            homePage.ClosePopUp.Click();
        }

    }
}
