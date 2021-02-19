using System;

namespace Exercicio03.Entidades
{
    public class Subtracao : Operacao
    {

        public override double EfetuarOperacao(double x, double y)
        {
            return x - y;
        }
    }
}
