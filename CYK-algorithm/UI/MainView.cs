using CYK_algorithm.Model;
using System;
using System.Windows.Forms;

namespace CYK_algorithm.UI
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            CYK Cyk = new CYK();
            Cyk.AddProduction("S", "AA");
            Cyk.AddProduction("S", "0");
            Cyk.AddProduction("A", "SS");
            Cyk.AddProduction("A", "1");
            Console.WriteLine(Cyk.CYKAlgorithm("000001"));
        }
    }
}
