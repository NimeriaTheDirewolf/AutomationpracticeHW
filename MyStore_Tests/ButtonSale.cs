using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Collections.Generic;

namespace MyStore_Tests
{
    public class ButtonSale
    {
        private IWebDriver _driver;
        public ButtonSale(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
