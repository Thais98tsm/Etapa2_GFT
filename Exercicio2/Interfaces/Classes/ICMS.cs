using System;

namespace Exercicio2
{
    public class ICMS : Imposto
    {
        double valorImposto;
        public double CalculaImposto(double valor){
           valorImposto = valor * 0.24;
           return valorImposto;
        }

    }
}