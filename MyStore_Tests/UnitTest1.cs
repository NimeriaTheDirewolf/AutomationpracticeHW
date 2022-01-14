using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Collections.Generic;

namespace MyStore_Tests
{
    public class UnitTest1: BaseTest
    {
        [Fact]
        public void TestBase()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homePage = new Header(driver);
            homePage.clickSignIn();
        }
        [Fact]
        public void TestContactUs()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homePage = new Header(driver);
            homePage.clickContactUs();
        }
        [Fact]
        public void TestButtonSale()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homePage = new Header(driver);
            homePage.clickButtonSale();
        }
        
    }
}
