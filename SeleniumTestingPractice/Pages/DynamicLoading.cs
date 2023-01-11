using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class DynamicLoading : CorePage
    {

        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By dynamicloadinglink = By.XPath("//a[normalize-space()='Dynamic Loading']");
        By dynamicloadingheading = By.XPath("//h3[normalize-space()='Dynamically Loaded Page Elements']");
        By dynamiccontroltext = By.XPath("//p[contains(text(),\"It's common to see an action get triggered that re\")]");
        By moredynamiccontroltext = By.XPath("//p[contains(text(),'There are two examples. One in which an element al')]");
        By examplebtnone = By.XPath("//a[normalize-space()='Example 1: Element on page that is hidden']");
        By exampleoneheading = By.XPath("//h4[normalize-space()='Example 1: Element on page that is hidden']");
        By startbutton = By.XPath("//button[normalize-space()='Start']");
        By textafterstartbtn = By.XPath("//h4[normalize-space()='Hello World!']");
        By examplebtntwo = By.XPath("//a[normalize-space()='Example 2: Element rendered after the fact']");
        By exampletwoheading = By.XPath("//h4[normalize-space()='Example 2: Element rendered after the fact']");
        By exampletwostartbtn = By.XPath("//button[normalize-space()='Start']");
        By startbtnexampletwo = By.XPath("//h4[normalize-space()='Hello World!']");
        // By enabledtextbox = By.XPath("//input[@type='text']");


        public void DynamicLoadingPage(string URL)
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
            driver.FindElement(dynamicloadinglink).Click();
            Thread.Sleep(1000);

            //HEADING
            string dynamicloadingheadingtext = driver.FindElement(dynamicloadingheading).Text;
            Console.WriteLine("Dynamic Loading Heading: " + dynamicloadingheadingtext);
            Console.WriteLine();

            //TEXT
            string dynamicloadingtext = driver.FindElement(dynamiccontroltext).Text;
            Console.WriteLine("Dynamic Loading Text: " + dynamicloadingtext);
            Console.WriteLine();

            //TEXT
            string moredynamicloadingtext = driver.FindElement(moredynamiccontroltext).Text;
            Console.WriteLine("Dynamic Loading Text: " + moredynamicloadingtext);
            Console.WriteLine();


            //EXAMPLE ONE
            driver.FindElement(examplebtnone).Click();
            Thread.Sleep(2000);

            //EXAMPLE ONE HEADING TEXT
            string exampleonetext = driver.FindElement(exampleoneheading).Text;
            Console.WriteLine("Dynamically Loaded Page Elements Text: " + exampleonetext);
            Console.WriteLine();


            driver.FindElement(startbutton).Click();
            Thread.Sleep(5000);

            //START BUTTON TEXT
            string startbtntext = driver.FindElement(textafterstartbtn).Text;
            Console.WriteLine("Start Button Text: " + startbtntext);
            Console.WriteLine();


            driver.Navigate().Back();

            //EXAMPLE TWO
            driver.FindElement(examplebtntwo).Click();


            //EXAMPLE TWO HEADING TEXT
            string exampletwotext = driver.FindElement(exampletwoheading).Text;
            Console.WriteLine("Dynamically Loaded Page Elements Text: " + exampletwotext);
            Console.WriteLine();


            driver.FindElement(exampletwostartbtn).Click();
            Thread.Sleep(5000);

            //START BUTTON TEXT
            string exampletwostartbtntext = driver.FindElement(startbtnexampletwo).Text;
            Console.WriteLine("Start Button Text: " + exampletwostartbtntext);
            Console.WriteLine();

            driver.Navigate().Back();

            driver.Navigate().Back();

            Thread.Sleep(3000);
        }
    }
}
