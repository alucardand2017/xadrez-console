using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao posicao = new Posicao(5,5);
            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.imprimiTabuleiro(tab);
        }
    }
}
