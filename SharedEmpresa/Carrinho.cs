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
                    string sql = "SELECT p.nomeProduto, ip.quantidadeDoProduto, p.precoProduto FROM ItensPedido ip JOIN Produto p ON ip.codigoProduto = p.codigoProduto WHERE ip.codigoPedido = @codigoPedido";
                    
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@codigoPedido", codigoPedido);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dataGridViewCarrinho.DataSource = tabela;

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
    }
}
