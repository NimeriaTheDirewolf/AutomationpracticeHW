using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
namespace MyStore_Tests
{
    public class Header
    {
        protected IWebDriver _driver;

        public Header(IWebDriver driver)
        {
            _driver = driver;
            
        }
        private By _signIn = By.LinkText("Sign in");
        private By _contactUs = By.LinkText("Contact us");
        private By _buttonSale = By.CssSelector(".row > a > .img-responsive");
        private By _search = By.Id("search_query_top");
        private By _lupa = By.Name("submit_search");
        private By _cart = By.CssSelector(".shopping_cart > a");
        private By _logo = By.CssSelector(".logo");
        private By _dropDownWomen = By.XPath("//a[contains(text(),'Women')]");
        private By _dropDownDresses = By.XPath("(//a[contains(text(),'Dresses')])[5]");
        private By _dropDownTShirts = By.XPath("(//a[contains(text(),'T-shirts')])[2]");
        private By _tShirts_women = By.LinkText("T-shirts");
        private By _blouses_women = By.LinkText("Blouses");
        private By _casualDresses_women = By.LinkText("Casual Dresses");
        private By _eveningDresses_women = By.LinkText("Evening Dresses");
        private By _summerDresses_women = By.XPath("//a[contains(text(),'Summer Dresses')]");
        private By _casualDresses_dresses = By.XPath("(//a[contains(text(),'Casual Dresses')])[2]");
        private By _eveningDresses_dresses = By.XPath("(//a[contains(text(),'Evening Dresses')])[2]");
        private By _summerDresses_dresses = By.XPath("(//a[contains(text(),'Summer Dresses')])[2]");

        public Header clickSignIn()
        {
            _driver.FindElement(_signIn).Click();
            return this;
        }

        public ContactUs clickContactUs()
        {
            _driver.FindElement(_contactUs).Click();
            return new ContactUs(_driver);
        }

        public ButtonSale clickButtonSale()
        {
            _driver.FindElement(_buttonSale).Click();
            return new ButtonSale(_driver);
        }

        
        public Search fillSearch()
        {
            _driver.FindElement(_search).SendKeys("shorts");
            return new Search(_driver);
        }

        public Search clickSearch()
        {
            _driver.FindElement(_search).SendKeys("shorts");
            _driver.FindElement(_search).SendKeys(Keys.Enter);
            return new Search(_driver);
        }

        public Search clickLupa()
        {
            _driver.FindElement(_search).SendKeys("shorts");
            _driver.FindElement(_lupa).Click();
            return new Search(_driver);
        }

        public Cart clickCart()
        {
            _driver.FindElement(_cart).Click();
            return new Cart(_driver);
        }

        public Logo clickLogo()
        {
            _driver.FindElement(_logo).Click();
            return new Logo(_driver);
        }

        public Header dropDownWomen()
        {
            Actions actions = new Actions(_driver);       
           IWebElement element =  _driver.FindElement(_dropDownWomen);
            actions.MoveToElement(element).Perform();
            return this;
        }
        public Header dropDownDresses()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownDresses);
            actions.MoveToElement(element).Perform();
            return this;
        }
        public Header dropDownTShirts()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownTShirts);
            actions.MoveToElement(element).Perform();
            return this;
        }

        public Header tShirts_women()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownWomen);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_tShirts_women).Click();
            return new Header(_driver);
        }
        public Header blouses_women()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownWomen);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_blouses_women).Click();
            return new Header(_driver);
        }
        public Header casualDresses_women()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownWomen);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_casualDresses_women).Click();
            return new Header(_driver);
        }
        public Header eveningDresses_women()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownWomen);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_eveningDresses_women).Click();
            return new Header(_driver);
        }
        public Header summerDresses_women()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownWomen);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_summerDresses_women).Click();
            return new Header(_driver);
        }

        public Header casualDresses_dresses()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownDresses);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_casualDresses_dresses).Click();
            return new Header(_driver);
        }

        public Header eveningDresses_dresses()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownDresses);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_eveningDresses_dresses).Click();
            return new Header(_driver);
            
        }

        public Header summerDresses_dresses()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_dropDownDresses);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_summerDresses_dresses).Click();
            return new Header(_driver);
        }
    }
}
