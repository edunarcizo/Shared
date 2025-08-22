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
using static System.Net.WebRequestMethods;

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
                    string sql = @"SELECT p.codigoProduto, p.nome, ip.quantidadeDoProduto as quantidade, p.valor FROM itensPedido ip JOIN produto p ON ip.codigoProduto = p.codigoProduto WHERE ip.codigoPedido = @codigoPedido";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@codigoPedido", codigoPedido);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dataGridViewCarrinho.DataSource = tabela;

                    if (dataGridViewCarrinho.Columns["codigoProduto"] != null)
                    {
                        dataGridViewCarrinho.Columns["codigoProduto"].Visible = false;
                    }

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
                    string sqlUpdatePedido = @"
               UPDATE pedido
               SET formaPagamento = @formaPagamento,
                   dataEntrega = @dataEntrega
               WHERE codigoPedido = @codigoPedido";
                    MySqlCommand comando = new MySqlCommand(sqlUpdatePedido, conexao);
                    comando.Parameters.AddWithValue("@formaPagamento", cboFormaPagamento.SelectedItem.ToString());
                    comando.Parameters.AddWithValue("@dataEntrega", dataEntrega);
                    comando.Parameters.AddWithValue("@codigoPedido", PedidoAtual.codigoPedido);
                    comando.ExecuteNonQuery();
                    MessageBox.Show($"Pedido realizado com sucesso! Prazo de entrega: {prazoEntrega} dias.");
                    dataGridViewCarrinho.DataSource = null;
                    dataGridViewCarrinho.Columns.Clear();
                    lblTotal.Text = "Total: R$ 0.00";
                    PedidoAtual.codigoPedido = 0;
                    this.Close();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtIdExcluir.Text))
            {
                MessageBox.Show("Por favor, selecione um item para excluir.");
            }
            int idExcluir;
            if (!int.TryParse(txtIdExcluir.Text, out idExcluir) || idExcluir <= 0)
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir este item do carrinho?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        string datasource = "datasource=localhost; username=root;password='';database=projeto";
                        using (MySqlConnection conexao = new MySqlConnection(datasource))
                        {
                            conexao.Open();
                            string sqldelete = "DELETE FROM itensPedido WHERE codigoPedido = @codigoPedido AND codigoProduto = @codigoProduto";
                            MySqlCommand comando = new MySqlCommand(sqldelete, conexao);
                            comando.Parameters.AddWithValue("@codigoPedido", PedidoAtual.codigoPedido);
                            comando.Parameters.AddWithValue("@codigoProduto", idExcluir);

                            int linhasAfetadas = comando.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Item excluído com sucesso.");
                                CarregarItensPedido(PedidoAtual.codigoPedido);
                                idExcluir = 0;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir item. Por favor, tente novamente.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir item: " + ex.Message);
                    }
               
            }
            
        }

        private void dataGridViewCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
