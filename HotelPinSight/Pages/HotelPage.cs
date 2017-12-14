using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace HotelPinSight.Pages
{
    public class HotelPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "ucPWP_ctl08_55218_lnkGoToBackOffice")]
        private IWebElement _backOfficeButton;

        public HotelPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnsurePageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.StartsWith("P UAT"));
        }

        //public HotelSearchPage GoToFrontOffice()
        //{
        //    _frontOfficeButton.Click();
        //    return new HotelSearchPage(_driver);
        //}
    }
}
