using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace SportLand.Page
{
    public class nikeZoomXVapourFlyNextPage : BasePage
    {
        private IWebElement nikeZoomXVapourFlyNextSlideNext => Driver.FindElement(By.CssSelector(".Slider-ArrowIcon_type_right"));
        private IWebElement nikeZoomXVapourFlyNextShoeSize => Driver.FindElement(By.CssSelector("a.ProductAttributeValue:nth-child(6)"));
        private IWebElement nikeZoomXVapourFlyNextShoeBuy => Driver.FindElement(By.CssSelector("button.Button:nth-child(1)"));
        private IWebElement closeBasketPopUpOpen => Driver.FindElement(By.XPath("/html/body/div[5]/div/header/button"));
        public nikeZoomXVapourFlyNextPage(IWebDriver webdriver) : base(webdriver) { }

        public void NikeShoeSize()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a.ProductAttributeValue:nth-child(6)")));
            nikeZoomXVapourFlyNextShoeSize.Click();
        }
        public void NikeNextSlide()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.Slider-ArrowWrapper:nth-child(3)")));
            nikeZoomXVapourFlyNextSlideNext.Click();
        }
        public void NikeBuy()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.Button:nth-child(1)")));
            nikeZoomXVapourFlyNextShoeBuy.Click();
        }
        public void VerifyBoughtNikeBasketPopOut()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".Popup-Content")));
            Assert.IsTrue(Driver.FindElement(By.CssSelector(".Popup-Content")).Displayed,"No displayed popup");
        }
        public void CloseShoeBasketPopOut()
        {
            Thread.Sleep(1000);
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[5]/div/header/button")));
            closeBasketPopUpOpen.Click();
        }
        public void ReturnToResultsPage()
        {
            Driver.Navigate().GoToUrl("https://sportland.lt/searchresults?q=vyriski+batai&ff.attr_!brand=Nike&ff.attr_!brand=Converse&ff.attr_!brand=ONeill&l=220&s=-priceForSort&s=-score");
        }
    }
}
