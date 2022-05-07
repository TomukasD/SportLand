using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SportLand.Page
{
    public class CheckoutPage : BasePage
    {
        private IWebElement verifyClickOnCheckout => Driver.FindElement(By.CssSelector(".Checkout"));
        private IWebElement verifyYourOrder => Driver.FindElement(By.XPath("/html/body/div[1]/main/section/div/div[2]/article/div/article/div[3]/ul/li/figure/figcaption/a/p[1]"));
        public CheckoutPage(IWebDriver webdriver) : base(webdriver) { }

        public void VerifyClickOnCheckout()
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".Checkout")));

            Assert.IsTrue(Driver.FindElement(By.CssSelector(".Checkout")).Displayed,"Wrong entered site");
        }
        public void VerifyYourOrder()
        {
            Assert.AreEqual("CONVERSE M CTAS TERRAN HI", verifyYourOrder.Text, "Wrong ordered shoe name");
        }
    }
}
