using POC_CCEE_Access.Driver;
using POC_CCEE_Access.Pages.CCEE;

namespace POC_CCEE_Access.Services
{
    public class CCEE_Service
    {
        private readonly IStefaniniWebDriver driver;

        public CCEE_Service(IStefaniniWebDriver _driver)
        {
            driver = _driver;
        }

        public void AcessarConteudoRestrito()
        {
            var HomePage = new CCEE_HomePage(driver);
            HomePage.IrPara()
                    .ClicarNaAreaConteudoExclusivo()
                    .InformarLogin("teste")
                    .InformarSenha("testeSenha")
                    .ClicarEmEntrar();
        }
    }
}
