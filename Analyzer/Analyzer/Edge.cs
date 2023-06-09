using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public class Edge
    {
        public char[] symbols;
        public Vertex destination;

        public Edge(char[] symbols, Vertex destination)
        {
            this.symbols = symbols.Clone() as char[];
            this.destination = destination;
        }
    }
}
