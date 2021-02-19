using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número para inicio do intervalo: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número para fim do intervalo: ");
            int num3 = int.Parse(Console.ReadLine());

            for(int i = num2; i <= num3; i++)
            {
                num3 = num1 * num2;
            }
            Console.WriteLine();
            Console.WriteLine($"Multiplicando: {num1}");
            Console.WriteLine($"Inicio do intervalo: {num2}");
            Console.WriteLine($"Fim do intervalo: {num3}");

            for (int i = num2; i <= num3; i++)
            {
                Console.WriteLine($"{num1} X {i} = {num1 * i}");
            }
        }
    }
}
