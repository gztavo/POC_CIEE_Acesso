using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_CCEE_Access.Driver
{
    public interface IStefaniniWebDriver : IWebDriver
    {
        IWait<IWebDriver> Wait { get; set; }
    }
}
