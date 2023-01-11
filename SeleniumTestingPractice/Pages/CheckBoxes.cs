using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class CheckBoxes : CorePage
    {

        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By checkboxeslinks = By.XPath("//a[normalize-space()='Checkboxes']");
        By clickcheckbox = By.XPath("//body//div//input[1]");
        By checkboxpageheader = By.XPath("//h3[normalize-space()='Checkboxes']");



        public void CheckboxesPage(string URL)
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


            //CHECKBOXES 
            driver.FindElement(checkboxeslinks).Click();
            Thread.Sleep(1000);

            string checkboxheader = driver.FindElement(checkboxpageheader).Text;
            Console.WriteLine("Checkbox Header: " + checkboxheader);
            driver.FindElement(clickcheckbox).Click();
            Thread.Sleep(1000);
            driver.Navigate().Back();






            Thread.Sleep(4000);

        }
    }
}
