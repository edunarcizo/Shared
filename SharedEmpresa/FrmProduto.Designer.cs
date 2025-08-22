namespace SharedEmpresa
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            label4 = new Label();
            txtQuantidade = new TextBox();
            label5 = new Label();
            txtID = new TextBox();
            pictureBox1 = new PictureBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluirProduto = new Button();
            btnAdicionarFoto = new Button();
            btnExcluirFoto = new Button();
            lblfoto = new Label();
            btnPesquisar = new Button();
            chkProdutoVisivel = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 309);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 353);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 400);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(136, 309);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(136, 353);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(114, 27);
            txtDescricao.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(136, 400);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(114, 27);
            txtValor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 447);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(136, 447);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(114, 27);
            txtQuantidade.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 267);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 8;
            label5.Text = "Id";
            // 
            // txtID
            // 
            txtID.Location = new Point(136, 256);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 9;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(498, 215);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 259);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = true;
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.Location = new Point(19, 557);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 30);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(121, 557);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(54, 33);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluirProduto.Location = new Point(224, 557);
            btnExcluirProduto.Margin = new Padding(3, 4, 3, 4);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(58, 33);
            btnExcluirProduto.TabIndex = 13;
            btnExcluirProduto.Text = "Excluir";
            btnExcluirProduto.UseVisualStyleBackColor = true;
            btnExcluirProduto.Click += btnExcluirProduto_Click;
            // 
            // btnAdicionarFoto
            // 
            btnAdicionarFoto.AutoSize = true;
            btnAdicionarFoto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionarFoto.Location = new Point(533, 548);
            btnAdicionarFoto.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarFoto.Name = "btnAdicionarFoto";
            btnAdicionarFoto.Size = new Size(115, 30);
            btnAdicionarFoto.TabIndex = 14;
            btnAdicionarFoto.Text = "Adicionar foto";
            btnAdicionarFoto.UseVisualStyleBackColor = true;
            btnAdicionarFoto.Click += btnAdicionarFoto_Click;
            // 
            // btnExcluirFoto
            // 
            btnExcluirFoto.AutoSize = true;
            btnExcluirFoto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluirFoto.Location = new Point(699, 548);
            btnExcluirFoto.Margin = new Padding(3, 4, 3, 4);
            btnExcluirFoto.Name = "btnExcluirFoto";
            btnExcluirFoto.Size = new Size(94, 30);
            btnExcluirFoto.TabIndex = 15;
            btnExcluirFoto.Text = "Excluir foto";
            btnExcluirFoto.UseVisualStyleBackColor = true;
            btnExcluirFoto.Click += btnExcluirFoto_Click;
            // 
            // lblfoto
            // 
            lblfoto.AutoSize = true;
            lblfoto.Location = new Point(479, 287);
            lblfoto.MaximumSize = new Size(343, 0);
            lblfoto.Name = "lblfoto";
            lblfoto.Size = new Size(0, 20);
            lblfoto.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(321, 559);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(86, 31);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // chkProdutoVisivel
            // 
            chkProdutoVisivel.AutoSize = true;
            chkProdutoVisivel.Location = new Point(136, 489);
            chkProdutoVisivel.Margin = new Padding(3, 4, 3, 4);
            chkProdutoVisivel.Name = "chkProdutoVisivel";
            chkProdutoVisivel.Size = new Size(144, 24);
            chkProdutoVisivel.TabIndex = 18;
            chkProdutoVisivel.Text = "Venda disponível";
            chkProdutoVisivel.UseVisualStyleBackColor = true;
            chkProdutoVisivel.CheckedChanged += chkProdutoVisivel_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(-2, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(988, 176);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(337, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(243, 177);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Violet;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(chkProdutoVisivel);
            Controls.Add(btnPesquisar);
            Controls.Add(lblfoto);
            Controls.Add(btnExcluirFoto);
            Controls.Add(btnAdicionarFoto);
            Controls.Add(btnExcluirProduto);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(pictureBox1);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(txtQuantidade);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProduto";
            Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private Label label4;
        private TextBox txtQuantidade;
        private Label label5;
        private TextBox txtID;
        private PictureBox pictureBox1;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluirProduto;
        private Button btnAdicionarFoto;
        private Button btnExcluirFoto;
        private Label lblfoto;
        private Button btnPesquisar;
        private CheckBox chkProdutoVisivel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}