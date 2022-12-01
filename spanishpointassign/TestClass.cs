
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Collections.Generic;
using spanishpointassign.baseClass;
using System;

namespace spanishpointassign
{
    [TestFixture]
    public class TestClass:baseclass
    {
        [Test]
        public void TestMethod()
        {
            //Cookie Handling
            IWebElement cookieRejBtn = driver.FindElement(By.XPath("//a[@id ='wt-cli-reject-btn']"));
            cookieRejBtn.Click();

            //Modern work link
            IWebElement ModernworkLink = driver.FindElement(By.XPath("//a[@href='https://www.spanishpoint.ie/solutions/modern-workplace/']"));
            ModernworkLink.Click();

            //Employer experience tab 
            IWebElement EmpExpTab = driver.FindElement(By.XPath("//a[@href='#1612869843368-c8e2f605-d38c']"));
            EmpExpTab.Click();

            //Text
            IWebElement textElement = driver.FindElement(By.XPath("//p/strong[1]"));
            string ActulResult = textElement.Text;
            NUnit.Framework.TestContext.WriteLine(ActulResult);
            string expectedResult = "Engaging, Mobile Intranet and Digital Workspace collaboration solution.";

            try
            {
                Assert.AreEqual(expectedResult, ActulResult);
                Console.WriteLine("Test case passed");
                Assert.Pass();
                
            }
            catch (Exception e) {
                TestContext.Out.WriteLine(e);
            }
        }
    }
}
