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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
            string usuario = textUsuario.Text.Trim();
            string senha = textSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            bool loginValido = ValidarLogin(usuario, senha);

            if (loginValido)
            {
                MessageBox.Show("Login realizado com sucesso!");

                Form4 menu = new Form4();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }
        

        public bool ValidarLogin(string usuario, string senha)
        {
            using (MySqlConnection conecta = Database.Conecta())
            {
                conecta.Open();

                string query = @"
            SELECT COUNT(*) 
            FROM LoginFunc 
            WHERE Usuario_Fun = @usuario 
              AND Senha_Fun = @senha;
        ";

                MySqlCommand cmd = new MySqlCommand(query, conecta);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textSenha.UseSystemPasswordChar = false;
            }
            else
            {
                textSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
