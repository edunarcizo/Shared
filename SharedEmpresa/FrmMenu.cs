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
            toolStripStatusLabel1.Text = SessaoUsuario.usuarioLogado;
            toolStripStatusLabel2.Text = SessaoUsuario.cargoUsuario.ToString();
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
    }
}
