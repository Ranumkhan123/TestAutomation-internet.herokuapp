using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTestingPractice.Pages
{
    public class JavaScriptAlerts : CorePage
    {


        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By alertslink = By.XPath("//a[normalize-space()='JavaScript Alerts']");
        By alertheading = By.XPath("//h3[normalize-space()='JavaScript Alerts']");
        By alerttext = By.XPath("//p[contains(text(),'Here are some examples of different JavaScript ale')]");
        By jsalertbtn = By.XPath("//button[normalize-space()='Click for JS Alert']");
        By jsalertresult = By.XPath("//p[@id='result']");
        By jsconfirm = By.XPath("//button[normalize-space()='Click for JS Confirm']");
        By jsconfirmresult = By.XPath("//p[@id='result']");
        By jsprompt = By.XPath("//button[normalize-space()='Click for JS Prompt']");
        By jspromptresult = By.XPath("//p[@id='result']");


        public void JavaScriptAlertsPage(string URL)
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


            //ALERTS 
            scroll.ExecuteScript("window.scrollBy(0,550)");
            driver.FindElement(alertslink).Click();
            Thread.Sleep(1000);


            //ALERTS HEADING TEXT
            string headingtextalert = driver.FindElement(alertheading).Text;
            Console.WriteLine("Alert Heading Message: " + headingtextalert);
            Console.WriteLine();

            //ALERTS TEXT
            string alerttextmessage = driver.FindElement(alerttext).Text;
            Console.WriteLine("Alert Text Message: " + alerttextmessage);
            Console.WriteLine();

            Console.WriteLine("ASSERTIONS");

            //JS ALERT BTN
            driver.FindElement(jsalertbtn).Click();
            IAlert JSalert = driver.SwitchTo().Alert();
            JSalert.Accept();


            //ASSERT ALERT
            string JSAlertResult = CorePage.driver.FindElement(jsalertresult).Text;
            Assert.AreEqual("You successfully clicked an alert", JSAlertResult);
            Console.WriteLine("JS Alert Result: " + JSAlertResult);


            //JS CONFIRM
            driver.FindElement(jsconfirm).Click();
            IAlert JSConfirm = driver.SwitchTo().Alert();
            JSConfirm.Accept();


            //ASSERT CONFIRM
            string JSConfirmResult = CorePage.driver.FindElement(jsconfirmresult).Text;
            Assert.AreEqual("You clicked: Ok", JSConfirmResult);
            Console.WriteLine("JS Confirm Result: " + JSConfirmResult);


            //JS PROMPT
            driver.FindElement(jsprompt).Click();
            IAlert JSPrompt = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            JSPrompt.SendKeys("HELLO....");
            JSPrompt.Accept();


            //ASSERT PROMPT
            string JSPromptResult = CorePage.driver.FindElement(jspromptresult).Text;
            Assert.AreEqual("You entered: HELLO....", JSPromptResult);
            Console.WriteLine("JS Prompt Result: " + JSPromptResult);

        }
    }
}
