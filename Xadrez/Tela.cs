using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.tabuleiro;

namespace Xadrez
{
    class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
           
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Pecas[i, j] == null)
                    {
                        Console.Write("-  ");
                    }
                    else
                    {
                        ImprimirPeca(tabuleiro.Pecas[i, j]);
                        Console.Write(" ");

                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("  A  B  C  D  E  F  G  H");
            
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(peca);
                Console.ForegroundColor = aux;

            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
