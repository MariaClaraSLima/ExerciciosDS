algoritmo "Exercicio1"
// Fun��o :
// Autor :Marcos Vinicius e Maria Clara
// Data : 16/03/2023
// Se��o de Declara��es 
var
   litros,result:real
   cod:caracter
inicio
      escreva("Digite a quantidade de litros: ")
      leia(litros)
      escreva("Digite A para alcool ou G para gasolina:")
      leia(cod)
               se(cod="A") entao
                           se (litros<=20) entao
                              result:=litros*(4.30-(4.30*3/100))
                              escreva("O valor a pagar �: r$", result)
                           senao
                                  result:=litros*(4.30-(4.30*5/100))
                                  escreva("O valor a pagar �: R$", result)
                           fimse
               senao
                    se(cod="G") entao
                                se(litros<=20) entao
                                              result:=litros*(5.50-(5.50*4/100))
                                              escreva("O valor a pagar �: R$", result)
                                senao
                                     result:=litros*(5.50-(5.50*6/100))
                                     escreva("O valor a pagar �: R$", result)
                                fimse
                    fimse
               fimse
// Se��o de Comandos 
fimalgoritmo
