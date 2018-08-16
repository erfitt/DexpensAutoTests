using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexpensAutoTests.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement firstNameTxt { get; set; }
        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement lastNameTxt { get; set; }
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement emailTxt { get; set; }
        [FindsBy(How = How.Id, Using = "passwordField")]
        public IWebElement passwordT { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='box-tick']")]

        public IWebElement randomPassChB { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='checkbox-tick']")]
        public IWebElement agreedChB { get; set; }
        [FindsBy(How = How.Id, Using = "register-finally")]
        public IWebElement registerBtn { get; set; }

        [FindsBy(How = How.ClassName, Using = "swap-to-email")]
        public IWebElement swapToPhoneBtn { get; set; }
        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        public IWebElement PhoneTxt { get; set; }
        [FindsBy(How = How.ClassName, Using = "selected-dial-code")]
        public IWebElement phoneIndexCodeBtn { get; set; }

        [FindsBy(How = How.Id, Using = "Google-button")]
        public IWebElement googleBtn { get; set; }
        [FindsBy(How = How.Id, Using = "Facebook-button")]
        public IWebElement facebookBtn { get; set; }

        public void RegisterClick()
        {
            registerBtn.Click();
        }
        public void UserRegisterDefault(string firstName, string lastName, string email, string password)
        {
            firstNameTxt.SendKeys(firstName);
            lastNameTxt.SendKeys(lastName);
            emailTxt.SendKeys(email);
            passwordT.SendKeys(password);
            RegisterClick();
        }
        public void UserRegisterPhone(string firstName, string lastName, string phoneNubmer, string password)
        {
            ChangeToPhone();
            firstNameTxt.SendKeys(firstName);
            lastNameTxt.SendKeys(lastName);
            PhoneTxt.SendKeys(phoneNubmer);
            passwordT.SendKeys(password);
            RegisterClick();
        }
        public void ChangeToPhone()
        {
            swapToPhoneBtn.Click();
        }
        public void ChangePhoneIndex()
        {
            //Needs to implement
        }
    }
}
