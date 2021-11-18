using SND.Driver;
using SND.Helpers;
using SND.POM;
using FluentAssertions;
using TechTalk.SpecFlow;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SND.Features.Steps
{
    [Binding]
    public class AccountSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;

        public AccountSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }
        Account accountPage = null;
        ReadOnlyCollection<IWebElement> ListiFrame = null;

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string urlCustomerAccount)
        {
            
            accountPage = new Account(driver.Current);
            Sleep(450);
            GoToUrl(driver.Current, urlCustomerAccount);

        }


        [Given(@"I click edit on payment details debit card field")]
        public void GivenIClickEditOnPaymentDetailsDebitCardField()
        {
            Sleep(2500);
            accountPage.EditPaymentDetails.Click();
        }

        [Given(@"I input the ""(.*)"" debit card credentials")]
        public void GivenIInputTheDebitCardCredentials(string condition)
        {
            ListiFrame = getAlliFrames(driver.Current);
            SwitchiFrame(driver.Current, ListiFrame[0]);
            if (condition=="correct")
            {           
                Sleep();
                accountPage.InputCardNumber.SendKeys("41111111111111111123432");
                driver.Current.SwitchTo().DefaultContent();
            }
            else if (condition=="incorrect")
            {
                Sleep();
                accountPage.InputCardNumber.SendKeys("40111111111111111123432");
                driver.Current.SwitchTo().DefaultContent();
            }
        }


        [When(@"I click save button")]
        public void WhenIClickSaveButton()
        {
            accountPage.SaveAccountDetails.Click();
        }
        
        [Then(@"The success message  should be ""(.*)"" displayed")]
        public void ThenTheSuccessMessageShouldBeDisplayed(string succesMessage)
        {
            Sleep(3500);
            accountPage.MessageAfterSaving.Text.Should()
                .Be(succesMessage, "This verifies if success message displayed");
        }


        [When(@"I input the incorrect expiratioal ""(.*)"" year")]
        public void WhenIInputTheIncorrectExpiratioalYear(string expYear)
        {
            SwitchiFrame(driver.Current, ListiFrame[0]);
            Sleep();
            accountPage.InputCardNumber.Clear();
            accountPage.InputCardNumber.SendKeys($"411111111111111111{expYear}432");
            driver.Current.SwitchTo().DefaultContent();
        }


        [Then(@"The error message  should be ""(.*)"" displayed")]
        public void ThenTheErrorMessageShouldBeDisplayed(string errorMessage)
        {
            Sleep(3500);
            accountPage.MessageAfterSaving.Text.Should().Be(errorMessage, "This verifies if error message displayed correctly");
            
        }

        [Then(@"I input only card number without mm/yy cvc")]
        public void ThenIInputOnlyCardNumberWithoutMmYyCvc()
        {
            SwitchiFrame(driver.Current, ListiFrame[0]);
            Sleep();
            accountPage.ExpDate.Clear();
            driver.Current.SwitchTo().DefaultContent();

        }


        [Then(@"I Input the incorrect expiratioal ""(.*)"" month")]
        public void ThenIInputTheIncorrectExpiratioalMonth(string expMonth)
        {
            
            
            accountPage.CancelEditingPaymentDetails.Click();
            GivenIClickEditOnPaymentDetailsDebitCardField();
            ListiFrame = getAlliFrames(driver.Current);
            SwitchiFrame(driver.Current, ListiFrame[0]);
            accountPage.InputCardNumber.SendKeys($"4111111111111111{expMonth}21432");
            driver.Current.SwitchTo().DefaultContent();
        }

        [Then(@"I dont input CVV code")]
        public void ThenIDontInputCVVCode()
        {
            accountPage.CancelEditingPaymentDetails.Click();
            GivenIClickEditOnPaymentDetailsDebitCardField();
            ListiFrame = getAlliFrames(driver.Current);
            SwitchiFrame(driver.Current, ListiFrame[0]);
            Sleep();
            accountPage.InputCardNumber.SendKeys("41111111111111111123");
            driver.Current.SwitchTo().DefaultContent();
        }
        string savedName;

        [Given(@"I save fullname current text")]
        public void GivenISaveFullnameCurrentText()
        {
            savedName = accountPage.TextFullName.Text;
        }

        [Given(@"I click full name  edit button in accout details")]
        public void GivenIClickFullNameEditButtonInAccoutDetails()
        {
            accountPage.EditFullName.Click();
        }

        [When(@"I click cancel button")]
        public void WhenIClickCancelButton()
        {
            accountPage.CancelFullName.Click();
        }

        [Then(@"I validate full name is not changed")]
        public void ThenIValidateFullNameIsNotChanged()
        {
            accountPage.TextFullName.Text.Should().Be(savedName);
            
        }
        string fullNameText;
        

        //[Given(@"I save fullname text")]
        //public void GivenISaveFullnameText()
        //{
        //    fullNameText = accountPage.TextFullName.Text;
        //}

        [Given(@"I clear textfield")]
        public void GivenIClearTextfield()
        {

            accountPage.FirstNameField.SendKeys(Keys.Control + "a" + Keys.Backspace);
        }

        [Given(@"I input firstname")]
        public void GivenIInputFirstname()
        {
            accountPage.FirstNameField.SendKeys("Buka");
        }
        [Given(@"I clear textfield lastname")]
        public void GivenIClearTextfieldLastname()
        {
            accountPage.LastNameField.SendKeys(Keys.Control + "a" + Keys.Backspace);
        }


        [Given(@"I input lastname")]
        public void GivenIInputLastname()
        {
            accountPage.LastNameField.SendKeys("Gulua");
        }

        [When(@"I click save button in full and lastname fields")]
        public void WhenIClickSaveButtonInFullAndLastnameFields()
        {
            accountPage.SaveAccountDetails.Click();
        }

        [Then(@"I validate fullname is changed")]
        public void ThenIValidateFullnameIsChanged()
        {
            accountPage.TextFullName.Text.Should().Be("Buka Gulua");

           
        }

        string emailName;

        [Given(@"I click email edit button on accounts page")]
        public void GivenIClickEmailEditButtonOnAccountsPage()
        {
            accountPage.EditEmail.Click();
        }
        [Given(@"I click email input field")]
        public void GivenIClickEmailInputField()
        {
            accountPage.EditEmailField.Click();
        }

        [Given(@"I input email")]
        public void GivenIInputEmail()
        {
            accountPage.EditEmailField.SendKeys("bukamd@gmail.com");
        }

        [Given(@"I clikc save button in email field")]
        public void GivenIClikcSaveButtonInEmailField()
        {
            accountPage.EmailSaveButton.Click();
        }

        //[When(@"I check email exhists")]
        //public void WhenICheckEmailExhists()
        //{
        //    emailName = accountPage.EmailTextName.Text;
        //}

        [Then(@"I validate email is changed")]
        public void ThenIValidateEmailIsChanged()
        {
            accountPage.EmailTextName.Text.Should().Be("bukamd@gmail.com");
        }



    }
}
