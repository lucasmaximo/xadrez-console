﻿using System;
using tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        //imprime o tabuleiro na tela, mostrando a posição de cada peça ou os espaços vazios
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for(int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if(tabuleiro.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                    Console.Write(tabuleiro.Peca(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
