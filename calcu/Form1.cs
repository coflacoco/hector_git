using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    public partial class Form1 : Form
    {
        double parte1;
        double parte2;
        double resultado;
        string Operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            parte2 = double.Parse(pantalla.Text);

            switch (operacion) {
                case "+":
                    resultado = parte1 + parte2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = parte1 - parte2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = parte1 / parte2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = parte1 * parte2;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            parte1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            parte1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            Operacion = "*";
            parte1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            parte1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            Operacion = "Raiz";
            parte1 = double.Parse(pantalla.Text);
            resultado = parte1;
            pantalla.Text = Math.Sqrt(parte1).ToString();
        }
    }
}
