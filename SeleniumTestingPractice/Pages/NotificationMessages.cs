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
    public class NotificationMessages : CorePage
    {
        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By notificationmessageslink = By.XPath("//a[contains(text(),'Notification Messages')]");
        By notificationmessage = By.XPath("//div[@id='flash']");
        By clickherebtn = By.XPath("//a[normalize-space()='Click here']");
        By newwindowtext = By.XPath("//h3[normalize-space()='New Window']");
        By jsalertresult = By.XPath("//p[@id='result']");
        By jsconfirm = By.XPath("//button[normalize-space()='Click for JS Confirm']");
        By jsconfirmresult = By.XPath("//p[@id='result']");
        By jsprompt = By.XPath("//button[normalize-space()='Click for JS Prompt']");
        By jspromptresult = By.XPath("//p[@id='result']");


        public void NotificationMessagesPage(string URL)
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


            //CLICK Notification Messages
            scroll.ExecuteScript("window.scrollBy(0,700)");
            driver.FindElement(notificationmessageslink).Click();


            //Notification Messages 
            string notificationmessages = driver.FindElement(notificationmessage).Text;
            Console.WriteLine("Notification Message: " + notificationmessages);
            Console.WriteLine();

            Thread.Sleep(2000);

            driver.FindElement(clickherebtn).Click();

            //Notification Messages 
            string othernotificationmessages = driver.FindElement(notificationmessage).Text;
            Console.WriteLine("Notification Message: " + othernotificationmessages);
            Console.WriteLine();

            Thread.Sleep(2000);

            driver.Navigate().Back();
            driver.Navigate().Back();
            

            Thread.Sleep(3000);
        }
    }
}
