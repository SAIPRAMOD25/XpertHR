using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Remote;
using XpertHRTest.PageObjects;
using XpertHRTest.Utilities;

namespace XpertHRTest
{
    public class Tests : Baseclass
    {
       
        [Test]
        public void Test1()
        {

            Homepage homepage = new Homepage(driver);
            homepage.getcookie().Click();
            homepage.searchvalue();
            homepage.searchbutton();

            Results results = new Results(driver);
            results.showmore();
            results.refine();

            //driver.Close();

        }
    }
}