using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Collections.Generic;
namespace MyStore_Tests
{
    public class ContactUs
    {
        private IWebDriver _driver;
        public ContactUs(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
