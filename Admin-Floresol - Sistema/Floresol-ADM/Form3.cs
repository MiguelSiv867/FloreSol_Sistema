using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaO;

namespace Floresol_ADM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CarregarDados2()
        {
            vendas.DataSource = DaO.DaO.CarregarDados2();
        }

        //querry
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 novaPagina = new Form4();
            novaPagina.Show();
            this.Hide();
        }

        private void Diario_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //querry
        public void DiarioLucro()
        {
            decimal lucro = DaO.DaO.ObterLucroDiario();
            label7.Text = lucro.ToString("0.00");
        }

        //querry
        public void SemanalLucro()
        {
            decimal lucro = DaO.DaO.ObterLucroSemanal();
            label12.Text = lucro.ToString("0.00");
        }


        public void MensalLucro()
        {
            decimal lucro = DaO.DaO.ObterLucroMensal();
            label14.Text = lucro.ToString("0.00");
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private readonly DaO.DaO dao = new DaO.DaO();


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DiarioLucro();
            SemanalLucro();
            MensalLucro();

            label9.Text = dao.VendasDiarias().ToString();
            label13.Text = dao.VendasSemana().ToString();
            label15.Text = dao.VendasMes().ToString();

            CarregarDados2();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DiarioLucro();
            SemanalLucro();
            MensalLucro();

            label9.Text = dao.VendasDiarias().ToString();
            label13.Text = dao.VendasSemana().ToString();
            label15.Text = dao.VendasMes().ToString();

            CarregarDados2();
        }
    }
}
