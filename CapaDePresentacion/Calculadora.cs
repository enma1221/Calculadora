using CapaDePresentacion.Operadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class Calculadora : Form
    {
        double primer_numero;
        double segundo_numero;
        String operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Operadores.CLaseSuma Sumar1 = new Operadores.CLaseSuma();
        Operadores.ClaseResta resta1 = new Operadores.ClaseResta();
        Operadores.clasemulti multi1 = new Operadores.clasemulti();
        Operadores.Clasediv dividir1 = new Operadores.Clasediv();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Size = new Size(150,40);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operador = "+";
            primer_numero = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
             segundo_numero = double.Parse(textBox1.Text);

            double sum;
            double res;
            double multis;
            double divi;

            if (operador ==  "+")
            {
                sum = Sumar1.Sumar((primer_numero), (segundo_numero));
                textBox1.Text = sum.ToString();
            }
            else if(operador == "-")
            {
                
                res = resta1.resta((primer_numero), (segundo_numero));
                textBox1.Text = res.ToString();
            } else if(operador == "*")
            {
                multis = multi1.multi((primer_numero), (segundo_numero));
                textBox1.Text = multis.ToString();
            }else if(operador == "/"){
                divi = dividir1.div((primer_numero), (segundo_numero));
                textBox1.Text = divi.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            operador = "-";


            primer_numero = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "*";
            
            primer_numero = double.Parse(textBox1.Text);
            textBox1.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "/";
            primer_numero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
    }
}
