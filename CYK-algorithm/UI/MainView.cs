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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear() {
            listBox1.Items.Clear();
            CYK.ClearProductions();
            simbolo.Text = "";
            regla.Text = "";
            cadena.Text = "";
            fallo.Visible = false;
            siii.Visible = false;
        }

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

        private void ShowRules() {
            listBox1.Items.Clear();
            for (int i = 0; i<CYK.GetProductions().Count; i++)
            {
                listBox1.Items.Add(CYK.GetProductions()[i].Symbol + "  -->  " + CYK.GetProductions()[i].Rule);
            }
        }

        private void Limp_Click(object sender, EventArgs e)
        {
            Clear();
            CYK.ClearProductions();
            ShowRules();
        }

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
