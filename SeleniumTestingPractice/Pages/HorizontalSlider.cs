using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTestingPractice.Pages
{
    public class HorizontalSlider : CorePage
    {
        By header = By.XPath("//h1[normalize-space()='Welcome to the-internet']");
        By horizontalsliderlink = By.XPath("//a[normalize-space()='Horizontal Slider']");
        By horizontalsliderpageheading = By.XPath("//h3[normalize-space()='Horizontal Slider']");
        By horizontalsliderpagetext = By.XPath("//h4[contains(text(),'Set the focus on the slider (by clicking on it) an')]");
        By sliderbtn = By.XPath("//input[@value='0']");
        By rangevalue = By.XPath("//span[@id='range']");




        public void HorizontalSliderPage(string URL)
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


            //Horizontal Slider
            scroll.ExecuteScript("window.scrollBy(0,500)");
            driver.FindElement(horizontalsliderlink).Click();
            Thread.Sleep(1000);

            //Horizontal Slider Heading
            string horizontalsliderheadingtext = driver.FindElement(horizontalsliderpageheading).Text;
            Console.WriteLine("Horizontal Slider Heading: " + horizontalsliderheadingtext);
            Console.WriteLine();

            //Horizontal Slider Text
            string horizontalslidertextmessage = driver.FindElement(horizontalsliderpagetext).Text;
            Console.WriteLine("Horizontal Slider Text Message: " + horizontalslidertextmessage);
            Console.WriteLine();

            driver.FindElement(sliderbtn).SendKeys(Keys.ArrowRight);
            driver.FindElement(sliderbtn).SendKeys(Keys.ArrowRight);
            driver.FindElement(sliderbtn).SendKeys(Keys.ArrowRight);

            //Slider range value
            string sliderrangevalue = driver.FindElement(rangevalue).Text;
            Console.WriteLine("Range Value of Slider: " + sliderrangevalue);
            Console.WriteLine();


            Thread.Sleep(2000);



        }
    }
}
