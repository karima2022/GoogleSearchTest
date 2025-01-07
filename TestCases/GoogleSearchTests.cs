using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

            // Accepter les cookies si le bouton est présent
            try
            {
                var acceptCookiesButton = _driver.FindElement(By.CssSelector("button[id='L2AGLb']"));
                acceptCookiesButton.Click();
            }
            catch (NoSuchElementException)
            {
                // Aucun bouton de cookies trouvé, continuer
            }


            // Attendre que le champ de recherche soit interactif
            var wait = new WebDriverWait(new SystemClock(), _driver, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(500));
            var searchBox = wait.Until(driver => driver.FindElement(By.Name("q")));

            // Taper la requête et appuyer sur Entrée
            searchBox.SendKeys("Test automation with Selenium");
            searchBox.SendKeys(Keys.Enter);

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
