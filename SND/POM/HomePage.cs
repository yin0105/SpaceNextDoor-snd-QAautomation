using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND.POM
{
   public class HomePage : BasePOM
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchField => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Search from Train station, district or place']"));
        public IWebElement FirstResultOfSearchField => driver.WaitUntilElementIsDisplayed(By.XPath("((//div[contains(text(),'Singapore')]))[1]"));
        public IWebElement XS_Estimator => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@class='MuiGrid-root MuiGrid-container MuiGrid-spacing-xs-6']/div)[2]"));
        public IWebElement S_Estimator => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@class='MuiGrid-root MuiGrid-container MuiGrid-spacing-xs-6']/div)[3]"));
        public IWebElement ViewAllofFirstStorge => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'VIEW ALL')])[1]"));
        public IWebElement ViewAllofSecondtStorge => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'VIEW ALL')])[2]"));
        //public IWebElement ViewAllofLastStorge => "));
        public IWebElement FirstStorageUnit => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(@class, 'MuiGrid-root MuiGrid-item MuiGrid-grid-xs-12 MuiGrid')])[3]"));
        public IWebElement SecondStorageUnit => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(@class, 'MuiGrid-root MuiGrid-item MuiGrid-grid-xs-12 MuiGrid')])[3]")); //16ad xo ar gadavakto?
        public IWebElement BookNowBtn => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'BOOK NOW')])[1]"));
        public IWebElement FullnameYourDetail => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Full name']"));
        public IWebElement EmailYourDetail => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Email address']"));
        public IWebElement PhoneNumberYourDetail => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='number']"));
        public IWebElement ReserveThisUnitBtn => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='submit'])[1]"));
        public IWebElement ContinueBtn => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='submit'])[1]"));
        public IWebElement RadioInsuranceBtn1 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='radio'])[1]"));
        public IWebElement RadioInsuranceBtn2 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'2000')])[2]"));
        public IWebElement RadioInsuranceBtn3 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='radio'])[3]"));
        public IWebElement RadioInsuranceBtn4 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='radio'])[4]"));
        public IWebElement RadioInsuranceBtn5 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='radio'])[5]"));
        public IWebElement CardNumberInPaymentMethod => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@name='cardnumber']"));
        public IWebElement MMYYInPaymentMethod => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@name='exp-date']"));
        public IWebElement CVCInPaymentMethod => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@name='cvc']"));
        public IWebElement PayBtn => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='submit'][@tabindex='0']"));
        public IWebElement iFramePayment => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@allow='payment *'])[1]']"));
        public IWebElement IsBookingConfirmed => driver.WaitUntilElementIsDisplayed(By.XPath("//*[text() = 'Your booking is confirmed!']"));      
        public IWebElement LivingRoomHomeRenv => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Living room')])[1]"));      
        public IWebElement KitchenHomeRenv => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Kitchen')])[1]"));      
        public IWebElement AppliancesHomeRenv => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Appliances')])[1]"));      
        public IWebElement OutdoorHomeRenv => driver.WaitUntilElementIsDisplayed(By.XPath("//*[text() = 'Your booking is confirmed!']"));      
        public IWebElement Sports => driver.WaitUntilElementIsDisplayed(By.XPath("//*[text() = 'Your booking is confirmed!']"));      
        public IWebElement BedFrameSingle => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='number'])[3]"));      
        public IWebElement BedFrameQueen => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='number'])[2]"));      
        public IWebElement BedFrameKing => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='number'])[1]"));
        public IWebElement HomeRenevationBtn => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='miniSquare0']"));    
        public IWebElement FindStorageBtn => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(span, 'Find storage')]"));    
        public IWebElement Declustering => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='miniSquare1']"));    
        public IWebElement NextBtnDeclustering => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Next')])[2]"));    
        public IWebElement AddBoxesPlusBtnDeclustering => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='add']"));    
        public IWebElement EstimateSizeBtnDeclustering => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'ESTIMATE SIZE')])[1]"));    
        public IWebElement FindStorageInDeclustering => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(span, 'FIND STORAGE')]"));    
        public IWebElement FindStorageInBusinessInventory => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(span, 'FIND STORAGE')]"));    
        public IWebElement RecommendedPlanDeclustering => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Recommended Plan')])[1]"));
        //business inventory
        public IWebElement BussinesInventory => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='miniSquare2']"));    
        public IWebElement OtherPurposes => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='miniSquare3']"));
        //sliders right
        public IWebElement RightSlider1 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[1]"));
        public IWebElement RightSlider2 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[2]"));
        public IWebElement RightSlider3 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[3]"));
        public IWebElement RightSlider4 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[4]"));
        //slider left
        public IWebElement LeftSlider1 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-left'])[1]"));
        public IWebElement LeftSlider2 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-left'])[2]"));
        public IWebElement LeftSlider3 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-left'])[3]"));
        public IWebElement LeftSlider4 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-left'])[4]"));

        //scroll into view
        //*[@style='transform:translateX(0px);transition-timing-function:ease;transition-duration:0.2s']
        public IWebElement FeaturedListingInSingapore => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Featured Listings in Singapore')])")); 
        public IWebElement FacebookLogo => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='https://www.facebook.com/spacenextdoor']"));
        public IWebElement InstagramLogo => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='https://www.instagram.com/spacenextdoor']"));

        //all items in other purpose
        public IWebElement BedroomItem => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Bedroom']"));
        public IWebElement LivingRoomItem => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Living room']"));
        public IWebElement KitchenItem => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Kitchen']"));
        public IWebElement AppliancesItem => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Appliances']"));
        public IWebElement OutdoorItem => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Outdoor']"));
        public IWebElement SportsItem => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Sports']"));
        public IWebElement MiscellaneousItem => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Miscellaneous']"));
        public IWebElement OfficeItem => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Office']"));
        public IWebElement SelectInactiveBoxType => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='inactive']"));
        public IWebElement WidthInBox => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='number'])[1]"));
        public IWebElement HeightInBox => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='number'])[2]"));
        public IWebElement DepthInBox => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='number'])[3]"));
        public IWebElement GoBackBtn => driver.WaitUntilElementIsDisplayed(By.XPath("//span[contains(text(),'Go back')]"));
        public IWebElement Est_SpaceNeeded_Verify => driver.WaitUntilElementIsDisplayed(By.XPath("//p[contains(text(),'183.3')]"));
        public IWebElement ClearAllListOfItems => driver.WaitUntilElementIsDisplayed(By.XPath("//a[contains(text(),'Clear all')]"));
        public IWebElement ClearOneItem => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='close'])[1]"));
        public IWebElement CounrtryDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@aria-haspopup='listbox'])[1]"));
        public IWebElement SingaporeInDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("//li[contains(text(),'Singapore')]"));
        public IWebElement ChangiInDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("//li[contains(text(),'Changi')]"));
        public IWebElement CityDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@aria-haspopup='listbox'])[2]"));
        public IWebElement DistricDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@aria-haspopup='listbox'])[3]"));
        public IWebElement GeylangDistricInDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Geylang')])[1]"));
        public IWebElement ChangiDistrictInDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Changi')])[1]"));
        public IWebElement ClementiDistrictInDropDown => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Clementi')])[1]"));
        public IWebElement StreetSearchLocation => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Search Location']"));
        public IWebElement FlatOptional => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='tel'])[1]"));
        public IWebElement Postcode => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='tel'])[2]"));
        public IWebElement NextBtnInHosting => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='submit']"));
        public IWebElement TitleOfStorage => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Cool Singapore Storage']"));
        public IWebElement WidthtMeasurement => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='text'])[1]"));
        public IWebElement DepthMeasurement => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='text'])[2]"));
        public IWebElement HeightMeasurement => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='text'])[3]"));
        public IWebElement UnitsOfThisSize => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='text'])[4]"));
        public IWebElement MonthlyPriceOfThisUnit => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='text'])[5]"));
        public IWebElement TotalAreaFt => driver.WaitUntilElementIsDisplayed(By.XPath("(//h4)[1]"));
        public IWebElement CheckwhatthisUnithas1 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'Locker')]"));
        public IWebElement CheckwhatthisUnithas2 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'Cupboard')]"));
        public IWebElement CheckwhatthisUnithas3 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'Unit')]"));
        public IWebElement PublishListingBtn => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'Publish')])[1]"));
        public IWebElement VerifyListingIsAdded => driver.WaitUntilElementIsDisplayed(By.XPath("(//h5)[1]"));


        //bookin

        public IWebElement HyperlinkSelfstorage => driver.WaitUntilFindElement(By.XPath("//*[@href='#']"));
        public IWebElement ClosePopUp => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='close']"));
        public IWebElement ClearAllFilter => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='MuiButton-label' and contains(text(),'Clear all filters')]"));
        
       

    }
}
