using BoDi;
using MercadoLivreSeleniumTest.Domain;
using MercadoLivreSeleniumTest.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MercadoLivreSeleniumTest.Hook
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private static SeleniumContext seleniumContext;
        private static LoginInteractions loginInteractions;
        private Usuario user = new Usuario().GetUsuario();


        public Hooks(IObjectContainer container)
        {
            this.objectContainer = container;
        }

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            seleniumContext = new SeleniumContext();
            loginInteractions = new LoginInteractions(seleniumContext.WebDriver);
            loginInteractions.Navigate();
            loginInteractions.BtnEntre_Click();
            loginInteractions.TxtUserId.SendKeys(user.Login);
            loginInteractions.BtnContinueLogin_Click();
            loginInteractions.TxtSenha.SendKeys(user.Password);

            loginInteractions.BtnLogin_click();
            objectContainer.RegisterInstanceAs<SeleniumContext>(seleniumContext);
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
