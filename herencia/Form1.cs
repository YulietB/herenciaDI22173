using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sumar suma = new Sumar(); //instancie o hice un nuevo objeto suma llamar el metodo de clase suma operar

            textBox3.Text = suma.operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restar restar = new Restar(); //instancie o hice un nuevo objeto suma llamar el metodo de clase suma operar

            textBox3.Text = restar.operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiplicar multiplicar = new Multiplicar(); //instancie o hice un nuevo objeto suma llamar el metodo de clase suma operar

            textBox3.Text = multiplicar.operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            Dividir dividir = new Dividir(); //instancie o hice un nuevo objeto suma llamar el metodo de clase suma operar

            textBox3.Text = dividir.operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
