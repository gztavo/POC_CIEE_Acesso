using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POC_CCEE_Access.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_CCEE_Access.Pages.CCEE
{
    public class CCEE_ConteudoExclusivoPage
    {
        private readonly IStefaniniWebDriver driver;

        public CCEE_ConteudoExclusivoPage(IStefaniniWebDriver _driver)
        {
            this.driver = _driver;
        }

        public CCEE_ConteudoExclusivoPage InformarLogin(string userNameText)
        {
            var login_Locator = By.Name("username");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(login_Locator));
            driver.FindElement(login_Locator).SendKeys(userNameText);
            return this;
        }

        public CCEE_ConteudoExclusivoPage InformarSenha(string senhaText)
        {
            var password_Locator = By.Name("password");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(password_Locator));
            driver.FindElement(password_Locator).SendKeys(senhaText);
            return this;
        }

        public CCEE_ConteudoExclusivoPage ClicarEmEntrar()
        {
            var button_Locator = By.TagName("button");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(button_Locator));
            driver.FindElement(button_Locator).Click();
            return this;
        }
    }
}
