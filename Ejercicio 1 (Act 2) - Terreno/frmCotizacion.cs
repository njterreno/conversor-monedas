using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1__Act_2____Terreno
{
    public partial class frmCotizacion : Form
    {
        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            frmConvertir frm = new frmConvertir();
            if (!string.IsNullOrEmpty(txtDolar.Text) && !string.IsNullOrEmpty(txtEuro.Text))
            {
                frm.cot_dolar = Convert.ToDouble(txtDolar.Text);
                frm.cot_euro = Convert.ToDouble(txtEuro.Text);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Debe ingresar cotización de Dolar y Euro antes de continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar == ',')
                    {
                        if (txtDolar.Text.Contains(",") || txtDolar.Text == "")
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
