using MercadoLivreSeleniumTest.Hook;
using MercadoLivreSeleniumTest.Interactions;
using MercadoLivreSeleniumTest.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.PageObjects
{
   public class RealizarUmaCompraPageObject : DefaultPageObject
    {
        #region Properties
        private readonly IWebDriver driver;
        private WebDriverWait wait;
      
      
        #endregion

        #region Constructor

        public RealizarUmaCompraPageObject(IWebDriver browser) : base(browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
        }
        #endregion

        public void BtnPesquisarProduto_Click()
        {
            Utils.XWaitForObjectBePresent(BtnPesquisarProduto, wait);
            BtnPesquisarProduto.Click();
            Utils.XWaitForObjectBePresent(CategoriaPesquisa, wait);

        }

        public void Item1dalista_Click()
        {
            Utils.XWaitForObjectBePresent(Item1dalista, wait);
            Item1dalista.Click();
            Utils.XWaitForObjectNotBePresent(Item1dalista, wait);
        }

        public void BtnQuantidade_Click(int quantidade)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(BtnQuantidade);
            action.Build();
            action.Perform();

            BtnQuantidade.Click();
            Utils.XWaitForObjectBePresent(UlNumeroDeItens, wait);
            var unidade = UlNumeroDeItens.FindElements(By.TagName("li"));
            if (quantidade == 1)
            {
                unidade[0].Click();
            }
            if (quantidade == 2)
            {
                unidade[1].Click();
            }
            if (quantidade == 3)
            {
                unidade[2].Click();
            }

            Thread.Sleep(1000);
        }

        public void BtnAdicionarAoCarrinho_Click()
        {
            Utils.XWaitForObjectBePresent(BtnAdicionarAoCarrinho, wait);
            BtnAdicionarAoCarrinho.Click();
            Utils.XWaitForObjectNotBePresent(BtnAdicionarAoCarrinho, wait);
        }


        public void BtnComprardepoisDeAdicionar_Click()
        {
            Utils.XWaitForObjectBePresent(BtnComprardepoisDeAdicionar, wait);
            BtnComprardepoisDeAdicionar.Click();
            Utils.XWaitForObjectNotBePresent(BtnComprardepoisDeAdicionar, wait);
        }

        public void BtnContinueDepoisDeAdcionardoComprar_Click()
        {

            Actions action = new Actions(driver);
            action.MoveToElement(BtnContinueDepoisDeAdcionardoComprar);
            action.Build();
            action.Perform();
            Utils.XWaitForObjectBePresent(BtnContinueDepoisDeAdcionardoComprar, wait);
            BtnContinueDepoisDeAdcionardoComprar.Click();
            Utils.XWaitForObjectNotBePresent(BtnContinueDepoisDeAdcionardoComprar, wait);
        }

        public void SelectNovoCartaoCredito_Click()
        {
            Utils.XWaitForObjectBePresent(SelectNovoCartaoCredito, wait);
            SelectNovoCartaoCredito.Click();
            Thread.Sleep(1000);
          //  Utils.XWaitForObjectNotBePresent(SelectNovoCartaoCredito, wait);
        }

        public void BtnContinuarFormaDePagamento_Click()
        {
            Utils.XWaitForObjectBePresent(BtnContinuarFormaDePagamento, wait);
            BtnContinuarFormaDePagamento.Click();
            Utils.XWaitForObjectNotBePresent(BtnContinuarFormaDePagamento, wait);

        }

        public void BtnContinueConfigurarCartao_Click()
        {
            Utils.XWaitForObjectBePresent(BtnContinueConfigurarCartao, wait);
            BtnContinueConfigurarCartao.Click();
            Utils.XWaitForObjectNotBePresent(BtnContinueConfigurarCartao, wait);
        }

        public void Parcelado1X_Click()
        {
            Utils.XWaitForObjectBePresent(Parcelado1X, wait);
            Parcelado1X.Click();
          
        }

        public void BtnConfirmarCompra_Click()
        {
            Utils.XWaitForObjectBePresent(BtnConfirmarCompra, wait);
            BtnConfirmarCompra.Click();
            Utils.XWaitForObjectNotBePresent(BtnConfirmarCompra, wait);
        }

    }
}
