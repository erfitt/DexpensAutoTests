using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DexpensAutoTests
{
    class LoginPage
    {
        public LoginPage(string username, string password)
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
            UserLogin(username, password);
        }
        [FindsBy(How = How.XPath, Using = "//img[@alt='Close']")]
        public IWebElement popup { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='LOG IN']")]
        public IWebElement btnLoginFirst { get; set; }

        [FindsBy(How = How.Id, Using = "Login")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        public IWebElement btnLogin { get; set; }

        public void UserLogin(string username, string password)
        {
            popup.Click();
            btnLoginFirst.Click();
            Thread.Sleep(800);
            //txtUserName = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(txtUserName.GetAttribute("Id"));
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            UserLoginClick();
        }
        public void UserLoginClick()
        {
            btnLogin.Click();
        }

    }
}
