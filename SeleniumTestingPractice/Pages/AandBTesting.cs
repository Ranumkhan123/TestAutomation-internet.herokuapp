using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class AandBTesting : CorePage
    {

        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By abtestinglink = By.XPath("//a[normalize-space()='A/B Testing']");
        By abpagetext = By.XPath("//p[contains(text(),'Also known as split testing. This is a way in whic')]");

       

        public void ABtest(string URL)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            
            //Actions Actions = new Actions(driver);

            driver.Manage().Window.Maximize();

            //URL
            driver.Url = URL;
            Console.WriteLine("URL: " + URL);
            Console.WriteLine();


            //TITLE 
            string title = driver.Title;
            Console.WriteLine(title);
            Console.WriteLine();


            //HEADER
            string headermessage = driver.FindElement(header).Text;
            Console.WriteLine(headermessage);
            Console.WriteLine();


            //CLICK ON A/B TESTING
            driver.FindElement(abtestinglink).Click();
            string andbtxtmessage = driver.FindElement(abpagetext).Text;
            Console.WriteLine(andbtxtmessage);

            Thread.Sleep(4000);

            driver.Navigate().Back();

            Thread.Sleep(2000);
        }

    }
}
