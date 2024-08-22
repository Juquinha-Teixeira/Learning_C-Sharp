using System;

namespace MyLearning
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*string firstName = "João";
            string lastName = "Pedro";

            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            Console.WriteLine(10+15);*/

            /*Console.Write("Insira um numero: ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Insira outro numero: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int adiction = numberOne + numberTwo;

            Console.WriteLine($"A soma de {numberOne} e {numberTwo} é {adiction}");*/

            /*string[] names = {"João", "Pedro"};

            for(int i = 0; i < names.Length; i++)
                Console.Write(names[i] + " ");*/

            int nota1 = 10;
            int nota2 = 2;
            int nota3 = 5;

            float soma = nota1 + nota2 + nota3;

            float media = soma/3;

            if(media >= 6)
                Console.WriteLine("O aluno foi aprovado");
            else
                Console.WriteLine("O aluno não foi aprovado");

        }
    }
}


