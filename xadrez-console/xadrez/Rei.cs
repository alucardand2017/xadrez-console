using System;
using tabuleiro;
using xadrez;
namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "R";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao();
            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if(Tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna +1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //direita
            pos.DefinirValores(Posicao.Linha , Posicao.Coluna +1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna +1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna -1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //esquerda
            pos.DefinirValores(Posicao.Linha , Posicao.Coluna -1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            //acima
            pos.DefinirValores(Posicao.Linha -1, Posicao.Coluna -1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;
            return mat;
        }
       
    }
}
