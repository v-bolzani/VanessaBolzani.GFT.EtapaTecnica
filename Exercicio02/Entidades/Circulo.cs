using Exercicio02.Interfaces;
using System;

namespace Exercicio02.Entidades
{
    class Circulo : IAreaCalculavel
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
