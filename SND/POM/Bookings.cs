using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND.POM
{
  public class Bookings : BasePOM
    {
        IWebDriver driver;

        public Bookings(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement PromotionError => driver.WaitUntilElementIsDisplayed(By.XPath("//p[contains(text(),'The promotion cannot be applied to this booking because it does not meeting the minimum criteria')]"));
        public IWebElement MoveOutCalendar => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='calendar'])[2]"));
        public IWebElement MoveInCalendar => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='calendar'])[1]"));
        public IWebElement ConfirmCalenar => driver.WaitUntilElementIsDisplayed(By.XPath("//p[contains(text(),'confirm')]"));
        public IWebElement YearPromo => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@id='promo0']/label/span)[1]"));
        public IWebElement SIXmnthPromo => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@id='promo1']/label/span)[2]"));
        public IWebElement THREEmnthPomo => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@id='promo2']/label/span)[2]"));
        public IWebElement NoPromo => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@aria-label='promoId']//child::*//span)[last()]"));
        public IWebElement PromoInputField => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Promo Code']"));
        public IWebElement ApplyPromoBtn => driver.WaitUntilElementIsDisplayed(By.XPath("//p[contains(text(),'APPLY')]"));
        public IWebElement VoucherPromoError => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='MuiFormHelperText-root MuiFormHelperText-contained Mui-error MuiFormHelperText-filled']"));
        public IWebElement MoveInSearchPage => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='openMoveInDateModal']"));
        public IWebElement MoveOutSearchPage => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='openMoveOutDateModal']"));
        public IWebElement n14 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement n15 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
    }
}
