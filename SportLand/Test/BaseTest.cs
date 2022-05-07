using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SportLand.Drivers;
using SportLand.Page;
using SportLand.Tools;

namespace SportLand.Test
{
    public class BaseTest
    {
        protected static IWebDriver driver;
        protected static SportLandMainPage _SportLandMainPage;
        protected static SportLandSearchResultsPage _SportLandSearchResultsPage;
        protected static nikeZoomXVapourFlyNextPage _nikeZoomXVapourFlyNextPage;
        protected static ConverseMCtasTerranHiPage _ConverseMCtasTerranHiPage;
        protected static SportLandCartPage _SportLandCartPage;
        protected static CheckoutPage _CheckoutPage;




        [OneTimeSetUp]
        protected static void SetUp()
        {
            driver = CustomDrivers.GetFirefoxDriver();
            _SportLandMainPage = new SportLandMainPage(driver);
            _SportLandSearchResultsPage = new SportLandSearchResultsPage(driver);
            _nikeZoomXVapourFlyNextPage = new nikeZoomXVapourFlyNextPage(driver);
            _ConverseMCtasTerranHiPage = new ConverseMCtasTerranHiPage(driver);
            _SportLandCartPage = new SportLandCartPage(driver);
            _CheckoutPage = new CheckoutPage(driver);
        }
        [TearDown]
        protected static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                ScreenShot.TakeScreenShots(driver);
            }
        }

        [OneTimeTearDown]
        protected static void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
