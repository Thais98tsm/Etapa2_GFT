using System;

namespace Exercicio2
{
    public class IPI : Imposto
    {
        double valorImposto;
        public double CalculaImposto(valor){
            if(valor < 20000){
                valorImposto = valor * 0.05;
            }
            else if(valor > 20000){
                valorImposto = valor * 0.11;
            }
            return valorImposto;
        }

    }
}