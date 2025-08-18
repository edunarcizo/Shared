using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System.Data;
namespace SharedEmpresa
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        int idCargo;
        public Form1()
        {
            InitializeComponent();
        }

        private void AtualiarGrid()
        {
            try
            {
                dataGridView1.DataSource = obterdados("SELECT * FROM usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a grid: " + ex.Message);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexaoStr = "datasource=localhost;username=root;password='';database=projeto";
                using (MySqlConnection conexao = new MySqlConnection(conexaoStr))
                {
                    conexao.Open();
                    
                    string sql = "SELECT * FROM usuario WHERE 1=1";
                    if (!string.IsNullOrEmpty(txtCodigo.Text))
                        sql += " AND codigo = @codigo";
                    if (!string.IsNullOrEmpty(txtEmail.Text))
                        sql += " AND email LIKE @email";
                    
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    if (!string.IsNullOrEmpty(txtCodigo.Text))
                        comando.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCodigo.Text));
                    if (!string.IsNullOrEmpty(txtEmail.Text))
                        comando.Parameters.AddWithValue("@email", "%" + txtEmail.Text.Trim() + "%");
                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        txtCodigo.Text = row["codigo"].ToString();
                        txtNome.Text = row["nome"].ToString();
                        txtEmail.Text = row["email"].ToString();
                        txtSenha.Text = row["senha"].ToString();
                        cboCargo.SelectedValue = Convert.ToInt32(row["cargo"]);
                        chkAtivo.Checked = Convert.ToBoolean(row["ativo"]);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário encontrado com os critérios informados.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost; username=root; password=''; database=projeto ";
                conexao = new MySqlConnection(data_source);
                string sql = "INSERT INTO usuario (nome, email, senha, cargo, ativo) VALUES (@nome, @email, @senha, @cargo, @ativo)";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                string senha = txtSenha.Text.Trim();
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);
                comando.Parameters.AddWithValue("@senha", senhahash);
                comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                comando.Parameters.AddWithValue("@cargo", idCargo);
                comando.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                comando.Parameters.AddWithValue("@ativo", 1);
                conexao.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    AtualiarGrid();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*cboCargo.Items.Add("Gerente");
            cboCargo.Items.Add("Vendedor");
            cboCargo.Items.Add("Estoquista");
            cboCargo.Items.Add("Assistente");
            cboCargo.Items.Add("Diretor");
            */


            cboCargo.DataSource = obterdados("select * from cargo");
            cboCargo.ValueMember = "codigoCargo";
            cboCargo.DisplayMember = "cargo";
            dataGridView1.DataSource = obterdados("select * from usuario");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost; username=root; password=''; database='projeto' ";
                conexao = new MySqlConnection(data_source);
                string sql = "update usuario set nome=@nome,email=@email,senha=@senha,cargo=@cargo where codidgo=@codigo";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                string senha = txtSenha.Text.Trim();
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);
                comando.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCodigo.Text));
                comando.Parameters.AddWithValue("@senha", senhahash);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@cargo", idCargo);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);

                conexao.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    AtualiarGrid();
                    MessageBox.Show("Mudança realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao editar!");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {


                    string data_source = "datasource=localhost; username=root; password=''; database='projeto' ";
                    conexao = new MySqlConnection(data_source);
                    string sql = "delete from usuario where codigo=@codigo";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCodigo.Text));


                    conexao.Open();

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        AtualiarGrid();
                        MessageBox.Show("Usuário excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao exluir!");
                    }

                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, informe o código do usuário a ser excluído.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            txtCodigo.Text = codigo.ToString();
            txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            cboCargo.Text = dataGridView1.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            bool ativo = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["ativo"].Value);
            chkAtivo.Visible = true;
            if (ativo == true)
            {
                chkAtivo.Checked = true;
            }
            else
            {
                chkAtivo.Checked = false;
            }
        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCargo = Convert.ToInt32(((DataRowView)cboCargo.SelectedItem)["codigoCargo"]);

        }
    }
}
