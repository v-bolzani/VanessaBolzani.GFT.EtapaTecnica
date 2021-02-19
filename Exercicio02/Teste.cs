using Exercicio02.Entidades;
using System;
using System.Globalization;

namespace Exercicio02
{
    class Teste
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite o valor do lado do quadrado: ");
            double ladoQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Quadrado quadrado = new Quadrado(ladoQuadrado);
            Console.WriteLine(quadrado.CalcularArea());

            
            Console.WriteLine("Digite o valor do lado do retangulo: ");
            double ladoRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor da altura do retangulo: ");
            double alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Retangulo retangulo = new Retangulo(ladoRetangulo, alturaRetangulo);
            Console.WriteLine(retangulo.CalcularArea().ToString("F2", CultureInfo.InvariantCulture));

            
            Console.WriteLine("Digite o valor do raio do circulo: ");
            double raioCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Circulo circulo = new Circulo(raioCirculo);
            Console.WriteLine(circulo.CalcularArea().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
