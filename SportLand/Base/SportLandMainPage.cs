using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace SportLand.Page
{
    public class SportLandMainPage : BasePage
    {
        private const string PageAddress = "https://sportland.lt/";
        private const string SearchText = "vyriski batai";
        private IWebElement cookieButton => Driver.FindElement(By.CssSelector("button.Button:nth-child(1)"));
        private IWebElement clickSearchField => Driver.FindElement(By.Id("sn-q"));
        private IWebElement searchBarOptions => Driver.FindElement(By.CssSelector(".sn-hints-wrapper > div:nth-child(2) > b:nth-child(1)"));
        private IWebElement searchIcon => Driver.FindElement(By.CssSelector(".button-1.search-box-button"));
        public SportLandMainPage(IWebDriver webdriver) : base(webdriver) { }
        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
        }

        public void CloseCookies()
        {
            Thread.Sleep(2000);
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.Button:nth-child(1)")));
            cookieButton.Click();
        }
        public void SearchByText(string SearchText)
        {
            clickSearchField.Click();
            clickSearchField.Clear();
            clickSearchField.SendKeys(SearchText);
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".sn-hints-wrapper > div:nth-child(2)")));
            Assert.AreEqual("vyriski batai", searchBarOptions.Text, "Wrong result");
        }
        public void ClickOnSearchBarOptions()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".sn-hints-wrapper > div:nth-child(2)")));
            searchBarOptions.Click();
        }
        
    }
}
