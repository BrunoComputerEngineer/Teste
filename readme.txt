****** Foi todo sistema foi desenvolvido em português apenas para facilitar o entendimento de quem vai corrigir, porém costumo fazer me inglês *********
(Como no teste foi pedido que não seria necessario a finalização do pedido os passos param ao adicionar um novo cartao porem no cenario foi escrito que seria finalizado a compra)

Foi criada uma conta no gmail com os seguintes dados:
login: testebrunociet@gmail.com
senha: Mudar@123

foi criada uma conta no mercado livre com os seguintes dados:
login: testebrunociet@gmail.com
senha: Mudar@123

Configuração e Instalação
- Foi criado um projeto do tipo Unit Test Project (.Net Framework 4.7)
- Incluir bibliotecas do selenium
Selenium.WebDriver
Selenium.Support
Selenium.WebDriverBackendSelenium

- Foi instalado no Nuget os seguintes pacotes:
SpecFlow v2.4.1

specrun.Runner
Nunit
- É necessario instalar uma extensão no visual studio do specFlow
SpecFlow for Visual Studio 2017
é necessario fechar o visual studio e abri novamente



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








