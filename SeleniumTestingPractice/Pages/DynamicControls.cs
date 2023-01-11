using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class DynamicControls : CorePage
    {
        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By dynamiccontrollink = By.XPath("//a[normalize-space()='Dynamic Controls']");
        By dynamiccontrolheading = By.XPath("//h4[normalize-space()='Dynamic Controls']");
        By dynamiccontroltext = By.XPath("//p[contains(text(),'This example demonstrates when elements (e.g., che')]");
        By dynamiccheckbox = By.XPath("//input[@type='checkbox']");
        By removebutton = By.XPath("//button[normalize-space()='Remove']");
        By removebtnmessage = By.XPath("//p[@id='message']");
        By enabledisablebtn = By.XPath("//button[normalize-space()='Enable']");
        By enabledmessage = By.XPath("//p[@id='message']");
        By enabledtextbox = By.XPath("//input[@type='text']");
        By disabletextbtn = By.XPath("//button[normalize-space()='Enable']");
        By disabletext = By.XPath("//p[@id='message']");
       // By enabledtextbox = By.XPath("//input[@type='text']");


        public void DynamicControlsPage(string URL)
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


            //DYNAMIC CONTROLS 
            driver.FindElement(dynamiccontrollink).Click();
            Thread.Sleep(1000);

            //HEADING
            string dynamicheading = driver.FindElement(dynamiccontrolheading).Text;
            Console.WriteLine("Dynamic Control Heading: " + dynamicheading);
            Console.WriteLine();

            //TEXT
            string dynamictext = driver.FindElement(dynamiccontroltext).Text;
            Console.WriteLine("Dynamic Control Text: " + dynamictext);
            Console.WriteLine();


            driver.FindElement(dynamiccheckbox).Click();
            Thread.Sleep(1000);
            driver.FindElement(removebutton).Click();
            Thread.Sleep(5000);

            string dynamicremovebtnmessage = driver.FindElement(removebtnmessage).Text;
            Console.WriteLine("Remove Button: " + dynamicremovebtnmessage);
            Console.WriteLine();
            Thread.Sleep(2000);

            
            //Enable/disable
            driver.FindElement(enabledisablebtn).Click();
            Thread.Sleep(4500);

            string enablemessagetext = driver.FindElement(enabledmessage).Text;
            Console.WriteLine("Enable Button Text: " + enablemessagetext);
            Console.WriteLine();
            Thread.Sleep(2000);

        }
    }
}
