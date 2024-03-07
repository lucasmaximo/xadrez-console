using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando um tabuleiro de tamanho 8x8
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            //coloca as peças no tabuleiro, apontando sua cor e sua posição
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 1));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

            //imprimindo o tabuleiro na tela
            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadLine();
        }
    }
}
