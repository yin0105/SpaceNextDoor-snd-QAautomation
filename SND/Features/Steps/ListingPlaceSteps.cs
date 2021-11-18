using SND.Driver;
using SND.POM;
using System;
using TechTalk.SpecFlow;
using QAssistant.Extensions;
using QAssistant.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SND.Helpers;
using TechTalk.SpecFlow.Assist;
using FluentAssertions;

namespace SND.Features.Steps
{
    [Binding]
    public class ListingPlaceSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;


        public ListingPlaceSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        HomePage homePage = null;
        Login loginPage = null;

        [Given(@"I log in with hardcoded ""(.*)"" and ""(.*)""")]
        public void GivenILogInWithHardcodedAnd(int phoneNumber, int OTP)
        {
            homePage = new HomePage(driver.Current);
            loginPage = new Login(driver.Current);
            loginPage.LoginSlide.Click();
            loginPage.LoginButtonOnSlider.Click();
            loginPage.PhoneNumberWith.Click();
            loginPage.InputPhoneNumber.SendKeys(phoneNumber.ToString());
            loginPage.IAgreeCheckBox.Click();
            loginPage.LoginBtnViaPhoneNumber.Click();
            loginPage.OTPField.SendKeys(OTP.ToString());
            loginPage.VerifyOTP.Click();
            
            //IWebElement otpFieldParent =loginPage.OTPField.GetParent();
            //otpFieldParent.SendKeys(OTP.ToString());
        }

        [Given(@"I select switch to host")]
        public void GivenISelectSwitchToHost()
        {
            Sleep(4555);
            loginPage.LoginSlide.Click();
            homePage.SwitchToHost.Click();
            homePage.CreateListing.Click();
        }

        [Given(@"I select ""(.*)"" in property dropdown")]
        public void GivenISelectInPropertyDropdown(string option)
        {
            
            if (option == "Commercial")
            {
                homePage.PropertyTypeDropDown.Click();
                homePage.CommercialDropDown.Click();
            }
            else if (option == "Industrial")
            {
                homePage = new HomePage(driver.Current);
                homePage.PropertyTypeDropDown.Click();
                homePage.IndustrialDropDown.Click();

            }
            else if (option == "Residental")
            {
                homePage.PropertyTypeDropDown.Click();
                homePage.ResidentalDropDown.Click();
            }
        }


        [Given(@"I select what floor is the space on ""(.*)""")]
        public void GivenISelectWhatFloorIsTheSpaceOn(string floorNumber)
        {
            homePage.FloorTypeDropDown.Click();
            Sleep();
            driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//li[contains(text(),'{floorNumber}')]")).Click();
        }

        [Given(@"I mark are you listing SND as part of a company\? ""(.*)""")]
        public void GivenIMarkAreYouListingSNDAsPartOfACompany(string listingType)
        {
            if(listingType== "registered business")
            {
                homePage.HostingAsRegisteredBusiness.GetParent().Click();
            }
            else if (listingType== "individual or sole owner")
            {
                homePage.HostingAsAIndividualOwner.Click();
            }
      
        }

        [Given(@"I Select ""(.*)"" in Country/Region dropdown")]
        public void GivenISelectInCountryRegionDropdown(string countryOption)
        {
            if (countryOption=="Singapore")
            {
                Sleep(2000);
                homePage.CounrtryDropDown.Click();
                homePage.SingaporeInDropDown.Click();
                
            }
            else if (countryOption=="another country")
            {
                //do some click logic here
            }
        }

        [Given(@"I Select ""(.*)"" in City dropdown")]
        public void GivenISelectInCityDropdown(string cityOption)
        {
            if (cityOption=="Singapore")
            {
                homePage.CityDropDown.Click();
                homePage.SingaporeInDropDown.Click();
            }
            else if(cityOption=="Changi")
            {
                homePage.CityDropDown.Click();
                homePage.ChangiInDropDown.Click();
            }
        }

        [Given(@"I select ""(.*)"" in District dropdown")]
        public void GivenISelectInDistrictDropdown(string districOption)
        {
            if (districOption=="Geylang")
            {
                
                homePage.DistricDropDown.Click();
                driver.Current.ScrollIntoView(homePage.GeylangDistricInDropDown);
                homePage.GeylangDistricInDropDown.Click();
            }
            else if (districOption=="Changi")
            {
                homePage.DistricDropDown.Click();
                driver.Current.ScrollIntoView(homePage.ChangiDistrictInDropDown);
                homePage.ChangiDistrictInDropDown.Click();
            }
            else if (districOption=="Clementi")
            {
                homePage.DistricDropDown.Click();
                driver.Current.ScrollIntoView(homePage.ClementiDistrictInDropDown);
                homePage.ClementiDistrictInDropDown.Click();

            }
        }

        [Given(@"I search and select ""(.*)"" in street field")]
        public void GivenISearchAndSelectInStreetField(string streetOptions)
        {
            if (streetOptions== "Geylang, Singapore")
            {
                //IJavaScriptExecutor js = (IJavaScriptExecutor)driver.Current;
                //js.ExecuteScript($"arguments[0].value='{streetOptions}';", homePage.StreetSearchLocation);
                
                homePage.StreetSearchLocation.SendKeys(streetOptions);
                driver.Current.WaitUntilElementIsDisplayed(By.XPath("(//div[@role='option'])[1]")).Click(); ;
            }
            else if (streetOptions=="Singapore")
            {
                homePage.StreetSearchLocation.SendKeys(streetOptions);
                driver.Current.WaitUntilElementIsDisplayed(By.XPath("(//div[@role='option'])[1]")).Click();
            }
        }

        [Given(@"I input ""(.*)"" in Flat field")]
        public void GivenIInputInFlatField(int flatOption)
        {
            homePage.FlatOptional.SendKeys(flatOption.ToString());
        }

        [Given(@"I input ""(.*)"" in Postcode field")]
        public void GivenIInputInPostcodeField(int postCode)
        {
            Sleep();
            homePage.Postcode.SendKeys(postCode.ToString());
        }

        [Given(@"I click next button in hosting")]
        public void GivenIClickNextButtonInHosting()
        {
            Sleep();
            homePage.NextBtnInHosting.Click();
        }

        [Given(@"I mark all options in features page")]
        public void GivenIMarkAllOptionsInFeaturesPage()
        {
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'WIFI')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Power supply')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Sprinkler')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Racking/Shelving')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Step ladder')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Trollyes')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Free parking')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'CCTV')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Security')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'24 hours access')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Air con')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Lift access')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Lockable doors')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'On Site staff')]")).Click();
                driver.Current.WaitUntilElementIsDisplayed(By.XPath($"//*[contains(text(),'Loading dock')]")).Click();

        }

        [Given(@"I upload photo of storage")]
        public void GivenIUploadPhotoOfStorage()
        { 
            Sleep();
            driver.Current.WaitUntilFindElement(By.XPath("(//input)[1]")).SendKeys(@"C:\testStorage.jpg");
           // driver.Current.WaitUntilFindElement(By.XPath("(//input)[1]")).SendKeys(@"C:\Users\lukag\OneDrive\testStorage");
        }

        [Given(@"I input ""(.*)"" of my storage")]
        public void GivenIInputOfMyStorage(string title)
        {
            homePage.TitleOfStorage.SendKeys(title);
        }

        [Given(@"I input ""(.*)"" in describe your place field")]
        public void GivenIInputInDescribeYourPlaceField(string description)
        {
            driver.Current.WaitUntilElementIsDisplayed(By.XPath("//textarea")).SendKeys(description);
        }

        [Given(@"I input following parameters")]
        public void GivenIInputFollowingParameters(Table table)
        {
            homePage.HeightMeasurement.SendKeys(Keys.Control + "a" + Keys.Delete);
            homePage.WidthtMeasurement.SendKeys(Keys.Control + "a" + Keys.Delete);
            homePage.DepthMeasurement.SendKeys(Keys.Control + "a" + Keys.Delete);
            dynamic data = table.CreateDynamicInstance();
            
            homePage.WidthtMeasurement.SendKeys(data.Width.ToString());
            homePage.DepthMeasurement.SendKeys(data.Depth.ToString());
            homePage.HeightMeasurement.SendKeys(data.Height.ToString());
        }

        [Given(@"I verify if Total Area ""(.*)"" is calculated correctly")]
        public void GivenIVerifyIfTotalAreaIsCalculatedCorrectly(string totalAreaCalculated)
        {

            homePage.TotalAreaFt.Text.Should().Be(totalAreaCalculated, "This verifies if Total area calculated correctly");
        }

        [Given(@"I input Units of the size ""(.*)""")]
        public void GivenIInputUnitsOfTheSize(string sizeOfUnits)
        {
            homePage.UnitsOfThisSize.SendKeys(Keys.Control + "a" + Keys.Delete);
            homePage.UnitsOfThisSize.SendKeys(sizeOfUnits);
        }

        [Given(@"I input Monthly price ""(.*)""")]
        public void GivenIInputMonthlyPrice(string monthlyPrice)
        {
            homePage.MonthlyPriceOfThisUnit.SendKeys(Keys.Control + "a" + Keys.Delete);
            homePage.MonthlyPriceOfThisUnit.SendKeys(monthlyPrice);
        }

        [Given(@"I mark some options this unit has")]
        public void GivenIMarkSomeOptionsThisUnitHas()
        {
            homePage.CheckwhatthisUnithas1.Click();
            homePage.CheckwhatthisUnithas2.Click();
            homePage.CheckwhatthisUnithas3.Click();
        }

        [Given(@"I click publish button")]
        public void GivenIClickPublishButton()
        {
            homePage.PublishListingBtn.Click();
        }

        [When(@"I get redirected to listings page")]
        public void WhenIGetRedirectedToListingsPage()
        {
            Sleep();
            driver.Current.Url.Should().Be("https://stag.spacenextdoor.com/host/listings");
        }

        [Then(@"I should see ""(.*)"" in  Your listings")]
        public void ThenIShouldSeeInYourListings(string listedSpaceName)
        {
            homePage.VerifyListingIsAdded.Text.Should().Be(listedSpaceName, "This verifies if listing is added succesfully");
        }

    }
}
