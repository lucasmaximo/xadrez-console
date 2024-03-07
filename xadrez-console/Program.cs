using tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando um tabuleiro de tamanho 8x8
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            //imprimindo o tabuleiro na tela
            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadLine();
        }
    }
}
