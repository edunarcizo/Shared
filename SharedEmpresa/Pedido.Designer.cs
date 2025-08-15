namespace SharedEmpresa
{
    partial class Pedido
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
            dataGridView1 = new DataGridView();
            lblNome = new Label();
            lblDescricao = new Label();
            lblValor = new Label();
            txtQuantidade = new TextBox();
            label1 = new Label();
            btnAdicionar = new Button();
            btnVerCarrinho = new Button();
            lblIdProduto = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(703, 245);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(34, 271);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(34, 311);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(34, 351);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(40, 15);
            lblValor.TabIndex = 3;
            lblValor.Text = "Preço:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(127, 391);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 391);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Quantidade:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(582, 391);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnVerCarrinho
            // 
            btnVerCarrinho.Location = new Point(696, 391);
            btnVerCarrinho.Name = "btnVerCarrinho";
            btnVerCarrinho.Size = new Size(79, 23);
            btnVerCarrinho.TabIndex = 7;
            btnVerCarrinho.Text = "Ver carrinho";
            btnVerCarrinho.UseVisualStyleBackColor = true;
            btnVerCarrinho.Click += btnVerCarrinho_Click;
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Location = new Point(731, 27);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(38, 15);
            lblIdProduto.TabIndex = 8;
            lblIdProduto.Text = "label2";
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIdProduto);
            Controls.Add(btnVerCarrinho);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(txtQuantidade);
            Controls.Add(lblValor);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(dataGridView1);
            Name = "Pedido";
            Text = "Pedido";
            Load += Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblNome;
        private Label lblDescricao;
        private Label lblValor;
        private TextBox txtQuantidade;
        private Label label1;
        private Button btnAdicionar;
        private Button btnVerCarrinho;
        private Label lblIdProduto;
    }
}