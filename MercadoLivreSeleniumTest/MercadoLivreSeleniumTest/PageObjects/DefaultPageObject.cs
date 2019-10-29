using MercadoLivreSeleniumTest.Domain;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.PageObjects
{
    public class DefaultPageObject
    {

        #region Properties

        private readonly IWebDriver driver;
        private WebDriverWait wait;
        private Usuario _user = new Usuario().GetUsuario();

        #endregion

        #region Constructor

        public DefaultPageObject(IWebDriver browser)
        {
            driver = browser;
            wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(browser, this);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [FindsBy(How = How.Id, Using = "_3Jul3o")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/header/div/form/input")]
        public IWebElement CampoPesquisaProduto { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/header/div/form/button")]
        public IWebElement BtnPesquisarProduto { get; set; }

        [FindsBy(How = How.Id, Using = "categorySearch")]
        public IWebElement CategoriaPesquisa { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/main/div[1]/div/section/ol/li[1]/div")]
        public IWebElement Item1dalista { get; set; }
                                            
        [FindsBy(How = How.XPath, Using = "/html/body/main/div[1]/div/section/ol/li[3]")]
        public IWebElement Item2dalista { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div[1]/div[2]/div[1]/section[1]/div/form/fieldset[2]/div[2]/button")]
        public IWebElement BtnQuantidade { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[1]/div[2]/div[1]/section[1]/div/form/fieldset[3]/div[2]/button")]
        public IWebElement BtnQuantidade2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[1]/div[2]/div[1]/section[1]/div/form/fieldset[3]/div[2]/div/ul")]
        public IWebElement UlNumeroDeItens2 { get; set; }                                 
        
        [FindsBy(How = How.XPath, Using = "/html/body/main/div[2]/div[1]/div[2]/div[1]/section[1]/div/form/fieldset[2]/div[2]/div/ul")]
        public IWebElement UlNumeroDeItens { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='productInfo']/div[4]/div/div/input[3]")]
        public IWebElement BtnAdicionarAoCarrinho { get; set; }

        
        [FindsBy(How = How.XPath, Using = "/html/body/main/div[1]/div/div/div[2]/div[2]/a[2]")]
        public IWebElement BtnComprardepoisDeAdicionar { get; set; }
        
                                            
        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[3]/div/div/div[1]/div/div/div/div[4]/div[2]/button")]
        public IWebElement BtnContinueDepoisDeAdcionardoComprar { get; set; }
                                            
        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[3]/div/div/div[1]/div/div/div[4]/div/div/section/form/div[2]/input")]
        public IWebElement BtnContinueDepoisDeAdcionardoComprar2 { get; set; }
        


        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[3]/div/div/div[1]/div/section/div/form/article[2]/ul/li[1]/div/label")]
        public IWebElement SelectNovoCartaoCredito { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[3]/div/div/div[1]/div/section/div/form/div/div[2]/button")]
        public IWebElement BtnContinuarFormaDePagamento { get; set; }


        [FindsBy(How = How.Id, Using = "cardNumber")]
        public IWebElement NumeroDoCartao { get; set; }
        //NumeroDoCartao


        //NomeeSobreNome
        [FindsBy(How = How.Id, Using = "ownerName")]
        public IWebElement NomeeSobreNome { get; set; }
        //*[@id="uniqueSection"]/fieldset/div/div/div[1]/div[2]/div/label

        //DataDeVencimento id
        [FindsBy(How = How.Id, Using = "expirationDate")]
        public IWebElement DataDeVencimento { get; set; }
        //

        //CodigoDeSeguranca
        [FindsBy(How = How.Id, Using = "securityCode")]
        public IWebElement CodigoDeSeguranca { get; set; }
        

        //CPFDoTitularDoCartao
        [FindsBy(How = How.Id, Using = "userIdentificationNumber")]
        public IWebElement CPFDoTitularDoCartao { get; set; }
        // 

        //BtnContinueConfigurarCartao
        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[3]/div/div/div[1]/div/div/div[4]/div/section/div/form/div[2]/button")]
        public IWebElement BtnContinueConfigurarCartao { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[3]/div/div/div[1]/div/section/div/form/article/div/ul/li[1]")]
        public IWebElement Parcelado1X { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div/div[3]/div/div/div[1]/div/section/div/div[4]/div[2]/button")]
        public IWebElement BtnConfirmarCompra { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/header/div/a[3]")]
        public IWebElement BtnCarrinhoDeCompras { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[1]/div/div[2]/div[1]/div/ul/li[1]")]
        public IWebElement AbaCarrinho { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/main/div[1]/div/div[2]/div[4]/div/div[1]/div/div/article/div[3]/ul/li[4]/form/input[2]")]
        public IWebElement BtnExcluirItemCarrinho { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/main/div[1]/div/div[2]/div[4]/div")]
        public IWebElement DivItensNoCarrinho { get; set; }
        

        #endregion

    }
}
