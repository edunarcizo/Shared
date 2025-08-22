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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            dataGridView1 = new DataGridView();
            lblNome = new Label();
            lblDescricao = new Label();
            lblValor = new Label();
            txtQuantidade = new TextBox();
            label1 = new Label();
            btnAdicionar = new Button();
            btnVerCarrinho = new Button();
            lblIdProduto = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 110);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(14, 453);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(14, 492);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(77, 20);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(14, 529);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(49, 20);
            lblValor.TabIndex = 3;
            lblValor.Text = "Preço:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(120, 569);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(114, 27);
            txtQuantidade.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 569);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 5;
            label1.Text = "Quantidade:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(682, 556);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(86, 31);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnVerCarrinho
            // 
            btnVerCarrinho.Location = new Point(812, 556);
            btnVerCarrinho.Margin = new Padding(3, 4, 3, 4);
            btnVerCarrinho.Name = "btnVerCarrinho";
            btnVerCarrinho.Size = new Size(90, 31);
            btnVerCarrinho.TabIndex = 7;
            btnVerCarrinho.Text = "Ver carrinho";
            btnVerCarrinho.UseVisualStyleBackColor = true;
            btnVerCarrinho.Click += btnVerCarrinho_Click;
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Location = new Point(839, 110);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(50, 20);
            lblIdProduto.TabIndex = 8;
            lblIdProduto.Text = "label2";
            lblIdProduto.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumBlue;
            pictureBox2.Location = new Point(-3, -9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(988, 116);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(369, -9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 116);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblIdProduto);
            Controls.Add(btnVerCarrinho);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(txtQuantidade);
            Controls.Add(lblValor);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pedido";
            Text = "Pedido";
            Load += Pedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}