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

namespace SharedEmpresa
{
    public partial class Pedido : Form
    {
        MySqlConnection conexao;
        public Pedido()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNome.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            lblDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            lblValor.Text = dataGridView1.Rows[e.RowIndex].Cells["valor"].Value.ToString();
            lblIdProduto.Text = dataGridView1.Rows[e.RowIndex].Cells["codigoProduto"].Value.ToString();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = obterdados("select * from produto WHERE ativo = 1");

            if (PedidoAtual.codigoPedido == 0)
            {
                CriarPedido();
            }
            lblIdProduto.Visible = false;

        }

        private void CriarPedido()
        {
            try
            {
                string datasource = "datasource=localhost; username=root; password=''; database=projeto ";
                using (var conexao = new MySqlConnection(datasource))
                {
                    string sql = "INSERT INTO pedido (formaPagamento, dataEntrega, codigoCliente, dataPedido) VALUES (NULL, NULL, @codigoCliente, NOW()); SELECT LAST_INSERT_ID();";
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@codigoCliente", SessaoUsuario.codigoUsuario);
                        comando.Parameters.AddWithValue("@dataPedido", DateTime.Now);
                        conexao.Open();
                        PedidoAtual.codigoPedido = Convert.ToInt32(comando.ExecuteScalar());
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar pedido: " + ex.Message);
            }
        }
        public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();
            string datasource = "datasource=localhost;username=root;password='';database=projeto";
            conexao = new MySqlConnection(datasource);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(comando);
            mySqlDataAdapter.Fill(dt);
            conexao.Close();


            return dt;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblIdProduto.Text))
                {
                    MessageBox.Show("Selecione um produto para adicionar ao carrinho.");
                    return;
                }
                if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("Por favor, insira uma quantidade válida.");
                    return;
                }
                int codigoProduto = int.Parse(lblIdProduto.Text);
                int codigoPedido = PedidoAtual.codigoPedido;
                string datasource = "datasource=localhost; username=root; password=''; database=projeto ";
                using (var conexao = new MySqlConnection(datasource))
                {
                    conexao.Open();
                    string sqlEstoque = "SELECT quantidade FROM produto WHERE codigoProduto = @codigoProduto";
                    using (var comandoEstoque = new MySqlCommand(sqlEstoque, conexao))
                    {
                        comandoEstoque.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                        int estoqueAtual = Convert.ToInt32(comandoEstoque.ExecuteScalar());
                        string sqlCarrinho = @"SELECT quantidadeDoProduto
                                      FROM itensPedido
                                      WHERE codigoPedido = @codigoPedido AND codigoProduto = @codigoProduto";
                        using (var comandoCarrinho = new MySqlCommand(sqlCarrinho, conexao))
                        {
                            comandoCarrinho.Parameters.AddWithValue("@codigoPedido", codigoPedido);
                            comandoCarrinho.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                            object result = comandoCarrinho.ExecuteScalar();
                            int quantidadeNoCarrinho = result != null ? Convert.ToInt32(result) : 0;
                            if (quantidade + quantidadeNoCarrinho > estoqueAtual)
                            {
                                MessageBox.Show($"Quantidade solicitada ultrapassa o estoque disponível ({estoqueAtual}).");
                                return;
                            }
                        }
                    }
                    string sqlInserir = @"INSERT INTO itensPedido (codigoPedido, codigoProduto, quantidadeDoProduto)
                                 VALUES (@codigoPedido, @codigoProduto, @quantidadeDoProduto)";
                    using (var comando = new MySqlCommand(sqlInserir, conexao))
                    {
                        comando.Parameters.AddWithValue("@codigoPedido", codigoPedido);
                        comando.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                        comando.Parameters.AddWithValue("@quantidadeDoProduto", quantidade);
                        if (comando.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Adicionado com sucesso!");
                            lblNome.Text = "Nome:";
                            lblIdProduto.Text = "ID:";
                            lblDescricao.Text = "Descrição:";
                            lblValor.Text = "Valor:";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnVerCarrinho_Click(object sender, EventArgs e)
        {
            Form FrmMenu = this.MdiParent;
            this.Close();
            Carrinho vercarrinho = new Carrinho();
            vercarrinho.MdiParent = FrmMenu;
            vercarrinho.CarregarItensPedido(PedidoAtual.codigoPedido);
            vercarrinho.Show();

            
        }
    }
}
