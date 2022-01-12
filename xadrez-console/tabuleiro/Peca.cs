using System;
using tabuleiro;
using xadrez;
namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; set; }
        public Tabuleiro Tab { get; protected set; }
        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            QteMovimento = 0;
            Tab = tab;
        }
        public void IncrementarQteMovimentos()
        {
            QteMovimento++;
        }
        public void DecrementoQMovimentos()
        {
            QteMovimento--;
        }
        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j])
                        return true;
                }
            }
            return false;
        }
        public abstract bool[,] MovimentosPossiveis();
        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }
    }
}
