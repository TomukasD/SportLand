using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace SportLand.Page
{
    public class SportLandSearchResultsPage : BasePage
    {
        private IWebElement closeCookiesNextPage => Driver.FindElement(By.CssSelector("button.Button:nth-child(1)"));
        private IWebElement openBrandNames => Driver.FindElement(By.CssSelector("div.ConfigurableAttribute-Wrapper:nth-child(1) > article:nth-child(1) > button:nth-child(1) > span:nth-child(1)"));
        private IWebElement checkBoxNike => Driver.FindElement(By.CssSelector(".ExpandableContent-Content_isContentExpanded > div:nth-child(1) > a:nth-child(1) > div:nth-child(1)"));
        private IWebElement checkBoxConverse => Driver.FindElement(By.CssSelector(".ExpandableContent-Content_isContentExpanded > div:nth-child(1) > a:nth-child(12) > div:nth-child(1)"));
        private IWebElement checkBoxVans => Driver.FindElement(By.CssSelector(".ExpandableContent-Content_isContentExpanded > div:nth-child(1) > a:nth-child(4) > div:nth-child(1)"));
        private IWebElement checkBoxTimberlands => Driver.FindElement(By.CssSelector(".ExpandableContent-Content_isContentExpanded > div:nth-child(1) > a:nth-child(3) > div:nth-child(1)"));
        private IWebElement deSelectCheckBoxTimberlands => Driver.FindElement(By.CssSelector(".ExpandableContent-Content_isContentExpanded > div:nth-child(1) > a:nth-child(3) > div:nth-child(1)"));
        private IWebElement deCheckBoxVans => Driver.FindElement(By.CssSelector(".ExpandableContent-Content_isContentExpanded > div:nth-child(1) > a:nth-child(4) > div:nth-child(1)"));
        private IWebElement sortBy => Driver.FindElement(By.CssSelector(".CategorySort-Select"));
        private IWebElement highestPrice => Driver.FindElement(By.CssSelector(".Field-SelectOptions_isExpanded > li:nth-child(3)"));
        private IWebElement verifyHighestPriceOption => Driver.FindElement(By.CssSelector("#category-sort > option:nth-child(3)"));
        private IWebElement chooseNikeZoomXVapourFlyNext => Driver.FindElement(By.CssSelector("li.ProductCard:nth-child(1) > a:nth-child(1) > div:nth-child(1)"));
        private IWebElement verifySelectedNike => Driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/article/div/section[2]/h1"));
        private IWebElement verifySelectedConverse => Driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/article/div/section[2]/h1"));
        private IWebElement chooseConverseMCtasTerranHi => Driver.FindElement(By.CssSelector("li.ProductCard:nth-child(151) > a:nth-child(1) > div:nth-child(1)"));
        private IWebElement searchField => Driver.FindElement(By.Id("sn-q"));

        public SportLandSearchResultsPage(IWebDriver webdriver) : base(webdriver) { }

        public void VerifyClickedSearchField()
        {
            Assert.AreEqual(searchField.Text, searchField.Text, "Wrong result");

        }
        public void CloseCookies()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.Button:nth-child(1)")));
            closeCookiesNextPage.Click();
        }
        public void ClickBrandNames()
        {
            openBrandNames.Click();
        }
        public void ClickBrandNike()
        {
            checkBoxNike.Click();
        }
        public void ClickBrandConverse()
        {
            ((IJavaScriptExecutor)Driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", checkBoxConverse);
            Console.WriteLine(checkBoxConverse.Text);
            checkBoxConverse.Click();
        }
        public void ClickBrandVans()
        {
            ((IJavaScriptExecutor)Driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", checkBoxVans);
            Console.WriteLine(checkBoxVans.Text);
            checkBoxVans.Click();
        }
        public void ClickBrandTimberlands()
        {
            ((IJavaScriptExecutor)Driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", checkBoxTimberlands);
            Console.WriteLine(checkBoxTimberlands.Text);
            checkBoxTimberlands.Click();
        }
        public void DeClickBrandTimberlands()
        {
            deSelectCheckBoxTimberlands.Click();
        }
        public void DeClickBrandVans()
        {
            ((IJavaScriptExecutor)Driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", deCheckBoxVans);
            Console.WriteLine(deCheckBoxVans.Text);
            deCheckBoxVans.Click();
        }
        public void VerifySelectedBrands()
        {
            Assert.IsTrue(Driver.FindElement(By.Id("Nike")).Selected,"Nike is not displayed");
            Assert.IsTrue(Driver.FindElement(By.Id("Converse")).Selected,"Converse is not displayed");
        }

        public void SortByClick()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".CategorySort-Select")));
            sortBy.Click();
        }
        public void HighestPriceChoose()
        {
            highestPrice.Click();
        }
        public void VerifySelectedPriceFilter()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.Field-SelectWrapper:nth-child(2)")));
            Assert.AreEqual("Kaina: nuo Aukščiausios iki Žemiausios", verifyHighestPriceOption.Text, "Wrong selected filter");
        }
        public void ChoosenikeZoomXVapourFlyNext()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li.ProductCard:nth-child(1) > a:nth-child(1) > div:nth-child(1)")));
            chooseNikeZoomXVapourFlyNext.Click();
        }
        public void VerifySelectedNike()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/main/section/div/article/div/section[2]/h1")));
            Assert.AreEqual("NIKE ZOOMX VAPORFLY NEXT%", verifySelectedNike.Text, "Wrong shoe name");
        }
        public void VerifyBackToResultsPage()
        {
            Assert.IsTrue(Driver.FindElement(By.CssSelector(".ContentWrapper")).Displayed,"Wrong return page");
        }
        public void ChooseConverseMCtasTerranHi()
        {
            ((IJavaScriptExecutor)Driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", chooseConverseMCtasTerranHi);
            Thread.Sleep(2000);
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li.ProductCard:nth-child(151) > a:nth-child(1) > div:nth-child(1)")));
            chooseConverseMCtasTerranHi.Click();

        }
        public void VerifySelectedConverse()
        {
            Thread.Sleep(1000);
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/main/section/div/article/div/section[2]/h1")));
            Assert.AreEqual("CONVERSE M CTAS TERRAN HI", verifySelectedConverse.Text, "Wrong shoe name");
        }
    }
}
