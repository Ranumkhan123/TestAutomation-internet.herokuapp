using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class DisappearingElements :CorePage
    {
        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By disappearingelementslink = By.XPath("//a[normalize-space()='Disappearing Elements']");
        By hometab = By.XPath("//a[normalize-space()='Home']");
        By abouttab = By.XPath("//a[normalize-space()='About']");
        By abouttabmessage = By.XPath("//h1[normalize-space()='Not Found']");
        By contactustab = By.XPath("//a[normalize-space()='Contact Us']");
        By contactustabmessage = By.XPath("//h1[normalize-space()='Not Found']");
        By portfoliotab = By.XPath("//a[normalize-space()='Portfolio']");
        By portfoliotabmessage = By.XPath("//h1[normalize-space()='Not Found']");
        By gallerytab = By.XPath("//a[normalize-space()='Gallery']");
        By gallerytabmessage = By.XPath("//h1[normalize-space()='Not Found']");



        public void DisappearingElementsPage(string URL)
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


            //Disappearing Elements
            driver.FindElement(disappearingelementslink).Click();
            Thread.Sleep(1000);
            driver.FindElement(hometab).Click();
            Thread.Sleep(1000);
            driver.FindElement(disappearingelementslink).Click();
            Thread.Sleep(1000);

            driver.FindElement(abouttab).Click();
            
            string aboutscreeenurl = driver.Url;
            Console.WriteLine("Current URL: " + aboutscreeenurl);
            Console.WriteLine();

            string aboutscreenmessage = driver.FindElement(abouttabmessage).Text;
            Console.WriteLine("About Screen: " + aboutscreenmessage);
            Console.WriteLine();
            Thread.Sleep(2000);

            driver.Navigate().Back();

            driver.FindElement(contactustab).Click();

            string contactscreeenurl = driver.Url;
            Console.WriteLine("Current URL: " + contactscreeenurl);
            Console.WriteLine();

            string contactusscreenmessage = driver.FindElement(contactustabmessage).Text;
            Console.WriteLine("Contact Us Screen: " + contactusscreenmessage);
            Console.WriteLine();
            Thread.Sleep(2000);
            driver.Navigate().Back();

            driver.FindElement(portfoliotab).Click();

            string portfolioscreeenurl = driver.Url;
            Console.WriteLine("Current URL: " + portfolioscreeenurl);
            Console.WriteLine();
            
            string portfolioscreenmessage = driver.FindElement(portfoliotabmessage).Text;
            Console.WriteLine("Contact Us Screen: " + portfolioscreenmessage);
            Console.WriteLine();
            Thread.Sleep(2000);
            driver.Navigate().Back();

            /*
            driver.FindElement(gallerytab).Click();

            string galleryscreenmessage = driver.FindElement(gallerytabmessage).Text;
            Console.WriteLine("Contact Us Screen: " + galleryscreenmessage);
            Console.WriteLine();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            */

            Thread.Sleep(1000);
            driver.Navigate().Back();

            Thread.Sleep(2000);
        }
    }
}