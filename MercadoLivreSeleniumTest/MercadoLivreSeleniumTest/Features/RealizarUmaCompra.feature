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
	E Selecionar a quantidade de parcelas "1x" e clicar em continuar
	E clicar em confirmar a compra
	Então a compra será finalizada