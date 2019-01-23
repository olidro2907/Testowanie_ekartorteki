using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.IE;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChromeMethod()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            var pageUrl = "https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w";

            driver.Navigate().GoToUrl(pageUrl);
            //driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            Assert.AreEqual(driver.Url, pageUrl);


            IWebElement b_login = driver.FindElement(By.CssSelector("#logowanie"));
            b_login.Click();
            IWebElement Email = driver.FindElement(By.CssSelector("#Email"));
            Email.SendKeys("anna.nowak@email.pl");
            IWebElement Haslo = driver.FindElement(By.CssSelector("#Haslo"));
            Haslo.SendKeys("annanowak");
            IWebElement b_zapamietaj = driver.FindElement(By.CssSelector(".checkbox"));
            b_zapamietaj.Click();
            IWebElement b_zaloguj = driver.FindElement(By.CssSelector("#zaloguj"));
            b_zaloguj.Click();
            IWebElement b_dane = driver.FindElement(By.CssSelector(".nav.navbar-nav.navbar-left"));
            b_dane.Click();

            //driver.Navigate().Back();
            //driver.SwitchTo().Window("Logowanie - Strona");
            //driver.Close();

        }

        [Test]
        public void IEMethod()
        {
            IWebDriver driver = new InternetExplorerDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            driver.Navigate().GoToUrl("https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w");
            driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            //driver.Close();

        }

        

        [Test]
        public void FirefoxMethod()
        {
            IWebDriver driver = new FirefoxDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            driver.Navigate().GoToUrl("https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w");
            driver.Manage().Window.Minimize();
            driver.Manage().Window.Maximize();
            driver.Manage().Window.FullScreen();
            //driver.Close();

        }

        //[Test]
        //public void OperaMethod()
        //{
        //    IWebDriver driver = new OperaDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
        //    driver.Navigate().GoToUrl("https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w");
        //    driver.Manage().Window.Maximize();
        //    driver.Close();

        //}
    }
}