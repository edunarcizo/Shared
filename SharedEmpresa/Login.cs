using BCrypt.Net;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Data;
using System.Windows.Forms;

namespace SharedEmpresa

{

    public partial class Login : Form

    {

        private int tentativas = 0; // Limite de tentativas

        public Login()

        {

            InitializeComponent();

            this.AcceptButton = btnLogar; // Enter para logar

            txtSenha.UseSystemPasswordChar = true; // Oculta a senha por padrão

        }

        private void btnLogar_Click(object sender, EventArgs e)

        {

            label12.ForeColor = System.Drawing.Color.Red; // Mensagens de erro em vermelho

            label12.Text = "";

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))

            {

                label12.Text = "Email e senha são obrigatórios";

                return;

            }

            if (tentativas >= 5)

            {

                MessageBox.Show("Número máximo de tentativas excedido.");

                this.Close();

                return;

            }

            tentativas++;

            string datasource = "datasource=localhost;username=root;password='';database=projeto";

            try

            {

                using (MySqlConnection conexao = new MySqlConnection(datasource))

                {

                    string sql = "SELECT codigo,nome,email,cargo,senha,ativo FROM usuario WHERE email=@Email";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))

                    {

                        comando.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        conexao.Open();

                        using (MySqlDataReader reader = comando.ExecuteReader())

                        {

                            if (reader.Read())

                            {

                                int ativo = Convert.ToInt32(reader["ativo"]);

                                string senhaHash = reader["senha"].ToString();

                                if (ativo == 0)

                                {

                                    label12.Text = "Sua conta está desativada";

                                    return;

                                }

                                if (BCrypt.Net.BCrypt.Verify(txtSenha.Text, senhaHash))

                                {

                                    // Sessão do usuário

                                    SessaoUsuario.codigoUsuario = Convert.ToInt32(reader["codigo"]);

                                    SessaoUsuario.usuarioLogado = reader["nome"].ToString();

                                    SessaoUsuario.cargoUsuario = Convert.ToInt32(reader["cargo"]);

                                    MessageBox.Show($"Bem-vindo, {SessaoUsuario.usuarioLogado}!");

                                    FrmMenu principal = new FrmMenu();

                                    principal.Show();

                                    this.Hide();

                                }

                                else

                                {

                                    label12.Text = "Email ou senha inválido";

                                }

                            }

                            else

                            {

                                label12.Text = "Email ou senha inválido";

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


        private void txtEmail_TextChanged(object sender, EventArgs e)

        {

            label12.Text = "";

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)

        {

            label12.Text = "";

        }

        private void chkMostrarSenha_CheckedChanged_1(object sender, EventArgs e)
        {
                txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }
    }

}