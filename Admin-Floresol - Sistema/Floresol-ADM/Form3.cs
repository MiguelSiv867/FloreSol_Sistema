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

        //querry
        public void CarregarDados()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT p.id_pedido, " +
                    "c.nome_cliente, " +
                    "pr.nome_produto," +
                    "php.quantidade, " +
                    "pr.preco_produto, " +
                    "(php.quantidade * pr.preco_produto) AS total_item, " +
                    "p.valor AS total_pedido," +
                    " p.data_transacao " +
                    "FROM Pedido p " +
                    "JOIN Cliente c ON p.id_cliente = c.id_cliente " +
                    "JOIN Pedido_has_Produto php ON p.id_pedido = php.id_pedido " +
                    "JOIN Produto pr ON php.id_produto = pr.id_produto " +
                    "ORDER BY p.id_pedido; ";


                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                vendas.DataSource = dt;
            }
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
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT SUM(valor) FROM Pedido  WHERE DATE(data_transacao) = CURDATE(); ";
                   

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    label7.Text = dt.Rows[0][0].ToString();
                else
                    label7.Text = "0";

            }
        }
        //querry
        public void SemanalLucro()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT SUM(valor) FROM Pedido  WHERE YEARWEEK(data_transacao, 1) = YEARWEEK(CURDATE(), 1); ";


                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    label12.Text = dt.Rows[0][0].ToString();
                else
                    label12.Text = "0";

            }
        }

        public void MensalLucro()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT SUM(valor) FROM Pedido  WHERE MONTH(data_transacao) = MONTH(CURDATE())  AND YEAR(data_transacao) = YEAR(CURDATE()); ";


                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    label14.Text = dt.Rows[0][0].ToString();
                else
                    label14.Text = "0";

            }
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
        
        public void DiarioVenda()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT COUNT(*) " +
                               "FROM Pedido " +
                               "WHERE DATE(data_transacao) = CURDATE();";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    label9.Text = dt.Rows[0][0].ToString();
                else
                    label9.Text = "0";
            }
        }

        public void SemanalVenda()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT COUNT(*) " +
                    "FROM Pedido " +
                    "WHERE YEARWEEK(data_transacao, 1) = YEARWEEK(CURDATE(), 1); ";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    label13.Text = dt.Rows[0][0].ToString();
                else
                    label13.Text = "0";
            }

        }

        public void MensalVenda()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT COUNT(*) " +
                    "FROM Pedido " +
                    "WHERE MONTH(data_transacao) = MONTH(CURDATE())  AND YEAR(data_transacao) = YEAR(CURDATE()); ";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    label15.Text = dt.Rows[0][0].ToString();
                else
                    label15.Text = "0";
            }

        }

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
            DiarioVenda();
            SemanalVenda();
            SemanalLucro();
            MensalVenda();
            MensalLucro();
            CarregarDados();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
