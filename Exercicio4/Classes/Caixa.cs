using System;

namespace Exercicio4
{
    public class Caixa : Produto
    {
        //Métodos
        static double CalculaValorFinal(Produto prod, int quantidade){
            double valorFinal = prod.Valor * quantidade;
            if(prod.Tipo == 1){
                valorFinal -= valorFinal * 0.05; 
            }
            else if(prod.Tipo == 2){
                valorFinal -= valorFinal * 0.12;
            }
            else if(quantidade > 5){
                valorFinal -= valorFinal * 0.07;
            }
        }  
    }
}