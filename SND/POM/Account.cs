using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND.POM
{
   public class Account : BasePOM
    {
        IWebDriver driver;

        public Account(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        //ასდასდასდასდასდასდასდ
        public IWebElement EditPaymentDetails => driver.WaitUntilElementIsDisplayed(By.XPath("(//div[contains(text(),'Edit')])[last()]"));
        public IWebElement InputCardNumber => driver.WaitUntilElementIsDisplayed(By.XPath("//input[@name='cardnumber']"));
        public IWebElement SaveAccountDetails => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'save')])[1]"));
        public IWebElement MessageAfterSaving => driver.WaitUntilElementIsDisplayed(By.XPath("(//p)[last()]"));
        public IWebElement ExpDate => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@name='exp-date']"));
        public IWebElement CancelEditingPaymentDetails => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='cancelEditingPaymentDetails']"));
        public IWebElement EditFullName => driver.WaitUntilElementIsDisplayed(By.XPath("(//div[contains(text(),'Edit')])[1]"));
        public IWebElement TextFullName => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='fullNameDisplay']"));
        public IWebElement CancelFullName => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='cancelUserDetails']"));
        public IWebElement FirstNameField => driver.WaitUntilElementIsDisplayed(By.XPath("(//input[@type='text'])[1]"));
        public IWebElement LastNameField => driver.WaitUntilElementIsDisplayed(By.XPath("(//input[@type='text'])[2]"));
        public IWebElement SaveFullName => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='updateUserDetails']"));
        public IWebElement EditEmail => driver.WaitUntilElementIsDisplayed(By.XPath("(//div[contains(text(),'Edit')])[2]"));
        public IWebElement EditEmailField => driver.WaitUntilElementIsDisplayed(By.XPath("(//input[@type='text'])[1]"));
        public IWebElement EmailSaveButton => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='updateUserDetails']"));
        public IWebElement EmailTextName => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='emailAddressDisplay']"));
        public IWebElement x2 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='updateUserDetails']"));
        public IWebElement x3 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='updateUserDetails']"));
        public IWebElement x4 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='updateUserDetails']"));
        
    }      //input[@type='text'][1]
}
