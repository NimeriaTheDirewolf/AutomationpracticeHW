using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace MyStore_Tests
{
    public class Body
    {
        protected IWebDriver _driver;

        public Body(IWebDriver driver)
        {
            _driver = driver;

        }
    }
}