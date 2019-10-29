#language: pt-br
Funcionalidade: RealizarUmaCompra
	Como usuario desejo realizar uma compra no mercado livre

@mytag
Cenario: Realizar uma compra
	Dado que eu estou logado no site com um usuario e senha valida
	Quando digitar "ps4" no campo de pesquisa de produtos
	E selecionar o produto que contenha "ps4"
	E selecionar a quantidade de itens "1" 
	E clicar em Adicionar ao carrinho
	E clicar em Comprar do carrinho
	E clicar em continuar
	E selecionar a opção novo cartão de credito e clicar em continuar
	E Preencher todas as informações do formulario e clicar em continuar
	E Selecionar a quantidade de parcelas "1" e clicar em continuar
	E clicar em confirmar a compra
	Então a compra será finalizada

	@mytag
Cenario: Realizar uma Nova compra e adcionar mais de um item
	Dado que eu estou logado no site com um usuario e senha valida
	Quando digitar "ps4" no campo de pesquisa de produtos
	E selecionar o produto que contenha "ps4 2"
	E selecionar a quantidade de itens "2" 
	E clicar em Adicionar ao carrinho
	E clicar em Comprar do carrinho
	E clicar em continuar
	E selecionar a opção novo cartão de credito e clicar em continuar
	E Preencher todas as informações do formulario e clicar em continuar
	E Selecionar a quantidade de parcelas "1" e clicar em continuar
	E clicar em confirmar a compra
	Então a compra será finalizada

	@mytag
Cenario: Excluir um item do carrinho de compras
	Dado que eu estou logado no site com um usuario e senha valida
	Quando Clicar na opção carrinho de compras
	E Clicar para excluir um item
	Então ficará apenas um item no carrinho

