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
            Cyk.AddProduction("S", "AB");
            Cyk.AddProduction("A", "CD");
            Cyk.AddProduction("A", "CF");
            Cyk.AddProduction("B", "2");
            Cyk.AddProduction("B", "EB");
            Cyk.AddProduction("C", "0");
            Cyk.AddProduction("D", "1");
            Cyk.AddProduction("E", "2");
            Cyk.AddProduction("F", "AD");
            Console.WriteLine(Cyk.CYKAlgorithm("00011122"));
        }
    }
}
