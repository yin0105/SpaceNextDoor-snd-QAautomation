using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND.POM
{
   public class Login : BasePOM
    {
        IWebDriver driver;

        public Login(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement LoginSlide => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='MuiButtonBase-root MuiIconButton-root']"));
        public IWebElement LoginButtonOnSlider => driver.WaitUntilElementIsDisplayed(By.XPath("//span[contains(@class,'MuiButton-label') and text() = 'login']")); //adjustment need on id.
        public IWebElement Email => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Email']"));
        public IWebElement LoginButton => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='submit']"));
        public IWebElement IAgreeCheckBox => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'By signing in, I agree to Terms of Use and Privacy Policy.')]"));
        public IWebElement PhoneNumberWith => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='viaPhoneNumber']"));
        public IWebElement InputPhoneNumber => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='text']"));
        public IWebElement LoginBtnViaPhoneNumber => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='loginButton']"));
        public IWebElement OTPField => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='tel']"));
        public IWebElement VerifyOTP => driver.WaitUntilElementIsDisplayed(By.XPath("//div[contains(text(),'VERIFY')]"));
        public IWebElement Signout => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='signOut']"));
        public IWebElement PopupText => driver.WaitUntilElementIsDisplayed(By.XPath("//p[contains(text(),'Are you sure you want to Sign Out?')]"));
        public IWebElement YesPopup => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'YES')])[2]")); //yes on popup. should be improved with child class
        public IWebElement NoPupop => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'NO')])[2]"));
        public IWebElement errorMessagesInLoginPage => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(@class, 'MuiFormHelperText')]"));
    }
}
