using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SND.POM
{
   public class Details : BasePOM
    {

        IWebDriver driver;
        public Details(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }




        public IWebElement StorageCoverPhoto => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Main site cover']"));
        public IWebElement FirstThumbnail => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='thumbnail'])[last()]"));
        public IWebElement LastThumbnail => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='thumbnail'])[1]"));
        public IWebElement FifthThumbnail => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='thumbnail'])[5]"));
        public IWebElement CloseXSlideView => driver.FindElement(By.XPath("//*[@alt='close_white']"));
        public IWebElement SecondaryStorageCoverPhoto => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Secondary small cover']"));
        public IWebElement SmallCoverPhoto => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='Small site'])[2]"));
        public IWebElement LeftSlide => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='arrow-left']"));
        public IWebElement RightSlide => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[2]"));
        public IWebElement DisableChatPopup => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@data-test-id='popup_close_button']"));
        public IWebElement HelcrunchIframe => driver.FindElement(By.XPath("//*[@name='helpcrunch-iframe']"));
        public IWebElement GETaQUOTE => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'GET A QUOTE')])[1]"));
        public IWebElement Whatsfitinthissize => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='__next']/div/div[3]/div/div[2]/div[1]/div[1]/p[3]"));
        public IWebElement XS_SE => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='__next']/div/div[3]/div/div[2]/div[1]/div[2]/span/span"));
        public IWebElement RightSliderQT => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='arrowRight']"));
        public IWebElement LeftSliderQT => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='arrowLeft']"));
        public IWebElement SelectBtnQT => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='button']//*[contains(text(),'SELECT')]"));
        public IWebElement NextBtnQT => driver.WaitUntilElementIsDisplayed(By.XPath("//span[contains(text(),'NEXT')]"));
        public IWebElement LeftSliderInCalendar => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='button'])[1]"));
        public IWebElement RightSliderInCalendar => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='button'])[2]"));
        public IWebElement FullnameQT => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Full name']"));
        public IWebElement EmailQT => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Email address']"));
        public IWebElement NumberQT => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='number']"));
        public IWebElement BackToHomePageQT => driver.FindElement(By.XPath("(//*[contains(text(), 'Back To Homepage')])[1]"));
    }
}
