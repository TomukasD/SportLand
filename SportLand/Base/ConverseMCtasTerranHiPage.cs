using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SportLand.Page
{
    public class ConverseMCtasTerranHiPage : BasePage
    {
        private IWebElement converseShoeSize => Driver.FindElement(By.CssSelector("a.ProductAttributeValue:nth-child(2)"));
        private IWebElement converseBuy => Driver.FindElement(By.CssSelector(".Button > span:nth-child(1)"));
        private IWebElement basketPopUpOpenGoToCart => Driver.FindElement(By.CssSelector(".AddToCartPopup-CartButton"));
        private IWebElement verifyBoughtShoeBasketPopUp => Driver.FindElement(By.CssSelector(".Popup-Content"));
        private IWebElement verifyGoToCartPage => Driver.FindElement(By.CssSelector(".CartPage"));
        public ConverseMCtasTerranHiPage(IWebDriver webdriver) : base(webdriver) { }

        public void ConverseShoeSizeSelect()
        {
            converseShoeSize.Click();
        }
        public void ConverseShoeBuy()
        {
            converseBuy.Click();
        }
        public void VerifyBoughtConverseBasketPopUp()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".Popup-Content")));
            Assert.IsTrue(Driver.FindElement(By.CssSelector(".Popup-Content")).Displayed,"Basket popup is not displayed");
        }
        public void PopUpOpenGoToCart()
        {
            basketPopUpOpenGoToCart.Click();
        }
        public void VerifyGoToCartPage()
        {
            Assert.IsTrue(Driver.FindElement(By.CssSelector(".CartPage")).Displayed,"Wrong entered site");
        }

    }
}
