using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ValidarAmericanas
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        PageObject.PageObjectAmericanas pagina;
        //Select select = new Select(comboBox);

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
            System.Threading.Thread.Sleep(2000);
            action.Click(driver.FindElement(pagina.arvoreNatal)).Perform();
            IWebElement cBox = driver.FindElement(By.Id("form-control-flat selectbox"));
            System.Threading.Thread.Sleep(2000);
            action.MoveToElement(cBox).Click().Perform();
            new SelectElement(driver.FindElement(By.CssSelector("select.form-control-flat.form-control"))).SelectByText("Menores Preços");


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
