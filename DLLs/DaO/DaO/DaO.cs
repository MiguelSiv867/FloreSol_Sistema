using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DaO
{
    public class DaO
    {
        public static string connect =
            "server=localhost;uid=root;pwd=root;database=bank_adm";

        public static MySqlConnection Conecta()
        {
            return new MySqlConnection(connect);
        }

        public static DataTable CarregarDados1()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = "select (nome_produto,tipo_produto,quantidade_produto,preco_produto) from produto;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static DataTable CarregarDados2()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query =
                    "SELECT p.id_pedido, " +
                    "c.nome_cliente, " +
                    "pr.nome_produto, " +
                    "php.quantidade, " +
                    "pr.preco_produto, " +
                    "(php.quantidade * pr.preco_produto) AS total_item, " +
                    "p.valor AS total_pedido, " +
                    "p.data_transacao " +
                    "FROM Pedido p " +
                    "JOIN Cliente c ON p.id_cliente = c.id_cliente " +
                    "JOIN Pedido_has_Produto php ON p.id_pedido = php.id_pedido " +
                    "JOIN Produto pr ON php.id_produto = pr.id_produto " +
                    "ORDER BY p.id_pedido;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static DataTable CarregarDados3()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = "SELECT * FROM Funcionario";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }


        public static DataTable Delivery()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"
            SELECT
                P.id_pedido,
                C.nome_cliente,
                Pr.nome_produto,
                PHP.quantidade,
                E.rua,
                E.numero,
                E.bairro,
                E.cidade,
                E.sgestado,
                D.codrastreio_delivery AS codigo_rastreio,
                D.StTransporte_delivery AS status_entrega
            FROM
                Pedido AS P
            INNER JOIN
                Cliente AS C ON P.id_cliente = C.id_cliente
            INNER JOIN
                Delivery AS D ON P.id_delivery = D.id_delivery
            INNER JOIN
                Pedido_has_Produto AS PHP ON P.id_pedido = PHP.id_pedido
            INNER JOIN
                Produto AS Pr ON PHP.id_produto = Pr.id_produto
            INNER JOIN
                Cliente_has_Endereco AS CHE ON C.id_cliente = CHE.id_cliente
            INNER JOIN
                Endereco AS E ON CHE.id_endereco = E.id_endereco
            ORDER BY
                P.id_pedido;"
                MySqlDataAdapter da = new MySqlDataAdapter(query, conecta);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static int AtuCodRastreio(int idPedido, string codigo)
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"
            UPDATE Delivery d
            JOIN Pedido p ON d.id_delivery = p.id_delivery
            SET d.codrastreio_delivery = @codigo
            WHERE p.id_pedido = @idPedido";

                using (MySqlCommand cmd = new MySqlCommand(query, conecta))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static decimal ObterLucroDiario()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"SELECT SUM(valor) 
                         FROM Pedido  
                         WHERE DATE(data_transacao) = CURDATE();";

                using (MySqlCommand cmd = new MySqlCommand(query, conecta))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == DBNull.Value || result == null)
                        return 0;

                    return Convert.ToDecimal(result);
                }
            }
        }

        public static decimal ObterLucroSemanal()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"SELECT SUM(valor) 
                         FROM Pedido  
                         WHERE YEARWEEK(data_transacao, 1) = YEARWEEK(CURDATE(), 1);";

                using (MySqlCommand cmd = new MySqlCommand(query, conecta))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == DBNull.Value || result == null)
                        return 0;

                    return Convert.ToDecimal(result);
                }
            }
        }

        public static decimal ObterLucroMensal()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"SELECT SUM(valor) 
                         FROM Pedido  
                         WHERE MONTH(data_transacao) = MONTH(CURDATE())  
                         AND YEAR(data_transacao) = YEAR(CURDATE());";

                using (MySqlCommand cmd = new MySqlCommand(query, conecta))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == DBNull.Value || result == null)
                        return 0;

                    return Convert.ToDecimal(result);
                }
            }
        }
        public int VendasDiarias()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"
            SELECT COUNT(*)
            FROM Pedido
            WHERE DATE(data_transacao) = CURDATE();
        ";

                MySqlCommand cmd = new MySqlCommand(query, conecta);

                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public int VendasSemana()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"
            SELECT COUNT(*)
            FROM Pedido
            WHERE YEARWEEK(data_transacao, 1) = YEARWEEK(CURDATE(), 1);
        ";

                MySqlCommand cmd = new MySqlCommand(query, conecta);

                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public int VendasMes()
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"
            SELECT COUNT(*) FROM Pedido WHERE MONTH(data_transacao) = MONTH(CURDATE()) AND YEAR(data_transacao) = YEAR(CURDATE());";

                MySqlCommand cmd = new MySqlCommand(query, conecta);

                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public static bool ValidarLogin(string usuario, string senha)
        {
            using (MySqlConnection conecta = DaO.Conecta())
            {
                conecta.Open();

                string query = @"
                SELECT COUNT(*) 
                FROM LoginFunc 
                WHERE Usuario_Fun = @usuario AND Senha_Fun = @senha;
            ";

                MySqlCommand cmd = new MySqlCommand(query, conecta);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

    }
}
