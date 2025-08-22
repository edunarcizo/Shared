using System;
using System.Windows.Forms;
namespace SharedEmpresa
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = $"Nome: {SessaoUsuario.usuarioLogado}";
            toolStripStatusLabel2.Text = $"Cargo: {GetCargoNome(SessaoUsuario.cargoUsuario)}";
            AjustarMenuPorCargo(SessaoUsuario.cargoUsuario);
            logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
        }
        private string GetCargoNome(int cargo)
        {
            return cargo switch
            {
                3 => "Dono",
                2 => "Vendedor",
                1 => "Moderador",
                4 => "Usuário",
                _ => "Cargo Desconhecido"
            };
        }
        private void AjustarMenuPorCargo(int cargo)
        {
            usuarioToolStripMenuItem.Visible = (cargo == 3);
            produtoToolStripMenuItem.Visible = (cargo == 1 || cargo == 3);
            adicionarToolStripMenuItem.Visible = (cargo != 1);
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formUsuario = new Form1
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            formUsuario.Show();
        }
        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProduto formProduto = new FrmProduto
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            formProduto.Show();
        }
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido formPedido = new Pedido
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            formPedido.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                SessaoUsuario.usuarioLogado = string.Empty;
                SessaoUsuario.cargoUsuario = 0;
                SessaoUsuario.codigoUsuario = 0;
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            carrinho.MdiParent = this;
            carrinho.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}