using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace XpertHRTest.PageObjects
{
    public class Homepage
    {
        //driver.FindElement(By.CssSelector("button[id='onetrust-accept-btn-handler']"))
        /// <summary>
        /// By.CssSelector("button[id='onetrust-accept-btn-handler']"
        private IWebDriver driver;
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }


        //PageObject Factory

        [FindsBy(How = How.CssSelector, Using = "button[id='onetrust-accept-btn-handler']")]
        private IWebElement cookie;
        public IWebElement getcookie()
        {
            return cookie;
        }

        //Methods
        public void searchvalue()
       {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebElement search = (WebElement)js.ExecuteScript("return document.querySelector('body > xhr-header-component').shadowRoot.querySelector('#pageHeader > div > div.site-branding-and-search-container > div > div > xhr-search-field').shadowRoot.querySelector('#globalSearch > xhr-search').shadowRoot.querySelector('#search > input')");
            search.SendKeys("Pay");
       }

        public void searchbutton()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor) driver;
            WebElement button = (WebElement)jse.ExecuteScript("return document.querySelector('body > xhr-header-component').shadowRoot.querySelector('#pageHeader > div > div.site-branding-and-search-container > div > div > xhr-search-field').shadowRoot.querySelector('#globalSearch > xhr-search').shadowRoot.querySelector('#search > button')");
            button.Click();
        }
        


    }
}
