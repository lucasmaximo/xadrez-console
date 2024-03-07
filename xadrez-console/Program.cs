using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //instanciando um tabuleiro de tamanho 8x8
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                //coloca as peças no tabuleiro, apontando sua cor e sua posição
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 5));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(0, 3));

                //imprimindo o tabuleiro na tela
                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
