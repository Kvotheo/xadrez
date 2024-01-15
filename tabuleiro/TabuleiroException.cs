using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    public class TabuleiroException : Exception
    {
        // Constructor
        public TabuleiroException(string msg) : base(msg)
        {

        }
    }
}
