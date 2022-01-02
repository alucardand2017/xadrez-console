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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while(!partida.Terminada)
                {
                    Console.Clear();
                    Tela.imprimiTabuleiro(partida.Tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.imprimiTabuleiro(partida.Tab, posicoesPossiveis);



                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                    partida.ExecutaMovimento(origem, destino);
                }



            }
            catch (TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
