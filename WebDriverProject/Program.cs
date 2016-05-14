using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverProject
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver(@"C:\WebDrivers\");
            driver.Url = "http://www.google.com";

           var searchBox = driver.FindElement(By.ClassName("gsfi"));
            searchBox.SendKeys("pluralsight");
        }
    }
}
