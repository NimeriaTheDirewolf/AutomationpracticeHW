using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
namespace MyStore_Tests
{
    public class UnitTest2: BaseTest
    {
        [Fact]
        public void TestSearch()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homePage = new Header(driver);
            homePage.fillSearch();
        }
        [Fact]
        public void TestSearch2()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homePage = new Header(driver);
            homePage.clickSearch();
        }
        [Fact]
        public void TestLupa()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homePage = new Header(driver);
            homePage.clickLupa();
        }

        [Fact]
        public void TestCart()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.clickCart();
        }

        [Fact]
        public void TestLogo()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.clickLogo();
        }

        [Fact]
        public void TestWomen()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.dropDownWomen();
        }

        [Fact]
        public void TestDresses()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.dropDownDresses();
        }

        [Fact]
        public void TestTShirts()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.dropDownTShirts();
        }

        [Fact]
        public void TestTShirts_Women()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.tShirts_women();
        }

        [Fact]
        public void TestBlouses_Women()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.blouses_women();
        }

        [Fact]
        public void TestCasualDress_Women()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.casualDresses_women();
        }

        [Fact]
        public void TestEveningDress_Women()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.eveningDresses_women();
        }

        [Fact]
        public void TestSummerDress_Women()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.summerDresses_women();
        }

        [Fact]
        public void TestCasualDress_Dresses()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.casualDresses_dresses();
        }

        [Fact]
        public void TestEveningDress_Dresses()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.eveningDresses_dresses();
        }

        [Fact]
        public void TestSummerDress_Dresses()
        {
            IWebDriver driver = StartDtiverOnPage("http://automationpractice.com/index.php");
            Header homepage = new Header(driver);
            homepage.summerDresses_dresses();
        }

    }
}
