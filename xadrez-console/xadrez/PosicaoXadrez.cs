﻿using tabuleiro;
namespace xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
        public Posicao toPosicao() //converte a posicao do xadrez para objeto de matriz normal
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
    }
}
