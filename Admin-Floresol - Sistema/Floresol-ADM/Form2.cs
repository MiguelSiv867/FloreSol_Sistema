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
            CarregarDados();
            Delivery();
        }

        
        public void CarregarDados()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "select nome_produto,tipo_produto,quantidade_produto,preco_produto from produto;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                estoque.DataSource = dt;
            }
        }

        public void Delivery()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT    p.id_pedido,   c.nome_cliente,    pr.nome_produto,   php.quantidade,    e.rua,   e.numero,  e.bairro,    e.cidade,   e.sgestado,   d.codrastreio_delivery AS codigo_rastreio,   d.StTransporte_delivery AS status_entrega FROM Pedido p JOIN Cliente c ON p.id_cliente = c.id_cliente JOIN Pedido_has_Produto php ON p.id_pedido = php.id_pedido JOIN Produto pr ON php.id_produto = pr.id_produto JOIN Delivery d ON p.id_delivery = d.id_delivery JOIN Cliente_has_Endereco ce ON c.id_cliente = ce.id_cliente JOIN Endereco e ON ce.id_endereco = e.id_endereco ORDER BY p.id_pedido; ";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                delivery.DataSource = dt;
            }
        }




        private void delivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = @"
            UPDATE Delivery d
            JOIN Pedido p ON d.id_delivery = p.id_delivery
            SET d.codrastreio_delivery = @codigo
            WHERE p.id_pedido = @idPedido";

                using (MySqlCommand cmd = new MySqlCommand(query, conecta))
                {
                    
                    cmd.Parameters.AddWithValue("@codigo", CR.Text.Trim());

                    
                    cmd.Parameters.AddWithValue("@idPedido", int.Parse(IDP.Text));

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                        MessageBox.Show("Código de rastreio atualizado!");
                    else
                        MessageBox.Show("Nenhum registro foi atualizado.\nVerifique o ID do pedido.");
                }
            }
        

        }

        private void CR_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarDados();
            Delivery();
        }
    }
}
