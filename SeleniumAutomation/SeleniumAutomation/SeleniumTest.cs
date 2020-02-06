using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumAutomation
{
    public class SeleniumTest
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\driver");
            driver.Url = "http://demowebshop.tricentis.com/";
            driver.Manage().Window.Maximize();
            string title = driver.Title;
            if (title.Equals("Demo Web Shop"))
            {
                Console.WriteLine("Test Pass");
            }
            else
            {
                Console.WriteLine("test Fail");
            }
            driver.Quit();
        }
    }
}
