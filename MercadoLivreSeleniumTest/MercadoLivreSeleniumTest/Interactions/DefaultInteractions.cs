using MercadoLivreSeleniumTest.Domain;
using MercadoLivreSeleniumTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.Interactions
{
    public class DefaultInteractions : DefaultPageObject
    {
        #region Properties

        private readonly IWebDriver driver;
        private WebDriverWait wait;
        private Usuario _user = new Usuario().GetUsuario();
        private EnvironmentData environmentData = new EnvironmentData().GetEnvironmentData();

        #endregion

        #region Constructor

        public DefaultInteractions(IWebDriver browser) : base(browser)
        {
            this.driver = browser;
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
        }

       

        #endregion

    }
}
