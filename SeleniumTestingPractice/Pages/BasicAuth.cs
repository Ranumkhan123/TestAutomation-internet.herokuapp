using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class BasicAuth : CorePage
    {

        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By basicauthlink = By.XPath("//a[normalize-space()='Basic Auth']");
        By addelementbtn = By.XPath("//button[normalize-space()='Add Element']");
        By delelement = By.XPath("//button[normalize-space()='Delete']");
        By addandremovepage = By.XPath("//h3[normalize-space()='Add/Remove Elements']");


        public void BasicAuthPage(string URL)
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

            //BSIC AUTH
            driver.FindElement(basicauthlink).Click();

            //driver.SwitchTo().Alert().Dismiss();
           // basicauthalert.SendKeys("admin");
           // basicauthalert.SendKeys("admin");
           // basicauthalert.Accept();





            Thread.Sleep(4000);

        }
    }
}
