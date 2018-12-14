using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace ValidarAmericanas
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        PageObject.PageObjectAmericanas pagina;

        [TestInitialize]
        public void Iniciar()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.americanas.com.br/";
            driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public void TestMethod1()
        {
            pagina = new PageObject.PageObjectAmericanas();
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(pagina.compreDepartamento)).Perform();
            System.Threading.Thread.Sleep(2000);
            action.MoveToElement(driver.FindElement(pagina.enfeitesNatal)).Perform();
            System.Threading.Thread.Sleep(5000);
            action.Click(driver.FindElement(pagina.arvoreNatal)).Perform();
            

            if (pagina.label.Equals("árvores de natal")) 
            {
                Console.Write("Rolou!!");
            }
            else 
            { 
                Console.Write("Nao rolou!!");
            }

            

        }

        [TestCleanup]
        public void Finalizar()
        {
            driver.Quit();
            driver = null;
        }
    }
}
