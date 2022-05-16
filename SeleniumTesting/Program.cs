using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started");
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(2000);

            driver.Manage().Window.Maximize();
            IWebElement ele1 = driver.FindElement(By.Name("q"));

            ele1.SendKeys("javatpoint tutorials");
            Thread.Sleep(2000);

            IWebElement ele2 = driver.FindElement(By.Name("btnK"));

            ele2.Click();
            Thread.Sleep(3000);

            driver.Close();
            Console.Write("Test Case Ended");
        }
    }
}