using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotelPinSight.Pages
{
    /// <summary>
    /// The login page for the TavelNXT platform.
    /// </summary>
    public class LoginPage : BasePage
    {
        private const string APP_URL = "https://uat-parallel-managetlg.travelnxt.com/Login";

        [FindsBy(How = How.Id, Using = "userName")]
        private IWebElement _username;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _passWord;

        [FindsBy(How = How.Id, Using = "SubmitButton")]
        private IWebElement _signInButton;

        public string Username
        {
            get
            {
                return _username.Text;
            }
            set
            {
                _username.SendKeys(value);
            }
        }

        public string Password
        {
            set
            {
                _passWord.SendKeys(value);
            }
        }        

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver"></param>
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Navigate to the page.
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static LoginPage NavigateTo(IWebDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver));
            }

            driver.Navigate().GoToUrl(APP_URL);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.StartsWith("Login"));
            return new LoginPage(driver);
        }

        public HotelPage Login()
        {
            _signInButton.Click();
            return new HotelPage(_driver);
        }
    }
}

