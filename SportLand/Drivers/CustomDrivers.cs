using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace SportLand.Drivers
{
    public class CustomDrivers
    {

        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browsers.Firefox);
        }

        private static IWebDriver GetDriver(Browsers browserName)
        {
            IWebDriver driver = null;

            switch (browserName)
            {
                case Browsers.Firefox:
                    driver = new FirefoxDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return driver;
        }
    }
}
