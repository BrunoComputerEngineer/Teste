﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MercadoLivreSeleniumTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RealizarUmaCompra")]
    public partial class RealizarUmaCompraFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RealizarUmaCompra.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "RealizarUmaCompra", "\tComo usuario desejo realizar uma compra no mercado livre", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Realizar uma compra")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void RealizarUmaCompra()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar uma compra", null, new string[] {
                        "mytag"});
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("que eu estou logado no site com um usuario e senha valida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 8
 testRunner.When("digitar \"ps4\" no campo de pesquisa de produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 9
 testRunner.And("selecionar o produto que contenha \"ps4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.And("selecionar a quantidade de itens \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 11
 testRunner.And("clicar em Adicionar ao carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 12
 testRunner.And("clicar em Comprar do carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 13
 testRunner.And("clicar em continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 14
 testRunner.And("selecionar a opção novo cartão de credito e clicar em continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
 testRunner.And("Preencher todas as informações do formulario e clicar em continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 16
 testRunner.And("Selecionar a quantidade de parcelas \"1\" e clicar em continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
 testRunner.And("clicar em confirmar a compra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 18
 testRunner.Then("a compra será finalizada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Realizar uma Nova compra e adcionar mais de um item")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void RealizarUmaNovaCompraEAdcionarMaisDeUmItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar uma Nova compra e adcionar mais de um item", null, new string[] {
                        "mytag"});
#line 21
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 22
 testRunner.Given("que eu estou logado no site com um usuario e senha valida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 23
 testRunner.When("digitar \"ps4\" no campo de pesquisa de produtos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 24
 testRunner.And("selecionar o produto que contenha \"ps4 2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 25
 testRunner.And("selecionar a quantidade de itens \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 26
 testRunner.And("clicar em Adicionar ao carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 27
 testRunner.And("clicar em Comprar do carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 28
 testRunner.And("clicar em continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 29
 testRunner.And("selecionar a opção novo cartão de credito e clicar em continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 30
 testRunner.And("Preencher todas as informações do formulario e clicar em continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 31
 testRunner.And("Selecionar a quantidade de parcelas \"1\" e clicar em continuar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 32
 testRunner.And("clicar em confirmar a compra", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 33
 testRunner.Then("a compra será finalizada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Excluir um item do carrinho de compras")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ExcluirUmItemDoCarrinhoDeCompras()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excluir um item do carrinho de compras", null, new string[] {
                        "mytag"});
#line 36
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 37
 testRunner.Given("que eu estou logado no site com um usuario e senha valida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 38
 testRunner.When("Clicar na opção carrinho de compras", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 39
 testRunner.And("Clicar para excluir um item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 40
 testRunner.Then("ficará apenas um item no carrinho", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

