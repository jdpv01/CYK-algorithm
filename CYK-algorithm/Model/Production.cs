using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_algorithm.Model
{
    public class Production
    {
        public string Symbol { get; }

        public string Rule { get; }

        public Production(string Symbol, string Rule)
        {
            this.Symbol = Symbol;
            this.Rule = Rule;
        }
    }
}
