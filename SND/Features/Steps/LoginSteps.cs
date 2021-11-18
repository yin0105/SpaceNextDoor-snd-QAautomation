using SND.Driver;
using System;
using TechTalk.SpecFlow;
using SND.POM;
using SND.Helpers;
using FluentAssertions;
using QAssistant.Extensions;

namespace SND.Features.Steps
{
    [Binding]
    public class LoginSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;

        public LoginSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        Login loginPage = null;


        [Given(@"I am on the Login page")]
        public void GivenIAmOnTheLoginPage()
        {
            loginPage = new Login(driver.Current);
            // Methods.GoToUrl(driver.Current, "https://stag.spacenextdoor.com");
            driver.Current.Url.Should().Be("https://stag.spacenextdoor.com/", "Url is passed form outside and im just verifying");
            loginPage.LoginSlide.Click();
            loginPage.LoginButtonOnSlider.Click();

        }
        
        [When(@"I Enter the valid ""(.*)"" Email")]
        public void WhenIEnterTheValidEmail(string email)
        {
            //its yahoo mail.
            loginPage.Email.SendKeys(email);
        }
        
        [When(@"I Mark IAgree checkbox")]
        public void WhenIMarkIAgreeCheckbox()
        {
            loginPage.IAgreeCheckBox.Click();
        }

        [When(@"I Click Login Button")]
        public void WhenIClickLoginButton()
        {
            loginPage.LoginButton.Click();
        }

        [When(@"I Check and copy Email verification code")]
        public void WhenICheckAndCopyEmailVerificationCode()
        {
            
        }
        
        [When(@"I Input Email verification code into login form")]
        public void WhenIInputEmailVerificationCodeIntoLoginForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Click Verify")]
        public void WhenIClickVerify()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The user shoud be logged in and home page shoud be displayed")]
        public void ThenTheUserShoudBeLoggedInAndHomePageShoudBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"I sign out")]
        public void GivenISignOut()
        {
            loginPage = new Login(driver.Current);
            Sleep(2500);
            loginPage.LoginSlide.Click();
            Sleep(2500);
            loginPage.Signout.Click();
        }

        [Given(@"The popup is displayed with ""(.*)""")]
        public void GivenThePopupIsDisplayedWith(string popupText)
        {
            loginPage.PopupText.Text.Should().Be(popupText, "This verifies if popup text is displayed correctly");
        }


        [Given(@"I click ""(.*)"" on popup")]
        public void GivenIClickOnPopup(string option)
        {
           // var ListiFrame = getAlliFrames(driver.Current);
           // SwitchiFrame(driver.Current, ListiFrame[0]);
            
            if (option == "Yes")
            {
                loginPage.YesPopup.Click();
            }
            else if (option=="No")
            {
                loginPage.NoPupop.Click();
            }
        }


        [Then(@"I am signed out")]
        public void ThenIAmSignedOut()
        {
            
            
            
          loginPage.LoginSlide.Click();
            loginPage.LoginButtonOnSlider.Click();
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage = new Login(driver.Current);
            loginPage.LoginButton.Click();
        }

        [Given(@"I validate if error message ""(.*)"" is displayed")]
        public void GivenIValidateIfErrorMessageIsDisplayed(string errorMessage)
        {
            loginPage.errorMessagesInLoginPage.Text.Should().Be(errorMessage, "This validates if error message displayed correctly");
        }

        [Given(@"I navigate to phone number login")]
        public void GivenINavigateToPhoneNumberLogin()
        {
            loginPage.PhoneNumberWith.Click();
        }

        [Then(@"I validate if error message ""(.*)"" is displayed")]
        public void ThenIValidateIfErrorMessageIsDisplayed(string errorMessage)
        {
            loginPage.errorMessagesInLoginPage.Text.Should().Be(errorMessage, "This validates if error message displayed correctly");
        }


    }
}
