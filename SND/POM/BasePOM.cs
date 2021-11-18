using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using QAssistant.Extensions;

namespace SND.POM
{
  public  class BasePOM
    {
        IWebDriver driver;

        public BasePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public BasePOM()
        {

        }



        #region ALL Xpath which are needed everywhere

        public IWebElement SwitchToHost => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='switchToHost']"));
        public IWebElement CreateListing => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='createListingsButton']"));
        public IWebElement PropertyTypeDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@aria-haspopup='listbox']"));
        public IWebElement CommercialDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'Commercial')]"));
        public IWebElement IndustrialDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'Industrial')]"));
        public IWebElement ResidentalDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'Residential')]"));
        public IWebElement FloorTypeDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@aria-haspopup='listbox'])[2]"));
        public IWebElement HostingAsRegisteredBusiness => driver.WaitUntilElementIsDisplayed(By.XPath("//span[contains(text(),'I’m hosting as a registered business')]")); //gasasworebelia
        public IWebElement HostingAsAIndividualOwner => driver.WaitUntilElementIsDisplayed(By.XPath("//span[contains(text(),'I’m hosting as an individual or sole owner')]"));
        public IWebElement x1 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x2 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x3 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));

        #endregion ALL Xpath which are needed everywhere
    }
}
