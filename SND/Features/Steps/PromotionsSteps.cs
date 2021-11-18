using FluentAssertions;
using SND.Driver;
using SND.Helpers;
using SND.POM;
using System;
using TechTalk.SpecFlow;
using QAssistant.Extensions;
namespace SND.Features.Steps
{
    [Binding]
    public class PromotionsSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;

        public PromotionsSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }
        HomePage homePage = null;
        Bookings bookingsPage = null;
        [Given(@"I select ""(.*)"" public promo")]
        public void GivenISelectPublicPromo(string promoType)
        {

            bookingsPage = new Bookings(driver.Current);

            if (promoType == "1year")
            {
                bookingsPage.YearPromo.Click();
            }
            else if (promoType == "6month")
            {
                bookingsPage.SIXmnthPromo.Click();
            }
            else if (promoType == "3month")
            {
                bookingsPage.THREEmnthPomo.Click();
            }
            else if (promoType == "No, I don't need promotion")
            {
                bookingsPage.NoPromo.Click();
            }
        }

        [Given(@"I select ""(.*)"" date in calendar")]
        public void GivenISelectDateInCalendar(string moveType)
        {
            if (moveType == "Move_Out")
            {
                var parentButton = bookingsPage.MoveOutCalendar.GetParent().GetParent();
                // bookingsPage.MoveOutCalendar.Click();
                parentButton.Click();
                bookingsPage.ConfirmCalenar.Click();
            }          
        }

        [Given(@"I validate if error message ""(.*)"" displayed")]
        public void GivenIValidateIfErrorMessageDisplayed(string errorMessage)
        {
            bookingsPage.PromotionError.Text.Should().Be(errorMessage, "This verifies if error message displayed correctly");

        }

        [Given(@"I Input ""(.*)"" promo code")]
        public void GivenIInputPromoCode(string promoCode)
        {
            if (promoCode == "incorrect")
            {
                bookingsPage.PromoInputField.SendKeys(promoCode);
            }
            else if (promoCode == "")
            {
                //if any real promo code needs to be testes with different flom we can write logic here.
            }
        }

        [When(@"I click promo apply button")]
        public void WhenIClickPromoApplyButton()
        {

            bookingsPage.ApplyPromoBtn.Click();
        }

        [Then(@"I validate if error message ""(.*)"" displayed")]
        public void ThenIValidateIfErrorMessageDisplayed(string errorTextPromoCode)
        {
            bookingsPage.VoucherPromoError.Text.Should().Be(errorTextPromoCode, "This verifies if error message displayed correctly");
        }      
        }
    }

