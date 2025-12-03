using System;
using System.Windows.Forms;

namespace Floresol_ADM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novaPagina = new Form2();
            novaPagina.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 novaPagina = new Form1();
            novaPagina.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 novaPagina = new Form3();
            novaPagina.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 novaPagina = new Form5();
            novaPagina.Show();
            this.Hide();
        }
    }
}
