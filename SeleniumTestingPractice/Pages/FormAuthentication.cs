using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class FormAuthentication : CorePage
    {
        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By formauthentication = By.XPath("//a[normalize-space()='Form Authentication']");
        By username = By.XPath("//input[@id='username']");
        By password = By.XPath("//input[@id='password']");
        By submitbtn = By.XPath("//button[@type='submit']");
        By afterloginheading = By.XPath("//h2[normalize-space()='Secure Area']");
        By afterlogintext = By.XPath("//h4[contains(text(),'Welcome to the Secure Area. When you are done clic')]");
        By logoutbtn = By.XPath("//i[normalize-space()='Logout']");


        public void FormAuthenticationPage(string URL, string enterusername, string enterpassword)
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


            //Form Authentication
            driver.FindElement(formauthentication).Click();
            Thread.Sleep(1000);


            driver.FindElement(username).SendKeys(enterusername);
            driver.FindElement(password).SendKeys(enterpassword);
            driver.FindElement(submitbtn).Click();



            //AFTER LOGIN HEADING
            string loginmessage = driver.FindElement(afterloginheading).Text;
            Console.WriteLine("Login: " + loginmessage);
            Console.WriteLine();

            //AFTER LOGIN TEXT
            string logintextmessage = driver.FindElement(afterlogintext).Text;
            Console.WriteLine("Login Message: " + logintextmessage);
            Console.WriteLine();

            Thread.Sleep(1000);

            driver.FindElement(logoutbtn).Click();






            Thread.Sleep(3000);



        }
    }
}
