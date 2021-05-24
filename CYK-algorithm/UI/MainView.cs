using CYK_algorithm.Model;
using System;
using System.Windows.Forms;

namespace CYK_algorithm.UI
{
    public partial class MainView : Form
    {
        private readonly CYK CYK;

        public MainView()
        {
            InitializeComponent();
            CYK = new CYK();
            Clear();
        }

        /*
         * Allows to clear the listbox with a single click on the rule.
         */
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
        }


        /*
         * this method is called by listbox click, it allows to put all 
         * the textboxes clean and eliminates the rules.
         */
        private void Clear() {
            listBox1.Items.Clear();
            CYK.ClearProductions();
            simbolo.Text = "";
            regla.Text = "";
            cadena.Text = "";
            fallo.Visible = false;
            siii.Visible = false;
        }

        /*
         * It allows to add a rule, calling the model method and in case 
         * the user does not enter the symbol or the rule it sends an alert.
         */
        private void AddProduction_Click(object sender, EventArgs e)
        {
            if (simbolo.Text != "" && regla.Text != "")
            {
                CYK.AddProduction(simbolo.Text, regla.Text);
                simbolo.Text = "";
                regla.Text = "";
                ShowRules();
            }
            else {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OKCancel);
                simbolo.Text = "";
                regla.Text = "";
            }
        }

        /*
         * Displays the rules created by the user.
         */
        private void ShowRules() {
            listBox1.Items.Clear();
            for (int i = 0; i<CYK.GetProductions().Count; i++)
            {
                listBox1.Items.Add(CYK.GetProductions()[i].Symbol + "  -->  " + CYK.GetProductions()[i].Rule);
            }
        }

        /*
         * cleans the entire interface.
         */
        private void Limp_Click(object sender, EventArgs e)
        {
            Clear();
            CYK.ClearProductions();
            ShowRules();
        }

        /*
         *Allows to verify that the string is allowed by the rules set by the user. 
         */
        private void Check_Click(object sender, EventArgs e)
        {
            if (CYK.GetProductions().Count != 0 && cadena.Text != "") {
                if (CYK.CYKAlgorithm(cadena.Text)) {
                    fallo.Visible = false;
                    siii.Visible = true;
                    MessageBox.Show("LA CADENA SE PUEDE GENERAR!! :3", "RESPUESTA:", MessageBoxButtons.OKCancel);
                }
                else {
                    siii.Visible = false;
                    fallo.Visible = true;
                    MessageBox.Show("RESPUESTA.", "LA CADENA NO SE PUEDE GENERAR :,C", MessageBoxButtons.OKCancel);
                }
            }
        }
    }
}
