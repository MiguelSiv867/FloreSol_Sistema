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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 novaPagina = new Form4();
            novaPagina.Show();
            this.Hide();
        }

        private void estoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            estoque.DataSource = DaO.DaO. CarregarDados1();
            delivery.DataSource = DaO.DaO.Delivery();
        }
        private void delivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (!int.TryParse(IDP.Text, out int idPedido))
            {
                MessageBox.Show("ID do pedido inválido.");
                return;
            }

            string codigo = CR.Text.Trim();
            if (codigo == "")
            {
                MessageBox.Show("Digite o código de rastreio.");
                return;
            }

            int linhas = DaO.DaO.AtuCodRastreio(idPedido, codigo);

            if (linhas > 0)
                MessageBox.Show("Código de rastreio atualizado!");
            else
                MessageBox.Show("Nenhum registro foi atualizado.\nVerifique o ID do pedido.");


        }

        private void CR_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            estoque.DataSource = DaO.DaO.CarregarDados1();
            delivery.DataSource = DaO.DaO.Delivery();
        }
    }
}
