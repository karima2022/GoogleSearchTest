using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using GoogleSearchTest.Init;

namespace GoogleSearchTest.TestCases
{
    [TestFixture]
    public class GoogleSearchTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            // Initialiser le WebDriver
            _driver = DriverSetup.InitializeDriver();
        }

        [Test]
        public void TestGoogleSearch()
        {
            // Accéder à Google
            _driver.Navigate().GoToUrl("https://www.google.com");

            // Gestion des cookies
            try
            {
                var acceptCookiesButton = _driver.FindElement(By.CssSelector("button[id='L2AGLb']"));
                acceptCookiesButton.Click();
            }
            catch (NoSuchElementException)
            {
                // Aucun bouton de cookies trouvé, continuer
            }

            // Taper la requête et appuyer sur Entrée
            var searchBox = _driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Test automation with Selenium");
            searchBox.SendKeys(Keys.Enter);

            // Attendre que les résultats soient chargés
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div#search")));

            // Vérifier si les résultats s'affichent
            Assert.That(_driver.FindElements(By.CssSelector("div#search")).Count, Is.GreaterThan(0), "Aucun résultat trouvé !");
        }


        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();    // Ferme toutes les fenêtres du navigateur.
                _driver.Dispose(); // Libère toutes les ressources liées au WebDriver.
            }
        }
    }
}
