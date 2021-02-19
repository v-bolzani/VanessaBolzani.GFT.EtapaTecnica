using System;

namespace Exercicio03.Entidades
{
    public class Soma : Operacao
    {

        public override double EfetuarOperacao(double x, double y)
        {
            return x + y;
        }
    }
}
