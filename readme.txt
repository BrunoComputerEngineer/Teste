****** Foi todo sistema foi desenvolvido em portugu�s apenas para facilitar o entendimento de quem vai corrigir, por�m costumo fazer me ingl�s *********
(Como no teste foi pedido que n�o seria necessario a finaliza��o do pedido os passos param ao adicionar um novo cartao porem no cenario foi escrito que seria finalizado a compra)

Foi criada uma conta no gmail com os seguintes dados:
login: testebrunociet@gmail.com
senha: Mudar@123

foi criada uma conta no mercado livre com os seguintes dados:
login: testebrunociet@gmail.com
senha: Mudar@123

Configura��o e Instala��o
- Foi criado um projeto do tipo Unit Test Project (.Net Framework 4.7)
- Incluir bibliotecas do selenium
Selenium.WebDriver
Selenium.Support
Selenium.WebDriverBackendSelenium

- Foi instalado no Nuget os seguintes pacotes:
SpecFlow v2.4.1

specrun.Runner
Nunit
- � necessario instalar uma extens�o no visual studio do specFlow
SpecFlow for Visual Studio 2017
� necessario fechar o visual studio e abri novamente



A estrutura do projeto foi baseada no padr�o de projeto PageObject com a seguinte estrutura:

- Data 
Cont�m arquivos .CSV utilizados para parametriza��o dos testes e facilidade da manuten��o dos dados inseridos durante os testes.
ex: dados de inser��o, Urls, Ambiente e etc...

- Domain
Cont�m arquivos para realizar a leitura dos .Csv.

- Features
Cont�m as features com a syntax gherkin dos testes utlizadas no (Cucumber/Specflow) .feature.


- Hook
S�o os ganchos, que s�o blocos de c�digos executados "antes" ou "depois de" cada cen�rio ou steps.
(tamb�m foi criado um "SeleniumContext") - Para realizar a inicializa��o do ambiente e possivel execu��o em outros navegadores.
ex: Google Chrome e FireFox (Atualmente deve funcionar nesses dois).

- Interactions
Cont�m as intera��es (os cliques do usu�rio) do usuario utilizadas nos Steps.
EX: BtnLogin_Click();

- Page Objects
Cont�m o conceito de page objects consigerando por pagina, contem os atributos para o selenium encontar os elementos.
Ex: Name, id, Xpath.

- Steps
Cont�m os passos gerados pelas features do (Cucumber/SpeckFlow);

- Utiliy
Cont�m alguns ultils Criados para auxiliar na espera de um elemnto, verificar se est� visivel, se j� sumiu tela etc...
(Essa classe utils eu mesmo que fiz utilizo em todos projetos com selenium)








