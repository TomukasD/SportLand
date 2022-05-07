using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace SportLand.Page
{
    public class SportLandCartPage : BasePage
    {
        private const string searchText = "asasasa";
        private IWebElement addNikeZoomXVapourFlyNext => Driver.FindElement(By.CssSelector("li.CartItem:nth-child(1) > figure:nth-child(1) > div:nth-child(3) > button:nth-child(2) > span:nth-child(1)"));
        private IWebElement verifyAddedNike => Driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/div[1]/ul/li[1]/figure/div[3]/div[1]/p/span/data"));
        private IWebElement removeNikes => Driver.FindElement(By.CssSelector("li.CartItem:nth-child(1) > figure:nth-child(1) > div:nth-child(1) > button:nth-child(2) > span:nth-child(1)"));
        private IWebElement converseShoeCost => Driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/div[1]/ul/li/figure/div[3]/div[1]/p/span/data"));
        private IWebElement cartSum => Driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/div[2]/article/dl[2]/dd"));
        private IWebElement openForCoupons => Driver.FindElement(By.CssSelector(".CartPage-ExpandableContentButton"));
        private IWebElement typeInWrongCouponField => Driver.FindElement(By.Id("couponCode"));
        private IWebElement submitWrongCoupon => Driver.FindElement(By.CssSelector(".CartCoupon-Button"));
        private IWebElement verifyWrongCoupon => Driver.FindElement(By.CssSelector(".Notification-Text"));
        private IWebElement clickOnCheckout => Driver.FindElement(By.CssSelector(".CartPage-CheckoutButton"));
        public SportLandCartPage(IWebDriver webdriver) : base(webdriver) { }

        public void AddNike()
        {
            addNikeZoomXVapourFlyNext.Click();
        }
        public void VerifyAddedNike()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/main/section/div/div[1]/ul/li[1]/figure/div[3]/div[1]/p/span/data")));
            
            Assert.AreEqual(verifyAddedNike.Text, verifyAddedNike.Text, "Wrong sum");
        }
        public void RemoveNike()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li.CartItem:nth-child(1) > figure:nth-child(1) > div:nth-child(1) > button:nth-child(2) > span:nth-child(1)")));
            removeNikes.Click();
        }
        public void VerifyRemovedNike()
        {
            Thread.Sleep(1000);
            
            Assert.AreEqual(converseShoeCost.Text, cartSum.Text, "Wrong sum");
        }
        public void OpenCouponText()
        {
            openForCoupons.Click();
        }
        public void TypeWrongCouponCode(string SearchText)
        {
            typeInWrongCouponField.Click();
            typeInWrongCouponField.SendKeys(SearchText);
        }
        public void SubmitWrongCouponeCode()
        {
            submitWrongCoupon.Click();
        }
        public void VerifyWrongTypedCouponeCode()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".Notification-Text")));

            Assert.AreEqual("Nuolaidos kodas yra negaliojantis", verifyWrongCoupon.Text, "Wrong notification");
        }
        public void ClickOnCheckout()
        {
            clickOnCheckout.Click();
        }
        


    }
}
