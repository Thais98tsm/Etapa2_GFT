using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int[] maior10 = new int[5];
            int[] menor10 = new int[5];
            int maior, menor, soma = 0, igual = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                soma += numeros[i];
            }
            Array.Sort(numeros);
            maior = numeros[4];
            menor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                int k = 0, j = 0;
                igual = numeros[i];
                if (numeros[i] > 10)
                {
                    maior10[j] = numeros[i];
                    j++;
                }
                if (numeros[i] < 10)
                {
                    menor10[k] = numeros[i];
                    i++;
                }
                if(!(igual == numeros[i]))
                {
                    igual = -1;
                }
                  
            }
            Console.WriteLine($"Maior número {maior}");
            Console.WriteLine($"Menor número {menor}");
            foreach (int n in maior10)
            {
                Console.WriteLine($"Maiores que 10 {n}");
            }
            foreach (int n in menor10)
            {
                Console.WriteLine($"Menores que 10 {n}");
            }
            if (igual == -1)
                Console.WriteLine("Todos números são iguais");
        }
    }
}
