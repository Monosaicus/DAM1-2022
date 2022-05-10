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

        private void btnSumar_Click(object sender, EventArgs e)
        {
            float nombre1, nombre2;


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

<<<<<<< Updated upstream
        private void button1_Click(object sender, EventArgs e)
=======
        private void lblResultat_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {

        }

<<<<<<< Updated upstream
        private void button3_Click(object sender, EventArgs e)
=======
        private void txtResultat_TextChanged(object sender, EventArgs e)
>>>>>>> Stashed changes
        {

        }
    }
}

