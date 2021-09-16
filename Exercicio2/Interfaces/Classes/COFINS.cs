using System;

namespace Exercicio2
{
    public class COFINS : Imposto
    {
        double valorImposto;
        public double CalculaImposto(valor){
            if(valor > 12000){
                valorImposto += valor * 0.04;
            }
            return valorImposto;
        }

    }
}