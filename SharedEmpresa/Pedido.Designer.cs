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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(700, 230);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(23, 309);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(23, 338);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(23, 366);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(40, 15);
            lblValor.TabIndex = 3;
            lblValor.Text = "Preço:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(116, 396);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 396);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Quantidade:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(597, 417);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnVerCarrinho
            // 
            btnVerCarrinho.Location = new Point(710, 417);
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
            lblIdProduto.Location = new Point(371, 309);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(38, 15);
            lblIdProduto.TabIndex = 8;
            lblIdProduto.Text = "label2";
            lblIdProduto.Visible = false;
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Pedido;
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