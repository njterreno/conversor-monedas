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
    public partial class frmConvertir : Form
    {
        public double importe1, cot_dolar, cot_euro;
        public frmConvertir()
        {
            InitializeComponent();            
        }

        //validacion de textbox donde se ingresa el importe a convertir
        private void txtImporteConvertir_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (txtImporteConvertir.Text.Contains(",") || txtImporteConvertir.Text == "")
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

        private void rdbDolarConvertido_CheckedChanged(object sender, EventArgs e)
        {
            Convertir();
        }

        private void txtImporteConvertir_TextChanged(object sender, EventArgs e)
        {
            Convertir();
        }

        //boton restablecer
        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Seguro que desea restablecer los valores?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                txtImporteConvertir.Text = cot_dolar.ToString();
                txtImporteConvertido.Text = "1";
                rdbPesoConvertir.Checked = true;
                rdbDolarConvertido.Checked = true;
            }
        }

        private void btnEditarCotizacion_Click(object sender, EventArgs e)
        {
            frmCotizacion frmCotizacion = new frmCotizacion();
            frmCotizacion.Show();
        }

        private void frmConvertir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //metodo donde convierte el importe ingresado en el importe seleccionado
        private void Convertir()
        {
            try
            {
                if (txtImporteConvertir.Text == "")
                {
                    MessageBox.Show("Ingrese un valor", "Alerta");
                }
                else
                {
                    if (rdbPesoConvertir.Checked && rdbPesoConvertido.Checked)
                    {
                        importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                        txtImporteConvertido.Text = Convert.ToString(importe1);
                    }
                    else
                    {
                        if (rdbPesoConvertir.Checked && rdbDolarConvertido.Checked)
                        {
                            importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                            txtImporteConvertido.Text = Convert.ToString(importe1 / cot_dolar);
                        }
                        else
                        {
                            if (rdbPesoConvertir.Checked && rdbEuroConvertido.Checked)
                            {
                                importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                                txtImporteConvertido.Text = Convert.ToString(importe1 / cot_euro);
                            }
                            else
                            {
                                if (rdbDolarConvertir.Checked && rdbPesoConvertido.Checked)
                                {
                                    importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                                    txtImporteConvertido.Text = Convert.ToString(importe1 * cot_dolar);
                                }
                                else
                                {
                                    if (rdbDolarConvertir.Checked && rdbEuroConvertido.Checked)
                                    {
                                        importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                                        txtImporteConvertido.Text = Convert.ToString(importe1 * (cot_dolar / cot_euro));
                                    }
                                    else
                                    {
                                        if (rdbDolarConvertir.Checked && rdbDolarConvertido.Checked)
                                        {
                                            importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                                            txtImporteConvertido.Text = Convert.ToString(importe1);
                                        }
                                        else
                                        {
                                            if (rdbEuroConvertir.Checked && rdbPesoConvertido.Checked)
                                            {
                                                importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                                                txtImporteConvertido.Text = Convert.ToString(importe1 * cot_euro);
                                            }
                                            else
                                            {
                                                if (rdbEuroConvertir.Checked && rdbDolarConvertido.Checked)
                                                {
                                                    importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                                                    txtImporteConvertido.Text = Convert.ToString(importe1 * (cot_euro / cot_dolar));
                                                }
                                                else
                                                {
                                                    if (rdbEuroConvertir.Checked && rdbEuroConvertido.Checked)
                                                    {
                                                        importe1 = Convert.ToDouble(txtImporteConvertir.Text);
                                                        txtImporteConvertido.Text = Convert.ToString(importe1);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al convertir los montos de las monedas indicadas. Intente nuevamente y asegúrese de poner las " +
                    "cotizaciones, luego de poner la cantidad a convertir y por último seleccionar la de qué moneda a qué moneda desea " +
                    "convertir el monto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConvertir_Load(object sender, EventArgs e)
        {
            
            //txtImporteConvertir.Text = cot_dolar.ToString();
            //txtImporteConvertido.Text = "1";
        }
    }
}
