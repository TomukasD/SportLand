using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.IO;
using System.Reflection;

namespace SportLand.Tools
{
    public class ScreenShot
    {
        public static void TakeScreenShots(IWebDriver webdriver)
        {
            Screenshot screenshot = webdriver.TakeScreenshot();
            string myScreenShots = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
            string myScreenShotFolder = Path.Combine(myScreenShots, "screenshots");
            Directory.CreateDirectory(myScreenShotFolder);
            string screeShotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm}.png";
            string screenShotPath = Path.Combine(myScreenShotFolder, screeShotName);
            screenshot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);
        }
    }
}
