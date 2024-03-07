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

        //retorna a linha e a coluna da peça na hora que imprimimos o tabuleiro na tela
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha,coluna];
        }
    }
}
