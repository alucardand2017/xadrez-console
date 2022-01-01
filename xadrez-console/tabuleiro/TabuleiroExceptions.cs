using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class TabuleiroExceptions : Exception
    {
        public TabuleiroExceptions( string msg) : base(msg)
        {
        }
    }
}
