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


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //querry
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
        //querry
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
        }
    }
}
