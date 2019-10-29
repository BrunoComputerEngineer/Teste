                                            # MercadoLivre Teste (Selenium/Cucumber/SpecFlow)
# Escolha da linguagem

O sistema foi desenvolvido em português apenas para facilitar o entendimento de quem vai corrigir, porém costumo fazer me inglês.

# Escolha da ferramenta e sua linguagem

Foi escolhido o visual Studio 2017 .Net, pelo fato de ser a ferramenta presente no meu dia a dia e estou em contato com maior frequencia, porém poderia ser feito exatamente igual utilizando java (eclipse).

# Dados Criados no mercado livre

Foi criada uma conta no mercado livre com os seguintes dados:
- login: testebrunociet@gmail.com
- senha: Mudar@123



# Configuração e Instalação
- Foi criado um projeto do tipo Unit Test Project (.Net Framework 4.7)
- Incluir bibliotecas do selenium/Nunit/SpecFlow:
Selenium.WebDriver
Selenium.Support
Selenium.WebDriverBackendSelenium
Nunit
Nunit3TestAdapter
Selenium.WebDriver.ChromeDriver
SpecFlow v2.4.1
SpecFlow.Nunit
Gherkin
specrun.Runner

- É necessario instalar uma extensão no visual studio do specFlow
SpecFlow for Visual Studio 2017
- é necessario fechar o visual studio e abri novamente

# Parametrização do projeto 
Todos os dados foram parametrizados em um arquivo .Csv e feito a leitura apartir dele assim quando necessario alterar alguma informação de insert,
é feito apenas a alteração nos arquivos .csv, que serão explicados na estrutura do projeto (Data).

# Estrutura do Projeto

A estrutura do projeto foi baseada no padrão de projeto PageObject com a seguinte estrutura:

- Data 
Contém arquivos .CSV utilizados para parametrização dos testes e facilidade da manutenção dos dados inseridos durante os testes.
ex: dados de inserção, Urls, Ambiente e etc...

- Domain
Contém arquivos para realizar a leitura dos .Csv.

- Features
Contém as features com a syntax gherkin dos testes utlizadas no (Cucumber/Specflow) .feature.


- Hook
São os ganchos, que são blocos de códigos executados "antes" ou "depois de" cada cenário ou steps.
(também foi criado um "SeleniumContext") - Para realizar a inicialização do ambiente e possivel execução em outros navegadores.
ex: Google Chrome e FireFox (Atualmente deve funcionar nesses dois).

- Interactions
Contém as interações (os cliques do usuário) do usuario utilizadas nos Steps.
EX: BtnLogin_Click();

- Page Objects
Contém o conceito de page objects consigerando por pagina, contem os atributos para o selenium encontar os elementos.
Ex: Name, id, Xpath.

- Steps
Contém os passos gerados pelas features do (Cucumber/SpeckFlow);

- Utiliy
Contém alguns ultils Criados para auxiliar na espera de um elemnto, verificar se está visivel, se já sumiu tela etc...
(Essa classe utils eu mesmo que fiz utilizo em todos projetos com selenium)



# Cenarios 

##### Cenario: Realizar uma compra

  ''
> -		Dado que eu estou logado no site com um usuario e senha valida
> -		Quando digitar "ps4" no campo de pesquisa de produtos
> -		E selecionar o produto que contenha "ps4"
> -		E selecionar a quantidade de itens "1" 
> -		E clicar em Adicionar ao carrinho
> -		E clicar em Comprar do carrinho
> -		E clicar em continuar
> -		E selecionar a opção novo cartão de credito e clicar em continuar
> -		E Preencher todas as informações do formulario e clicar em continuar
> -		E Selecionar a quantidade de parcelas "1" e clicar em continuar
> -		E clicar em confirmar a compra
> -		Então a compra será finalizada

##### Cenario: Realizar uma Nova compra e adcionar mais de um item

  ''
> -		Dado que eu estou logado no site com um usuario e senha valida
> -		Quando digitar "ps4" no campo de pesquisa de produtos
>	- E selecionar o produto que contenha "ps4 2"
> -		E selecionar a quantidade de itens "2" 
> -		E clicar em Adicionar ao carrinho
> -		E clicar em Comprar do carrinho
> -		E clicar em continuar
> -		E selecionar a opção novo cartão de credito e clicar em continuar
> -		E Preencher todas as informações do formulario e clicar em continuar
> -		E Selecionar a quantidade de parcelas "1" e clicar em continuar
> -		E clicar em confirmar a compra
> -		Então a compra será finalizada

##### Cenario: Excluir um item do carrinho de compras

  ''
> -		Dado que eu estou logado no site com um usuario e senha valida
> -		Quando Clicar na opção carrinho de compras
> -		E Clicar para excluir um item
> -		Então ficará apenas um item no carrinho

# Executar o Projeto

Para executar o projeto basta:
- Ter o visual studio intalado utilizei o 2017
- Ir em test  >  Windowns > Test Explorer (para abrir a aba lateral com os testes e Cenarios)

- 1º clocar o projeto do GitHub 
- 2º realizar o build da solution
- 3º Dar um restore Nuguet Packages
- 4º Clicar com o botão direito no Test Explorer Clicar em "RUn All" para executar todos os testes

# referencias

* [Selenium] - https://www.seleniumhq.org
* [.Net] - https://docs.microsoft.com/pt-br/dotnet/
* [Cucumber] - https://cucumber.io/
* [SpecFlow] - https://specflow.org/
* [PageObjects] - https://blog.caelum.com.br/organizacao-de-testes-de-aceitacao-com-pageobjects/

