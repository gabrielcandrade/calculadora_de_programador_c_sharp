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
        // Declaracao de Variaveis
        string operador;
        int a = 0;
        bool validar = false;

        // Conversor de Decimal para Binario
        static string DecimalParaBinario(int n)
        {
            int resto;
            string result = string.Empty;
            while (n > 0)
            {
                resto = n % 2;
                n /= 2;
                result = resto.ToString() + result;
            }

            return result.ToString();
        }

        // Conversor de Decimal para Octal
        static string DecimalParaOctal(int n)
        {
            int resto;
            string result = string.Empty;
            while (n > 0)
            {
                resto = n % 8;
                n /= 8;
                result = resto.ToString() + result;
            }

            return result.ToString();
        }

        // Conversor de Decimal para Hexadecimal
        static string DecimalParaHexadecimal(int n)
        {
            int intValue = n;
            string hexValue = intValue.ToString("X");
            return hexValue.ToString();
        }

            public Form1()
        {
            InitializeComponent();
        }

        // Metodo que puxa o Text de cada botao e joga na TextBox
        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
            labelbin.Text = DecimalParaBinario(Convert.ToInt32(txt_valor.Text));
            labeloct.Text = DecimalParaOctal(Convert.ToInt32(txt_valor.Text));
            labelhex.Text = DecimalParaHexadecimal(Convert.ToInt32(txt_valor.Text));
        }
        
        // Metodo para limpar o TextBox
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_valor.Text = "";
            label1.Text = "";
            labelbin.Text = "0";
            labeloct.Text = "0";
            labelhex.Text = "0";
            a = 0;
            validar = false;

        }   

        // Metodo de operacao soma, so pode ser clicado uma vez. Se clicar duas vezes, buga.
        private void btn_adicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txt_valor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_adicao.Text;
                a = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        // Metodo de operacao subtracao, so pode ser clicado uma vez. Se clicar duas vezes, buga.
        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txt_valor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_subtracao.Text;
                a = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        // Metodo de operacao multiplicacao, so pode ser clicado uma vez. Se clicar duas vezes, buga.
        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txt_valor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_multiplicacao.Text;
                a = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        // Metodo de operacao divisao, so pode ser clicado uma vez. Se clicar duas vezes, buga.
        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txt_valor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_divisao.Text;
                a = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        // Metodo para executar a operacao e imprimir o valor no TextBox.
        private void btn_igual_Click(object sender, EventArgs e)
        {
            // Quando faz a soma, ele pega o resultado e converte individualmente e imprime no TextBox
            if (operador == "+")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a + Convert.ToInt32(txt_valor.Text));
                labelbin.Text = DecimalParaBinario(Convert.ToInt32(txt_valor.Text));
                labeloct.Text = DecimalParaOctal(Convert.ToInt32(txt_valor.Text));
                labelhex.Text = DecimalParaHexadecimal(Convert.ToInt32(txt_valor.Text));
            }
            // Quando faz a subtracao, ele pega o resultado e converte individualmente e imprime no TextBox
            else if (operador == "-")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a - Convert.ToInt32(txt_valor.Text));
                labelbin.Text = DecimalParaBinario(Convert.ToInt32(txt_valor.Text));
                labeloct.Text = DecimalParaOctal(Convert.ToInt32(txt_valor.Text));
                labelhex.Text = DecimalParaHexadecimal(Convert.ToInt32(txt_valor.Text));
            }
            // Quando faz a multiplicacao, ele pega o resultado e converte individualmente e imprime no TextBox
            else if (operador == "*")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a * Convert.ToInt32(txt_valor.Text));
                labelbin.Text = DecimalParaBinario(Convert.ToInt32(txt_valor.Text));
                labeloct.Text = DecimalParaOctal(Convert.ToInt32(txt_valor.Text));
                labelhex.Text = DecimalParaHexadecimal(Convert.ToInt32(txt_valor.Text));
            }
            // Quando faz a divisao, ele pega o resultado e converte individualmente e imprime no TextBox
            else if (operador == "/")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a / Convert.ToInt32(txt_valor.Text));
                labelbin.Text = DecimalParaBinario(Convert.ToInt32(txt_valor.Text));
                labeloct.Text = DecimalParaOctal(Convert.ToInt32(txt_valor.Text));
                labelhex.Text = DecimalParaHexadecimal(Convert.ToInt32(txt_valor.Text));
            }
        }
    }
}
