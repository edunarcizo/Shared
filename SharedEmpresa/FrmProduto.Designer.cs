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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 58);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 91);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 126);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 58);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(113, 91);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(113, 126);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 161);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(113, 161);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 26);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 8;
            label5.Text = "Id";
            // 
            // txtID
            // 
            txtID.Location = new Point(113, 18);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 9;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(419, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 194);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = true;
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.Location = new Point(24, 380);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(67, 25);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(113, 380);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(47, 25);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluirProduto.Location = new Point(203, 380);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(51, 25);
            btnExcluirProduto.TabIndex = 13;
            btnExcluirProduto.Text = "Excluir";
            btnExcluirProduto.UseVisualStyleBackColor = true;
            btnExcluirProduto.Click += btnExcluirProduto_Click;
            // 
            // btnAdicionarFoto
            // 
            btnAdicionarFoto.AutoSize = true;
            btnAdicionarFoto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionarFoto.Location = new Point(442, 250);
            btnAdicionarFoto.Name = "btnAdicionarFoto";
            btnAdicionarFoto.Size = new Size(93, 25);
            btnAdicionarFoto.TabIndex = 14;
            btnAdicionarFoto.Text = "Adicionar foto";
            btnAdicionarFoto.UseVisualStyleBackColor = true;
            btnAdicionarFoto.Click += btnAdicionarFoto_Click;
            // 
            // btnExcluirFoto
            // 
            btnExcluirFoto.AutoSize = true;
            btnExcluirFoto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluirFoto.Location = new Point(587, 250);
            btnExcluirFoto.Name = "btnExcluirFoto";
            btnExcluirFoto.Size = new Size(76, 25);
            btnExcluirFoto.TabIndex = 15;
            btnExcluirFoto.Text = "Excluir foto";
            btnExcluirFoto.UseVisualStyleBackColor = true;
            btnExcluirFoto.Click += btnExcluirFoto_Click;
            // 
            // lblfoto
            // 
            lblfoto.AutoSize = true;
            lblfoto.Location = new Point(419, 215);
            lblfoto.Name = "lblfoto";
            lblfoto.Size = new Size(0, 15);
            lblfoto.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(288, 382);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProduto";
            Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}