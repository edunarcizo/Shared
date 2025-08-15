using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SharedEmpresa
{


    public static class PedidoAtual
    {
        public static string formaPagamento { get; set; }
        public static DateTime dataEntrega { get; set; }
        public static int codigoPedido { get; set; }
        public static void InicializarPedido(int codigoUsuario)
        {
            codigoPedido = ObterPedidoAberto(codigoUsuario);
            if (codigoPedido == 0)
            {
                CriarNovoPedido(codigoUsuario);
            }
        }
        private static int ObterPedidoAberto(int codigoUsuario)
        {
            using (var conexao = database.GetConnection())
            {
                conexao.Open();
                string sql = "SELECT codigoPedido FROM Pedido WHERE codigoUsuario = @codigoUsuario AND status = 'aberto'";
                using (var comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);
                    var resultado = comando.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : 0;
                }
            }
        }

        private static void CriarNovoPedido(int codigoUsuario)
        {
            using (var conexao = database.GetConnection())
            {
                conexao.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO Pedido (formaPagamento, dataEntrega, codigoCliente, dataPedido) VALUES (NULL, NULL, @cliente, NOW()); SELECT LAST_INSERT_ID();", conexao);

                cmd.Parameters.AddWithValue("@codigoCliente", codigoUsuario);
                codigoPedido = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void AdicionarItem(int codigoProduto, int quantidade)
        {
            using (var conexao = database.GetConnection())
            {
                conexao.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO ItensPedido (codigoPedido, codigoProduto, quantidadeDoProduto) VALUES (@codigoPedido, @codigoProduto, @quantidade)", conexao);

                cmd.Parameters.AddWithValue("@codigoPedido", codigoPedido);
                cmd.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);

                cmd.ExecuteNonQuery();
            }
        }

        public static void FinalizarPedido()
        {
            using (var conexao = database.GetConnection())
            {
                conexao.Open();
                var cmd = new MySqlCommand(
                    "UPDATE Pedido SET formaPagamento = @forma, dataEntrega= @dataEntrega WHERE codigoPedido = @codigoPedido", conexao);

                cmd.Parameters.AddWithValue("@codigoPedido", codigoPedido);
                cmd.Parameters.AddWithValue("@forma", formaPagamento);
                cmd.Parameters.AddWithValue("@dataEntrega", dataEntrega);

                cmd.ExecuteNonQuery();
            }
            codigoPedido = 0;
        }
    }
}
