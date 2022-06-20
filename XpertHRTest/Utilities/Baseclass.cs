using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace XpertHRTest.Utilities
{
    public class Baseclass
    {

        public IWebDriver driver;
        [SetUp]
        public void Setup() // Invoking and Setting up the browser settings 
        {

            // This will basically take care of all chrome exe files,basically if we don't have this we need to download the chrome exe on our own
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.xperthr.co.uk/";   //setting the url for the browser

        }

    }
}
