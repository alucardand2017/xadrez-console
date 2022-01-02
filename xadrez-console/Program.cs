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
                    try
                    {
                        Console.Clear();
                        Tela.imprimiTabuleiro(partida.Tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno " + partida.Turno);
                        Console.WriteLine("Jogador atual: " + partida.JogadorAtual);
                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoOrigem(origem);
                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                        Console.Clear();
                        Tela.imprimiTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.WriteLine("Turno " + partida.Turno);
                        Console.WriteLine("Jogador atual: " + partida.JogadorAtual);
                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDestino(origem, destino);
                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroExceptions e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ResetColor();
                        Console.ReadLine();
                    }
                   
                }



            }
            catch (TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }
}
