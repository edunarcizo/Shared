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
using BCrypt.Net;

namespace SharedEmpresa
{
    public partial class Login : Form
    {
        MySqlConnection conexao;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "")
                {
                    label2.Text = "Email está vazio";
                    return;
                }
                if (txtSenha.Text == "")
                {
                    label2.Text = "Senha está vazio";
                    return;

                }
                string datasource = "datasource=localhost;username=root;password='';database=projeto";
                conexao = new MySqlConnection(datasource);
                string sql = "select codigo,nome,email,cargo,senha,ativo from usuario where email=@email";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    SessaoUsuario.cargoUsuario = Convert.ToInt32(reader["cargo"]);
                    SessaoUsuario.usuarioLogado = reader["nome"].ToString();
                    SessaoUsuario.codigoUsuario = Convert.ToInt32(reader["codigo"]);
                    string senha = reader["senha"].ToString();
                    int ativo = Convert.ToInt32(reader["ativo"].ToString());
                    if (ativo == 0)
                    {
                        label2.Text = "Sua conta está desativada";
                        return;
                    }
                    else
                    {
                        if (BCrypt.Net.BCrypt.Verify(txtSenha.Text, senha))
                        {
                            MessageBox.Show($"Bem-vindo, {SessaoUsuario.usuarioLogado} ");
                            FrmMenu principal = new FrmMenu();
                            principal.Show();
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro: "+ ex.Message);
            }
        }
    }
}
