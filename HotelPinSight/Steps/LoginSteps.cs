using HotelPinSight.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace HotelPinSight.Steps
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;
        private HotelPage _hotelPage;

        [Given(@"Given that I navigate to the pinSight application")]
        public void GivenGivenThatINavigateToThePinSightApplication()
        {
            _driver = WebDriverFactory.Create();
            _loginPage = LoginPage.NavigateTo(_driver);
        }
        
        [Given(@"And I enter testuser@mailinator\.com as the username")]
        public void GivenAndIEnterTestuserMailinator_ComAsTheUsername(string username)
        {
            _loginPage.Username = username;
        }
        
        [Given(@"I enter Test@(.*) as password")]
        public void GivenIEnterTestAsPassword(string password)
        {
            _loginPage.Password = password;
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            _hotelPage = _loginPage.Login();
        }
        
        [Then(@"I should land on the Hotel page")]
        public void ThenIShouldLandOnTheHotelPage()
        {
            _hotelPage.EnsurePageIsLoaded();
            Assert.AreEqual("home", _driver.Title);//fix this
        }
    }
}
