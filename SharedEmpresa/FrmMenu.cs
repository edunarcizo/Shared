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
            // Mostra usuário e cargo no StatusStrip
            toolStripStatusLabel1.Text = $"Nome: {SessaoUsuario.usuarioLogado}";
            toolStripStatusLabel2.Text = $"Cargo: {GetCargoNome(SessaoUsuario.cargoUsuario)}";
            // Ajusta visibilidade dos menus conforme cargo
            AjustarMenuPorCargo(SessaoUsuario.cargoUsuario);
        }
        // Retorna o nome do cargo
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
        // Ajusta quais menus aparecem para cada cargo
        private void AjustarMenuPorCargo(int cargo)
        {
            // Usuários: apenas Dono
            usuarioToolStripMenuItem.Visible = (cargo == 3);
            // Produtos: Moderador e Dono
            produtoToolStripMenuItem.Visible = (cargo == 1 || cargo == 3);
            // Pedidos: todos exceto Moderador
            adicionarToolStripMenuItem.Visible = (cargo != 1);
        }
        // Abre formulário de Usuários
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formUsuario = new Form1
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            formUsuario.Show();
        }
        // Abre formulário de Produtos
        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProduto formProduto = new FrmProduto
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            formProduto.Show();
        }
        // Abre formulário de Pedidos
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido formPedido = new Pedido
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            formPedido.Show();
        }
    }
}