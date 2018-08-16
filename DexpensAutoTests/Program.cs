using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexpensAutoTests
{
    
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //PropertiesCollection.driver = new FirefoxDriver();
            //ExcelLib.PopulateInCollection(@"D:\data.xlsx");   
            PropertiesCollection.driver.Manage().Window.Maximize();

            PropertiesCollection.driver.Navigate().GoToUrl("https://dexpens-dev.azurewebsites.net/");
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

        [Test]
        public void UserLogin()
        {
            var myUser = new LoginPage("yuriiaxionweb@gmail.com", "111111");
        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Quit();
        }
    }
}
