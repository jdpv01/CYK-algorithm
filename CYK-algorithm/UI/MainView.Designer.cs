
namespace CYK_algorithm.UI
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fallo = new System.Windows.Forms.PictureBox();
            this.siii = new System.Windows.Forms.PictureBox();
            this.agregar = new System.Windows.Forms.Button();
            this.simbolo = new System.Windows.Forms.TextBox();
            this.cadena = new System.Windows.Forms.TextBox();
            this.Limp = new System.Windows.Forms.Button();
            this.generar = new System.Windows.Forms.Button();
            this.regla = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fallo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siii)).BeginInit();
            this.SuspendLayout();
            // 
            // fallo
            // 
            this.fallo.Image = global::CYK_algorithm.Properties.Resources.images__1_;
            this.fallo.Location = new System.Drawing.Point(879, 262);
            this.fallo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fallo.Name = "fallo";
            this.fallo.Size = new System.Drawing.Size(225, 192);
            this.fallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fallo.TabIndex = 1;
            this.fallo.TabStop = false;
            // 
            // siii
            // 
            this.siii.Image = global::CYK_algorithm.Properties.Resources.images;
            this.siii.Location = new System.Drawing.Point(879, 262);
            this.siii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siii.Name = "siii";
            this.siii.Size = new System.Drawing.Size(225, 192);
            this.siii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siii.TabIndex = 0;
            this.siii.TabStop = false;
            // 
            // agregar
            // 
            this.agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregar.Location = new System.Drawing.Point(477, 90);
            this.agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(160, 35);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar Regla";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.AddProduction_Click);
            // 
            // simbolo
            // 
            this.simbolo.Location = new System.Drawing.Point(70, 94);
            this.simbolo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.simbolo.Name = "simbolo";
            this.simbolo.Size = new System.Drawing.Size(90, 26);
            this.simbolo.TabIndex = 3;
            // 
            // cadena
            // 
            this.cadena.Location = new System.Drawing.Point(70, 157);
            this.cadena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cadena.Name = "cadena";
            this.cadena.Size = new System.Drawing.Size(350, 26);
            this.cadena.TabIndex = 4;
            // 
            // Limp
            // 
            this.Limp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Limp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limp.Location = new System.Drawing.Point(477, 248);
            this.Limp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Limp.Name = "Limp";
            this.Limp.Size = new System.Drawing.Size(160, 35);
            this.Limp.TabIndex = 5;
            this.Limp.Text = "Limpiar Reglas";
            this.Limp.UseVisualStyleBackColor = false;
            this.Limp.Click += new System.EventHandler(this.Limp_Click);
            // 
            // generar
            // 
            this.generar.BackColor = System.Drawing.SystemColors.Highlight;
            this.generar.Location = new System.Drawing.Point(477, 153);
            this.generar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(160, 35);
            this.generar.TabIndex = 6;
            this.generar.Text = "Verificar";
            this.generar.UseVisualStyleBackColor = false;
            this.generar.Click += new System.EventHandler(this.Check_Click);
            // 
            // regla
            // 
            this.regla.Location = new System.Drawing.Point(168, 94);
            this.regla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regla.Name = "regla";
            this.regla.Size = new System.Drawing.Size(253, 26);
            this.regla.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(70, 248);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 204);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "SÍMBOLO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(164, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "REGLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(66, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "CADENA";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.regla);
            this.Controls.Add(this.generar);
            this.Controls.Add(this.Limp);
            this.Controls.Add(this.cadena);
            this.Controls.Add(this.simbolo);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.fallo);
            this.Controls.Add(this.siii);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainView";
            this.Text = "CYK algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.fallo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox siii;
        private System.Windows.Forms.PictureBox fallo;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox simbolo;
        private System.Windows.Forms.TextBox cadena;
        private System.Windows.Forms.Button Limp;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.TextBox regla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

