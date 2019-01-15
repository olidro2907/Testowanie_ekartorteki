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
            driver.Navigate().GoToUrl("https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w");
            driver.Manage().Window.Maximize();
            driver.Manage().Window.FullScreen();
            //driver.SwitchTo().Window("Logowanie - Strona");


            //driver.Close();

        }

        [Test]
        public void IEMethod()
        {
            IWebDriver driver = new InternetExplorerDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            driver.Navigate().GoToUrl("https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w");
            driver.Manage().Window.Maximize();
            driver.Close();

        }

        [Test]
        public void OperaMethod()
        {
            IWebDriver driver = new OperaDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            driver.Navigate().GoToUrl("https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w");
            driver.Manage().Window.Maximize();
            driver.Close();

        }

        [Test]
        public void FirefoxMethod()
        {
            IWebDriver driver = new FirefoxDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            driver.Navigate().GoToUrl("https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w");
            driver.Manage().Window.Maximize();
            driver.Close();

        }
    }
}