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
    public partial class Form1 : Form
    {
      
        string operador;
        double a = 0;
        bool validar=false;         


        public Form1()
        {
            InitializeComponent();

            MessageBox.Show( " Kaue Oleano 2215109823 \n Mauricio Menezes 2215112944 \n Felipe Gonçalves Santana 2215108868 ");



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;



        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_valor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToDouble(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txt_valor.Text = "";
                operador = "+";



            }
            else
            {

                label1.Text = txt_valor.Text + btn_soma.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "+";
                validar = true;


            }

        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToDouble(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txt_valor.Text = "";
                operador = "-";



            }
            else
            {

                label1.Text = txt_valor.Text + btn_subtracao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "-";
                validar = true;


            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToDouble(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txt_valor.Text = "";
                operador = "*";



            }
            else
            {

                label1.Text = txt_valor.Text + btn_multiplicacao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "*";
                validar = true;


            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToDouble(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txt_valor.Text = "";
                operador = "/";



            }
            else
            {

                label1.Text = txt_valor.Text + btn_divisao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "/";
                validar = true;


            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a + Convert.ToDouble(txt_valor.Text));

            }
            else if (operador == "-")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a - Convert.ToDouble(txt_valor.Text));

            }
            else if (operador == "*")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a * Convert.ToDouble(txt_valor.Text));

            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a / Convert.ToDouble(txt_valor.Text));

            }

        }

    }
}
