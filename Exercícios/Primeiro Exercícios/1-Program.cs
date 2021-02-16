using System;

namespace ExercícioClasses_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa X = new Pessoa();
            Pessoa Y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            X.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            Y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Y.Idade = int.Parse(Console.ReadLine());
            
            if(Y.Idade > X.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + Y.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + X.Nome);
            }

        }
    }
}
