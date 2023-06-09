using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public class Vertex
    {
        public string name;
        public List<Edge> edges;

        public Vertex(string name)
        {
            this.name = name;
            this.edges = new List<Edge>();
        }

        public void Forward(char symbol)
        {
            bool flag = false;

            foreach(Edge edge in this.edges)
            {
                if (edge.symbols.Contains(symbol))
                {
                    this.name = edge.destination.name;
                    this.edges = edge.destination.edges;
                    flag = true;
                }
            }

            if (!flag)
            {
                this.name = "E";
            }
        }
    }
}
