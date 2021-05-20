using CYK_algorithm.Model;
using System;
using System.Windows.Forms;

namespace CYK_algorithm.UI
{
    public partial class MainView : Form
    {
        CYK Cyk;
        public MainView()
        {
            
            InitializeComponent();
            Cyk = new CYK();
            clear();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void clear() {
            if (listBox1 != null)
            {
                listBox1.Items.Clear();
                
            }
            Cyk.clearProduction();
            simbolo.Text = "";
            regla.Text = "";
            cadena.Text = "";
            fallo.Visible = false;
            siii.Visible = false;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (simbolo.Text != "" && regla.Text != "")
            {
                Cyk.AddProduction(simbolo.Text, regla.Text);
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
            if (listBox1 != null)
            {
                listBox1.Items.Clear();

            }
            for (int i = 0; i<Cyk.GetProductions().Count; i++)
            {
                listBox1.Items.Add(Cyk.GetProductions()[i].Symbol + "  -->  " + Cyk.GetProductions()[i].Rule);
            }
        }

        private void Limp_Click(object sender, EventArgs e)
        {
            clear();
            Cyk.clearProduction();
            ShowRules();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            if (Cyk.GetProductions().Count != 0 && cadena.Text != "") {
                if (Cyk.CYKAlgorithm(cadena.Text)) {
                    siii.Visible = true;
                    MessageBox.Show("RESPUESTA.", "LA CADENA SE PUDO GENERAR!! :3", MessageBoxButtons.OKCancel);
                }
                else {
                    fallo.Visible = true;
                    MessageBox.Show("RESPUESTA.", "LA CADENA NO SE PUDO GENERAR :,C", MessageBoxButtons.OKCancel);
                    
                }
            }
        }
    }
}
