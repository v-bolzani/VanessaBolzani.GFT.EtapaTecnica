using System;
using System.Globalization;
using Exercicio03.Entidades;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de x: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor de y: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Soma soma = new Soma();
            Console.WriteLine($"{x} + {y} = {soma.EfetuarOperacao(x, y)}");

            Subtracao substracao = new Subtracao();
            Console.WriteLine($"{x} - {y} = {substracao.EfetuarOperacao(x, y)}");

            Multiplicacao multiplicacao = new Multiplicacao();
            Console.WriteLine($"{x} * {y} = {multiplicacao.EfetuarOperacao(x, y)}");

            Divisao divisao = new Divisao();
            Console.WriteLine($"{x} / {y} = {divisao.EfetuarOperacao(x, y)}");
        }
    }
}
