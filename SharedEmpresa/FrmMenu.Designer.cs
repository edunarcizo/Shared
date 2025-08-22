namespace SharedEmpresa
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 0, 192);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, pedidoToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.BackColor = Color.Blue;
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, produtoToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(224, 26);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(224, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click_1;
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.BackColor = Color.MediumBlue;
            pedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem });
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(69, 24);
            pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(224, 26);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.BackColor = Color.RoyalBlue;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(914, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(151, 20);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenu";
            Text = "FrmMenu";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}