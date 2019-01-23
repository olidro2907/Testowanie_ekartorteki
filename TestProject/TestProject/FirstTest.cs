using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using System.Collections.Generic;

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
            driver.Manage().Window.Maximize();
            driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            Assert.AreEqual(driver.Url, pageUrl);


            IWebElement b_login = driver.FindElement(By.CssSelector("#logowanie"));                      
            b_login.Click();
            IWebElement zap_h = driver.FindElement(By.PartialLinkText("Zapomnia³eœ/aœ has³a?"));
            Actions action3 = new Actions(driver);
            action3.MoveToElement(zap_h).Build().Perform();
            Thread.Sleep(2000);
            zap_h.Click();
            Thread.Sleep(2500);
            driver.Navigate().Back();
            
            IWebElement rej = driver.FindElement(By.PartialLinkText("Rejestracja"));
            Actions action4 = new Actions(driver);
            action4.MoveToElement(rej).Build().Perform();
            Thread.Sleep(2000);
            rej.Click();
            Thread.Sleep(2500);
            driver.Navigate().Back();
            

            IWebElement Email = driver.FindElement(By.CssSelector("#Email"));
            Thread.Sleep(2000);
            Email.SendKeys("anna.nowak@email.pl");
            IWebElement Haslo = driver.FindElement(By.CssSelector("#Haslo"));
            Thread.Sleep(2000);
            Haslo.SendKeys("annanowak");
            IWebElement b_zapamietaj = driver.FindElement(By.CssSelector(".checkbox"));
            Thread.Sleep(2000);
            b_zapamietaj.Click();
            IWebElement b_zaloguj = driver.FindElement(By.CssSelector("#zaloguj"));
            Actions action = new Actions(driver);
            action.MoveToElement(b_zaloguj).Build().Perform();
            Thread.Sleep(2000);
            b_zaloguj.Click();
            Thread.Sleep(2000);
            IWebElement b_dane = driver.FindElement(By.CssSelector("#dane"));
            b_dane.Click();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            IWebElement b_wizyty = driver.FindElement(By.CssSelector("#wizyty"));
            b_wizyty.Click();
            IWebElement Data = driver.FindElement(By.CssSelector(".form-control"));
            Thread.Sleep(2000);
            Data.SendKeys("1/21/2019");
            IWebElement b_szukaj = driver.FindElement(By.CssSelector(".btn.btn-default"));
            Actions action1 = new Actions(driver);
            action1.MoveToElement(b_szukaj).Build().Perform();
            Thread.Sleep(2500);          
            b_szukaj.Click();
            var b_lek = driver.FindElements(By.PartialLinkText("Leki"));
            Actions action2 = new Actions(driver);
            action2.MoveToElement(b_lek[1]).Build().Perform();
            Thread.Sleep(2500);            
            b_lek[1].Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            IWebElement strona_g = driver.FindElement(By.PartialLinkText("Strona g³ówna"));
            strona_g.Click();
            Thread.Sleep(2000);
            IWebElement b_leki = driver.FindElement(By.CssSelector("#leki"));
            b_leki.Click();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            IWebElement zm = driver.FindElement(By.PartialLinkText("Zmieñ has³o"));
            zm.Click();
            Thread.Sleep(2500);
            IWebElement wyloguj = driver.FindElement(By.CssSelector(".btn.btn-link.navbar-btn.navbar-link"));
            Actions action5 = new Actions(driver);
            action5.MoveToElement(wyloguj).Build().Perform();
            Thread.Sleep(2050);
            wyloguj.Click();
            driver.Manage().Window.Minimize();
            driver.Close();










        }

       
        [Test]
        public void FirefoxMethod()
        {
        IWebDriver driver = new FirefoxDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
        var pageUrl = "https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w";

        driver.Navigate().GoToUrl(pageUrl);
            driver.Navigate().GoToUrl(pageUrl);
            driver.Manage().Window.Maximize();
            driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            Assert.AreEqual(driver.Url, pageUrl);


            IWebElement b_login = driver.FindElement(By.CssSelector("#logowanie"));
            b_login.Click();
            IWebElement zap_h = driver.FindElement(By.PartialLinkText("Zapomnia³eœ/aœ has³a?"));
            Actions action3 = new Actions(driver);
            action3.MoveToElement(zap_h).Build().Perform();
            Thread.Sleep(2000);
            zap_h.Click();
            Thread.Sleep(2500);
            driver.Navigate().Back();

            IWebElement rej = driver.FindElement(By.PartialLinkText("Rejestracja"));
            Actions action4 = new Actions(driver);
            action4.MoveToElement(rej).Build().Perform();
            Thread.Sleep(2000);
            rej.Click();
            Thread.Sleep(2500);
            driver.Navigate().Back();


            IWebElement Email = driver.FindElement(By.CssSelector("#Email"));
            Thread.Sleep(2000);
            Email.SendKeys("anna.nowak@email.pl");
            IWebElement Haslo = driver.FindElement(By.CssSelector("#Haslo"));
            Thread.Sleep(2000);
            Haslo.SendKeys("annanowak");
            IWebElement b_zapamietaj = driver.FindElement(By.CssSelector(".checkbox"));
            Thread.Sleep(2000);
            b_zapamietaj.Click();
            IWebElement b_zaloguj = driver.FindElement(By.CssSelector("#zaloguj"));
            Actions action = new Actions(driver);
            action.MoveToElement(b_zaloguj).Build().Perform();
            Thread.Sleep(2000);
            b_zaloguj.Click();
            Thread.Sleep(2000);
            IWebElement b_dane = driver.FindElement(By.CssSelector("#dane"));
            b_dane.Click();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            IWebElement b_wizyty = driver.FindElement(By.CssSelector("#wizyty"));
            b_wizyty.Click();
            IWebElement Data = driver.FindElement(By.CssSelector(".form-control"));
            Thread.Sleep(2000);
            Data.SendKeys("1/21/2019");
            IWebElement b_szukaj = driver.FindElement(By.CssSelector(".btn.btn-default"));
            Actions action1 = new Actions(driver);
            action1.MoveToElement(b_szukaj).Build().Perform();
            Thread.Sleep(2500);
            b_szukaj.Click();
            var b_lek = driver.FindElements(By.PartialLinkText("Leki"));
            Actions action2 = new Actions(driver);
            action2.MoveToElement(b_lek[1]).Build().Perform();
            Thread.Sleep(2500);
            b_lek[1].Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            IWebElement strona_g = driver.FindElement(By.PartialLinkText("Strona g³ówna"));
            strona_g.Click();
            Thread.Sleep(2000);
            IWebElement b_leki = driver.FindElement(By.CssSelector("#leki"));
            b_leki.Click();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            IWebElement zm = driver.FindElement(By.PartialLinkText("Zmieñ has³o"));
            zm.Click();
            Thread.Sleep(2500);
            IWebElement wyloguj = driver.FindElement(By.CssSelector(".btn.btn-link.navbar-btn.navbar-link"));
            Actions action5 = new Actions(driver);
            action5.MoveToElement(wyloguj).Build().Perform();
            Thread.Sleep(2050);
            wyloguj.Click();
            driver.Manage().Window.Minimize();
            driver.Close();
        }

        [Test]
        public void EgdeMethod()
        {
            IWebDriver driver = new EdgeDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            var pageUrl = "https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w";

            driver.Navigate().GoToUrl(pageUrl);
            driver.Manage().Window.Maximize();

            driver.Manage().Window.Minimize();
            driver.Close();

        }

        public void IEMethod()
        {
            IWebDriver driver = new FirefoxDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            var pageUrl = "https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w";

            driver.Navigate().GoToUrl(pageUrl);
            driver.Manage().Window.Maximize();

            driver.Manage().Window.Minimize();
            driver.Close();

        }

        public void OperaMethod()
        {
            IWebDriver driver = new OperaDriver(@"C:\Users\Oliwia Drozdek\Documents\GitHub\Testowanie_ekartorteki\TestProject\TestProject\bin\Debug\netcoreapp2.1");
            var pageUrl = "https://ekartoteka.azurewebsites.net/?fbclid=IwAR1PCdfWuVGB-KeHWhwJ8DImd2rJ2AtxEK2M2AXdv2YNhXhXLRegRp3No4w";

            driver.Navigate().GoToUrl(pageUrl);
            driver.Manage().Window.Maximize();

            driver.Manage().Window.Minimize();
            driver.Close();

        }

    }
}