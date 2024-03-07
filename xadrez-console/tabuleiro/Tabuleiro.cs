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

        public Tabuleiro(int linhas, int colunas) { 
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas,colunas];
        }

        //retorna a peça ou o espaço vazio dentro da matriz de peças quando imprimimos o tabuleiro na tela
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha,coluna];
        }

        //coloca uma peça dentro da matriz de peças do tabuleiro e atribui a posição àquela peça
        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }
    }
}
