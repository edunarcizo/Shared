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

namespace SharedEmpresa
{
    public partial class Carrinho : Form
    {
        

        public Carrinho()
        {
            InitializeComponent();
        }

        public void CarregarItensPedido(int codigoPedido)
        {
            try
            {
                string datasource = "datasource=localhost; username=root; password=''; database=projeto ";
                using (MySqlConnection conexao = new MySqlConnection(datasource))
                {
                    conexao.Open();
                    string sql = "SELECT p.nome, ip.quantidadeDoProduto as quantidade, p.valor FROM itensPedido ip JOIN produto p ON ip.codigoProduto = p.codigoProduto WHERE ip.codigoPedido = @codigoPedido";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@codigoPedido", codigoPedido);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dataGridViewCarrinho.DataSource = tabela;

                    decimal totalPedido = tabela.AsEnumerable().Sum(row => row.Field<decimal>("valor") * row.Field<int>("quantidade"));
                    lblTotal.Text = "Total: R$ " + totalPedido.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar itens do pedido: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form FrmMenu = this.MdiParent;
            this.Close();
            Pedido verpedido = new Pedido();
            verpedido.MdiParent = FrmMenu;
            verpedido.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)

        {

            if (cboFormaPagamento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento.");
                return;
            }

            try
            {
                string datasource = "datasource=localhost; username=root; password=''; database=projeto";
                using (MySqlConnection conexao = new MySqlConnection(datasource))
                {
                    conexao.Open();
                    Random random = new Random();
                    int prazoEntrega = random.Next(10, 16);
                    DateTime dataEntrega = DateTime.Now.AddDays(prazoEntrega);
                    string sqlPedido = @"
                INSERT INTO pedido (formaPagamento, dataEntrega, codigoCliente, dataPedido)
                VALUES (@formaPagamento, @dataEntrega, @codigoCliente, @dataPedido);
                SELECT LAST_INSERT_ID();";

                    MySqlCommand comando = new MySqlCommand(sqlPedido, conexao);
                    comando.Parameters.AddWithValue("@formaPagamento", cboFormaPagamento.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@codigoCliente", SessaoUsuario.codigoUsuario);
                    comando.Parameters.AddWithValue("@dataPedido", DateTime.Now);
                    comando.Parameters.AddWithValue("@dataEntrega", dataEntrega);
                    int codigoPedido = Convert.ToInt32(comando.ExecuteScalar());
                    foreach (DataGridViewRow row in dataGridViewCarrinho.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int codigoProduto = Convert.ToInt32(row.Cells["codigoProduto"].Value);
                            int quantidade = Convert.ToInt32(row.Cells["quantidade"].Value);
                            string sqlItens = @"
                        INSERT INTO itensPedido (codigoPedido, codigoProduto, quantidadeDoProduto)
                        VALUES (@codigoPedido, @codigoProduto, @quantidadeDoProduto)";
                            MySqlCommand comandoItens = new MySqlCommand(sqlItens, conexao);
                            comandoItens.Parameters.AddWithValue("@codigoPedido", codigoPedido);
                            comandoItens.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                            comandoItens.Parameters.AddWithValue("@quantidadeDoProduto", quantidade);
                            comandoItens.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show($"Pedido realizado com sucesso! Prazo de entrega: {prazoEntrega} dias.");
                    dataGridViewCarrinho.DataSource = null;
                    lblTotal.Text = "Total: R$ 0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao finalizar pedido: " + ex.Message);
            }
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            cboFormaPagamento.Items.Add("Cartão de Crédito");
            cboFormaPagamento.Items.Add("Cartão de Débito");
            cboFormaPagamento.Items.Add("Boleto Bancário");
            cboFormaPagamento.Items.Add("Pix");
            
        }
    }
}
