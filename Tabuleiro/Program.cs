using System;

namespace Tabuleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo();
            var quantidadeJogadas = 0;
            Console.WriteLine();
            Console.WriteLine("Tabuleiro construído!");
            jogo.ConstruirTabuleiro();
            jogo.EmbaralharTabuleiro();
            MostrarTabuleiro(jogo);
            Console.WriteLine();

            while (!jogo.FinalizouJogo())
            {
                Console.WriteLine();
                Console.WriteLine("Selecione a letra que deseja mover:");
                Console.Write("Letra: ");
                var letraSelecionada = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                quantidadeJogadas++;
                
                while (!jogo.ValidarLetraJaExistente(letraSelecionada))
                {
                    Console.WriteLine();
                    Console.WriteLine("A letra informada não existe no jogo. Informe uma letra presente no quadro.");
                    MostrarTabuleiro(jogo);
                    Console.WriteLine();
                    Console.Write("Letra: ");
                    letraSelecionada = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                }

                while (!jogo.MoverPecaTabuleiro(letraSelecionada))
                {
                    Console.WriteLine();
                    Console.WriteLine("Esta letra não pode ser movida! Tente outra.");
                    MostrarTabuleiro(jogo);
                    Console.WriteLine();
                    Console.Write("Letra: ");
                    
                    letraSelecionada = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                }
                Console.WriteLine();
                Console.Clear();
                MostrarTabuleiro(jogo);
                Console.WriteLine();
                Console.WriteLine("Jogadas executadas: {0}", quantidadeJogadas);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Parabéns, você ordenou o tabuleiro.");
            Console.ReadKey();
        }

        private static void MostrarTabuleiro(Jogo jogo)
        {
            char[,] tabuleiro = jogo.RetornarTabuleiro();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabuleiro[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}