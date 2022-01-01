using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 2));

                Tela.imprimiTabuleiro(tab);
            }
            catch (TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
