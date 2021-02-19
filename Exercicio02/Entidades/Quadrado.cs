using Exercicio02.Interfaces;
using System;

namespace Exercicio02.Entidades
{
    class Quadrado : IAreaCalculavel
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
