using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
namespace MyStore_Tests
{
    public class BaseTest: IDisposable
    {
        private IWebDriver _driver;
        

        public IWebDriver StartDtiverOnPage(string url)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            _driver.Navigate().GoToUrl(url);
            return _driver;
        }
        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
