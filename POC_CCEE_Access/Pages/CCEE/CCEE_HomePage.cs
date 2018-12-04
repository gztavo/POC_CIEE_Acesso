using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POC_CCEE_Access.Driver;

namespace POC_CCEE_Access.Pages.CCEE
{
    public class CCEE_HomePage
    {
        private readonly IStefaniniWebDriver driver; 

        public CCEE_HomePage(IStefaniniWebDriver _driver)
        {
            this.driver = _driver;
        }

        public CCEE_HomePage IrPara()
        {
            driver.Navigate().GoToUrl("https://www.ccee.org.br");
            return this;
        }

        public CCEE_ConteudoExclusivoPage ClicarNaAreaConteudoExclusivo()
        {
            var conteudoExclusivo_Locator = By.ClassName("acesso-conteudo-exclusivo");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(conteudoExclusivo_Locator));
            driver.FindElement(conteudoExclusivo_Locator).Click();
            return new CCEE_ConteudoExclusivoPage(driver);
        }


    }
}
