using System;
using tabuleiro;
using xadrez;


namespace xadrez
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "B";
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
            //cima-direita
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    break;
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //cima-esquerda
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna-1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    break;
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            //baixo-esquerda
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    break;
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }
            //baixo-direita
            pos.DefinirValores(Posicao.Linha -1 , Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    break;
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }
            return mat;
        }
    }
}    

