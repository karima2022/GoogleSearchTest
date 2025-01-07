using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleSearchTest.Init
{
    public static class DriverSetup
    {
        public static IWebDriver InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            return driver;
        }
    }
}