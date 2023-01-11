using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class MultipleWindows : CorePage
    {
        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By multiplewindowslink = By.XPath("//a[normalize-space()='Multiple Windows']");
        By multiplewindowheanding = By.XPath("//h3[normalize-space()='Opening a new window']");
        By clickherebtn = By.XPath("//a[normalize-space()='Click Here']");
        By newwindowtext = By.XPath("//h3[normalize-space()='New Window']");
        By jsalertresult = By.XPath("//p[@id='result']");
        By jsconfirm = By.XPath("//button[normalize-space()='Click for JS Confirm']");
        By jsconfirmresult = By.XPath("//p[@id='result']");
        By jsprompt = By.XPath("//button[normalize-space()='Click for JS Prompt']");
        By jspromptresult = By.XPath("//p[@id='result']");


        public void MultipleWindowsPage(string URL)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;

            Actions action = new Actions(driver);


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


            //MULTIPLE WINDOWS 
            scroll.ExecuteScript("window.scrollBy(0,650)");
            driver.FindElement(multiplewindowslink).Click();
            Thread.Sleep(1000);

            //MULTIPLE WINDOW
            string multiplewindowheadingtext = driver.FindElement(multiplewindowheanding).Text;
            Console.WriteLine("Multiple Window Heading: " + multiplewindowheadingtext);
            Console.WriteLine();

            driver.FindElement(clickherebtn).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);

            //NEW WINDOW TEXT
            string newwindowtextmessage = driver.FindElement(newwindowtext).Text;
            Console.WriteLine("New Window Message: " + newwindowtextmessage);
            Console.WriteLine();


            driver.Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            driver.Navigate().Back();
            Thread.Sleep(2000);

        }
    }
}
