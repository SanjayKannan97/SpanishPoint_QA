using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spanishpointassign.baseClass
{
    public class baseclass
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            string url = "https://www.spanishpoint.ie/";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [OneTimeTearDown]
        public void close()
        {
            driver.Close();
        }

    }
}
