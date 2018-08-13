using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexpensAutoTests
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// Extended method for entering text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        /// <summary>
        /// Click into button, dropdown
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }
        /// <summary>
        /// Selecting dropdown
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
