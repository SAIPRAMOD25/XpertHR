using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace XpertHRTest.PageObjects
{
    public class Results
    {
        private IWebDriver driver;
        public Results(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        //Methods
        public void showmore()
        {
            IJavaScriptExecutor smr = (IJavaScriptExecutor)driver;
            WebElement more = (WebElement)smr.ExecuteScript("return document.querySelector('#refineByTool > div.refine-criterion-filters.show-more > div > div > p > a > span:nth-child(1)')");
            more.Click();
        }

        public void refine()
        {
            IJavaScriptExecutor qs = (IJavaScriptExecutor)driver;
            WebElement query = (WebElement)qs.ExecuteScript("return document.querySelector('#refineByTool > div:nth-child(2) > ul > li:nth-child(11) > a')");
            query.Click();
        }
    }
}
