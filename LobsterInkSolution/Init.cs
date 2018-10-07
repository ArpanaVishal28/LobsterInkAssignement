using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobsterIncSolution
{
        [TestFixture]
        public class Init
        {

            public static IWebDriver driver;
            public WebDriverWait wait;



            [SetUp]
            public void SetUp()

            {
                
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://my.lobsterink.com/learn");
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            }

            [TearDown]
            public void Cleanup()

            {
                wait = null;
                driver.Close();
            }

        }
    }


