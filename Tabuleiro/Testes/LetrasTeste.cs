using System;
using FluentAssertions;
using NUnit.Framework;

namespace Tabuleiro.Testes
{
    internal class LetrasTeste
    {
        [TestCase("A,B,C,D,E,F,G,H")]
        public void RetornaListaComAsPrimeirasNoveLetras(string resultado)
        {
            var letras = resultado.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            var lst = Letras.PreencherLetras();

            foreach (var letra in letras)
            {
                lst.Should().Contain(letra);
            }
        }
    }
}