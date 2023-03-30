algoritmo "Exercicio2-b"
// Função :
// Autor :Marcos Vinicius e Maria Clara
// Data : 16/03/2023
// Seção de Declarações 
var
     num,result,i:real
inicio
      escreva("Digite um número: ")
      leia(num)
      i:=0
      repita
            result:=num*i
            escreval(num," X", i," =",result)
            i:=i+1
      ate(i>=10)

fimalgoritmo
