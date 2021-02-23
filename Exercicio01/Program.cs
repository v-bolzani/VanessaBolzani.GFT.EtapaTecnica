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

            if (num1 < 0 || num1 > 3000 || num2 < 0 || num2 > 3000 || num3 < 0 || num3 > 3000)
            {
                Console.WriteLine("Por favor, informe números válidos");
            }
            else
            {
                if (num3 > num2 && num3 - num2 < 10)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Multiplicando: {num1}");
                    Console.WriteLine($"Inicio do intervalo: {num2}");
                    Console.WriteLine($"Fim do intervalo: {num3}");

                    for (int i = num2; i <= num3; i++)
                    {
                        Console.WriteLine($"{num1} X {i} = {num1 * i}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, informe um intervalo válido");
                }
            }
        }
    }
}
