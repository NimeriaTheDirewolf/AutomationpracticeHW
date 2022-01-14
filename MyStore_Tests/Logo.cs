
using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Collections.Generic;
namespace MyStore_Tests
{
    public class Logo
    {
        private IWebDriver _driver;
        public Logo(IWebDriver driver)
        {
            _driver = driver;
        }
    }
   
}
