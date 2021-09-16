using System;

namespace Exercicio2
{
    class Program
    {
        static ICMS valorICMS = new ICMS();
        static IPI valorIPI = new IPI();
        static COFINS valorCOFINS = new COFINS();

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor do ICMS: {valorICMS.CalculaImposto(valor)}");
            Console.WriteLine($"Valor do IPI: {valorIPI.CalculaImposto(valor)}");
            Console.WriteLine($"Valor do COFINS: {valorCOFINS.CalculaImposto(valor)}"); 
            
            valorTotal = valor + valorICMS.CalculaImposto(valor) + valorIPI.CalculaImposto(valor) + valorCOFINS.CalculaImposto(valor);
            Console.WriteLine($"Total a pagar: {valorTotal}}"); 

        }
    }
}
