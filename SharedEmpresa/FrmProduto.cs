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
    public partial class FrmProduto : Form
    {
        MySqlConnection conexao;
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost; username=root; password=''; database=projeto ";
                conexao = new MySqlConnection(data_source);
                string sql = "INSERT INTO produto (nome, descricao, valor, quantidade, foto) VALUES (@nome, @descricao, @valor, @quantidade, @foto)";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                comando.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
                comando.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                comando.Parameters.AddWithValue("@foto", lblfoto.Text);
                conexao.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto!");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();

            foto.Filter = "Image file(*.jpg;*.png)|*jpg;*.png";
            foto.Title = "Selecione uma foto";
            if (foto.ShowDialog() == DialogResult.OK)
            {
                Image arquivo = Image.FromFile(foto.FileName);

                string CaminhoCompleto = foto.FileName;
                string nomeArquivo = Path.GetFileName(CaminhoCompleto);
                string caminhoDestino = Path.Combine(Application.StartupPath, "Produto", nomeArquivo);

                if (!Directory.Exists(caminhoDestino))
                {
                    Directory.CreateDirectory(caminhoDestino);
                }

                string caminhoFinal = Path.Combine(caminhoDestino, nomeArquivo);
                try
                {
                    File.Copy(CaminhoCompleto, caminhoFinal, true);
                    lblfoto.Text = caminhoFinal;
                    pictureBox1.Image = arquivo;
                    lblfoto.Text = foto.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao copiar a foto: " + ex.Message);
                    lblfoto.Text = "";
                }

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost; username=root; password=''; database='projeto' ";
                conexao = new MySqlConnection(data_source);
                string sql = "update produto set nome=@nome,descricao=@descricao,valor=@valor,quantidade=@quantidade,foto=@foto where codigoProduto=@codigoProduto";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigoProduto", Convert.ToInt32(txtID.Text));
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                comando.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
                comando.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                comando.Parameters.AddWithValue("@foto", lblfoto.Text);

                conexao.Open();

                if (comando.ExecuteNonQuery() == 1)
                {
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

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {


                    string data_source = "datasource=localhost; username=root; password=''; database='projeto' ";
                    conexao = new MySqlConnection(data_source);
                    string sql = "delete from produto where codigoProduto=@codigoProduto";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigoProduto", Convert.ToInt32(txtID.Text));


                    conexao.Open();

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Produto excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao exluir!");
                    }

                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, informe o código do produto a ser excluído.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnExcluirFoto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            lblfoto.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Por favor, informe o código do produto.");
                    return;
                }
                string data_source = "datasource=localhost; username=root; password=''; database=projeto ";
                using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    string sql = "SELECT * FROM produto WHERE codigoProduto=@codigoProduto";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@codigoProduto", Convert.ToInt32(txtID.Text));
                        conexao.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Preenche os campos do formulário
                                txtNome.Text = reader["nome"].ToString();
                                txtDescricao.Text = reader["descricao"].ToString();
                                txtValor.Text = reader["valor"].ToString();
                                txtQuantidade.Text = reader["quantidade"].ToString();
                                lblfoto.Text = reader["foto"].ToString();
                                // Se houver foto salva, mostra no PictureBox
                                if (!string.IsNullOrEmpty(lblfoto.Text) && System.IO.File.Exists(lblfoto.Text))
                                {
                                    pictureBox1.Image = Image.FromFile(lblfoto.Text);
                                }
                                else
                                {
                                    pictureBox1.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
