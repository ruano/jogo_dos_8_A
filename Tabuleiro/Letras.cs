using System.Collections.Generic;

namespace Tabuleiro
{
    public class Letras
    {
        internal static List<char> PreencherLetras()
        {
            var lista = new List<char>();
            char letra = 'A';
            for (int i = 0; i < 8; i++)
            {
                lista.Add(letra);
                letra = (char)(letra + 1);
            }
            return lista;
        }
    }
}