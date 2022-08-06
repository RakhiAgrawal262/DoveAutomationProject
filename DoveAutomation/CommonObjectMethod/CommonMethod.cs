using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using NPOI.XSSF.UserModel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.ObjectModel;
using DoveAutomation.Utilities;
using Docker.DotNet.Models;
using OpenQA.Selenium.Interactions;



namespace DoveAutomation.CommonObjectMethod
{
    public class CommonMethod
    {


        public void OpenDoveURL()
        {

            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html ");
            Thread.Sleep(2000);
        }
        public void EnteredShampoo()
        {
            BaseClass.driver.FindElement(By.XPath("//div[@class='c-search-wrapper c-search-wrapper--even']")).Click();



            BaseClass.driver.FindElement(By.XPath("//*[@id='globalSearch']/div[2]/div/span/input")).SendKeys("Shampoo");
            Thread.Sleep(5000);

        }
        public void PressSearch()
        {
            BaseClass.driver.FindElement(By.XPath("//*[@id='globalSearch']/div[2]/div/button[2]")).Click();

            ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(5000);

        }

        public void VerifyShampoo()
        {
            string text = BaseClass.driver.FindElement(By.XPath("//h2[text()='Baby Shampoo']")).Text;

            if (text.Contains("Shampoo"))
            {
                Console.WriteLine("Shampoo keyword is present");
            }
            else
            {
                Console.WriteLine("Shampoo Keyword is not present");
            }

            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile
           (@"C:\Users\DELL\source\repos\DoveAutomation\DoveAutomation\ScreenShot\image1.png");

        }

        public void OpenDoveURL1()
        {
            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html ");
            Thread.Sleep(5000);
        }
        public void ClickOnDiscoverMore()
        {
            Thread.Sleep(2000);

            BaseClass.driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']")).Click();
            Thread.Sleep(3000);

            BaseClass.driver.FindElement(By.XPath("//a[@data-title='Discover more']")).Click();
            Thread.Sleep(5000);
            ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(5000);
        }

        public void VerifyTheRealWomen()
        {
            string text = BaseClass.driver.FindElement(By.XPath("/html/body/div[1]/section/div[1]/div[2]/div/div/div/div[1]/h2")).Text;

            if (text.Contains("The Real Women behind #StopTheBeautyTest"))
            {
                Console.WriteLine("The Real Women behind #StopTheBeautyTest text is present");
            }
            else
            {
                Console.WriteLine("The Real Women behind #StopTheBeautyTest text is not present");
            }

            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile
           (@"C:\Users\DELL\source\repos\DoveAutomation\DoveAutomation\ScreenShot\image2.png");

        }


        public void OpenDoveURL2()
        {
            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html ");
            Thread.Sleep(5000);
        }

        public void ClickonTermsofuse()
        {
            Thread.Sleep(5000);
            BaseClass.driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']")).Click();
            Thread.Sleep(2000);

            BaseClass.driver.FindElement(By.XPath("//a[@href='https://www.dove.com/in/terms-of-use.html']")).Click();
            Thread.Sleep(2000);
            ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(5000);
        }


        public void VerifyProhibitedUses()
        {

            string text = BaseClass.driver.FindElement(By.XPath("//b[text()='2. Prohibited Uses']")).Text;

            if (text.Contains("Prohibited Uses in the Terms of Use page"))
            {
                Console.WriteLine("Prohibited Uses in the Terms of Use page text is present");
            }
            else
            {
                Console.WriteLine("Prohibited Uses in the Terms of Use page is not present");
            }

            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile
           (@"C:\Users\DELL\source\repos\DoveAutomation\DoveAutomation\ScreenShot\image3.png");
        }

    }
    }

