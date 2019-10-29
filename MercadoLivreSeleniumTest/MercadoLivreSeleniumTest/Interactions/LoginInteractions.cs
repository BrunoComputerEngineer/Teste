using MercadoLivreSeleniumTest.Domain;
using MercadoLivreSeleniumTest.PageObjects;
using MercadoLivreSeleniumTest.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.Interactions
{
    public class LoginInteractions : LoginPageObject
    {
        private readonly IWebDriver driver;
        private readonly string url;
        private WebDriverWait wait;
        private EnvironmentData environmentData = new EnvironmentData().GetEnvironmentData();
        private DefaultInteractions defaultInteractions;

        public LoginInteractions(IWebDriver browser) : base(browser)
        {
            {
                this.driver = browser;
                url = Utils.UrlBase;
#pragma warning disable CS0618 // Type or member is obsolete
                PageFactory.InitElements(browser, this);
                wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
                defaultInteractions = new DefaultInteractions(browser);
            }
        }



        #region Navigate
        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
            Utils.XWaitForObjectBePresent(BtnEntre, wait);
        }

        public void BtnEntre_Click()
        {
            Utils.XWaitForObjectBePresent(BtnEntre, wait);
            BtnEntre.Click();
           // this.driver.Navigate().GoToUrl("https://www.mercadolivre.com/jms/mlb/lgz/login?platform_id=ML&go=https%3A%2F%2Fwww.mercadolivre.com.br%2F&loginType=explicit#nav-header");
            Utils.WaitForObjectBePresent(TxtUserId, wait);
        }

        public void BtnContinueLogin_Click()
        {
            Utils.XWaitForObjectBePresent(BtnContinueLogin, wait);
            BtnContinueLogin.Click();
            Utils.XWaitForObjectNotBePresent(BtnContinueLogin, wait);
        }

        public void TxtUserId_Click()
        {
            Utils.WaitForObjectBePresent(TxtUserId, wait);
            TxtUserId.Click();
        }

        public void BtnLogin_click()
        {
            Utils.WaitForObjectBePresent(BtnLogin, wait);
            BtnLogin.Click();
            Utils.WaitForObjectNotBePresent(BtnLogin, wait);
        }
        #endregion

    }
}
