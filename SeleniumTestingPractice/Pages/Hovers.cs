using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class Hovers : CorePage
    {

        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By hoverslink = By.XPath("//a[normalize-space()='Hovers']");
        By hoverstext = By.XPath("//p[normalize-space()='Hover over the image for additional information']");
        By pictureone = By.XPath("//body/div/div[@id='content']/div/div[1]/img[1]");
        By picturetwo = By.XPath("//div//div[2]//img[1]");
        By picturethree = By.XPath("//div//div[3]//img[1]");
        By pictureonetext = By.XPath("//h5[normalize-space()='name: user1']");
        By picturetwotext = By.XPath("//h5[normalize-space()='name: user2']");
        By picturethreetext = By.XPath("//h5[normalize-space()='name: user3']");


        public void HoversPage(string URL)
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


            //Hovers 
            scroll.ExecuteScript("window.scrollBy(0,550)");
            driver.FindElement(hoverslink).Click();
            Thread.Sleep(1000);


            //HOVERS TEXT
            string hoverstextmessage = driver.FindElement(hoverstext).Text;
            Console.WriteLine("Hovers Text Message: " + hoverstextmessage);
            Console.WriteLine();

            //HOVER TO PICTURE ONE
            action.MoveToElement(driver.FindElement(pictureone)).Click().Build().Perform();
            string textpictureone = driver.FindElement(pictureonetext).Text;
            Console.WriteLine("Picture One Text: " + textpictureone);
            Console.WriteLine();



            //HOVER TO PICTURE TWO
            action.MoveToElement(driver.FindElement(picturetwo)).Click().Build().Perform();
            string textpicturetwo = driver.FindElement(picturetwotext).Text;
            Console.WriteLine("Picture Two Text: " + textpicturetwo);
            Console.WriteLine();


            //HOVER TO PICTURE THREE
            action.MoveToElement(driver.FindElement(picturethree)).Click().Build().Perform();
            string textpicturethree = driver.FindElement(picturethreetext).Text;
            Console.WriteLine("Picture Three Text: " + textpicturethree);
            Console.WriteLine();



            Thread.Sleep(3000);





        }
    }
}
