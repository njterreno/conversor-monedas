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
    public partial class Form1 : Form
    {
        //variables de uso
        double importe1 = 0, cot_dolar = 20, cot_euro = 25;

        public Form1()
        {
            InitializeComponent();
        }

        //validacion de textbox donde se ingresa el importe a convertir
        private void txb_impconvertir_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (txbimpconvertir.Text.Contains(",") || txbimpconvertir.Text == "")
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

        private void rdbpesoconvertir_CheckedChanged(object sender, EventArgs e)
        {
            Convertir();
        }

        private void rdbdolarconvertir_CheckedChanged(object sender, EventArgs e)
        {
            Convertir();
        }

        private void rdbpesoconvertido_CheckedChanged(object sender, EventArgs e)
        {
            Convertir();
        }

        private void rdbdolarconvertido_CheckedChanged(object sender, EventArgs e)
        {
            Convertir();
        }

        private void txbimpconvertir_TextChanged(object sender, EventArgs e)
        {
            Convertir();
        }

        //boton restablecer
        private void btnrestab_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Seguro que desea restablecer los valores?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                txbimpconvertir.Text = cot_dolar.ToString();
                txbimpconvertido.Text = "1";
                rdbpesoconvertir.Checked = true;
                rdbdolarconvertido.Checked = true;
            }  
        } 

        //metodo donde convierte el importe ingresado en el importe seleccionado
        private void Convertir()
        {
            if (txbimpconvertir.Text == "")
            {
                MessageBox.Show("Ingrese un valor", "Alerta");
            }
            else
            {
                if (rdbpesoconvertir.Checked && rdbpesoconvertido.Checked)
                {
                    importe1 = Convert.ToDouble(txbimpconvertir.Text);
                    txbimpconvertido.Text = Convert.ToString(importe1);
                }
                else
                {
                    if (rdbpesoconvertir.Checked && rdbdolarconvertido.Checked)
                    {
                        importe1 = Convert.ToDouble(txbimpconvertir.Text);
                        txbimpconvertido.Text = Convert.ToString(importe1 / cot_dolar);
                    }
                    else
                    {
                        if (rdbpesoconvertir.Checked && rdbeuroconvertido.Checked)
                        {
                            importe1 = Convert.ToDouble(txbimpconvertir.Text);
                            txbimpconvertido.Text = Convert.ToString(importe1 / cot_euro);
                        }
                        else
                        {
                            if (rdbdolarconvertir.Checked && rdbpesoconvertido.Checked)
                            {
                                importe1 = Convert.ToDouble(txbimpconvertir.Text);
                                txbimpconvertido.Text = Convert.ToString(importe1 * cot_dolar);
                            }
                            else
                            {
                                if (rdbdolarconvertir.Checked && rdbeuroconvertido.Checked)
                                {
                                    importe1 = Convert.ToDouble(txbimpconvertir.Text);
                                    txbimpconvertido.Text = Convert.ToString(importe1 * (cot_dolar / cot_euro));
                                }
                                else
                                {
                                    if (rdbdolarconvertir.Checked && rdbdolarconvertido.Checked)
                                    {
                                        importe1 = Convert.ToDouble(txbimpconvertir.Text);
                                        txbimpconvertido.Text = Convert.ToString(importe1);
                                    }
                                    else
                                    {
                                        if (rdbeuroconvertir.Checked && rdbpesoconvertido.Checked)
                                        {
                                            importe1 = Convert.ToDouble(txbimpconvertir.Text);
                                            txbimpconvertido.Text = Convert.ToString(importe1 * cot_euro);
                                        }
                                        else
                                        {
                                            if (rdbeuroconvertir.Checked && rdbdolarconvertido.Checked)
                                            {
                                                importe1 = Convert.ToDouble(txbimpconvertir.Text);
                                                txbimpconvertido.Text = Convert.ToString(importe1 * (cot_euro / cot_dolar));
                                            }
                                            else
                                            {
                                                if (rdbeuroconvertir.Checked && rdbeuroconvertido.Checked)
                                                {
                                                    importe1 = Convert.ToDouble(txbimpconvertir.Text);
                                                    txbimpconvertido.Text = Convert.ToString(importe1);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            txbimpconvertir.Text = cot_dolar.ToString();
            txbimpconvertido.Text = "1";
        }        
    }
}
