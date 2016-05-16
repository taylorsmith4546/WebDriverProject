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
            driver.Url = @"file:///C:\Dev\TestSelenium\WebDriverProject\WebDriverProject\TestPage.html";

            var radioButtons = driver.FindElements(By.Name("color"));
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Selected)
                    Console.WriteLine(radioButton.GetAttribute("value"));
            }

        }
    }
}
