using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Floresol_ADM
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            //referencia a querry na tablea
            CarregarDados();
        }
        //querry
        public void CarregarDados()
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = "SELECT * FROM Funcionario"; 

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                funcionario.DataSource = dt;
            }
        }
        //querry
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 novaPagina = new Form4();
            novaPagina.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}