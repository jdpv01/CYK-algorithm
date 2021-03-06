using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK_algorithm.Model
{
    public class CYK
    {
        private readonly List<Production> CFG;

        public CYK()
        {
            CFG = new List<Production>();
        }

        /*
         * Adds a new production to the list of productions.
         */
        public void AddProduction(string Symbol, string Rule)
        {
            CFG.Add(new Production(Symbol, Rule));
        }

        /*
         * Clear the list.
         */
        public void ClearProductions() {
            CFG.Clear();
        }

        /*
         * Performs the CYK algorithm to test whether
         * a given word w belongs to the language generated 
         * by a context free grammar CFG in Chomsky normal form.
         */
        public bool CYKAlgorithm(string Word)
        {
            bool output = false;
            List<Production>[,] CYKMatrix = new List<Production>[Word.Length, Word.Length];

            for (int i = 0; i < Word.Length; i++)
            {
                for (int j = 0; j < Word.Length; j++)
                {
                    CYKMatrix[i, j] = new List<Production>();
                }
            }
            //filling the diagonal of the matrix with the symbols that generate the character at i
            for (int i = 0; i < Word.Length; i++)
            {
                foreach (Production prod in CFG)
                {
                    if (Word[i].ToString() == prod.Rule)
                    {
                        CYKMatrix[i, i].Add(prod);
                        Console.WriteLine(prod.Symbol);
                    }
                }
            }

            List<string> productions = new List<string>();
            int lastColumn = Word.Length - 1;

            //Iterates over the rows of the matrix to find productions 
            for (int i = 1; i < Word.Length; i++)
            {
                int a = i;
                int b = 0;
                //Iterates over the columns 
                for (int j = 0; j < lastColumn; j++)
                {
                    //Fins k and the symbols in the positions [i, k][k, j]
                    for (int k = b; k < a; k++)
                    {
                        int c = k;
                        int d = k + 1;
                        List<Production> list1 = CYKMatrix[b, c];
                        List<Production> list2 = CYKMatrix[d, a];
                        if (list1.Count == 0 || list2.Count == 0)
                            break;
                        else
                        {
                            foreach (Production p1 in list1)
                            {
                                //Combines the symbols found and adds them to the productions list
                                foreach (Production p2 in list2)
                                    productions.Add(p1.Symbol + p2.Symbol);
                            }
                        }
                    }
                    foreach (string s in productions)
                    {
                        foreach (Production prod in CFG)
                        {
                            //If the productions found are contained in the given CFG, then 
                            //adds them to the matrix
                            if (s == prod.Rule)
                            {
                                CYKMatrix[b, a].Add(prod);
                            }
                        }
                    }
                    b++;
                    a++;
                }
                productions.Clear();
                lastColumn--;
            }

            // Checks if the starting symbol is found in the list of the first row and last column
            // if true, the given word belongs to the language generated by the given CFG
            // if not, returns false.
            foreach (Production production in CFG)
            {
                if (production.Symbol == "S" && CYKMatrix[0, Word.Length - 1].Contains(production))
                    output = true;
            }
            return output;
        }

        public List<Production> GetProductions()
        {
            return CFG;
        }
    }
}
