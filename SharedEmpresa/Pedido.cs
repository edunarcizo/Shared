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
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = obterdados("select * from produto");

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

        }

        private void btnVerCarrinho_Click(object sender, EventArgs e)
        {
            this.Close();
            Carrinho carrinho = new Carrinho();
            carrinho.Show();
            
        }
    }
}
