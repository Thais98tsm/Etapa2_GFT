using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int caloria, totalCaloria = 0; 
            Console.WriteLine("Digite a quantidade de calorias: ");
            int quantCalorias = int.Parse(Console.ReadLine());
            Console.WriteLine("----- Alimetos consumidos ----- ");
            do{
                Console.WriteLine("Nome do alimento: ");
                string alimento = Console.ReadLine();
                Console.WriteLine("Quantidade: ");
                caloria = Console.ReadLine();
                totalCaloria += caloria;
            }while(!String.Equals(alimento, "sair"));
            if(totalCaloria < quantCalorias)
                Console.WriteLine("Você consumiu {0} calorias e ficou abaixo da meta");
            else if(totalCaloria > quantCalorias)
                Console.WriteLine("Você consumiu {0} calorias e ficou acima da meta");
            else
                Console.WriteLine("Você consumiu {0} calorias e atingiu a meta");


        }
    }
}
