using System;

namespace Exercicio03.Entidades
{
    public class Divisao : Operacao
    {
        public override double EfetuarOperacao(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Divisao por zero não permitida!");
                return 0;
            }
            else
            {
                return x / y;
            }
        }
    }
}
