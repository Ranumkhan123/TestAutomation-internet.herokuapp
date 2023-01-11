using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class AddandRemoveElement : CorePage
    {
        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By addandremovelink = By.XPath("//a[normalize-space()='Add/Remove Elements']");
        By addelementbtn = By.XPath("//button[normalize-space()='Add Element']");
        By delelement = By.XPath("//button[normalize-space()='Delete']");
        By addandremovepage = By.XPath("//h3[normalize-space()='Add/Remove Elements']");


        public void AddandRemove(string URL)
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


            //ADD AND REMOVE ELEMENTS
            driver.FindElement(addandremovelink).Click();

            //ADD AND REMOVE PAGE HEADER
            string addandremovepagemessage = driver.FindElement(addandremovepage).Text;
            Console.WriteLine(addandremovepagemessage);


            driver.FindElement(addelementbtn).Click();
            Thread.Sleep(1000);
            driver.FindElement(delelement).Click();

            //ADD MULTIPLE ELEMENTS
            driver.FindElement(addelementbtn).Click();
            Thread.Sleep(1000);
            driver.FindElement(addelementbtn).Click();
            Thread.Sleep(1000);
            driver.FindElement(addelementbtn).Click();
            Thread.Sleep(3000);

            //DELETE MULTIPLE ELEMENTS
            driver.FindElement(delelement).Click();
            Thread.Sleep(1000);
            driver.FindElement(delelement).Click();
            Thread.Sleep(1000);
            driver.FindElement(delelement).Click();
            Thread.Sleep(2000);



            driver.Navigate().Back();

            Thread.Sleep(3000);



        }
    }
}
