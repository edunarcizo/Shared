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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }


        private void FrmMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Nome: {SessaoUsuario.usuarioLogado}";

            if (SessaoUsuario.cargoUsuario == 3)
            {
                toolStripStatusLabel2.Text = "Cargo: Dono";
            }
            if (SessaoUsuario.cargoUsuario == 2)
            {
                toolStripStatusLabel2.Text = "Cargo: Vendedor";
            }
            if (SessaoUsuario.cargoUsuario == 1)
            {
                toolStripStatusLabel2.Text = "Cargo: Moderador";
            }
            int cargo = SessaoUsuario.cargoUsuario;
            switch (cargo)
            {
                case 1: // Moderador
                    usuarioToolStripMenuItem.Visible = false;
                    produtoToolStripMenuItem.Visible = true;
                    break;

                case 2: // Vendedor
                    usuarioToolStripMenuItem.Visible = false;
                    produtoToolStripMenuItem.Visible = false;

                    break;


                case 3: // Dono

                    usuarioToolStripMenuItem.Visible = true;
                    produtoToolStripMenuItem.Visible = true;

                    break;

                default:
                    MessageBox.Show("Cargo não reconhecido.");
                    this.Close();
                    break;
            }

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cadastrar = new Form1();
            cadastrar.MdiParent = this;
            cadastrar.Show();
        }

        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.MdiParent = this;
            produto.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.MdiParent = this;
            pedido.Show();
        }
    }
}
