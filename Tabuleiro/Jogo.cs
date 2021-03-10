using System;
using System.Collections.Generic;
using System.Linq;

namespace Tabuleiro
{
    class Jogo
    {
        private char[,] tabuleiro;
        private List<char> letrasSorteadas, letrasAdicionadas;

        public Jogo()
        {
        }

        public void EmbaralharTabuleiro()
        {
            this.letrasAdicionadas = new List<char>();
            var index = 0;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    index++;
                    if (index <= 8)
                    {
                        var letra = this.SortearLetras();
                        while (this.ValidarLetraJaExistente(letra))
                        {
                            letra = this.SortearLetras();
                        }
                        this.tabuleiro[i, j] = letra;
                        this.letrasAdicionadas.Add(letra);
                    }
                }
            }
        }

        public void ConstruirTabuleiro()
        {
            this.tabuleiro = new char[3, 3];
            this.letrasSorteadas = Letras.PreencherLetras();
            var indice = 0;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (indice <= 7)
                    {
                        this.tabuleiro[i, j] = this.letrasSorteadas[indice];
                        indice++;
                    }
                }
            }
        }

        public bool ValidarLetraJaExistente(char letra)
        {
            if (this.letrasAdicionadas != null)
            {
                return this.letrasAdicionadas.Contains(letra);
            }
            return true;
        }

        public bool MoverPecaTabuleiro(char letra)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (this.tabuleiro[i, j] == letra)
                    {
                        return this.ValidarPosicoesDisponiveisTabuleiro(i, j, letra);
                    }
                }
            }
            return false;
        }

        private bool ValidarPosicoesDisponiveisTabuleiro(int i, int j, char letra)
        {
            // Dada uma coordenada no array, poderá executar as seguintes jogadas nos IFs
            if (i == 0 && j == 0)
            {
                if (this.tabuleiro[i + 1, j] == '\0')
                {
                    this.tabuleiro[i + 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j + 1] == '\0')
                {
                    this.tabuleiro[i, j + 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            if (i == 0 && j == 1)
            {
                if (this.tabuleiro[i + 1, j] == '\0')
                {
                    this.tabuleiro[i + 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j + 1] == '\0')
                {
                    this.tabuleiro[i, j + 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j - 1] == '\0')
                {
                    this.tabuleiro[i, j - 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            if (i == 0 && j == 2)
            {
                if (this.tabuleiro[i + 1, j] == '\0')
                {
                    this.tabuleiro[i + 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j - 1] == '\0')
                {
                    this.tabuleiro[i, j - 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            if (i == 1 && j == 0)
            {
                if (this.tabuleiro[i + 1, j] == '\0')
                {
                    this.tabuleiro[i + 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i - 1, j] == '\0')
                {
                    this.tabuleiro[i - 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j + 1] == '\0')
                {
                    this.tabuleiro[i, j + 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            if (i == 1 && j == 1)
            {
                if (this.tabuleiro[i + 1, j] == '\0')
                {
                    this.tabuleiro[i + 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i - 1, j] == '\0')
                {
                    this.tabuleiro[i - 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j + 1] == '\0')
                {
                    this.tabuleiro[i, j + 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j - 1] == '\0')
                {
                    this.tabuleiro[i, j - 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            if (i == 1 && j == 2)
            {
                if (this.tabuleiro[i + 1, j] == '\0')
                {
                    this.tabuleiro[i + 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i - 1, j] == '\0')
                {
                    this.tabuleiro[i - 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j - 1] == '\0')
                {
                    this.tabuleiro[i, j - 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            if (i == 2 && j == 0)
            {
                if (this.tabuleiro[i - 1, j] == '\0')
                {
                    this.tabuleiro[i - 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j + 1] == '\0')
                {
                    this.tabuleiro[i, j + 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            if (i == 2 && j == 1)
            {
                if (this.tabuleiro[i - 1, j] == '\0')
                {
                    this.tabuleiro[i - 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j + 1] == '\0')
                {
                    this.tabuleiro[i, j + 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j - 1] == '\0')
                {
                    this.tabuleiro[i, j - 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            if (i == 2 && j == 2)
            {
                if (this.tabuleiro[i - 1, j] == '\0')
                {
                    this.tabuleiro[i - 1, j] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
                if (this.tabuleiro[i, j - 1] == '\0')
                {
                    this.tabuleiro[i, j - 1] = letra;
                    this.tabuleiro[i, j] = '\0';
                    return true;
                }
            }
            return false;
        }

        public bool FinalizouJogo()
        {
            var letra = 'A';
            var iteracoes = 0;
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    iteracoes++;
                    if (iteracoes != 9)
                    {
                        if (this.tabuleiro[i, j] == letra)
                        {
                            letra = this.RetornarProximaLetra(letra);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private char RetornarProximaLetra(char letraAtual)
        {
            return (char)(letraAtual + 1);
        }

        private char SortearLetras()
        {
            var random = new Random();
            if (this.letrasSorteadas == null)
                this.letrasSorteadas = Letras.PreencherLetras();
            return this.letrasSorteadas[random.Next(this.letrasSorteadas.Count())];
        }

        public char[,] RetornarTabuleiro()
        {
            return this.tabuleiro;
        }
    }
}