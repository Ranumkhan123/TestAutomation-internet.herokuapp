using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class EntryAd : CorePage
    {
        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By entryadlink = By.XPath("//a[normalize-space()='Entry Ad']");
        By closebtn = By.XPath("//p[normalize-space()='Close']");
        By modalheading = By.XPath("//h3[normalize-space()='This is a modal window']");
        By modaltext = By.XPath("//p[contains(text(),\"It's commonly used to encourage a user to take an \")]");
        By enteryadheading = By.XPath("//h3[normalize-space()='Entry Ad']");
        By enteryadtext = By.XPath("//p[normalize-space()='Displays an ad on page load.']");
       

        public void EntryAdPage(string URL)
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
            Console.WriteLine("Title: " + title);
            Console.WriteLine();


            //HEADER
            string headermessage = driver.FindElement(header).Text;
            Console.WriteLine("Header Message: " + headermessage);
            Console.WriteLine();


            //ENTRY AD 
            driver.FindElement(entryadlink).Click();
            Thread.Sleep(1000);

            //MODAL HEADING
            string modalheadingtext = driver.FindElement(modalheading).Text;
            Console.WriteLine("Dynamic Loading Heading: " + modalheadingtext);
            Console.WriteLine();

            //MODAL TEXT
            string modaltextmessage = driver.FindElement(modaltext).Text;
            Console.WriteLine("Dynamic Loading Heading: " + modaltextmessage);
            Console.WriteLine();


            driver.FindElement(closebtn).Click();


            //ENTRY AD PAGE HEADING
            string enteryadpageheading = driver.FindElement(enteryadheading).Text;
            Console.WriteLine("Dynamic Loading Heading: " + enteryadpageheading);
            Console.WriteLine();

            //ENTRY AD PAGE TEXT
            string entryadpagetext = driver.FindElement(enteryadtext).Text;
            Console.WriteLine("Dynamic Loading Heading: " + entryadpagetext);
            Console.WriteLine();


            driver.Navigate().Back();

            Thread.Sleep(1000);

        }
    }
}
