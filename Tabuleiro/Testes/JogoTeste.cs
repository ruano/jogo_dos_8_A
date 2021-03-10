using NUnit.Framework;

namespace Tabuleiro.Testes
{
    public class JogoTeste
    {
        [Test]
        public void ObtemEstadoAtualDoTabuleiro()
        {
            var jogo = DadoUmJogo();

            var tabuleiro = jogo.RetornarTabuleiro();
            //tabuleiro.GetLength(0).Should().Be(dificuldade);
            //tabuleiro.GetLength(1).Should().Be(dificuldade);
        }

        private static Jogo DadoUmJogo()
        {
            var jogo = new Jogo();
            jogo.ConstruirTabuleiro();
            jogo.EmbaralharTabuleiro();
            return jogo;
        }

        [Test]
        public void ValidarTesteEmbaralharTabuleiro()
        {
            var jogo = DadoUmJogo();
        }

        [Test]
        public void VerificarSeOJogoFoiEncerrado()
        {
            var jogo = DadoUmJogo();
            Assert.IsFalse(jogo.FinalizouJogo());
        }

        [Test]
        public void VerificarSeLetraJaFoiInformada()
        {
            var jogo = DadoUmJogo();
            Assert.IsTrue(jogo.ValidarLetraJaExistente('X'));
        }

        [TestCase('A')]
        [TestCase('B')]
        [TestCase('C')]
        [TestCase('D')]
        [TestCase('E')]
        [TestCase('F')]
        [TestCase('G')]
        [TestCase('H')]
        public void ValidarMudancaPosicaoTabuleiro(char letra)
        {
            var jogo = DadoUmJogo();
            Assert.IsFalse(jogo.MoverPecaTabuleiro(letra));
        }
    }
}