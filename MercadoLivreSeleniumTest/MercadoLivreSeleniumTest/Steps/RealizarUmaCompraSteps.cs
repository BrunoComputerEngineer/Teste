using MercadoLivreSeleniumTest.Domain;
using MercadoLivreSeleniumTest.Hook;
using MercadoLivreSeleniumTest.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MercadoLivreSeleniumTest.Steps
{
   

    [Binding]
    public class RealizarUmaCompraSteps
    {
        private SeleniumContext seleniumContext;
        private WebDriverWait wait;
        private RealizarUmaCompraPageObject realizarUmaCompraPageObject;
        private InformacoesDoCartaoDeCredito informacoesDoCartaoDeCredito = new InformacoesDoCartaoDeCredito().GetInformacoesDoCartaoDeCredito();


        public RealizarUmaCompraSteps(SeleniumContext seleniumContext)
        {
            this.seleniumContext = seleniumContext;
            wait = new WebDriverWait(seleniumContext.WebDriver, TimeSpan.FromSeconds(10));
            realizarUmaCompraPageObject = new RealizarUmaCompraPageObject(seleniumContext.WebDriver);
        }

        [Given(@"que eu estou logado no site com um usuario e senha valida")]
        public void DadoQueEuEstouLogadoNoSiteComUmUsuarioESenhaValida()
        {
           
        }

        [When(@"digitar ""(.*)"" no campo de pesquisa de produtos")]
        public void QuandoDigitarNoCampoDePesquisaDeProdutos(string itenNome)
        {
            realizarUmaCompraPageObject.CampoPesquisaProduto.SendKeys(itenNome);
            realizarUmaCompraPageObject.BtnPesquisarProduto_Click();
        }

        [When(@"selecionar o produto que contenha ""(.*)""")]
        public void QuandoSelecionarOProdutoQueContenha(string p0)
        {
            realizarUmaCompraPageObject.Item1dalista_Click();
        }

        [When(@"selecionar a quantidade de itens ""(.*)""")]
        public void QuandoSelecionarAQuantidadeDeItens(int quantidade)
        {
            realizarUmaCompraPageObject.BtnQuantidade_Click(quantidade);
        }


        [When(@"clicar em Adicionar ao carrinho")]
        public void QuandoClicarEmAdicionarAoCarrinho()
        {
            realizarUmaCompraPageObject.BtnAdicionarAoCarrinho_Click();
        }

        [When(@"clicar em Comprar do carrinho")]
        public void QuandoClicarEmComprarDoCarrinho()
        {
            realizarUmaCompraPageObject.BtnComprardepoisDeAdicionar_Click();
        }

        [When(@"clicar em continuar")]
        public void QuandoClicarEmContinuar()
        {
            realizarUmaCompraPageObject.BtnContinueDepoisDeAdcionardoComprar_Click();
        }

        [When(@"selecionar a opção novo cartão de credito e clicar em continuar")]
        public void QuandoSelecionarAOpcaoNovoCartaoDeCreditoEClicarEmContinuar()
        {
            realizarUmaCompraPageObject.SelectNovoCartaoCredito_Click();
            realizarUmaCompraPageObject.BtnContinuarFormaDePagamento_Click();
        }

        [When(@"Preencher todas as informações do formulario e clicar em continuar")]
        public void QuandoPreencherTodasAsInformacoesDoFormularioEClicarEmContinuar()
        {
            realizarUmaCompraPageObject.NumeroDoCartao.SendKeys(informacoesDoCartaoDeCredito.NumeroDoCartao);
            realizarUmaCompraPageObject.NomeeSobreNome.SendKeys(informacoesDoCartaoDeCredito.NomeeSobreNome);
            realizarUmaCompraPageObject.DataDeVencimento.SendKeys(informacoesDoCartaoDeCredito.DataDeVencimento);
            realizarUmaCompraPageObject.CodigoDeSeguranca.SendKeys(informacoesDoCartaoDeCredito.CodigoDeSeguranca);
            realizarUmaCompraPageObject.CPFDoTitularDoCartao.SendKeys(informacoesDoCartaoDeCredito.CPFDoTitularDoCartao);
            realizarUmaCompraPageObject.BtnContinueConfigurarCartao_Click();

        }

        [When(@"Selecionar a quantidade de parcelas ""(.*)"" e clicar em continuar")]
        public void QuandoSelecionarAQuantidadeDeParcelasEClicarEmContinuar(int numeroParcelas)
        {
            if (numeroParcelas == 1)
            {
                realizarUmaCompraPageObject.Parcelado1X_Click();
            }
            else
            {
                realizarUmaCompraPageObject.Parcelado1X_Click();
            }
            
        }

        [When(@"clicar em confirmar a compra")]
        public void QuandoClicarEmConfirmarACompra()
        {
            realizarUmaCompraPageObject.BtnConfirmarCompra_Click();
        }

        [Then(@"a compra será finalizada")]
        public void EntaoACompraSeraFinalizada()
        {
           
        }


    }
}
