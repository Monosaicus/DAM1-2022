using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        private Control _focusedControl;
        private string Operacio;
        public frmCalculadora()
        {
            InitializeComponent();
            
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            // bucles
            // Sequència numèrica

                //i = 0;
                //while (i <= nombre1)
                // {
                //     txtResultat.Text = txtResultat.Text + "," + i.ToString();
                //     i += nombre2;
                // }

                //for (i=0; i<=nombre1; i+=nombre2)
                //{
                //    txtResultat.Text = txtResultat.Text + "," + i.ToString();
                //}

                //i = 0;
                //do
                //{
                //    txtResultat.Text = txtResultat.Text + "," + i.ToString();
                //    i += nombre2;
                //} while (i<=nombre1);
            //}

            //foreach (Control c in this.Controls)
            //{
            //    if (c is TextBox t)
            //    {
            //        t.Text = "";
            //    }
            //}

        }
        private void txtNombre1_GotFocus(object sender, EventArgs e)
        {
            _focusedControl = (Control)sender;
        }
        private void txtNombre2_GotFocus(object sender, EventArgs e)
        {
            _focusedControl = (Control)sender;
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            float nombre1, nombre2;
            Operacio = "+";

            if (!String.IsNullOrEmpty(txtNombre1.Text)
                && 
                !String.IsNullOrEmpty(txtNombre2.Text))
            {   // Sumar 
                nombre1 = float.Parse(txtNombre1.Text);
                nombre2 = float.Parse(txtNombre2.Text);

                txtResultat.Text = (nombre1 + nombre2).ToString();
            }

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            float nombre1, nombre2;
            Operacio = "-";

            if (!String.IsNullOrEmpty(txtNombre1.Text)
                &&
                !String.IsNullOrEmpty(txtNombre2.Text))
            {   // Restar 
                nombre1 = float.Parse(txtNombre1.Text);
                nombre2 = float.Parse(txtNombre2.Text);

                txtResultat.Text = (nombre1 - nombre2).ToString();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            float nombre1, nombre2;
            Operacio = "*";

            if (!String.IsNullOrEmpty(txtNombre1.Text)
                &&
                !String.IsNullOrEmpty(txtNombre2.Text))
            {   // Multiplicar
                nombre1 = float.Parse(txtNombre1.Text);
                nombre2 = float.Parse(txtNombre2.Text);

                txtResultat.Text = (nombre1 * nombre2).ToString();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float nombre1, nombre2;
            Operacio = "/";

            if (!String.IsNullOrEmpty(txtNombre1.Text)
                &&
                !String.IsNullOrEmpty(txtNombre2.Text))
            {   // Dividir
                nombre1 = float.Parse(txtNombre1.Text);
                nombre2 = float.Parse(txtNombre2.Text);
                if (nombre2 != 0 )
                {
                    txtResultat.Text = (nombre1 / nombre2).ToString();
                }
            }

        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            float nombre1, nombre2;
            Operacio = "%";

            if (!String.IsNullOrEmpty(txtNombre1.Text)
                &&
                !String.IsNullOrEmpty(txtNombre2.Text))
            {   // Restar 
                nombre1 = float.Parse(txtNombre1.Text);
                nombre2 = float.Parse(txtNombre2.Text);

                txtResultat.Text = (nombre1 % nombre2).ToString();
            }
        }
        private void btnExp_Click(object sender, EventArgs e)
        {
            float nombre1, nombre2, resultat=1;
            Operacio = "^";

            if (!String.IsNullOrEmpty(txtNombre1.Text)
                &&
                !String.IsNullOrEmpty(txtNombre2.Text))
            {   // Restar 
                nombre1 = float.Parse(txtNombre1.Text);
                nombre2 = float.Parse(txtNombre2.Text);
                for (int i = 1; i <= nombre2; i++)
                    resultat *= nombre1;
                txtResultat.Text = (resultat).ToString();
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            Operacio = "";
        }
            private void btnSequencia_Click(object sender, EventArgs e)
        {
            // sequencia numèrica que començara per 0 fins nombre1 
            // amb increments de nombre2

            int nombre1, nombre2;
            int seq = 0;

            if (!String.IsNullOrEmpty(txtNombre1.Text)
                &&
                !String.IsNullOrEmpty(txtNombre2.Text))
            {   // Multiplicar
                nombre1 = int.Parse(txtNombre1.Text);
                nombre2 = int.Parse(txtNombre2.Text);

                txtResultat.Text = "";

                // sequencia opcio 1
                while (seq <= nombre1)
                {
                    txtResultat.Text = txtResultat.Text + "," + seq.ToString();
                    seq = seq + nombre2;
                }

                // sequencia opcio 2

                //for (seq =0; seq<=nombre1; seq+=nombre2)
                //{
                //    txtResultat.Text = txtResultat.Text + "," + seq.ToString();
                //}

            }
        }
        private void ActualitzaTextBox(int Tecla)
        {
            float TeclaNum;
            if (_focusedControl != null)
            {
                if (!String.IsNullOrEmpty(_focusedControl.Text))
                {
                    TeclaNum = (int.Parse(_focusedControl.Text) * 10) + Tecla;
                    _focusedControl.Text = TeclaNum.ToString();
                }
                else
                {
                    TeclaNum = Tecla;
                    _focusedControl.Text = TeclaNum.ToString();
                }
            }

        }
        private void button0_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ActualitzaTextBox(9);
        }
    }
}

