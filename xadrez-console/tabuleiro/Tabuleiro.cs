using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        //retorna a peça ou o espaço vazio dentro da matriz de peças quando imprimimos o tabuleiro na tela
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        //sobrecarga do método Peca, mas recetornando uma posição dentro da matriz de Pecas
        public Peca Peca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        //verifica se existe uma peça em uma determinada posição
        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return Peca(posicao) != null;
        }


        //coloca uma peça dentro da matriz de peças do tabuleiro e atribui a posição àquela peça
        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        //testa se uma posição é válida
        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha > Linhas || posicao.Coluna < 0 || posicao.Coluna > Colunas)
            {
                return false;
            }
            return true;
        }

        //trata erros de posições das peças de maneira personalizada
        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
