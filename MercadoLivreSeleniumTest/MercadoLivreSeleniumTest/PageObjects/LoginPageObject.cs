using MercadoLivreSeleniumTest.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.PageObjects
{
    public class LoginPageObject : DefaultInteractions
    {
        #region Properties


        #endregion

        #region Constructor

        public LoginPageObject(IWebDriver browser) : base(browser)
        {

        }
        #endregion

        #region Fields



        [FindsBy(How = How.XPath, Using = "//*[@id='nav-header-menu']/a[2]")]
        public IWebElement BtnEntre { get; set; }

        [FindsBy(How = How.Id, Using = "user_id")]
        public IWebElement TxtUserId { get; set; }
        

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement TxtSenha { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='login_user_form']/div[2]/input")]
        public IWebElement BtnContinueLogin { get; set; }
        

        [FindsBy(How = How.Id, Using = "action-complete")]
        public IWebElement BtnLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div[2]/div[1]/div[2]/div/div/div[5]/div/div/div[2]/div")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "header_user_name")]
        public IWebElement LblUserName { get; set; }

        [FindsBy(How = How.Id, Using = "_1mGav-")]
        public IWebElement BtnSearchGlobal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='_3OLppY']/div[2]")]
        public IWebElement MessageErrorLogin { get; set; }

        [FindsBy(How = How.Id, Using = "_1CrF5l")]
        public IWebElement BtnForgotMyPassword { get; set; }

        [FindsBy(How = How.Id, Using = "_1FrD8f")]
        public IWebElement TxtRecoverMyEmailPassword { get; set; }

        [FindsBy(How = How.Id, Using = "drQLma")]
        public IWebElement BtnContinueRetrievePassword { get; set; }

        [FindsBy(How = How.Id, Using = "_3YIJdS")]
        public IWebElement BtnBackRecoverPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='dD9COc']/div/div/div[2]")]
        public IWebElement TextEmailRetrive { get; set; }

        [FindsBy(How = How.Id, Using = "_2UDWEy")]
        public IWebElement TxtNewPassword { get; set; }

        [FindsBy(How = How.Id, Using = "_2tc61l")]
        public IWebElement TxtRe_EnterPassword { get; set; }

        [FindsBy(How = How.Id, Using = "_1asvhU")]
        public IWebElement BtnContinueRecoverPassword { get; set; }

        [FindsBy(How = How.Id, Using = "_3YIJdS")]
        public IWebElement BtnRecoverBack { get; set; }

        [FindsBy(How = How.Id, Using = "o1FEcN")]
        public IWebElement LblMenssageErrorCodInvalid { get; set; }

        [FindsBy(How = How.Id, Using = "_26YT2L")]
        public IWebElement ToggleSwitchKeepConnected { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div[2]/div[2]/div/div/div[1]/div/div/div/div[1]/span")]
        public IWebElement WellcomeToTalkture { get; set; }

        #endregion

    }

}
