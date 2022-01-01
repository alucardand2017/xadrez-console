using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.ColocarPeca(new Rei(Cor.Preta, tab) , new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));

            Tela.imprimiTabuleiro(tab);

        }
    }
}
