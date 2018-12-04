using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace POC_CCEE_Access.Driver
{
    public class StefaniniWebDriver : ChromeDriver, IStefaniniWebDriver
    {
        public IWait<IWebDriver> Wait { get; set; }

        public StefaniniWebDriver() : base()
        {
            this.Wait = new WebDriverWait(this, new TimeSpan(0, 0, 40));
            this.Manage().Window.Maximize();
        }

    }
}
