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
    public partial class Dias : Form
    {
        public Dias()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String valor = "Domingo";

            label2.Text = valor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String valor = "Lunes";

            label2.Text = valor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String valor = "Martes";

            label2.Text = valor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String valor = "Miercoles";

            label2.Text = valor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String valor = "Jueves";

            label2.Text = valor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String valor = "Viernes";

            label2.Text = valor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String valor = "Sabado";

            label2.Text = valor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dias_Load(object sender, EventArgs e)
        {
            // Calcular la posición para centrar el formulario
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int x = (screenWidth - formWidth) / 2;
            int y = (screenHeight - formHeight) / 2;

            // Establecer la ubicación del formulario
            this.Location = new Point(x, y);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
