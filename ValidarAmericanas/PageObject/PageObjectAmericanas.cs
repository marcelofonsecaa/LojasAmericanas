using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarAmericanas.PageObject
{
    class PageObjectAmericanas
    {
        public string urlSite = "https://www.americanas.com.br/";
        public By compreDepartamento { get { return By.ClassName("mmn-sdb-title"); } }
        public By enfeitesNatal {  get { return By.XPath("//*[@id='h_menu']/div/div/div/div/div[1]/ul/li[2]/a"); } }
        //public By arvoreNatal {  get { return By.ClassName("mmn-item.sz.sz-1.hover"); } }
        //public By arvoreNatal {  get { return By.LinkText("https://www.americanas.com.br/categoria/enfeites-de-natal/arvores-de-natal"); } }
        public By arvoreNatal {  get { return By.XPath("//*[@id='h_menu']/div/div/div/div/div[1]/ul/li[2]/div/ul/li[3]/div/ul/li[3]/a"); } }
        public By label { get { return By.XPath("//*[@id='content - top']/div[1]/div/h1"); } }
    }


}
