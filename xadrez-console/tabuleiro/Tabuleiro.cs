using System;
using tabuleiro;
using xadrez;
namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca Peca(int Linha, int Coluna)
        {
            return pecas[Linha, Coluna];
        }
        public Peca Peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }
        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos); //lança uma exceção caso pos não seja uma posição válida.
            return Peca(pos) != null; //tem peça?
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if(ExistePeca(pos))
            {
                throw new TabuleiroExceptions("Já existe uma peca no local");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Coluna < 0 || pos.Linha >= Linhas || pos.Coluna >= Colunas)
                return false;
            return true;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if(!PosicaoValida(pos))
            {
                throw new TabuleiroExceptions("Posicao Invalida");
            }
        }
    }
}
