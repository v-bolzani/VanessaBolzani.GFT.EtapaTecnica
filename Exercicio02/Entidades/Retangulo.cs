using Exercicio02.Interfaces;
using System;

namespace Exercicio02.Entidades
{
    class Retangulo : IAreaCalculavel
    {
        public double Lado { get; set; }
        public double Altura { get; set; }

        public Retangulo(double lado, double altura)
        {
            Lado = lado;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Lado * Altura;
        }
    }
}