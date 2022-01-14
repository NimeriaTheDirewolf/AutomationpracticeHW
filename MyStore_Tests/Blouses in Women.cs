using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Collections.Generic;
namespace MyStore_Tests
{
    public class Blouses_in_Women
    {
        private IWebDriver _driver;
        public Blouses_in_Women(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
